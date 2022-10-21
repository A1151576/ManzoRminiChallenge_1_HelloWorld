/*
Rafael Manzo 
Combine Level One
Monday October 17 2022
This program is an update to our old code from the combine where we use a simpe program to ask the user their name and then greet them. We will be ading data validation and pushing our code to our GitHub repostiories
                                --Hello World--
*/      
        string stop = "";
        Console.Clear();
        while(stop != "no"){
        Console.WriteLine("hello what is your name");

        string name1 = Console.ReadLine();
        Console.WriteLine("" );
        Console.WriteLine("" );

        Console.WriteLine("hello " + name1 + " nice to meet you." );
        Console.WriteLine("" );
        Console.WriteLine("" );

        Console.WriteLine("Play Again?" );
        Console.WriteLine("Type anything to restart || Type \"no\" to end program" );
        stop = Console.ReadLine();
        Console.WriteLine("" );
        Console.WriteLine("" );
        
        }
