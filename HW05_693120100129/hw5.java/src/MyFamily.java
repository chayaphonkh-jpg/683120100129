public class MyFamily {


    static class GrandFather {
        String name;
        int age;


        GrandFather(String name, int age) {
            this.name = name;
            this.age = age;
        }


        GrandFather() {
            this("mark", 89);
        }

        String infoFamilyGrandFather() {
            return "grandFather[name : " + name + ", age : " + age + "]";
        }
    }


    static class Uncle {
        String name;
        int age;

        Uncle(String name, int age) {
            this.name = name;
            this.age = age;
        }

        Uncle() {
            this("nopy", 54);
        }

        String infoFamilyUncle() {
            return "Uncle[name : " + name + ", age : " + age + "]";
        }
    }


    static class Father {
        String name;
        int age;

        Father(String name, int age) {
            this.name = name;
            this.age = age;
        }

        Father() {
            this("jack", 49);
        }

        String infoFamilyFather() {
            return "Father[name : " + name + ", age : " + age + "]";
        }


        static class Brother {
            String name;
            int age;

            Brother(String name, int age) {
                this.name = name;
                this.age = age;
            }

            Brother() {
                this("aoy", 24);
            }

            String infoFamilyBrother() {
                return "Brother[name : " + name + ", age : " + age + "]";
            }

            /* ======== Niece ======== */
            static class Niece {
                String name;
                int age;

                Niece(String name, int age) {
                    this.name = name;
                    this.age = age;
                }

                Niece() {
                    this("susa", 4);
                }

                String infoFamilyNiece() {
                    return "Niece[name : " + name + ", age : " + age + "]";
                }
            }
        }


        static class Me {
            String name;
            int age;

            Me(String name, int age) {
                this.name = name;
                this.age = age;
            }

            Me() {
                this("mark", 11);
            }

            String infoFamilyMe() {
                return "Me[name : " + name + ", age : " + age + "]";
            }


            static class Dog {
                String name;
                int age;

                Dog(String name, int age) {
                    this.name = name;
                    this.age = age;
                }

                Dog() {
                    this("BOBO", 1);
                }

                String infoFamilyDog() {
                    return "Dog[name : " + name + ", age : " + age + "]";
                }
            }
        }
    }


    public static void main(String[] args) {

        GrandFather gf = new GrandFather("sai", 75);
        Uncle uncle = new Uncle("Preecha", 50);
        Father father = new Father("mark", 48);

        Father.Brother brother = new Father.Brother("Krit", 25);
        Father.Brother.Niece niece = new Father.Brother.Niece("Ploysai", 6);

        Father.Me me = new Father.Me("farm", 17);
        Father.Me.Dog dog = new Father.Me.Dog("bobo", 2);

        System.out.println(gf.infoFamilyGrandFather());
        System.out.println(uncle.infoFamilyUncle());
        System.out.println(father.infoFamilyFather());
        System.out.println(brother.infoFamilyBrother());
        System.out.println(niece.infoFamilyNiece());
        System.out.println(me.infoFamilyMe());
        System.out.println(dog.infoFamilyDog());
    }
}
