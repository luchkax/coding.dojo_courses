from flask import Flask, render_template, request, redirect
app = Flask(__name__)

@app.route('/')
def home():
   return render_template('index.html')


@app.route('/', methods=['POST'])
def create_user():
    # recall the name attributes we added to our form inputs
    # to access the data that the user input into the fields we use request.form['name_of_input']
    name = request.form['name']
    email = request.form['email']
    return redirect('/success') # redirects back to the '/' route

@app.route('/success')
def projects():
   return render_template('success.html')

  



app.run(debug=True) # run our server
