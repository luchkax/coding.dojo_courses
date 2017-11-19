from flask import Flask, render_template, request, redirect
app = Flask(__name__)

@app.route('/')
def home():
    return render_template('index.html')

@app.route('/ninja')
def ninja():
    return render_template('ninja.html')


@app.route('/ninja/red')
def raph():
    return render_template('red.html') 

@app.route('/ninja/blue')
def leo():
    return render_template('blue.html') 

@app.route('/ninja/purple')
def don():
    return render_template('purple.html') 

@app.route('/ninja/orange')
def mikey():
    return render_template('orange.html') 

@app.route('/notapril')
def april():
    return render_template('april.html') 

@app.errorhandler(404)
def No_page(e):
    return redirect ('/notapril') 

app.run(debug=True)