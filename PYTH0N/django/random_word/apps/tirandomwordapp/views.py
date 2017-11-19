from django.shortcuts import render, HttpResponse, redirect
from django.utils.crypto import get_random_string

def index(request):
    try:
        request.session['attempt']
    except KeyError:
        request.session['attempt'] = 0

    return render(request, "tirandomwordapp/index.html")

def generate(request):
    request.session['attempt'] += 1  
    request.session['random_str'] = get_random_string(length=14)
    return redirect('/random_word')

def reset(request):
    if request.session['attempt'] > 0: 
        del request.session['attempt']
        del request.session['random_str']
    else:
        pass
    return redirect('/random_word')
