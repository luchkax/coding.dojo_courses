from django.conf.urls import url
from . import views

print "im in urls2"

urlpatterns = [
    url(r'^$', views.index),
    url(r'^surveys/process$', views.process),
    url(r'^result$', views.display_result)
]