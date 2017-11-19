from __future__ import unicode_literals
from django.shortcuts import render, redirect
import random
from datetime import datetime

def index(request):
    try:
        request.session['gold']
    except KeyError:
        request.session['gold'] = 0

    try:
        request.session['activity_list']
    except KeyError:
        request.session['activity_list'] = []

    # if request.session.gold not in request.session.keys():
    #     request.session.gold = 0
    # if 'activity_list' not in request.session.keys():
    #     request.session.activity_list = []

    return render(request, "ninja/index.html")

def process(request):
    choice = request.POST['building']
    print "You clicked", choice

    earned_gold = 0

    if choice == "farm":
        earned_gold = random.randint(10,20)
    elif choice == "cave":
        earned_gold = random.randint(5,10)
    elif choice =="house":
        earned_gold = random.randint(2,5)
    elif choice == "casino":
        if request.session['gold'] <= 0:
            request.session['activity.list'].append("Youcan't go to the casino if you don't have any gold! ({})".format(datetime.now()))
            return redirect('/')
        earned_gold = random.randint(-50,50)
        if earned_gold < 0:
            if request.session['gold'] - abs(earned_gold) > 0:
                print "{} - {} > 0".format(request.session['gold'], earned_gold)
                request.session['activity_list'].append("Entered a casino and lost {} gold... Ouch. ({})".format(abs(earned_gold), datetime.now()))
            else:
                request.session['activity_list'].append("Entered a casino and lost all gold... Unlucky day my friend! ({})".format(datetime.now()))
            request.session['gold'] += earned_gold
            return redirect ('/')
    request.session['gold'] += earned_gold
    request.session['activity_list'].append("Earned {} gold from the {}! ({})".format(earned_gold, choice, datetime.now()))

    return redirect('/')

def reset(request):
    del request.session['gold']
    del request.session['activity_list']
    return redirect ('/')

