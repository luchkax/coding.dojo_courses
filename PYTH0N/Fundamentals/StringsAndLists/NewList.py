x = [19,2,54,-2,7,12,98,32,10,-3,6]
x.sort(key=float)
y=x[:len(x)/2]
z=x[len(x)/2:]
z.insert(0,y)
print z