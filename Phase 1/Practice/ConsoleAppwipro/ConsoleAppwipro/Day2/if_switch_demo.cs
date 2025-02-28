//using System;


//namespace ConsoleAppwipro.Day2
//{
//    class if_switch_demo
//    {
//        static void Main(string[] args)
//        {
//            //int age;
//            //Console.WriteLine("Enter the age of the candidate:");
//            //age = int.Parse(Console.ReadLine());

//            //// if else
//            ///
//            ////if (age >= 18)
//            ////    Console.WriteLine("The candidate is eligible for voting.");
//            ////else
//            ////    Console.WriteLine("The candidate is ineligible.");

//            // ==================================================================================================================

//            // if else if

//            //if (age < 10)
//            //    Console.WriteLine("Age is less than 10");
//            //else if (age < 20)
//            //    Console.WriteLine("Age is greater than or equal to 10 but less than 20");
//            //else if (age < 30)
//            //    Console.WriteLine("Age is greater than or equal to 20 but less than 30");
//            //else
//            //    Console.WriteLine("Age is greater than or equal to 30");

//            //====================================================================================================================

//            //switch

//            //int num;
//            //Console.WriteLine("Enter a number between 1 and 5");
//            //num = int.Parse(Console.ReadLine());
//            //switch (num)
//            //{
//            //    case 1:
//            //        Console.WriteLine("The number given is 1");
//            //        break;
//            //    case 2:
//            //        Console.WriteLine("The number given is 2");
//            //        break;
//            //    case 3:
//            //        Console.WriteLine("The number given is 3");
//            //        break;
//            //    case 4:
//            //        Console.WriteLine("The number given is 4");
//            //        break;
//            //    case 5:
//            //        Console.WriteLine("The number given is 5");
//            //        break;
//            //    default:
//            //        Console.WriteLine("Please enter a number between 1 and 5 only");
//            //        break;
//            //}

//            // practice programs

//            // accept day number and display day name

//            // if else if

//            //int num;
//            //Console.WriteLine("Enter a number between 0 and 7");
//            //num = int.Parse(Console.ReadLine());
//            //if (num == 0 || num == 7)
//            //    Console.WriteLine("Sunday");
//            //else if (num == 1)
//            //    Console.WriteLine("Monday");
//            //else if (num == 2)
//            //    Console.WriteLine("Tuesday");
//            //else if (num == 3)
//            //    Console.WriteLine("Wednesday");
//            //else if (num == 4)
//            //    Console.WriteLine("Thursday");
//            //else if (num == 5)
//            //    Console.WriteLine("Friday");
//            //else if (num == 6)
//            //    Console.WriteLine("Saturday");
//            //else
//            //    Console.WriteLine("Please enter a number between 0 and 7");

//            // ====================================================================================================================================

//            // Swtich case

//            //int num;
//            //Console.WriteLine("Enter a number between 0 and 7");
//            //num = int.Parse(Console.ReadLine());
//            //switch (num)
//            //{
//            //    case 0:
//            //    case 7:
//            //        Console.WriteLine("Sunday");
//            //        break;
//            //    case 1:
//            //    Console.WriteLine("Monday");
//            //    break;
//            //case 2:
//            //    Console.WriteLine("Tuesday");
//            //    break;
//            //case 3:
//            //    Console.WriteLine("Wednesday");
//            //    break;
//            //case 4:
//            //    Console.WriteLine("Thursday");
//            //    break;
//            //case 5:
//            //    Console.WriteLine("Friday");
//            //    break;
//            //case 6:
//            //    Console.WriteLine("Saturday");
//            //    break;
//            //    default:
//            //        Console.WriteLine("Please enter a value between 0 and 7");
//            //        break;
//            //}

//            // ==========================================================================================================================


//            // accept day name and display day number

//            // if else if

//            //string name;
//            //Console.WriteLine("Enter the name of the day");
//            //name = Console.ReadLine();
//            //if (String.Equals(name, "Sunday"))
//            //    Console.WriteLine("0 or 7");
//            //else if (String.Equals(name, "Monday"))
//            //    Console.WriteLine("1");
//            //else if (String.Equals(name, "Tuesday"))
//            //    Console.WriteLine("2");
//            //else if (String.Equals(name, "Wednesday"))
//            //    Console.WriteLine("3");
//            //else if (String.Equals(name, "Thursday"))
//            //    Console.WriteLine("4");
//            //else if (String.Equals(name, "Friday"))
//            //    Console.WriteLine("5");
//            //else if (String.Equals(name, "Saturday"))
//            //    Console.WriteLine("6");
//            //else
//            //    Console.WriteLine("Please enter a valid day");

//            // ==========================================================================================================================

//            //Swtich case

//            //string name;
//            //Console.WriteLine("Enter the name of the day");
//            //name = Console.ReadLine();

