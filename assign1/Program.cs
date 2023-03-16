namespace assign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num !=5) {

           
                Console.WriteLine("please enter 1 for finding cube of a number:");
                Console.WriteLine("please enter 2 for age eligibility program:");
                Console.WriteLine("please enter 3 for display multiplication table vertically:");
                Console.WriteLine("please enter 4 for eligibility condition of admission program:");
                Console.WriteLine("please enter 5 to exit:");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("please enter a number:");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i <= n; i++)
                        {
                            Console.WriteLine("number is:{0} and cube of number is:{1}", i, i * i * i);
                        }
                        break;
                    case 2:
                        Console.WriteLine("please enter your age:");
                        int age = int.Parse(Console.ReadLine());
                        if (age >= 18)
                        {
                            Console.WriteLine("eligible to caste vote");
                        }
                        else { Console.WriteLine("not eligible to caste vote"); }
                        break;
                    case 3:
                        Console.WriteLine("please enter the number");
                        int mul_num = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= mul_num; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.WriteLine("{0}*{1}={2}", i, j, i * j);
                            }

                        }
                        break;
                    case 4:
                        Console.WriteLine("enter the marks");
                        Console.WriteLine("enter the marks of math:");
                        int math_marks = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the marks of phy:");
                        int phy_marks = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the marks of chem:");
                        int chem_marks = int.Parse(Console.ReadLine());
                        int total_marks = math_marks + phy_marks + chem_marks;
                        if (math_marks >= 65 && phy_marks >= 55 && chem_marks >= 50)
                        {
                            if (total_marks >= 180)
                            {
                                Console.WriteLine("congrats,you are selected");
                            }
                            else
                            {
                                Console.WriteLine("you are not selected");
                            }

                        }
                        else
                        {
                            Console.WriteLine("you are not selected");
                        }
                        break;
                     
                       
                        

                }
            }


        }

             
    }
}