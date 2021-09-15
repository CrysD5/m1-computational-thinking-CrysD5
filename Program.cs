using System;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Names the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            // NOTE: great implementation and clean code
            Console.WriteLine("Please enter a number for A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a number for B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a == b)
            {
                Console.WriteLine("These numbers are equal.");
            }
            else 
            {
                Console.WriteLine("These numbers are not equal.");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            // NOTE: clean implementation
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if ((number % 2) == 0)
            {
                // divisible by 2
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd.");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Please enter a letter: ");
            char letter = Convert.ToChar(Console.ReadLine());
            // NOTE: using a switch case is good but you could have just used an if statement
            // e.g. if(letter == 'a' || letter == 'e' || etc...)
            switch(letter)
            {
                case 'a': 
                    Console.WriteLine("Vowel");
                    break;
                case 'e': 
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;

            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number for A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number for B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a - b;
            // NOTE: good way to use math to solve this
            if (c > 0)
            {
                Console.WriteLine("A is bigger than B");
            }
            else if (c < 0)
            {
                Console.WriteLine("B is bigger than A");
            }
            else
            {
                Console.WriteLine("Your numbers are the same.");
            }





            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if((number % 3) == 0) 
            {
                // divisible by 3
                Console.WriteLine("Divisible by Three");
            }
            else
            {
                Console.WriteLine("Not divisible by Three");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here
            // NOTE: the line below this should have been deleted or commented out
            // NOTE: rearranging the code below could have saved you a few lines of code
            // e.g. only apply the discount if it meets the condition rather than calulating both and then using the one you need
            Console.WriteLine(4 * 13);

            Console.WriteLine("\n\nPlease enter the number of people on the bill.");
            int customerCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nPlease enter the amount of one dinner.");
            int dinnerCost = Convert.ToInt32(Console.ReadLine());
            float bill = dinnerCost * customerCount;
            double billTotal = Math.Round(bill, 2);
            double discount1 = Math.Round(billTotal * 0.90, 2);
            double discount2 = Math.Round(billTotal * 0.95, 2);

            Console.WriteLine("\nYour total is $" + billTotal);

            if (billTotal >= 50)
            {
                Console.WriteLine("\nAfter applying a 10% discount your new total is $" + discount1);
            }
            else
            {
                Console.WriteLine("\nAfter applying a 5% discount your new total is $" + discount2);
            }



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
                    // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here
            Console.WriteLine("Please enter your age.");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 0 && age < 3)
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if(age >= 3 && age < 5)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if(age >=5 && age < 12){
                Console.WriteLine("Elementary School");
            }
            else if(age >= 12 && age < 15)
            {
                Console.WriteLine("Middle School");
            }
            else if (age >= 15 && age < 19)
            {
                Console.WriteLine("High School");
            }
            else if (age >= 19 && age < 23)
            {
                Console.WriteLine("College");
            }
            else if (age >= 23 && age < 66)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (age >= 66 && age < 101)
            {
                Console.WriteLine("The Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans");
            }



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number from zero to ten in word format.");
            string num = Console.ReadLine();

            // NOTE: good job performing a ToLower() for this comparison
            string number = num.ToLower();

            switch (number)
            {
                case "zero":
                    Console.WriteLine("The number you enter is: 0");
                    break;
                case "one":
                    Console.WriteLine("The number you enter is: 1");
                    break;
                case "two":
                    Console.WriteLine("The number you enter is: 2");
                    break;
                case "three":
                    Console.WriteLine("The number you enter is: 3");
                    break;
                case "four":
                    Console.WriteLine("The number you enter is: 4");
                    break;
                case "five":
                    Console.WriteLine("The number you enter is: 5");
                    break;
                case "six":
                    Console.WriteLine("The number you enter is: 6");
                    break;
                case "seven":
                    Console.WriteLine("The number you enter is: 7");
                    break;
                case "eight":
                    Console.WriteLine("The number you enter is: 8");
                    break;
                case "nine":
                    Console.WriteLine("The number you enter is: 9");
                    break;
                case "ten":
                    Console.WriteLine("The number you enter is: 10");
                    break;
                default:
                    Console.WriteLine("Number not recognized. Please check your spelling and enter a number between zero and ten in word format.");
                    break;
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here
            Console.WriteLine("Enter your first name:");
            string first = Console.ReadLine();
            // NOTE: you didn't have to save these to new variables you could have used first.Length in the if statement condition
            int firstLength = first.Length;
            Console.WriteLine("Enter your last name:");
            string last = Console.ReadLine();
            int lastLength = last.Length;

            Console.WriteLine(first + " " + last + " is your full name.");

            if (firstLength > lastLength)
            {
                Console.WriteLine("First is longer.");
            }
            else if (firstLength == lastLength)
            {
                Console.WriteLine("Same-sies!");
            }
            else
            {
                Console.WriteLine("Last must be longer!");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here
            // NOTE: should have done a ToLower() comparison because this would fail with case sensitivity
            Console.WriteLine("Please enter name A: ");
            string nameA = Console.ReadLine();

            Console.WriteLine("Please enter name B: ");
            string nameB = Console.ReadLine();



            if (nameA == nameB)
            {
                Console.WriteLine("The names are the same.");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here
            Console.WriteLine("Please enter your first name.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter where you were born.");
            string born = Console.ReadLine();
            // NOTE: nice sentence structure
            Console.WriteLine("Hello " + name + ". " + born + " seems like a very nice place to be born!");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
