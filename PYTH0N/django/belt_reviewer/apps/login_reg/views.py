from django.shortcuts import render, HttpResponse, redirect
from .models import *
from django.contrib import messages


def index(request):
    return render(request, "login_reg/index.html")

def register(request):
    result = User.objects.validate_registration(request.POST)
    if type(result) == list:
        for err in result:
            messages.error(request, err)
        return redirect('/users')
    else:
        request.session['user_id'] = result.id
        messages.success(request, "Successefully Registered!")
    return redirect('/users')

def login(request):
    result = User.objects.validate_login(request.POST)
    if type(result) == list:
        for err in result:
            messages.error(request, err)
        return redirect('/')

    request.session['user_id'] = result.id
    messages.success(request, "Successfully logged in!")
    return redirect('/users/{}'.format(request.session['user_id']))

def showuser(request, user_id):
    context = {
        'user': User.objects.get(id=user_id)
    }

    return render(request, "login_reg/showuser.html", context)

def logout(request):
    request.session.clear()
    messages.success(request, "Successfully logged out")
    return redirect('/users')

def showbook(request):  #--------------------------------------
 
    context = {
        'user': User.objects.get(id=request.session['user_id'])
    }
        #to pick up user info we need to do thru context
    return render(request, "login_reg/showbook.html", context)
  
# def addbook(request):
     
    #  add author
    

    # new_book = Book.objects.create(
    #         title = request.POST['name']
    #         author = request.POST['author']
    #         reviews = request.POST['review']
    #         stars = int(request.POST['stars'])
    # )

