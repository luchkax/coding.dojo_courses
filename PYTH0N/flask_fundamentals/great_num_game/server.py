from flask import Flask, flash, render_template, request, redirect, session
import random

app = Flask(__name__)
app.secret_key = 'ThisIsSecret'

@app.route('/')
def index():
    if not 'random' in session:
        session['random'] = random.randrange(0,101)
    if not 'counter' in session:
        session['counter'] = 0
    session['counter'] += 1
    return render_template('index.html')

@app.route('/submit', methods = ['POST'])
def guess():
    guess = int(request.form['guess'])
    if session['random'] < guess:
        session['content'] = "Too high, you tried " + str(session['counter'])+" times"
    elif session['random'] > guess:
        session['content'] = "Too low, you tried " + str(session['counter'])+" times"
    else: 
        session['content'] = "You are the winner in " + str(session['counter'])+" times"
    return redirect('/')

@app.route('/clear', methods=['POST'])
def clear():
    session.clear()
    return redirect("/")

app.run(debug=True)
