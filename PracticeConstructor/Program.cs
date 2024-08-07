using PracticeConstructor; 
{

    BabyClass baby1 = new BabyClass(); // new object default constructors
    baby1._name = "ramazan";
    baby1._surname = "yıldırım";


    baby1.BabyDisplay();


    BabyClass baby2 = new BabyClass("ramazan", "yıldırım"); // two parameters constructor


    baby2.BabyDisplay();




}
