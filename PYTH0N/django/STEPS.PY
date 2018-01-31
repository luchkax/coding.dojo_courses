virtualenv djangoEnv
source djangoEnv/bin/activate
go into django folder

Creation
1) create a Django project
    --> django-admin startproject <project name goes here>


2) create an 'apps' folder
    --> cd <project name goes here>
    --> mkdir apps
    
    # --> cd <project name goes here>
    # --> md apps


3) create dunder-file in apps folder
    --> cd apps
    --> touch __init__.py

    # --> cd apps
    # --> copy nul __init__.py


4) create an app in the 'apps' folder
    --> python ../manage.py startapp <app name goes here>


5) create urls.py file inside of newly created app
    --> cd <app name goes here>
    --> touch urls.py

    # --> cd <app name goes here>
    # --> copy nul urls.py



Edit
1) settings.py in project folder -> register newly created app
    in INSTALLED_APPS add
    'apps.<appname>'
    # 'django_extensions'


2) include app urls.py in project urls.py
    from django.conf.urls import url, include
    url(r'^', include('apps.<appname>.urls'))


3) create a method in app's views.py

from django.shortcuts import render, HttpResponse

def index(request):
    response = "Hello, I am your first request!"
    return HttpResponse(response)


4) update new created app's urls.py file with route
from django.conf.urls import url
from views import *

urlpatterns = [
    url(r'^$', index),
    ]

# Go back to main project folder
python manage.py runserver
python manage.py makemigrations
python manage.py migrate

  make ERD diagram
  python manage.py graph_models -a -o myapp_models.png

Get table name raw queries
    User._meta.db_table


apps/appname/templates/


Named routes: 
action="{%url 'my_delete' id=5 %}"
return redirect(reverse('users:show', kwargs={'id': your_id_variable }))
<a href="{% url 'courses:index' %}">


# ORM COMMANDS

Creating a new record
Blog.objects.create({{field1}}="{{value}}", {{field2}}="{{value}}", etc) # creates a new record in the Blog table
Blog.objects.create(name="Star Wars Blog", desc="Everything about Star Wars") # creates a new blog record
Blog.objects.create(name="CodingDojo Blog") # creates a new blog record with the empty desc field
Alternative way of creating a record
b = Blog(name="Disney Blog", desc="Disney stuff")
b.name = "Disney Blog!"
b.desc = "Disney stuff!!!"
b.save()
Basic Retrieval
Blog.objects.first() - retrieves the first record in the Blog table
Blog.objects.last() - retrieves the last record in the Blog table
Blog.objects.all() - retrieves all records in the Blog table
Blog.objects.count() - shows how many records are in the Blog table
Updating the record - once you obtain an object that has the record you want to modify, use save() to update the record.  For example
b = Blog.objects.first() # gets the first record in the blogs table
b.name = "CodingDojo Blog"  # set name to be "CodingDojo Blog"
b.save() # updates the blog record
Deleting the record - use delete().  For example
b = Blog.objects.get(id=1)
b.delete() # deletes that particular record
Other methods to retrieve records
Blog.objects.get(id=1) - retrieves where id is 1; get only retrieves 1 record
Blog.object.filter(name="mike") - retrieves records where name is "mike"; returns multiple records
Blog.objects.exclude(name="mike") - opposite of filter; returns multiple records
Blog.objects.order_by("created_at") - orders by created_date field
Blog.objects.order_by("-created_at") - reverses the order
Blog.objects.raw("SELECT * FROM {{app_name}}_{{class/table name}}") - performs a raw SQL query
Blog.objects.first().comments.all() - grabs all comments from the first Blog
Blog.objects.get(id=15).comments.first() - grabs the first comment from Blog id = 15
Comment.objects.get(id=15).blog.name - returns the name of the blog where Comment id = 15 belongs to
Setting Relationship
Comment.objects.create(blog=Blog.objects.get(id=1), comment="test") - create a new comment where the comment's blog points to Blog.objects.get(id=1).

# Conditions
You can do a more complicated search than just if a given field is equal to a given value. Instead of just passing in the field name as a keyword argument to .get, .filter, or .exclude, you'd pass the field name__lookup type (that's a double underscore, also known as a "dunder" for people on-the-go). 

For example

Admin.objects.filter(first_name__startswith="S") - filters objects with first_name that starts with "S"
Admin.objects.exclude(first_name__contains="E") - excludes objects where first_name contains "E"
Admin.objects.filter(age__gt=80)  - filters objects with age greater than 80

# Combining queries
Queries can be chained together:

  admin = Admin.objects.filter(last_name__contains="o").exclude(first_name__contains="o")
  admin = Admin.objects.filter(age__lt=70).filter(first_name__startswith="S")
If it's the same type of query, instead of being chained you can add multiple arguments to the function:

  admin = Admin.objects.filter(age__lt=70, first_name__startswith="S")
These are cases where the conditions are joined with AND, as in, all users younger than 70 AND whose first name starts with "S". If you want OR, as in users who are younger than 70 OR whose first_name starts with "S", you can use | (the set union operator):

  admin = Admin.objects.filter(age__lt=70)|Admin.objects.filter(first_name__startswith="S")



  from apps.users.models import *