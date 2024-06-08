// See https://aka.ms/new-console-template for more information

using System; //using the System class to import its methods

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding the ingredient
            // Creating an instance of the Ingredient class
            Recipe recipeClass = new Recipe();

            String response = " "; // string must assign nothing to be able to store user's response

            int choice = 0;//

            int numberOfIngredients; // Declare numberOfRecipes variable

            int numberOfSteps;      //numberOfSteps



            // Display for the user
            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome To The Recipe App! \n" +
                                 "***************************************\n" +
                                 "Would you like to?\n" +
                                 "\n" +
                                 "1-To Enter the Recipe details\n" +
                                 "2-To Display Recipe details\n" +
                                 "3-To Scale the Recipe\n" +
                                 "4-To Reset Quantities\n" +
                                 "5-To Clear Data\n" +
                                 "6-To Exit ");

                    Console.Write("Type here:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Would you like to add recipe(s) (Y/N)?");

                            response = Console.ReadLine(); // User input

                            // A condition to check if the user agrees with the amount 
                            if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                            {
                                // adding the ingredients
                                Console.WriteLine("How many ingredients  do you want to add for your recipe?");

                                response = Console.ReadLine();

                                // To check if the user agrees with the amount
                                if (int.TryParse(response, out numberOfIngredients))
                                {

                                    Console.WriteLine($"You want to add {numberOfIngredients} ingredients (Y/N)");

                                    response = Console.ReadLine();


                                    if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                                    {
                                        //Calling the addIngredient method of the Ingredient class with the numberOfIngredients parameter
                                        recipeClass.AddIngredient(numberOfIngredients);

                                    }
                                    //If the user selects "N"- A condition will prompt the user to edit or exit application
                                    else if (response.Equals("N", StringComparison.OrdinalIgnoreCase))
                                    {
                                        Console.WriteLine("Choose option if you want to:\n" +
                                            "1-Edit number of Ingredient(s)\n" +
                                            "2-Quit");

                                        response = Console.ReadLine();

                                        switch (Convert.ToInt32(response))
                                        {
                                            case 1:
                                                Console.WriteLine("How many ingredients  do you want to add?");

                                                response = Console.ReadLine();
                                                if (int.TryParse(response, out numberOfIngredients))
                                                {

                                                    Console.WriteLine($"You want to add {numberOfIngredients} ingredients (Y/N)");

                                                    response = Console.ReadLine();

                                                    if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                                                    {

                                                        //Calling the addIngredient method of the Ingredient class with the numberOfIngredients parameter
                                                        recipeClass.AddIngredient(numberOfIngredients);
                                                    }
                                                    else if (response.Equals("N", StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        Console.WriteLine("Thank you for visiting THE RECIPE APP, SEE YOU SOON :)");

                                                        Environment.Exit(0);
                                                    }
                                                }

                                                break;

                                            case 2:
                                                Console.WriteLine("Thank you for visiting THE RECIPE APP, SEE YOU SOON :)");

                                                Environment.Exit(0);

                                                break;
                                        }
                                    }
                                }


                                //adding the steps
                                Console.WriteLine("How many STEPS do you want to add for your recipe?");

                                response = Console.ReadLine();

                                if (int.TryParse(response, out numberOfSteps))
                                {
                                    Console.WriteLine($"You want to add {numberOfSteps} steps (Y/N)");

                                    response = Console.ReadLine();

                                    if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                                    {
                                        //Calling the addIngredient method of the Ingredient class with the numberOfIngredients parameter
                                        recipeClass.AddSteps(numberOfSteps);

                                    }
                                    //If the user selects "N"- A condition will prompt the user to edit or exit application
                                    else if (response.Equals("N", StringComparison.OrdinalIgnoreCase))
                                    {
                                        Console.WriteLine("Choose option if you want to:\n" +
                                            "1-Edit number of STEP(S) \n" +
                                            "2-Quit");

                                        response = Console.ReadLine();

                                        switch (Convert.ToInt32(response))
                                        {
                                            case 1:
                                                Console.WriteLine("How many STEPS do you want to add for your recipe?");

                                                response = Console.ReadLine();
                                                if (int.TryParse(response, out numberOfSteps))
                                                {

                                                    Console.WriteLine($"You want to add {numberOfSteps} steps (Y/N)");

                                                    response = Console.ReadLine();

                                                    if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        recipeClass.AddSteps(numberOfSteps);
                                                    }
                                                    else if (response.Equals("N", StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        Console.WriteLine("Thank you for visiting THE RECIPE APP, SEE YOU SOON :)");

                                                        Environment.Exit(0);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.BackgroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Entered Invalid input. Must be ONLY INTERGER");
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    Console.WriteLine();
                                                    Console.ResetColor();
                                                    Console.WriteLine("");
                                                }

                                                break;

                                            case 2:
                                                Console.WriteLine("Thank you for visiting THE RECIPE APP, SEE YOU SOON :)");

                                                Environment.Exit(0);

                                                break;

                                            default:
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.BackgroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Entered Invalid input");
                                                Console.BackgroundColor = ConsoleColor.Black;
                                                Console.WriteLine();
                                                Console.ResetColor();
                                                Console.WriteLine("");
                                                break;

                                        }
                                    }
                ;
                                }else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Entered Invalid input. Must be ONLY INTERGER");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.WriteLine();
                                    Console.ResetColor();
                                    Console.WriteLine("");
                                }

                            }
                            else if (response.Equals("N", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Thank you for visiting THE RECIPE APP, SEE YOU SOON :)");
                                Environment.Exit(0);
                            }


                            break;

                        case 2:
                            //a case that will show the recipe details
                            recipeClass.DisplayRecipe();
                            break;

                        case 3:
                            //a function to scale the qantity of Recipe
                            recipeClass.ScaleQantityOfRecipe();
                            break;

                        case 4:
                            //a function that will reset the qauntity of recipe back to normal
                            recipeClass.ResetQantityOfRecipe();
                            break;

                        case 5:
                            //a function to clear user data
                            recipeClass.ClearData();
                            break;

                        case 6:
                            //exit the application
                            Console.WriteLine("Thank you for visiting THE RECIPE APP, SEE YOU SOON :)");

                            Environment.Exit(0);
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Entered Invalid input");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine();
                            Console.ResetColor();
                            Console.WriteLine("");
                            break;

                    }
                }catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input enter the correct input");
                    Console.WriteLine(e.Message);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("");

                }


            }
            // Pauses the program and waits for the user to press any key before continuing
            Console.ReadKey();

        }

    }
}
