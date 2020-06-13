using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number");
    var number1 = Console.ReadLine();
    int n1 = Convert.ToInt32(number1);
    Console.WriteLine ("Enter another number");
    var number2 = Console.ReadLine();   
    int n2 = Convert.ToInt32(number2); 
    Console.WriteLine ("Sum: " +  (n1+n2));
    Console.WriteLine ("Diff: " +  (n1-n2));
    Console.WriteLine ("Product: " +  (n1*n2));
    Console.WriteLine ("Quotient: " +  (n1/n2));
    Console.WriteLine ("Remainder: " +  (n1%n2));
  }
}

