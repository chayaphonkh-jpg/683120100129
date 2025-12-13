class myfamiry:
    
    class grandFather:
        def __init__(self, name="mark", age=89):
            self.name = name
            self.age = age
            
        def infoFamilyGrandFather(self):
            return f'grandFather[name : {self.name}, age : {self.age}]'
            
    
    class Uncle:
        def __init__(self, name="nopy", age=54):
            self.name = name
            self.age = age
            
        def infoFamilyUncle(self):
            return f'Uncle[name : {self.name}, age : {self.age}]'
        
        
    class Father:
        def __init__(self, name="jack", age=49):
            self.name = name
            self.age = age
            
        def infoFamilyFather(self):
            return f'Father[name : {self.name}, age : {self.age}]'
        
        class Brother:
            def __init__(self, name="aoy", age=24):
                self.name = name
                self.age = age
            
            def infoFamilyBrother(self):
                return f'Brother[name : {self.name}, age : {self.age}]'
            
            class Niece:
                def __init__(self, name="susa", age=4):
                    self.name = name
                    self.age = age
                    
                def infoFamilyNiece(self):
                    return f'Niece[name : {self.name}, age : {self.age}]'
        
        
        class Me:
            def __init__(self, name="mark", age=11):
                self.name = name
                self.age = age
            
            def infoFamilyMe(self):
                return f'Me[name : {self.name}, age : {self.age}]'
           
            class Dog:
                def __init__(self, name="BOBO", age=1):
                    self.name = name
                    self.age = age
                    
                def infoFamilyDog(self):
                    return f'Dog[name : {self.name}, age : {self.age}]'
                
    def __init__(self, name="None", age=None):
        self.name = name
        self.age = age
            
    def infoFamilyGrandFatherfamily(self):
        return f'grandFatherfamily[name : {self.name}, age : {self.age}]'

    
gf = myfamiry.grandFather("sai", 75)
uncle = myfamiry.Uncle("Preecha", 50)
father = myfamiry.Father("mark", 48)
brother = myfamiry.Father.Brother("Krit", 25)
niece = myfamiry.Father.Brother.Niece("Ploysai", 6)
me = myfamiry.Father.Me("farm", 17)
dog = myfamiry.Father.Me.Dog("bobo", 2)

print(gf.infoFamilyGrandFather())
print(uncle.infoFamilyUncle())
print(father.infoFamilyFather())
print(brother.infoFamilyBrother())
print(niece.infoFamilyNiece())
print(me.infoFamilyMe())
print(dog.infoFamilyDog())