from django.shortcuts import render, HttpResponse, redirect
from django.contrib import messages

def index(request):
    return render(request, 'django_survey/index.html')

def display_result(request):
    return render(request, 'django_survey/results.html')

def process(request):
    if len(request.POST['name']) < 1  and len(request.POST['comment']) < 1:
        messages.warning(request,'Name and Comment sections cannot be blank')
        return redirect('/')

    if len(request.POST['name']) < 1:
        messages.warning(request, 'Name and Comment sections cannot be blank')
        return redirect('/')
    
    if len(request.POST['comment']) < 1:
        messages.warning(request, 'Name and Comment sections cannot be blank')
        return redirect('/')
    
    else:    
        try:
            request.session['attempt']
        except KeyError:
            request.session['attempt'] = 0
        request.session['name'] = request.POST['name']
        request.session['location'] = request.POST['location']
        request.session['language'] = request.POST['language']
        request.session['comment'] = request.POST['comment']
        request.session['attempt'] += 1
        return redirect('/result')

# def process(request):
#     if request.POST['name'] == '' and request.POST['comment'] == '':
#         messages.add_message(request, messages.INFO, 'Name cannot be blank')
#         messages.add_message(request, messages.INFO, 'Comment cannot be blank')
#         return redirect('/')
# 
    # commentt = countLetters(session['comment'])
    # print commentt
    # if commentt > 120:
    #     flash('Comment is too long, no one will read this', 'commenttError')
    #     return redirect('/')

    # session['name'] = request.form['nameid']
    # session['location'] = request.form['locationid']
    # session['language'] = request.form['languageid']
    # session['comment'] = request.form['commentid'] 
         
    # return redirect('/')