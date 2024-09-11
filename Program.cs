// See https://aka.ms/new-console-template for more information
//Skriv ett programm som skriver ut alla heltal mellan 1 och 20

/*
int tal = 1;
while(tal <= 20)
{
    Console.WriteLine(tal);
    tal++;

}*/

/*
 for(int i = 1; i <= 20; i++) Console.WriteLine(i); */








/*Skrive ett program som där användaren får mata in ett heltal mellan 1 och 100. 
Programmet ska sedan skriva ut alla heltal mellan de tal användaren skrev in och 101. */

/*
Console.WriteLine("Skriv ett tal mellan 1 och 100!");
int tal = int.Parse(Console.ReadLine()) +1;
if(tal > 101)
    {
        Console.WriteLine("fel, ett tal mellan 1 och 100 tack!");
    }
while(tal <=101)
    {
        Console.WriteLine(tal);
        tal++;
    }
    */






    //Utöka programmet för medelvärde så att det även skriver ut största och minsta inmatade tal.

    {
        int antalTal;
        double summa = 0, input, biggestValue = 0, smallestValue = 0;
        Console.WriteLine("Antal tal som ska matas in?");
        antalTal = Convert.ToInt32(Console.ReadLine());
        for (int i=1; i<= antalTal; i++)
        {
            Console.WriteLine("Skriv värde " + i + ": ");
            input = Convert.ToDouble(Console.ReadLine());

            if(input < smallestValue || i ==1)
                smallestValue = input;

            if(input > biggestValue || i ==1)
                biggestValue = input;
            summa = summa + input;
        }

        Console.WriteLine("Medelvärdet är:" + (summa / antalTal));
        Console.WriteLine("Minsta värdet är:" + (smallestValue));
        Console.WriteLine("Största värdet är:"+ (biggestValue));
    }