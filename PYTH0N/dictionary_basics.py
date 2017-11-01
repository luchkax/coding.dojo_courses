portfolio = {'name': 'Anna', 
            'age': '101', 
            'country of birth': 'The United States', 
            'favourite language': 'Python'}
def dictionar(dict):
    for a, b in portfolio.iteritems():
        print "My {} is {}" .format(a,b)
dictionar(portfolio)