//            //switch (name)
//            //{
//            //    case "Sunday":
//            //        Console.WriteLine("0 or 7");
//            //        break;
//            //    case "Monday":
//            //        Console.WriteLine("1");
//            //        break;
//            //    case "Tuesday":
//            //        Console.WriteLine("2");
//            //        break;
//            //    case "Wednesday":
//            //        Console.WriteLine("3");
//            //        break;
//            //    case "Thursday":
//            //        Console.WriteLine("4");
//            //        break;
//            //    case "Friday":
//            //        Console.WriteLine("5");
//            //        break;
//            //    case "Saturday":
//            //        Console.WriteLine("6");
//            //        break;
//            //    default:
//            //        Console.WriteLine("Please Enter a Valid day");
//            //        break;
//            //}

//            // ==========================================================================================================================

//            // accept month number and display month name

//            // if else if

//            //int num;
//            //Console.WriteLine("Enter a number between 1 and 12");
//            //num = int.Parse(Console.ReadLine());
//            //if (num == 1)
//            //    Console.WriteLine("January");
//            //else if (num == 2)
//            //    Console.WriteLine("February");
//            //else if (num == 3)
//            //    Console.WriteLine("March");
//            //else if (num == 4)
//            //    Console.WriteLine("April");
//            //else if (num == 5)
//            //    Console.WriteLine("May");
//            //else if (num == 6)
//            //    Console.WriteLine("June");
//            //else if (num == 7)
//            //    Console.WriteLine("July");
//            //else if (num == 8)
//            //    Console.WriteLine("August");
//            //else if (num == 9)
//            //    Console.WriteLine("September");
//            //else if (num == 10)
//            //    Console.WriteLine("October");
//            //else if (num == 11)
//            //    Console.WriteLine("November");
//            //else if (num == 12)
//            //    Console.WriteLine("December");
//            //else
//            //    Console.WriteLine("Please enter a number between 1 and 12");

//            // ==========================================================================================================================

//            //switch case

//            //int num;
//            //Console.WriteLine("Enter a number between 1 and 12");
//            //num = int.Parse(Console.ReadLine());
//            //switch (num) 
//            //{
//            //    case 1:
//            //        Console.WriteLine("January");
//            //        break;
//            //    case 2:
//            //        Console.WriteLine("February");
//            //        break;
//            //    case 3:
//            //        Console.WriteLine("March");
//            //        break;
//            //    case 4:
//            //        Console.WriteLine("April");
//            //        break;
//            //    case 5:
//            //        Console.WriteLine("May");
//            //        break;
//            //    case 6:
//            //        Console.WriteLine("June");
//            //        break;
//            //    case 7:
//            //        Console.WriteLine("July");
//            //        break;
//            //    case 8:
//            //        Console.WriteLine("August");
//            //        break;
//            //    case 9:
//            //        Console.WriteLine("September");
//            //        break;
//            //    case 10:
//            //        Console.WriteLine("October");
//            //        break;
//            //    case 11:
//            //        Console.WriteLine("November");
//            //        break;
//            //    case 12:
//            //        Console.WriteLine("December");
//            //        break;
//            //    default:
//            //        Console.WriteLine("Please enter a number between 1 and 12");
//            //        break;

//            // ==========================================================================================================================

//            // accept operator and display result

//            // if else if

//            //int num1, num2;
//            //Console.WriteLine("Enter the first number");
//            //num1 = int.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter the second number");
//            //num2 = int.Parse(Console.ReadLine());
//            //char opr;
//            //Console.WriteLine("Enter the operator");
//            //opr = char.Parse(Console.ReadLine());
//            //if (opr == '+')
//            //    Console.WriteLine("The sum is " + (num1 + num2));
//            //else if (opr == '-')
//            //    Console.WriteLine("The difference is " + (num1 - num2));
//            //else if (opr == '*')
//            //    Console.WriteLine("The product is " + (num1 * num2));
//            //else if (opr == '/')
//            //    Console.WriteLine("The quotient is " + (num1 / num2));
//            //else if (opr == '%')
//            //    Console.WriteLine("The remainder is " + (num1 % num2));
//            //else
//            //    Console.WriteLine("Enter a valid operator");

//            // ==========================================================================================================================

//            // switch case

//            int num1, num2;
//            Console.WriteLine("Enter the first number");
//            num1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the second number");
//            num2 = int.Parse(Console.ReadLine());
//            char opr;
//            Console.WriteLine("Enter the operator");
//            opr = char.Parse(Console.ReadLine());

//            switch (opr)
//            {
//                case '+':
//                    Console.WriteLine("The sum is " + (num1 + num2));
//                    break;
//                case '-':
//                    Console.WriteLine("The difference is " + (num1 - num2));
//                    break;
//                case '*':
//                    Console.WriteLine("The product is " + (num1 * num2));
//                    break;
//                case '/':
//                    Console.WriteLine("The quotient is " + (num1 / num2));
//                    break;
//                case '%':
//                    Console.WriteLine("The remainder is " + (num1 % num2));
//                    break;
//                default:
//                    Console.WriteLine("Please enter a Valid operator");
//                    break;
//            }
//        }
//    }
//}
