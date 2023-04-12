int numInput = 0;
string contInput;
bool invalid;

do
{
    do //prevents the inputting of negatives, 0, and numbers that would cause overflow
    { 
        Console.WriteLine("Enter an integer: ");
        numInput = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (numInput <= 0 || numInput >= 1291)
        {
            Console.WriteLine("Please enter a valid number");
            invalid = true;
        }
        else
        {
            invalid= false;
            continue;
        }
    }while(invalid);
    //displays a power table starting from 1 and going to the integer input
    Console.WriteLine("Number\tSquared\tCubed");
    Console.WriteLine("=======\t=======\t=======");
    for (int i = 1; i <= numInput; i++)
    {
        Console.WriteLine($"{i}\t{i * i}\t{i * i * i}");
    }
    Console.WriteLine();
    //handles for inputs other than y
    do 
    { //if the input is neither y or n it asks again
        Console.WriteLine("Continue? (y/n)");
        contInput= Console.ReadLine();
        Console.WriteLine();
        // if n is input the program ends
        if(contInput == "n")
        {
            Console.WriteLine("Goodbye!");
            break;
        } 
        else if (contInput != "n" && contInput != "y")
        {
            Console.WriteLine("I didn't understand that, let's try again");
        }
    } while (contInput != "y");
} while (contInput == "y");