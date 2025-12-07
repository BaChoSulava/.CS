using System;

class HelloWorld {
    static void Main() {
        int number = 5;
        int answer = CalcFactorial(number);
        Console.WriteLine("factorial equals to " + answer);
    }

    static int CalcFactorial(int number) {
        if (number == 0) return 1;    // base
        return number * CalcFactorial(number - 1);
    }
}
