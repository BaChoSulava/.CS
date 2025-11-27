using System;
class PythagoreanTheorem {
    // TODO: 
    // write app that calculates by Pythagorean theorem
  static void Main() {
        string startprogram = "y";
        while(startprogram == "y"){
            
            string chosenMethod = AskWhichMethod();
            string answer = DoChosenMethod(chosenMethod);
            PrintAnswer(answer);
            
            // RESTART
            Console.Write("\n\nTo restart write 'y': ");
            startprogram = Console.ReadLine();
            Console.Write("\n------------------------\n");
    }
  }
  
  static string AskWhichMethod(){
      string chosenMethod;
      do{
          Console.WriteLine("I can calculate length of leg or hypotenuse or check if such triangle exists.\n Which one should I do?");
          Console.Write("type 'l' for leg, 'h' for hypotenuse or 'c' for checking: ");
          chosenMethod = Console.ReadLine();
          
      }while(method != "l" && method != "h" && method != "c");
      return chosenMethod;
  }
  
  static string DoChosenMethod(string chosenMethod){
      string[] triangle = {leg1: "a", leg2: "b", hypotenuse: "c"};
      
      if (chosenMethod == "l"){
          
          answer = CalcLeg(double leg1, double hypotenuse)  // leg is a or b
      }
      else if (chosenMethod == "h"){
          answer = CalcHypotenuse(leg1, leg2);
      }
      else if (chosenMethod == "c"){
          answer = CheckExistence();
      }
      return answer;
  }
  
  static bool CheckExistence(int a, int b, int c){
      if (Square(a) * Square(b) == Square(c)){
          return true;
      }
      else {
          return false;
      }
      
  }
  
  static double CalcLeg(double a, double c){
      return Math.Sqrt(Square(c) - Square(a));
  }
  
  static double CalcHypotenuse(double a, double b){
      return Math.Sqrt(Square(a) + Square(b));
  }
  
  static void PrintAnswer(answer){
      Console.WriteLine($"The answer is: {answer}");
  }
  
  static double Square(double number)
    {
        return number * number;
    }
}
