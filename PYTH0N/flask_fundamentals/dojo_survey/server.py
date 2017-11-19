from flask import Flask, render_template, request, redirect
app = Flask(__name__)

@app.route('/')
def home():
    return render_template ('index.html') 



@app.route('/result', methods=['POST'])
def form():
    name = request.form['nameid']
    location = request.form['locationid']
    language = request.form['languageid']
    comment = request.form['commentid'] 
    return render_template ('result.html', username = name, userlocation = location, userlanguage = language, usercomment = comment)
   

app.run(debug=True) 