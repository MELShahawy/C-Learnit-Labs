using D2_EMP;

internal class Program
{
    private static void Main(string[] args)
    {



        #region array of 10 employees and choose index to enter
        ////employees |#|#|A|#|#|S|#|#|#|#|
        ///choose index 0->9
        ///2
        ///enter id 1
        ///enter name ali
        ///enter age 22
        ///enter salary 1234
        ///continue y or n ? y
        ///choose index
        ///5
        ///enter id 2
        ///enter name Sara
        ///enter age 23
        ///enter salary 4234
        ///continue y or n ? n
        ///print Sara and ali ONLY

        Employees[] employees = new Employees[10];
        int index;
        //int[] indexs=new int[10];
        string flag;
        do
        {
            do
            {
                Console.WriteLine("Choose index 0->9");
                index = int.Parse(Console.ReadLine());
            } while (index < 0 || index > 9);


            employees[index] = new Employees();



            Console.WriteLine("Enter id");
            employees[index].SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter name");
            employees[index].SetName(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter age");
                employees[index].SetAge(int.Parse(Console.ReadLine()));
            }
            while (employees[index].GetAge() < 18 || employees[index].GetAge() > 60);

            Console.WriteLine("Enter salary");
            employees[index].SetSalary(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Continue , yes or no");
            flag = Console.ReadLine();

        }
        while (flag.ToLower() == "yes");

        for (int i = 0; i < employees.Length; i++)
        {
            try
            {
             
                Console.WriteLine(employees[i].PrintV2());
            }
            
            catch (System.NullReferenceException) { Console.WriteLine("null"); }
        }
        // still gives error!

        #endregion
        Console.ReadLine();

    }
}