from flask import Flask, render_template, redirect, request, session, flash
app = Flask(__name__)
app.secret_key = 'KeepItSecretKeepItSafe'

@app.route('/')
def home():
    return render_template ('index.html') 

def countLetters(word):
    count = 0
    for c in word:
        count += 1
    return count


@app.route('/create', methods=['POST'])
def create_user():
    if request.form['nameid'] == '' and request.form['commentid'] == '':
        flash('Name cannot be blank', 'nameError')
        flash('Comment cannot be blank', 'commentError')
        return redirect('/')
    if request.form['nameid'] == '':
        flash('Name cannot be blank', 'nameError')
        return redirect('/')
    elif request.form['commentid'] == '':
        flash('Comment cannot be blank', 'commentError')
        return redirect('/')
    
    commentt = countLetters(session['comment'])
    print commentt
    if commentt > 120:
        flash('Comment is too long, no one will read this', 'commenttError')
        return redirect('/')

    session['name'] = request.form['nameid']
    session['location'] = request.form['locationid']
    session['language'] = request.form['languageid']
    session['comment'] = request.form['commentid'] 
         
    return redirect('/process')

@app.route('/process')
def show_user():
    return render_template('result.html', username = session['name'], userlocation = session['location'], userlanguage = session['language'], usercomment = session['comment'])


   

app.run(debug=True) 