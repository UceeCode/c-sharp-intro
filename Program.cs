//NameSpace

// namespace TeamA
// {
//     class ClassA
//     {
//         public static void Print()
//         {
//             Console.WriteLine("Print a method");
//         }
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         TeamA.ClassA.Print(); 
//     }
// }

// using System;

// class Point {
//     public int x;
//     public int y;


//     public Point(Point point)
//     {
//         x = point.x;
//         y = point.y;
//     }


//     public Point() { }

//     public static void Main(){
//         Point myPoint = new Point();

//         myPoint.x = 5;
//         myPoint.y = 6;
//         Console.WriteLine(myPoint.x);
//         Console.WriteLine(myPoint.y);

   
//         myPoint = new Point(myPoint);
//         Console.WriteLine(myPoint.x);
//         Console.WriteLine(myPoint.y);
//     }
// }

// using System;

// public class ClassA {
    
//     public int Sum(int a, int b){
//         return a + b;
//     }

    
//     public static int Product(int a, int b){
//         return a * b;
//     }

//     public static void Main(string[] args){
//         Console.WriteLine("Welcome");

      
//         Console.WriteLine("Enter the first number:");
//         int a = int.Parse(Console.ReadLine());

//         Console.WriteLine("Enter the second number:");
//         int b = int.Parse(Console.ReadLine());

       
//         ClassA instance = new ClassA();

       
//         int sum = instance.Sum(a, b);
//         Console.WriteLine("The sum is: " + sum);

        
//         int product = ClassA.Product(a, b);
//         Console.WriteLine("The product is: " + product);
//     }
// }


using System;

// namespace TypeConversion{
//     internal class Program {
//         static void Main(string[] args){
//             float f = 3.142F;
//             int i = (int)f;
//             Console.WriteLine(i);
//         }
//     }
// }

// namespace TypeConversion{
//     internal class Program {
//         static void Main(string[] args){
//             float f = 123.4567F;
//             int i = Convert.ToInt32(f);
//             Console.WriteLine(i);
//         }
//     }
// }

// namespace TypeConversion{
//     internal class Program {
//         static void Main(string[] args){
//             string strNumber = "100";
//             int i = int.Parse(strNumber);
//             Console.WriteLine(i);
//         }
//     }
// }

// namespace TypeConversion{
//     internal class Program {
//         static void Main(string[] args){
//             string strNumber = "100";
//             int result;
//             bool isCoverSuccess = int.TryParse(strNumber, out result);
//             if(isCoverSuccess){
//                 Console.WriteLine(result);
//             } else {
//                 Console.WriteLine("Pls enter a valid variable");
//             }
//         }
//     }
// }

//an abstract class is a class that cannot be instantiated, that is you cannot crate an object of it, but you can only extend it using the colon sign.
//Abstract classses also work with namespaces

// using System;

// namespace AbstractClass
// {
//     public abstract class Customer
//     {
//         public abstract void Greet();
//     }

//     public class Program : Customer
//     {
//         // Implementation of the abstract method
//         public override void Greet()
//         {
//             Console.WriteLine("Hello Uchenna");
//         }

//         static void Main(string[] args)
//         {
//             Program obj = new Program();
//             obj.Greet();
//         }
//     }
// }

// class A
// {
//     public virtual void print()
//     {
//         Console.WriteLine("A Implementation");
//     }
// }

// class B : A
// {
//     public override void print(){
//         Console.WriteLine("B Implementation");
//     }
// }

// class C : B
// {
//     public override void print(){
//         Console.WriteLine("C Implementation");
//     }
// }

// class D : B
// {

// }

// class Program{
//     public static void Main(string[] args)
//     {
//         D d = new D();
//         d.print();
//     }
// }

// class LivingThings {
//     public virtual void trait(){
//         Console.WriteLine("All living things breath");
//     }
// }

// class Humans : LivingThings 
// {
//     public override void trait()
//     {
//         Console.WriteLine("Humans can talk");
//     }
// }

// class Animals : LivingThings
// {
//     public override void trait()
//     {
//        Console.WriteLine("Animals makes sounds");
//     }
// }

// class Mammmals : Animals 
// {
//     public override void trait(){
//         Console.WriteLine("They give birth to their offsprings alive");
//     }
// }

// class Rat : Mammmals
// {

// }

// class David : Humans
// {

// }

// class Program {
//     static void Main(string[] args)
//     {
//         Rat r = new Rat();
//         r.trait();

//         David d = new David();
//         d.trait();
//     }
// }

// using System;

// namespace Calculator 
// {
//     public class NumberManipulator
//     {
//         public void getValues(out int x)
//         {
//             int temp = 5;
//             x = temp;
//         }

//         public static void Main(string[] args)
//         {
//             NumberManipulator numManip = new NumberManipulator();
//             int a = 100;
//             Console.WriteLine("Before calling method, value of a is: " + a);
//             numManip.getValues(out a);
//             Console.WriteLine($"After calling method, value of a is: {a}");
//         }
//     }
// }

// using System;

// namespace Calculator 
// {
//     public class NumberManipulator
//     {
//         public void swap(ref int x, ref int y)
//         {
//             int temp;
//             temp = x;
//             x = y;
//             y = temp;
//         }

//         public static void Main(string[] args)
//         {
//             NumberManipulator numManip = new NumberManipulator();
//             int a = 100;
//             int b = 200;
//             Console.WriteLine("Before swap, value of a is: " + a);
//             Console.WriteLine("Before swap, value of b is: " + b);

