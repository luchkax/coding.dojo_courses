from __future__ import unicode_literals
import re
from django.db import models

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9\.\+_-]+@[a-zA-Z0-9\._-]+\.[a-zA-Z]*$')


class UserManager(models.Manager):
    def basic_validator(self, post_data):
        errors = {}
        for key, value in post_data.iteritems():
            if len(value)<1:
                errors[key] = "Field cannot be blank!"

            if key == "first_name" or key == "last_name":
                if not key in errors and len(value) < 3:
                    errors[key] = "First name and Last name must be at least 3 characters"

        if not "email" in errors and not re.match(EMAIL_REGEX, post_data['email']):
            errors['email'] = "Invalid email"

        else:
            if len(self.filter(email=post_data['email'])) > 1:
                errors['email'] = "Email already in use"
        return errors



class User(models.Model):
    first_name = models.CharField(max_length=255)
    last_name = models.CharField(max_length=255)
    email = models.TextField(max_length=100)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = UserManager()
    def __str__(self):
        return self.email