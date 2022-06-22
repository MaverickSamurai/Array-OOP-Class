using System;

namespace Array_OOP_Class
{
    class Program
    {
        static void Main(string[] args)
        {


           

            //int[] numbers = new int[6];

            //numbers[0] = 3;
            //numbers[1] = 5;
            //numbers[2] = 100;


            //Array.Resize(ref numbers, 20);

            //numbers[10] = 55;

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}



            //int[] nums = { 1, 2, 5,7,55,25};

            //Array.Sort(nums);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


            //int[,] arr = {

            //    {2, 3 },
            //    {3, 4 },
            //    {5, 6 }

            //};
            //Console.WriteLine(arr[1,1]);

            //int[,] arr = {

            //    {2, 3 },
            //    {3, 4 },
            //    {5, 6 }

            //};
            //Console.WriteLine(arr.Rank);


            //string name1 = "Orxan";
            //string surname1 = "Akberov";
            //int age1 = 26;


            //string name2 = "Emil";
            //string surname2 = "Abdullayev";
            //int age2 = 20;


            //string name3 = "Fidan";
            //string surname3 = "Mardanli";
            //int age3 = 17;

            //Console.WriteLine(name1 + " " +surname1 + " " +age1);


            //var obj1 = new
            //{
            //    name = "Orxan",
            //    surname = "Akberov",
            //    age = 26
            //};


            //var obj2 = new
            //{
            //    name = "Emil",
            //    surname = "Abdullayev",
            //    age = 20
            //};
            //Console.WriteLine(obj1);

            //2ci

            //var obj1 = new
            //{
            //    name = "Orxan",
            //    surname = "Akberov",
            //    age = 26
            //};


            //var obj2 = new
            //{
            //    name = "Emil",
            //    surname = "Abdullayev",
            //    age = 20
            //};
            ////Console.WriteLine(obj1.name + " " + obj1.surname + " " +obj1.age);
            //Console.WriteLine($"{obj2.name} {obj2.surname} {obj2.age}");



            //Student st1 = new Student();
            //st1.name = "Orxan";
            //st1.surname = "Akberov";
            //st1.age = 26;
            //st1.adress = "Baku";


            //Student st2 = new Student();
            //st2.name = "Emil";
            //st2.surname = "Abdullayev";
            //st2.age = 20;
            //st2.adress = "Zangilan";

            //Console.WriteLine(st1.name + " " + st1.surname);

            //Console.WriteLine(st1.FullName());

            //Console.WriteLine(st1.FullData());

            //Console.WriteLine(st2.FullName());

            //Student student = new Student();

            //student.name = "Mirsamir";

            //var result = student.GetGroupInfo();
            //Console.WriteLine(result);

            //Console.WriteLine(student.GetGroupInfo());




        }

        
    
    
    }



    class Student
    {
        public string name;
        public string surname;
        public int age;
        public string adress;


        //public Student(string StudentName, int StudentAge)
        //{
        //    name = StudentName;
        //    age = StudentAge;
        //    Console.WriteLine(name + " " + age);




        //public Student()
        //{


        //    Console.WriteLine("Empty");
        //}

        //public Student(int age, string adress) : this(adress)
        //{
        //    this.adress = adress;
        //    Console.WriteLine("Age" + age);

        //}
        //public Student(string adds): this(true)
        //{

        //    Console.WriteLine("adress" + adds);
        //}

        //public Student(bool IsMarried)
        //{
        //    Console.WriteLine("Married");
        //}









        //public string FullName()
        //{
        //    return name + " " + surname;
        //}

        //public string FullName()
        //{
        //    return name + " " + surname + " " + adress;
        //}


        public string GetGroupInfo()
        {
            Teacher teacher = new Teacher();
            teacher.name = "Cavid";

            return $"Teacher name:{teacher.GetTeacherName()}  Student name: {name} ";
        }



        //public string FullData()
        //{
        //    return name + " " + surname + " " + age;
        //}

    }




    class Teacher
    {
        public string name;
        public decimal salary;


        public string GetTeacherName()
        {
            return name;
        }
    }
}