//             numManip.swap(ref a, ref b);
//             Console.WriteLine($"After swap, value of a is: {a}");
//             Console.WriteLine($"After swap, value of b is: {b}");
//         }
//     }
// }


// using System;

// namespace DelegateApp
// {
//     // Define the delegate
//     delegate int NumberChanger(int x);

//     class TestDelegate
//     {
//         static int num = 10;

        
//         public static int addNum(int a)
//         {
//             num += a;
//             return num;
//         }

       
//         public static int multiplyNum(int q)
//         {
//             num *= q;
//             return num;
//         }

//         public static int getNum()
//         {
//             return num;
//         }
//         public static void Main(string[] args)
//         {
            
//             NumberChanger nc1 = new NumberChanger(addNum);
//             NumberChanger nc2 = new NumberChanger(multiplyNum);

            
//             nc1(25);
//             Console.WriteLine("Value after addition: " + num);

//             nc2(10);
//             Console.WriteLine("Value after multiplication: " + num);
//         }
//     }
// }


// using System;

// namespace PrintSeriesOfNumbers {
//     class PrintNums {
//         static void printn(int num1, int num2, int num3, int num4, int num5, int num6)
//         {
//             Console.WriteLine("The numbers are: " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + ", " + num5 + ", " + num6);
//         }

//         public static void Main(string[] args)
//         {
//            printn(3,6,9,12,15,18);
//         }
//     }
// }


// using System;

// namespace PrintCubeofNum
// {
//     class PrintCube 
//     {
//         public static void Printcube(int x)
//         {
//             Console.WriteLine("Cube = " + x * x * x);
//         }

//         public static void Main(string[] args)
//         {
//             Printcube(3);
//         }
//     }
// }


// using System;
// using System.Text.RegularExpressions;

// namespace RegularExpression 
// {
//     public class RegexExample 
//     {
//         private static void ShowMatch(string text, string expr)
//         {
//             Console.WriteLine("The expression is: " + expr);
//             MatchCollection matches = Regex.Matches(text, expr);
//             foreach (Match match in matches)
//             {
//                 Console.WriteLine("Found match: " + match.Value);
//             }
//         }

//         public static void Main(string[] args)
//         {
//             string text = "Hello World! Welcome to the world of regular expressions.";
//             string expr = @"\bworld\b";

//             ShowMatch(text, expr);
//         }
//     }
// }


// using System;
// using System.Text.RegularExpressions;

// namespace RegularExpression 
// {
//     public class RegexExample 
//     {
//         private static void ShowMatch(string text, string expr)
//         {
//             Console.WriteLine("The expression is: " + expr);
//             MatchCollection mc = Regex.Matches(text, expr);
//             foreach (Match match in mc)
//             {
//                 Console.WriteLine("Found match: " + match.Value);
//             }
//         }

//         public static void Main(string[] args)
//         {
//             string str = "Make Maize and Manage to Measure it";
//             Console.WriteLine("Matching words that start with 'e'");
//             ShowMatch(str, @"\bM\w*");

//             string str1 = "The chimp is a champ to the jungle";
//             Console.WriteLine("Matching words that starts with 'ch'");
//             ShowMatch(str1, @"\bch\w*");

//             string str2 = "Have you ever climbed the mount everest";
//             Console.WriteLine("Matching words that start with 'ever'");
//             ShowMatch(str2, @"\bever\w*");

//             string str3 = "I run to stay fit, run a business, run out of time and love to watch the sun run in the sky";
//             Console.WriteLine("Matching words that start with 'run'");
//             ShowMatch(str3, @"\brun\w*");
//         } 
//     }
// }
using System;

namespace MakingStructures
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public string book_id;
        public int pages;
    }

    public class BookStructure
    {
        Books Book1;
        Books Book2;

        public BookStructure()
        {
            Book1.title = "Welcome to structure in C#";
            Book1.author = "John Doe";
            Book1.subject = "Programming";
            Book1.book_id = "12345";
            Book1.pages = 1;

            Book2.title = "Advanced C#";
            Book2.author = "Jane Smith";
            Book2.subject = "Programming";
            Book2.book_id = "67890";
            Book2.pages = 5;
        }

        public void DisplayBooks()
        {
            Console.WriteLine($"Book1 Title: {Book1.title}");
            Console.WriteLine($"Book1 Author: {Book1.author}");
            Console.WriteLine($"Book1 Subject: {Book1.subject}");
            Console.WriteLine($"Book1 ID: {Book1.book_id}");
            Console.WriteLine($"Increased Book1 Pages: {IncreaseNum(Book1.pages)}");
            Console.WriteLine($"Decreased Book1 Pages: {DecreaseNum(Book1.pages)}");
            Console.WriteLine();
            Console.WriteLine($"Book2 Title: {Book2.title}");
            Console.WriteLine($"Book2 Author: {Book2.author}");
            Console.WriteLine($"Book2 Subject: {Book2.subject}");
            Console.WriteLine($"Book2 ID: {Book2.book_id}");
            Console.WriteLine($"Increased Book2 Pages: {IncreaseNum(Book2.pages)}");
            Console.WriteLine($"Decreased Book2 Pages: {DecreaseNum(Book2.pages)}");
        }

        public int IncreaseNum(int pages)
        {
            return ++pages; 
        }

        public int DecreaseNum(int pages)
        {
            return --pages; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookStructure bookStructure = new BookStructure();
            bookStructure.DisplayBooks();
        }
    }
}
