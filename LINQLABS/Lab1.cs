namespace LinQ
{
    class Subject 
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Subject[] subjects { get; set; }

    }
    internal class Lab1
    {
        private static void Main(string[] args)
        {
            #region Q1
            //List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            //var q1 = numbers.Distinct().OrderBy(x => x).ToList();
            //Console.WriteLine("Query 1 Res: ");
            //foreach (var x in q1)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("Query 2 Res: ");
            //foreach (var x in q1)
            //{
            //    Console.WriteLine($"Number= {x}, Multibly= {x * x} ");
            //} 
            #endregion

            #region Q2
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //var q1 = names.Where(s => s.Length == 3);
            //var q2 = names.Where(s=>s.Contains("a")||s.Contains("A")).OrderBy(n=>n.Length);
            //var q3 = names.Take(2);
            //foreach (var name in q3) 
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Q3

            List<Student> students = new List<Student>()
            {  new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
                   subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){ Code=33,Name="UML"}}},
               new Student(){ ID=2, FirstName="Mona", LastName="Gala",
                   subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){ Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}},
               new Student(){ ID=3, FirstName="Yara", LastName="Yousf",
                   subjects=new Subject[]{ new Subject (){ Code=22,Name="EF"}, new Subject (){ Code=25,Name="JS"}}},
               new Student(){ ID=1, FirstName="Ali", LastName="Ali",
                   subjects=new Subject []{  new Subject (){ Code=33,Name="UML"}}},

            };

            var q1= students.Select(s => s.subjects.Count()).ToArray();
            var q2 = students.Select(s => s.FirstName).ToArray();
            var q3 = students.Select(s => s.LastName).ToArray();
            for (int s = 0; s < q1.Length; s++)
            {
                Console.WriteLine($"FullName= {q2[s]} {q3[s]}, NoOfSubjects={q1[s]}");
            }

            var q4 = students.Where(s => s.ID>0).OrderByDescending(s=>s.FirstName).ThenBy(s=>s.LastName);
            foreach (var s in q4) { Console.WriteLine($"{s.FirstName} {s.LastName}"); }

            #endregion
        }
    }
}