from __future__ import unicode_literals

from django.db import models

# Create your models here.

class User(models.Model):
   first_name = models.CharField(max_length=255)
   last_name = models.CharField(max_length=255)
   email = models.CharField(max_length=255)
   created_at = models.DateTimeField(auto_now_add=True)
   updated_at = models.DateTimeField(auto_now=True)

class Book(models.Model):
   name = models.CharField(max_length=255)
   desc = models.TextField(max_length=100)
   created_at = models.DateTimeField(auto_now_add=True)
   updated_at = models.DateTimeField(auto_now=True)
   uploader = models.ForeignKey(User, related_name='uploaded_books')
   liked_by = models.ManyToManyField(User, related_name='liked_books')


# In [39]: u = Book.objects.get(id=2).uploader        
# In [40]: u
# Out[40]: <User: User object>
# In [43]: b = Book.objects.get(id=1)
# In [52]: b.liked_by.get(id=1)
# Out[52]: <User: User object>
# In [53]: a = b.liked_by.get(id=1)
# In [54]: a.first_name
# Out[54]: u'Nazar'


# In [104]: b = Book.objects.get(id = 2)

# In [105]: b.uploader
# Out[105]: <User: User object>

# In [106]: b.uploader.first_name
# Out[106]: u'Nazar'

# In [107]: 


