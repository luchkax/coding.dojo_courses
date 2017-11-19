from django.shortcuts import render, HttpResponse, redirect
from .models import User
from django.contrib.messages import error


def index(request):
    context = {
        'users': User.objects.all()
    }
    return render(request, 'users_app/index.html', context)

def new(request):
    return render(request, 'users_app/new.html')

def create(request):
    errors = User.objects.basic_validator(request.POST)
    if len(errors):
        for key, message in errors.iteritems():
            error(request,message, extra_tags=key)

        return redirect('/users/new')
    
    User.objects.create(
        first_name = request.POST['first_name'],
        last_name = request.POST['last_name'],
        email = request.POST['email']
    )
    return redirect('/users')

def show(request, user_id):
    context = {
        'user': User.objects.get(id=user_id)
    }

    return render(request, "users_app/users.html", context)

def edit(request, user_id):
    context = {
        'user': User.objects.get(id=user_id)
    }
    return render(request, "users_app/edit.html", context)

def update(request, user_id):
    
    errors = User.objects.basic_validator(request.POST)
    if len(errors):
        for key, message in errors.iteritems():
            error(request,message, extra_tags=key)

        return redirect('/users/{}/edit'.format(user_id))

    user_to_update = User.objects.get(id=user_id)
    user_to_update.first_name = request.POST['first_name']
    user_to_update.last_name = request.POST['last_name']
    user_to_update.email = request.POST['email']
    user_to_update.save()

    return redirect('/users')

def destroy(request, user_id):
    u = User.objects.get(id=user_id)
    u.delete()

    return redirect('/users')