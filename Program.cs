Console.Clear();

void CatCall()
{
    Console.WriteLine(@"     |\___/|");
    Console.WriteLine(@"     / o o \");
    Console.WriteLine(@"    |   Y   |");
    Console.WriteLine(@"     \  -  /");
    Console.WriteLine(@"     /'---''.");
    Console.WriteLine(@"    |         \   __");
    Console.WriteLine(@"    \          \ (_ \");
    Console.WriteLine(@"     |  | |  |  \  \ \");
    Console.WriteLine(@"     |  | |  | _.\ / /");
    Console.WriteLine(@"     (__| (__|(_____/");
    Console.ReadKey();
    Menu();
}



void ReturningFunction(){
    Console.WriteLine("Tell me something");
    string response = Console.ReadLine();
    Console.WriteLine($"You wrote {response}");
    Console.ReadKey();
    Menu();
}


void FunctionOfAdding(){
    Console.WriteLine("What two numbers would you like to add?\n1)");
    int Number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("2)");
    int Number2 = int.Parse(Console.ReadLine());
    int Sum = Number1 + Number2;
    Console.WriteLine($"Here is your sum {Sum}");
    Console.ReadKey();
    Menu();
}


void Subtracting(){
     Console.WriteLine("What two numbers would you like to Subtract?\n1)");
    int Number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("2)");
    int Number2 = int.Parse(Console.ReadLine());
    int difference = Number1 - Number2;
    Console.WriteLine($"Here is your sum {difference}");
    Console.ReadKey();
    Menu();
}


void Multiplication(){
     Console.WriteLine("What two numbers would you like to Multiply?\n1)");
    int Number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("2)");
    int Number2 = int.Parse(Console.ReadLine());
    int product = Number1 * Number2;
    Console.WriteLine($"Here is your sum {product}");
    Console.ReadKey();
    Menu();
}


void Division(){
     Console.WriteLine("What two numbers would you like to Divide?\n1)");
    decimal Number1 = decimal.Parse(Console.ReadLine());
    Console.WriteLine("2)");
    decimal Number2 = decimal.Parse(Console.ReadLine());
    decimal Quotient = Number1 / Number2;
    Console.WriteLine($"Here is your sum {Quotient:0.00}");
    Console.ReadKey();
    Menu();
}

void Menu(){
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. See a Cat\n2. Write Something\n3. Add Two Numbers\n4. Subtract Two Numbers\n5. Multiply Two Numbers\n6. Divide Two Numbers\n7. Stop");
    string response = Console.ReadLine();
    if(response == "1")
    CatCall();
    if(response == "2")
    ReturningFunction();
    if(response == "3")
    FunctionOfAdding();
    if(response == "4")
    Subtracting();
    if(response == "5")
    Multiplication();
    if(response == "6")
    Division();
    if(response == "7"){
    Console.WriteLine("Thank you for playing :)");
    System.Environment.Exit(0);
    }
    else{
        Menu();
    }
}
Menu();