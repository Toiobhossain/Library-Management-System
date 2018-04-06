using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Book
    {
        protected string id;
        protected string name;
        protected internal double Number_of_book;
        protected internal string book_avability;
        private string book_type;
        public string Book_type
        {
            get
            {
                return book_type;
            }
        }
        public Book(string id,string name,double Number_of_book,string book_avability,string book_type)
        {
            this.id = id;
            this.name = name;
            this.Number_of_book = Number_of_book;
            this.book_avability = book_avability;
            this.book_type = book_type;
        }
    }
    class hard_copy_book:Book
    {
        private string number_of_pages;
        public hard_copy_book(string id,string name,double Number_of_book,string book_avability,string number_of_pages,string book_type):base(id,name,Number_of_book,book_avability,book_type)
        {
            this.number_of_pages = number_of_pages;
        }
        public void Book_Avability()
        {
            if (book_avability == "yes")
            {
                Console.WriteLine("Hard copy Book is avaliavle");
            }
            else
            {
                Console.WriteLine("Hard copy Book is not avaliable");
            }
        }
        public void Borrowbook(Student s)

        {
            if (book_avability == "yes")
            {
                if (s.Student_type == "register")
                {
                    Console.WriteLine("They can borrow hard copy book");
                }
                else
                {
                    Console.WriteLine("please at first registration and try again");
                }
            }
        }
       
    }
    class audio_book:Book
    {
        public audio_book(string id,string name,double Number_of_book,string book_avability,string number_of_pages,string book_type):base(id,name,Number_of_book,book_avability,book_type)
        {

        }
        public void book_Avavility()
        {
            if (book_avability == "yes")
            {
                Console.WriteLine("Audio book is avaliable");
            }
            else
            {
                Console.WriteLine("Audio book is not avaliable");
            }
        }
        public void Readaccecibility(Student s)
        {
            if (book_avability == "yes")
            {
                if (s.Student_type == "regester")
                {
                    Console.WriteLine("They can listen audio book");
                }
                else
                {
                    Console.WriteLine("please at first registration and try again");

                }
            }
        }
       

    }
    class Student
    {
        protected string id;
        protected string name;
        private string student_type;
        protected internal double Number_of_book;
        public string Student_type
        {
            get
            {
                return student_type;
            }
        }
        public Student (string id,string name,string student_type,double Number_of_book)
        {
            this.id = id;
            this.name = name;
            this.student_type = student_type;
            this.Number_of_book = Number_of_book;
        }
    }
    class register_student:Student
    {
        public register_student(string id,string name,string student_type,double Number_of_book):base(id,name,student_type,Number_of_book)
        {

        }
        public void libraryenter()
        {
            Console.WriteLine("They will be avail to enter in the library and see all information");

        }
    }
    class non_register_student:Student
    {
      public non_register_student(string id,string name,string student_type,double Number_of_book):base(id,name,student_type,Number_of_book)
        {

        }
        public void registration()
      {
          Console.WriteLine("Non register student  must be registration");
      }
    }
    class Register
    {
        private string id;
        private string name;
        private double salary;
        List<register_student> register_s_list = new List<register_student>();
        public void add_student(register_student r)
        {
            register_s_list.Add(r);
        }
        List<hard_copy_book> hardcopy_book_list = new List<hard_copy_book>();
        public void add_hard_book(hard_copy_book h)
        {
            hardcopy_book_list.Add(h);
        }
        List<audio_book> audio_book_list = new List<audio_book>();
        public void add_audio_book(audio_book a)
        {
            audio_book_list.Add(a);
        }
        
        public Register(string id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void Checkstudent(Student s,Book b)
        {
            if(s.Student_type=="register")
            {
              if(b.Book_type=="hard copy")
              {
                  if (b.book_avability == "yes")
                  {
                      if (s.Number_of_book < 7)
                      {
                          Console.WriteLine("Can take more boks");
                      }
                      else
                      {
                          Console.WriteLine("Can't taken more books");
                      }
                  }
              }
            }
        }
        public void checkstudent(Student s,Book b)
        {
            if(s.Student_type=="register")
            {
                if(b.Book_type=="audio")
                {
                    if(b.book_avability=="yes")
                    {
                        Console.WriteLine("they can listening the book any time");
                    }
                    else
                    {
                        Console.WriteLine("they can not finding audio book");
                    }
                       
                }
            }
        }
    }
    public interface Icalculatesalary
    {
        double calculate_annual_salary();
        
    }
    public interface Ibonus
    {
        void calculate_bouns();
    }
    class employee:Icalculatesalary,Ibonus
    {
        protected string id;
        protected string name;
        protected double salary;
        public employee(string id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public double calculate_annual_salary()
        {
            double s = salary * 12;
            return s;
        }
        public void calculate_bouns()
        {
            Console.WriteLine("10% bouns");
        }
    }
    class liberian:employee
    {
        private string performance;

   public string Performance
        {

            get
            {
                return performance;
            }
        }
        public liberian(string id, string name, double salary, string performance)
            : base(id, name, salary)
        {
            this.performance = performance;
        }
        public void calcula_bouns(double sa)
        {
            double bouns = (sa * 15) / 100;
            Console.WriteLine("Liberian bouns:" + bouns + "taka");
        }
    }
    class stuff : employee
    {
        private string Experience;
        
        public string experience
        {

            get
            {
                return Experience;
            }
        }
        public stuff(string id,string name,double salary,string Experience):base(id,name,salary)
        {
            this.Experience = Experience;
        }
        public  void calculate_bouns(double sa)
        {
            double bouns = (sa * 10) / 100;
            Console.WriteLine("Stuff Bouns:" + bouns + "taka");
        }
    }
    class cleaner:employee
    {
        private string work_load;

        public string Work_load
        {
            get
            {
                return work_load;
            }
        }
        public cleaner(string id,string name,double salary,string work_load):base(id,name,salary)
        {
            this.work_load = work_load;
        }
        public void calculat_bouns(double sa)
        {
            double bouns = (sa * 5) / 100;
            Console.WriteLine("Cleaner bonus:" + bouns + "taka");
        }
    }

   
      class Admin
      {
          private string id;
          private string name;
          private double salary;
          List<stuff> stuff_list = new List<stuff>();
          public void add_stuff(stuff s)
          {
              stuff_list.Add(s);
          }

          List<cleaner> cleaner_list = new List<cleaner>();
          public void add_cleaner(cleaner c)
          {
              cleaner_list.Add(c);
          }
          public Admin(string id,string name,double salary)
          {
              this.id = id;
              this.name = name;
              this.salary = salary;

          }
          public void check_liberian(liberian l)
          {
              if(l.Performance=="good")
              {
                  Console.WriteLine("Liberian Performance is good");
              }
              else
              {
                  Console.WriteLine("Liberian performance is not good");
              }
          }
          public void check_stuff(stuff s)
          {
              if(s.experience=="10%")
              {
                  Console.WriteLine("Stuff is promoted");
              }
              else
              {
                  Console.WriteLine("Not promossion");
              }
          }
          public void check_cleaner(cleaner c)
          {
              if(c.Work_load=="Normal")
              {
                  Console.WriteLine("Provide some work for cleaner");
              }
              Console.WriteLine("Work is perfect");
          }
      }
    class services
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("34234", "amin", "regular", 5);
            register_student alam = new register_student("12134", "alam", "regular",5);
            non_register_student ali = new non_register_student("12431", "ali", "nonregular",0);
            alam.libraryenter();
            ali.registration();
            hard_copy_book data = new hard_copy_book("432434", "database", 00.0, "yes", "234", "hard copy");
            audio_book algo = new audio_book("23455","algo",0,"yes", "507", "audio");
            data.Book_Avability();
            data.Borrowbook(a);
            Register anika = new Register("123123", "anika", 50000);
            Book c = new Book("12323", "data", 7, "yes", "");
            anika.Checkstudent(a, c);
            anika.checkstudent(a, c);
            liberian akash = new liberian("34324","akash", 20000, "good");
            stuff abir = new stuff("32434", "abir", 15000, "10 years");
            cleaner kamal = new cleaner("24234", "kamal", 10000, "Normal");
           double r= akash.calculate_annual_salary();
           Console.WriteLine("liberian annual salary:"+r);
            double f=abir.calculate_annual_salary();
            Console.WriteLine("stuff annual  salary:" + f);
            double h=kamal.calculate_annual_salary();
            Console.WriteLine("cleaner annual salary:" + h);
            employee rr = new employee("32432", "erer", 0);
            rr.calculate_bouns();
            akash.calcula_bouns(r);
            abir.calculate_bouns(f);
            kamal.calculat_bouns(h);
            Admin tushar = new Admin("2332", "tushar", 40000);
            tushar.check_liberian(akash);
            tushar.check_stuff(abir);
            tushar.check_cleaner(kamal);
            Console.ReadKey();
        }
    }
}
