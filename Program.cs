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
