#part1
for count in range(1, 1001):
    if count % 2 != 0:
        print count

#part2
for count in range(5,1000000,5):
    print count

#sumList
a = [1, 2, 5, 10, 255, 3]
print sum(a)

#Average list
a = [1, 2, 5, 10, 255, 3]
avg = sum(a) / len(a)
print avg
