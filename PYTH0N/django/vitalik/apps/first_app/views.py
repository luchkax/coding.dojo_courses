from django.shortcuts import render, HttpResponse, redirect

# Create your views here.
def index(request):
    response = "Hello, I am your first request!"
    return HttpResponse(response)
# def test(request):
#     response = "hello i am test"
#     return HttpResponse(response)

# def index(request):
#     context = {
#         "email" : "blog@gmail.com",
#         "name" : "mike"
#     }
#     return render(request, "first_app/index.html", context)