
//task1();
void task1()
{

    Console.WriteLine("Please enter in your first name");
    String name = Console.ReadLine();

    Console.WriteLine("Please enter in your age");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(" Hello " + name + " you will be " + (age + 5) + " in 5 years");
    Console.ReadKey();

}


//task2();
void task2()
{

    Console.WriteLine("Please enter in your age");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age <= 13)
    {

        Console.WriteLine("You are a child");

    }

    else if (age > 13 && age < 19)

    {

        Console.WriteLine("You are a teenager");

    }

    else if (age > 19 && age < 110)
    {

        Console.WriteLine("You are an adult");

    }

    else if (age > 110)
    {

        Console.WriteLine("You are far too old");
    }
}


//task3();
void task3()
{

    Console.WriteLine("Please enter an integer");
    int integer = Convert.ToInt32(Console.ReadLine());

    if (integer > 0)
    {

        Console.WriteLine("This is a positive number");

    }

    else if (integer < 0)

    {

        Console.WriteLine("This is a negative number");

    }


    else
    {

        Console.WriteLine("This number is zero");
    }

}

//task5();
void task5()
{

    Console.WriteLine("Please enter a year:");
    int num = Convert.ToInt32(Console.ReadLine());


    if (num % 2 == 0)
    {

        Console.WriteLine("This number is even");

    }

    else
    {
        Console.WriteLine("This number is odd");
    }
}















