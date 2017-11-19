from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = 'victoriasecret'

@app.route('/')
def home():
    if 'counter' in session:
        session ['counter'] += 1
    else:
        session ['counter'] = 0
    return render_template ('/index.html')

@app.route('/reset_button')
def reset_button():
    session.clear()
    return redirect ('/')

@app.route('/plus_two')
def plus_two_but():
    session['counter'] +=1
    return redirect('/')

    




app.run(debug=True) 
