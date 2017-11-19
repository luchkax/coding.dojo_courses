from django.shortcuts import render, HttpResponse, redirect
 

def index(request):
    return HttpResponse("Placeholder to display all list of blogs")

def new(request):
    return HttpResponse("placeholder to display a new form to create a new blog")

def create1(request):
    return render(request, "blogs/index.html")

def create(request):
    if request.method == "POST":
        print"*"*50
        print request.POST
        request.session['name'] = request.POST['name']
        request.session['counter'] = 100
        print request.POST['desc']
        request.session['name'] = 'test'
        print"*"*50
        return redirect('/create1', )

def show(request, blog_id):
    print blog_id
    return HttpResponse("Placeholder to display blog {}".format(blog_id))

def edit(request, blog_id):
    print blog_id
    return HttpResponse("Placeholder to edit blog {}".format(blog_id))

def destroy(request, blog_id):
    print blog_id
    return redirect('/')




