namespace Class_0508
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine(s.GetName());

            Person s2= new Student();

            Console.WriteLine(s2.GetName());

            Console.WriteLine(((Person)s2).GetName());

            Console.WriteLine("***************");


            Teacher t= new Teacher();

            Console.WriteLine(t.GetName());

            People t2= new Teacher();
            Console.WriteLine(t2.GetName());

            Console.WriteLine(((Teacher)t2).GetName());


        }
    }
}
