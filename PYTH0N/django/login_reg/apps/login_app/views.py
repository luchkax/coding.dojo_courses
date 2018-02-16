from django.shortcuts import render, HttpResponse, redirect
from .models import User
from django.contrib import messages


def index(request):
    return render(request, "login_app/index.html")

# def success(request):
#     return render(request, "login_app/success.html")

def register(request):
    result = User.objects.validate_registration(request.POST)
    if type(result) == list:
        for err in result:
            messages.error(request, err)
        return redirect ('/')
    request.session['user_id'] = result.id 
    messages.success(request, "Successefully Registered!")
    return redirect('/success')

def login(request):
    result = User.objects.validate_login(request.POST)
    if type(result) == list:
        for err in result:
            messages.error(request, err)
        return redirect('/')
    request.session['user_id'] = result.id
    messages.success(request, "Successfully logged in!")
    return redirect('/success')

def success(request):
    try:
        request.session['user_id']
    except KeyError:
        return redirect('/')
    context = {
        'user': User.objects.get(id=request.session['user_id'])
    }
    return render(request, 'login_app/success.html', context)

def user_logout(request):
    del request.session['user_id']
    return redirect('/')


