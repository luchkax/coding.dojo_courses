from flask import Flask, request, redirect, render_template, session, flash
from mysqlconnection import MySQLConnector
import re

emailRegex = re.compile(r'^[a-zA-Z0-9\.\+_-]+@[a-zA-Z0-9\._-]+\.[a-zA-Z]*$')
app = Flask(__name__)
app.secret_key = 'KeepItSecretKeepItSafe'
mysql = MySQLConnector(app,'emaildb')

@app.route('/')
def index():
    return render_template('index.html')

@app.route('/create', methods=['POST'])
def checkemail():
    if len(request.form['email']) < 1:
        flash('Email cannot be blank')     
        return redirect ('/')

    elif not emailRegex.match(request.form['email']):
        flash('Invalid email address')
        return redirect ('/')

    else:
        check_email_query = "SELECT email FROM emails WHERE email = :email"
        check_email_query_data = {
            'email' : request.form['email']
        }
        email_check_results = mysql.query_db(check_email_query, check_email_query_data)
        if len(email_check_results)>0:
            flash("Email has been already taken!")
            return redirect ('/')
        else:    
            email = request.form['email']
            session['email'] = email
            query = "INSERT INTO emails (email, created_at, updated_at) VALUES (:email, NOW(), NOW())"
            data = {
                'email': request.form['email']
            }
            mysql.query_db(query, data)
            return redirect ('/success')

# @app.route('/success')
# def success_data():
#     return render_template('success.html')

@app.route('/success')
def success_data_emails():
    query = "SELECT * FROM emails"
    email = mysql.query_db(query)
    return render_template('success.html', emailz = email)

@app.route('/clear', methods = ['POST'])
def clear_email():
    query = "DELETE FROM emails WHERE id > 0"
    mysql.query_db(query)
    return redirect('/success')

app.run(debug=True)
