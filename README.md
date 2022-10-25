# PracticeSpace

            /////////////////////////////////////////////////////////////////////////////////////////////
            //This is a method
            static void DisplayGreeting()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Welcome to Our Employee Database");
                Console.WriteLine("-------------------");
            }

            //Our method signature for a return input.
            //static method. The return (output) type. This says that we expect this method to return a single string to the code that called it. The inputs, known as arguments. In this case a single string in a variable known as 'prompt'.
            static string PromptForString(string prompt)
            {
                //Add some emoji every time this prompt is used
                Console.WriteLine("xxxxx");
                //Use the argument, whatever the method caller sent us.
                Console.Write(prompt);
                //Get some user input
                var userInput = Console.ReadLine();
                //ReTURN that value as the output of this method. The calue in 'userInput' will go wherever the CALLER of the method has specified.
                return userInput;
            }

            static int PromptForInteger(string prompt)
            {
                Console.Write(prompt);
                var userInput = Console.ReadLine();
                var inputAsInteger = int.Parse(userInput);
                return inputAsInteger;
            }

            //Call the method for display greeting
            DisplayGreeting();
            //Console.Write("What is your name? ");
            //var name = Console.ReadLine();
            //lets redo the above for a more expressive, even better way. Reveals the intent without details.
            var name = PromptForString("What is your name? ");

            //Console.Write("What is your department number? ");
            //var department = int.Parse(Console.ReadLine());
            //Lets replace the above department with the new prompt for integer we just created.
            var department = PromptForInteger("What is your department number? ");

            //Console.Write("What is your yearly salary (in dollars)? ");
            //var salary = int.Parse(Console.ReadLine());
            var salary = PromptForInteger("What is your yearly salary (in dollars)? ");

            var salaryPerMonth = salary / 12;
            Console.WriteLine($"Hello, {name} you make {salaryPerMonth} a month. ");









        }
    }
