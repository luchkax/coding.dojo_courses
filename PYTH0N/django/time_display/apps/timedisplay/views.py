
from django.shortcuts import render, HttpResponse, redirect
from datetime import datetime
from django.utils import timezone


from django.shortcuts import render

# Create your views here.

def index(request):
    
    context = {
        "time": datetime.now() 
    }
    return render(request, "timedisplay/index.html", context)