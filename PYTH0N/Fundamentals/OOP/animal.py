class animal(object):
    def __init__(self, name):
        self.name = name
        self.health = 100

    def walk(self):
        self.health -=1
        return self
    def run(self):
        self.health -=5
        return self
    def display_health(self):
        print "{} health: {}" .format(self.name, self.health)
        return self

Animal = animal("Katy")
Animal.walk().walk().walk().run().run().display_health()

class dog(animal):
    def __init__(self,name):
        super(dog, self).__init__(name)
        self.health = 150

    def pet(self):
        self.health +=5
        return self

bulldog = dog("Rex")
bulldog.walk().walk().walk().run().run().pet().display_health()

class dragon(animal):
    def __init__(self, name):
        super(dragon, self).__init__(name)
        self.health = 170

    def fly(self):
        self.health -=10
        return self

    def display_health(self):
        print "I amd DRAGON!"
        super(dragon, self).display_health()
        return self

german_shephered = dragon("Jetta")
german_shephered.fly().display_health


