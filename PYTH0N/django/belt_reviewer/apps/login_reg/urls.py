from django.conf.urls import url
from . import views


urlpatterns = [
    url(r'^$', views.index),
    url(r'^register$', views.register),
    url(r'^login$', views.login),
    url(r'^(?P<user_id>\d+)$', views.showuser),
    url(r'^logout$', views.logout),
    url(r'^books$', views.showbook),
    # url(r'^books/add$', views.addbook),
     
]