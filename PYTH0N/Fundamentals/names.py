
# #PART 1!

# students = [
#      {'first_name':  'Michael', 'last_name' : 'Jordan'},
#      {'first_name' : 'John', 'last_name' : 'Rosales'},
#      {'first_name' : 'Mark', 'last_name' : 'Guillen'},
#      {'first_name' : 'KB', 'last_name' : 'Tonel'}
# ]
# for x in students:
#     print x['first_name'], x['last_name']

#PART 2!
users = {
 'Students': [
     {'first_name':  'Michael', 'last_name' : 'Jordan'},
     {'first_name' : 'John', 'last_name' : 'Rosales'},
     {'first_name' : 'Mark', 'last_name' : 'Guillen'},
     {'first_name' : 'KB', 'last_name' : 'Tonel'}
  ],
 'Instructors': [
     {'first_name' : 'Michael', 'last_name' : 'Choi'},
     {'first_name' : 'Martin', 'last_name' : 'Puryear'}
  ]
 }

def call_info(dict):    
    for x in users:
        counter = 0
        print x
        for j in users[x]:
            counter +=1
            first_name = j['first_name'].upper()
            last_name = j['last_name'].upper()
            length = len(first_name) + len(last_name)
            print "{} -  {} {} - {}" .format(counter, first_name, last_name, length)
call_info(users)