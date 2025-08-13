using System;

class Program
{
    static void Main()
    {
        // ------------------ 1(i) Float Literal - Fever Check ------------------
        float temperature = 36.6f;
        Console.WriteLine("Temperature: " + temperature);
        if (temperature > 37.0f)
            Console.WriteLine("Fever");
        else
            Console.WriteLine("Normal");

        // ------------------ 1(ii) Int Literal - Voting Eligibility ------------------
        int age = 18;
        if (age >= 18)
            Console.WriteLine("Eligible to Vote");
        else
            Console.WriteLine("Not Eligible");

        // ------------------ 1(iii) Char Literal - Gender ------------------
        char gender = 'M';
        if (gender == 'M')
            Console.WriteLine("Male");
        else if (gender == 'F')
            Console.WriteLine("Female");
        else
            Console.WriteLine("Other");

        // ------------------ 1(iv) Double Literal - Price & Discount ------------------
        double price = 1000.0;
        double discount = 10.0; // in %
        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price: " + finalPrice);

        // ------------------ 1(v) Bool Literal - Login ------------------
        bool loginSuccess = true;
        if (loginSuccess)
            Console.WriteLine("Login successful");
        else
            Console.WriteLine("Access denied");

        // ------------------ 1(vi) Print Value & Data Type ------------------
        int age2 = 25;
        float temp2 = 98.6f;
        char grade = 'A';
        bool isPassed = true;
        Console.WriteLine($"{age2} -> {age2.GetType()}");
        Console.WriteLine($"{temp2} -> {temp2.GetType()}");
        Console.WriteLine($"{grade} -> {grade.GetType()}");
        Console.WriteLine($"{isPassed} -> {isPassed.GetType()}");

        // ------------------ 2(i) Calculator for Kids ------------------
        int a = 10, b = 5;
        Console.WriteLine("Total apples: " + (a + b));
        Console.WriteLine("Difference of pencils: " + (a - b));
        Console.WriteLine("Total pages: " + (a * b));
        Console.WriteLine("Chocolates per kid: " + (a / b));
        Console.WriteLine("Leftover candies: " + (a % b));

        // ------------------ 2(ii) Player Score Comparison ------------------
        int playerA = 20, playerB = 15;
        Console.WriteLine("Player A > Player B? " + (playerA > playerB));
        Console.WriteLine("Scores equal? " + (playerA == playerB));
        Console.WriteLine("Player A <= Player B? " + (playerA <= playerB));

        // ------------------ 2(iii) Login System with Logical Operators ------------------
        string username = "admin", password = "1234";
        bool validUsername = (username == "admin");
        bool validPassword = (password == "1234");
        if (validUsername && validPassword)
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");

        Console.WriteLine("At least one correct? " + (validUsername || validPassword));
        Console.WriteLine("Opposite of validUsername: " + (!validUsername));

        // ------------------ 2(iv) Quiz Points ------------------
        int score = 50;
        score += 10; // correct answer
        Console.WriteLine("After correct answer: " + score);
        score -= 5; // wrong answer
        Console.WriteLine("After wrong answer: " + score);
        score *= 2; // bonus
        Console.WriteLine("After bonus: " + score);
        score /= 5; // penalty
        Console.WriteLine("After penalty: " + score);

        // ------------------ 2(v) Voting Booth with Loop ------------------
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter age: ");
            int personAge = Convert.ToInt32(Console.ReadLine());
            if (personAge >= 18)
                Console.WriteLine("Eligible to Vote");
            else
                Console.WriteLine("Not Eligible");
        }

        // ------------------ 3(i) ATM PIN Check ------------------
        int correctPIN = 1234;
        bool granted = false;
        for (int attempt = 1; attempt <= 3; attempt++)
        {
            Console.Write("Enter PIN: ");
            int enteredPIN = Convert.ToInt32(Console.ReadLine());
            if (enteredPIN == correctPIN)
            {
                Console.WriteLine("Access Granted");
                granted = true;
                break;
            }
            else
                Console.WriteLine("Wrong PIN");
        }
        if (!granted)
            Console.WriteLine("Card Blocked");

        // ------------------ 3(ii) Multiplication Table ------------------
        char repeat;
        do
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");

            Console.Write("Try another? (Y/N): ");
            repeat = Convert.ToChar(Console.ReadLine());
        } while (repeat == 'Y' || repeat == 'y');

        // ------------------ 3(iii) Electricity Bill ------------------
        Console.Write("Enter units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        double bill;
        if (units <= 100)
            bill = units * 2;
        else if (units <= 200)
            bill = (100 * 2) + ((units - 100) * 3);
        else
            bill = (100 * 2) + (100 * 3) + ((units - 200) * 5);
        Console.WriteLine("Total Bill: ₹" + bill);

        // ------------------ 3(iv) Student Average ------------------
        int[] marks = new int[5];
        int total = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
            total += marks[i];
        }
        double avg = total / 5.0;
        if (avg >= 40)
            Console.WriteLine("Passed");
        else
            Console.WriteLine("Failed");

        // ------------------ 3(v) Name Validation ------------------
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        bool isValid = true;
        foreach (char c in name)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                isValid = false;
                break;
            }
        }
        if (isValid)
            Console.WriteLine("Valid Name");
        else
            Console.WriteLine("Invalid Name");
    }
}
