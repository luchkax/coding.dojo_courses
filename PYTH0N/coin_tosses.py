head = 0
tail = 0

import random
for i in range(20):
    x = random.randint(1,40)
    if x % 2 == 0:
        head += 1
        print "Attempt #", i,": " + "Throwing a coin... It's a head! ... {} Head(s) and {} Tail(s)" .format(head, tail)
    else:    
        tail +=1
        print "Attempt #", i,": " + "Throwing a coin... It's a tail! ... {} Head(s) and {} Tail(s)" .format(head, tail)

