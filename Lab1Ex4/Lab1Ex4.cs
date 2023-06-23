/*Ex 4
Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”*/

class Lab1Ex1 {

    static void Main() {

        double numar;

        Console.WriteLine("Introdu numarul tau:");
        numar = double.Parse(Console.ReadLine());

        Console.WriteLine("Numarul tau este:");
        if (numar > 0) { 
            Console.WriteLine("+");
        }
        else if (numar == 0) {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("-");
        }

    }

}
