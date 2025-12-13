using System;

public class MyFamiry
{
    
    public class GrandFather
    {
        public string name;
        public int age;

        public GrandFather(string name = "mark", int age = 89)
        {
            this.name = name;
            this.age = age;
        }

        public string infoFamilyGrandFather()
        {
            return $"grandFather[name : {name}, age : {age}]";
        }
    }

    
    public class Uncle
    {
        public string name;
        public int age;

        public Uncle(string name = "nopy", int age = 54)
        {
            this.name = name;
            this.age = age;
        }

        public string infoFamilyUncle()
        {
            return $"Uncle[name : {name}, age : {age}]";
        }
    }

    
    public class Father
    {
        public string name;
        public int age;

        public Father(string name = "jack", int age = 49)
        {
            this.name = name;
            this.age = age;
        }

        public string infoFamilyFather()
        {
            return $"Father[name : {name}, age : {age}]";
        }

        public class Brother
        {
            public string name;
            public int age;

            public Brother(string name = "aoy", int age = 24)
            {
                this.name = name;
                this.age = age;
            }

            public string infoFamilyBrother()
            {
                return $"Brother[name : {name}, age : {age}]";
            }

            
            public class Niece
            {
                public string name;
                public int age;

                public Niece(string name = "susa", int age = 4)
                {
                    this.name = name;
                    this.age = age;
                }

                public string infoFamilyNiece()
                {
                    return $"Niece[name : {name}, age : {age}]";
                }
            }
        }

        
        public class Me
        {
            public string name;
            public int age;

            public Me(string name = "mark", int age = 11)
            {
                this.name = name;
                this.age = age;
            }

            public string infoFamilyMe()
            {
                return $"Me[name : {name}, age : {age}]";
            }

            
            public class Dog
            {
                public string name;
                public int age;

                public Dog(string name = "BOBO", int age = 1)
                {
                    this.name = name;
                    this.age = age;
                }

                public string infoFamilyDog()
                {
                    return $"Dog[name : {name}, age : {age}]";
                }
            }
        }
    }

  
    public static void Main(string[] args)
    {
        GrandFather gf = new GrandFather("sai", 75);
        Uncle uncle = new Uncle("Preecha", 50);
        Father father = new Father("mark", 48);

        Father.Brother brother = new Father.Brother("Krit", 25);
        Father.Brother.Niece niece = new Father.Brother.Niece("Ploysai", 6);

        Father.Me me = new Father.Me("farm", 17);
        Father.Me.Dog dog = new Father.Me.Dog("bobo", 2);

        Console.WriteLine(gf.infoFamilyGrandFather());
        Console.WriteLine(uncle.infoFamilyUncle());
        Console.WriteLine(father.infoFamilyFather());
        Console.WriteLine(brother.infoFamilyBrother());
        Console.WriteLine(niece.infoFamilyNiece());
        Console.WriteLine(me.infoFamilyMe());
        Console.WriteLine(dog.infoFamilyDog());
    }
}
