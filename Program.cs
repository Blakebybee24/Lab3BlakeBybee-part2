//while loop
bool loop23 = true;
while (loop23 == true) 
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.WriteLine ("Please enter a number between 10 and 99. To exit type exit");
    string twentythreetext = (Console.ReadLine ());
    if (twentythreetext == "exit")
    {
        loop23 = false;
        Console.WriteLine ("Thank you for playing ");
        break;
    }
    int twentythree = Convert.ToInt32(twentythreetext);
    if(twentythree <10 || twentythree > 99)
    {
        Console.WriteLine ("invalide number");
        continue;
    }
    if (twentythree>= 10 && twentythree<= 99)
    {

    if(twentythree ==23 || twentythree == 46)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.ReadKey();
        continue ;

    }
    if (twentythree == 69 || twentythree == 92)
    {
    Console.BackgroundColor = ConsoleColor.Green;
    Console.Clear();
    Console.ReadKey();
    continue;
    }

    else
    {
    Console.BackgroundColor = ConsoleColor.Red;
    Console.Clear();
    Console.ReadKey();
    continue;
    }
    }
    else 
    {
    Console.WriteLine ("Please enter a number or exit");
    }
}

//do while loop
bool loop34 = true;
do {

    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.WriteLine ("Please enter a number between 10 and 99. To exit type exit");
    string thirtyfourtext = (Console.ReadLine ());
    if (thirtyfourtext == "exit")
    {
        loop23 = false;
        Console.WriteLine ("Thank you for playing ");
        
    }
    int thirtyfour = Convert.ToInt32(thirtyfourtext);
    if(thirtyfour <10 || thirtyfour  > 99)
    {
        Console.WriteLine ("invalide number");
        
    }
    if (thirtyfour >= 10 && thirtyfour<= 99)
    {
        if (thirtyfour ==34 || thirtyfour == 68)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ReadKey();
            
        }
        else
        {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.ReadKey();
        
        }
    }
    else {
    Console.WriteLine ("Please enter a number or exit");
    }
}

while (loop34 ==true);


//for loop 
for (int exit= 1; exit ==1;)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.WriteLine ("Please enter a number between 10 and 99. To exit type exit");
    string thirtythreetext = (Console.ReadLine ());
if (thirtythreetext == "exit")
{
    exit = 0;
    Console.WriteLine ("thank you for playing");
    break;
}
int thirtythree = Convert.ToInt32(thirtythreetext);
if (thirtythree<10 || thirtythree>99)
{
    Console.WriteLine ("invalidenumber");
    continue;
}
if (thirtythree>10 && thirtythree<99)
{
    if (thirtythree %33== 0)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        continue;
    }
if (thirtythree !%33== 0)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        continue;
    }

}
}

