namespace Twitter
{
    class Program
    {
        public static int NumOfOdds(int number)
        {
            int c = 0;
            for (int i = 1; i <= number; i += 2)
            {
                c++;
            }
            return c;
        }
        static void Main()
        {
            int choice, width, height, trangleChoice;
            string str = "*";
            Console.WriteLine("enter 1 to rectengle 2 to trangle or 3 to exit:");
            bool res = int.TryParse(Console.ReadLine(), out choice);
            while (choice != 3)
            {
                Console.WriteLine("enter width of tower:");
                res = int.TryParse(Console.ReadLine(), out width);
                Console.WriteLine("enter height of tower:");
                res = int.TryParse(Console.ReadLine(), out height);
                while (height < 2)
                {
                    Console.WriteLine("Please enter a height greater than or equal to 2");
                    res = int.TryParse(Console.ReadLine(), out height);
                }
                if (choice == 1)
                {
                    if (Math.Abs(height - width) > 5)
                        Console.WriteLine("the shetach is:{0}", height * width);
                    else
                        Console.WriteLine("the heikef is:{0}", 2 * (height + width));

                }
                else if (choice == 2)
                {
                    Console.WriteLine("enter 1 to calculate the heikef or 2 to print the trangle:");
                    res = int.TryParse(Console.ReadLine(), out trangleChoice);
                    while (trangleChoice != 1 && trangleChoice != 2)
                    {
                        Console.WriteLine("enter 1 to calculate the heikef or 2 to print the trangle:");
                        res = int.TryParse(Console.ReadLine(), out trangleChoice);
                    }
                    if (trangleChoice == 1)//calculate
                    {
                        Console.WriteLine("the heikef is:{0}", width * height);
                    }
                    else//print
                    {
                        if (width % 2 == 0 || width > 2 * height)
                            Console.WriteLine("The triangle cannot be printed");

                        else
                        {
                            int numOfLines = height - 2, numOfGroups = NumOfOdds(width) - 2;
                            string space = "";
                            for (int i = 0; i < (width - 1) / 2; i++)
                                space += " ";
                            Console.WriteLine(space + "*");//first line
                                                           //middle lines

                            if (numOfLines % numOfGroups != 0)
                            {

                                for (int k = 0; k < numOfLines / numOfGroups + numOfLines % numOfGroups; k++)
                                {
                                    if (k == 0)
                                    {
                                        space = space.Substring(1);
                                        str += "**";
                                    }
                                    Console.WriteLine(space + str);
                                }
                                numOfGroups -= 1;
                            }

                            for (int l = 0; l < numOfGroups; l++)
                                for (int j = 0; j < numOfLines / numOfGroups; j++)
                                {

                                    if (j == 0)
                                    {
                                        space = space.Substring(1);
                                        str += "**";
                                    }
                                    Console.WriteLine(space + str);
                                }


                            //last line
                            Console.Write(str + "**");
                            Console.WriteLine("");
                            str = "*";
                        }
                    }
                }
                else
                    throw new Exception("not legal choice");
                Console.WriteLine("enter 1 to rectengle 2 to trangle or 3 to exit:");
                res = int.TryParse(Console.ReadLine(), out choice);
            }
        }
    }
}