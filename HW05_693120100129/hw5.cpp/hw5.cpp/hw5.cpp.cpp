#include <iostream>
#include <string>
using namespace std;

class MyFamiry {

public:
    
    class GrandFather {
    public:
        string name;
        int age;

        GrandFather(string name = "mark", int age = 89) {
            this->name = name;
            this->age = age;
        }

        string infoFamilyGrandFather() {
            return "grandFather[name : " + name + ", age : " + to_string(age) + "]";
        }
    };

    
    class Uncle {
    public:
        string name;
        int age;

        Uncle(string name = "nopy", int age = 54) {
            this->name = name;
            this->age = age;
        }

        string infoFamilyUncle() {
            return "Uncle[name : " + name + ", age : " + to_string(age) + "]";
        }
    };

    
    class Father {
    public:
        string name;
        int age;

        Father(string name = "jack", int age = 49) {
            this->name = name;
            this->age = age;
        }

        string infoFamilyFather() {
            return "Father[name : " + name + ", age : " + to_string(age) + "]";
        }

        
        class Brother {
        public:
            string name;
            int age;

            Brother(string name = "aoy", int age = 24) {
                this->name = name;
                this->age = age;
            }

            string infoFamilyBrother() {
                return "Brother[name : " + name + ", age : " + to_string(age) + "]";
            }

            
            class Niece {
            public:
                string name;
                int age;

                Niece(string name = "susa", int age = 4) {
                    this->name = name;
                    this->age = age;
                }

                string infoFamilyNiece() {
                    return "Niece[name : " + name + ", age : " + to_string(age) + "]";
                }
            };
        };

        
        class Me {
        public:
            string name;
            int age;

            Me(string name = "mark", int age = 11) {
                this->name = name;
                this->age = age;
            }

            string infoFamilyMe() {
                return "Me[name : " + name + ", age : " + to_string(age) + "]";
            }

            
            class Dog {
            public:
                string name;
                int age;

                Dog(string name = "BOBO", int age = 1) {
                    this->name = name;
                    this->age = age;
                }

                string infoFamilyDog() {
                    return "Dog[name : " + name + ", age : " + to_string(age) + "]";
                }
            };
        };
    };
};


int main() {

    MyFamiry::GrandFather gf("sai", 75);
    MyFamiry::Uncle uncle("Preecha", 50);
    MyFamiry::Father father("mark", 48);

    MyFamiry::Father::Brother brother("Krit", 25);
    MyFamiry::Father::Brother::Niece niece("Ploysai", 6);

    MyFamiry::Father::Me me("farm", 17);
    MyFamiry::Father::Me::Dog dog("bobo", 2);

    cout << gf.infoFamilyGrandFather() << endl;
    cout << uncle.infoFamilyUncle() << endl;
    cout << father.infoFamilyFather() << endl;
    cout << brother.infoFamilyBrother() << endl;
    cout << niece.infoFamilyNiece() << endl;
    cout << me.infoFamilyMe() << endl;
    cout << dog.infoFamilyDog() << endl;

    return 0;
}
