class product(object):
    def __init__(self, name, price, weight, brand):
        self.name = name
        self.price = price
        self.weight = weight
        self.brand = brand
        self.status = "For Sale"
    
    def display_info(self):
        print "Item: {}; Price: {} USD; Weight: {} g.; Brand: {};" .format(self.name, self.price, self.weight, self.brand)
        return self

    def sold(self):
        self.status = "Sold"
        print "Item is SOLD"
        return self

    def add_tax(self, tax):
        self.tax = tax
        self.taxonly = (self.price * self.tax + self.price) - self.price
        self.price = self.price * self.tax + self.price
        print "Tax: ", self.taxonly 
        print "Price after tax: " + str(self.price)
        return self

    def return_item(self, reason):
        self.reason = reason
        if reason == "Defective":
            self.status = "Defective"
            self.price = 0
            print "Item is defective. Not for Sale."
            
        elif reason == "Other":
            self.status = "For Sale"
            print "Item returned in new box. For Sale."

        elif reason == "Open box":
            self.status = "Used"
            self.price = self.price - (self.price * 0.2)
            print "Open Box. New price: {}" .format(self.price)
        return self

phone = product("Smartphone", 880, 208, "Apple inc.")
phone.display_info().sold().add_tax(0.12).return_item("Open box")
