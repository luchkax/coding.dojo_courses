from django.conf.urls import url
from . import views           # This line is new!
urlpatterns = [
    url(r'^$', views.index),     # This line has changed!
    url(r'^test$', views.test)
   
    # url(r'^articles/(?P\d+)$', views.show)
    # url(r'^articles/(?P\w+)$', views.show_word)
    # url(r'^articles/2003/$', views.special_case_2003)
    # url(r'^articles/(?P[0-9]{4})$', views.year_archive)
    # url(r'^articles/(?P[0-9]{4})/(?P[0-9]{2}$', views.month_archive)
]