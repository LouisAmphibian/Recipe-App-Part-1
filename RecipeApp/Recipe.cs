using System;

public class Recipe
{
    /* 
             Declaring an array to store: 
             * the names of ingredients, the 
             * unit Of Measurement,
             * ingredient Quantity,
             with size determined by numberOfIngredients
            */
    public string[] ingredientName;

    public string[] unitOfMeasurement;

    public double[] ingredientQuantity;

    public string[] ingredientSteps;

    double storedQauntity; //declaring but not assigning to use it as a open variable that will store the defualt Quantity;

    string storedMeasurement; // declaring but not assigning to use it as a open variable that will store the defualt unit of Measurement;

    public void AddIngredient(int numberOfIngredients)
    {

        /* 
         The array to store: 
         * the names of ingredients, the 
         * unit Of Measurement,
         * ingredient Quantity,
         with size determined by numberOfIngredients
        */
        ingredientName = new string[numberOfIngredients];

        unitOfMeasurement = new string[numberOfIngredients];

        ingredientQuantity = new double[numberOfIngredients];

        //loop to prompt the user till the number of ingredients is met.
        for (int i = 0; i < numberOfIngredients; i++)
        {
            //Prompting the user
            Console.WriteLine("Enter name of ingredient [e.g sugar/egg(s)]:");

            ingredientName[i] = Console.ReadLine();

            Console.WriteLine($"Enter the quantity/amount(numbers) for {ingredientName[i].ToUpper()} [e.g *2* eggs___ ]:");

            ingredientQuantity[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter the unit of measurenet  for {ingredientName[i].ToUpper()} [e.g tablespon/kg/ml/cup/bowl]:");

            unitOfMeasurement[i] = Console.ReadLine();

        }
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Successfully captured the ingredient details!");
        Console.ResetColor();
        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("");
    }

    public void AddSteps(int numberOfSteps)
    {
        //The array to store ingredient steps
        ingredientSteps = new string[numberOfSteps];

        //loop to prompt the user about the steps and store each step in the array
        for (int i = 0; i < numberOfSteps; i++)
        {
            //Setting stepNumber based on loop iteration
            int stepNumber = i + 1;

            // Prompting the user for the current step number
            Console.Write($"Step {stepNumber}: ");

            ingredientSteps[i] = Console.ReadLine();
        }
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Succesfully captured the Recipe Steps");
        Console.ResetColor();
        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("");
    }

    //displaying the recipe showing the user input
    public void DisplayRecipe()
    {
        //to display the whole recipe with the steps

        //to display the ingredient details
        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("THE RECIPE");
        Console.WriteLine("");
        Console.WriteLine("Ingredient(s)");

        for (int i = 0; i < ingredientName.Length; i++)
        {

            Console.WriteLine($"Ingredient name: {ingredientName[i]},the quantity: {ingredientQuantity[i]} and measurement: {unitOfMeasurement[i]}");

        }
        Console.WriteLine("");
        Console.WriteLine("STEP(s)");

        //to display the steps
        for (int i = 0; i < ingredientSteps.Length; i++)
        {
            //Setting stepNumber based on loop iteration
            int stepNumber = i + 1;

            Console.WriteLine($"Step {stepNumber}: {ingredientSteps[i]}");
        }
        Console.WriteLine("");
        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("");
    }

    //A function that will sccale the qauntity of the ingredient
    public void ScaleQantityOfRecipe()
    {
        double updatedScaleQauntityOfRecipe = 0;

        Console.WriteLine("Enter the name of ingredient you want to scale");

        string response = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < ingredientName.Length; i++) // for loop to ireterate through the ingredient name 
        {
            if (response.Equals(ingredientName[i])) //a condition to check if the user response matches the name
            {
                found = true;
                Console.WriteLine("Enter scaling factor (0.5, 2 or 3 or 4)");

                double factor;

                //a condition to check out if the user entered the correct scale 
                if (double.TryParse(Console.ReadLine(), out factor) && (factor == 0.5 || factor == 2 || factor == 3 || factor == 4))
                {

                    storedQauntity = ingredientQuantity[i]; //Storing the initial scale qauntity as defualt

                    ingredientQuantity[i] *= factor; //mutiplying the ingreient quantity with the factor and storing it back to the ingredientQauntity a

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Scaled quantity of {ingredientName[i]}: the updated quantity scale is :{ingredientQuantity[i]}");
                    Console.ResetColor();
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid scaling factor, must be (0.5, 2 or 3 or 4)");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("");
                }

                //Scalling the Unit measurement
                Console.WriteLine("Would you also like to scale/edit the Unit measurement? (Y/N) ");

                response = Console.ReadLine();

                if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {

                    Console.WriteLine($"Enter the unit of measurement for {ingredientName[i].ToUpper()} [e.g tablespon/kg/ml/cup/bowl]:");

                    storedMeasurement = unitOfMeasurement[i];//storing in case the user want to reset

                    unitOfMeasurement[i] = Console.ReadLine();

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Scaled quantity of {ingredientName[i].ToUpper()}: the updated unit of measurement  scale is :{unitOfMeasurement[i]}");
                    Console.ResetColor();
                    Console.WriteLine(""); ;
                }
                else if (response.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Your unit of measurement is still {unitOfMeasurement[i]} for {ingredientName[i].ToUpper()}");
                    Console.ResetColor();
                    Console.WriteLine("");

                }
            }
                break;

        }
            if (!found)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingredient not found in the recipe.");
            Console.ResetColor();
            Console.WriteLine("");
        }
        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("");

    }



    //A function that will reset the quantity 
    public void ResetQantityOfRecipe()
    {
        Console.WriteLine("Enter the name to reset the quantity");

        bool found = false;

        string response = Console.ReadLine();

        for (int i = 0; i < ingredientName.Length; i++) // for loop to ireterate through the ingredient name 
        {
            if (response.Equals(ingredientName[i])) //a condition to check if the user response matches the name
            {
                found = true;

                ingredientQuantity[i] = storedQauntity;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your reset is now {ingredientQuantity[i]}");
                Console.ResetColor();
                Console.WriteLine("");

                //reseting the Unit Measurement
                Console.WriteLine("Would you also like to reset the Unit measurement? (Y/N) ");

                response = Console.ReadLine();

                if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    unitOfMeasurement[i] = storedMeasurement;//reseting the unit of Measurement to defualt

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Reset unit measurement of {ingredientName[i].ToUpper()} is reset to {unitOfMeasurement[i]}");
                    Console.ResetColor();
                    Console.WriteLine(""); ;
                }
                else if (response.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Your unit of measurement is still {unitOfMeasurement[i]} for {ingredientName[i].ToUpper()}");
                    Console.ResetColor();
                    Console.WriteLine("");

                }
            }
            break;
        }

        if (!found)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingredient not found in the recipe.");
           Console.ResetColor();
            Console.WriteLine("");
        }

        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("");
    }


    //Clear data function to clear all data to zero
    public void ClearData()
    {
        ingredientName = new string[0];

        unitOfMeasurement = new string[0];

        ingredientQuantity = new double[0];

        ingredientSteps = new string[0];

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("You have cleared your data");
        Console.ResetColor();
        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("");
    }
}



