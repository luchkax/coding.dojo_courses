x = ['magical unicorns',19.5,'hello',98.98,'world']
mystr = ""
sum = 0

for i in x:
        if isinstance(i, int) or isinstance(i, float):
            sum = sum + i
        elif isinstance(i, str):
            mystr = mystr + ' ' + i

if mystr and sum:
    print "This list you entered is a mixed type"
    print "String", mystr
    print "Sum", sum

elif mystr:
    print "The list you entered is of string type"
    print "String:", mystr

else:
    print "The list you entered is of integer type"
    print "Sum", sum

