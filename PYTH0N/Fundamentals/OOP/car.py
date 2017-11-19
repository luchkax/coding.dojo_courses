class car(object):
    def __init__(self, price, speed, fuel, mileage):
        self.price = price
        self.speed = speed
        self.fuel = fuel
        self.mileage = mileage
        
    def display_info(self):
        print "CAR "
        print "Price: " + str(self.price)
        print "Speed: " + str(self.speed)
        print "Fuel: " + str(self.mileage)
        if self.price >= 10000:
            print "Tax: 15%"
        else:
            print "Tax: 12%"
        
    
car1 = car(2000, 35, "Full", 15)
car2 = car(2000, 35, "Not Full", 105)
car3 = car(2000, 15, "Kind of full", 95)
car4 = car(3000, 55, "Full", 120)
car5 = car(20040, 45, "Not FULL", 105)

car1.display_info()
car2.display_info()
car3.display_info()
car4.display_info()
car5.display_info()