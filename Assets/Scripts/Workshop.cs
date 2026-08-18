using Unity.VisualScripting;
using UnityEngine;

public class Workshop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Workshop started");
        As01_SyntaxIf();
        As02_StringComparisonExample();
        As03_NumberComparisonExample();
        As04_AndOrOperatorExample();
        As05_GuessingNumberExample();
        As06_GuessingNumberMoreOrLessExample();
        As07_VerifyIdentityExample();
    }

    public bool isSixOClock;
    public void As01_SyntaxIf()
    {
        if (isSixOClock == true)
        {
            Debug.Log("The door is open");
            Debug.Log("Knock knock!");
        }
        else
        {
            Debug.Log("Knock knock!");   
        }
        Debug.Log("                                                                            ");
    }

    public string password;
    public void As02_StringComparisonExample()
    {
        password = "Moon";
        if (password == "Moon")
        {
            Debug.Log("Login Complete");
        }
        else
        {
            Debug.Log("Login Failed");
        }
        Debug.Log("                                                                            ");
    }

    
    public int as03Number;
    public void As03_NumberComparisonExample()
    {
        as03Number = 11;
        Debug.Log(as03Number);
        if (as03Number > 10){ Debug.Log("The number is greater than 10"); }
        if (as03Number < 10){ Debug.Log("The number is less than 10"); }
        if (as03Number >= 10){ Debug.Log("The number is greater than 10"); }
        if (as03Number <= 10){ Debug.Log("The number is less than 10"); }
        if (as03Number == 10){ Debug.Log("The number is equal to 10"); }
        if (as03Number != 10){ Debug.Log("The number is equal to 10"); }
        
        Debug.Log("----------------------------------------------------------------");
        as03Number = 10;
        Debug.Log(as03Number);
        if (as03Number > 10){ Debug.Log("The number is greater than 10"); }
        if (as03Number < 10){ Debug.Log("The number is less than 10"); }
        if (as03Number >= 10){ Debug.Log("The number is greater than 10"); }
        if (as03Number <= 10){ Debug.Log("The number is less than 10"); }
        if (as03Number == 10){ Debug.Log("The number is equal to 10"); }
        if (as03Number != 10){ Debug.Log("The number is equal to 10"); }
        
        Debug.Log("----------------------------------------------------------------");
        as03Number = 9;
        Debug.Log(as03Number);
        if (as03Number > 10){ Debug.Log("The number is greater than 10"); }
        if (as03Number < 10){ Debug.Log("The number is less than 10"); }
        if (as03Number >= 10){ Debug.Log("The number is greater than 10"); }
        if (as03Number <= 10){ Debug.Log("The number is less than 10"); }
        if (as03Number == 10){ Debug.Log("The number is equal to 10"); }
        if (as03Number != 10){ Debug.Log("The number is equal to 10"); }
        Debug.Log("                                                                            ");
    }

    public int as04Number;
    public void As04_AndOrOperatorExample()
    {
        as04Number = 10;
        Debug.Log(as04Number);
        if (as04Number > 8 && as04Number < 12) { Debug.Log("The number is greater than 8 and less than 12"); }
        if (as04Number > 8 || as04Number < 12) { Debug.Log("The number is greater than 8 or less than 12"); }
        Debug.Log("----------------------------------------------------------------");
        
        as04Number = 7;
        Debug.Log(as04Number);
        if (as04Number > 8 && as04Number < 12) { Debug.Log("The number is greater than 8 and less than 12"); }
        if (as04Number > 8 || as04Number < 12) { Debug.Log("The number is greater than 8 or less than 12"); }
        Debug.Log("----------------------------------------------------------------");
        
        as04Number = 13;
        Debug.Log(as04Number);
        if (as04Number > 8 && as04Number < 12) { Debug.Log("The number is greater than 8 and less than 12"); }
        if (as04Number > 8 || as04Number < 12) { Debug.Log("The number is greater than 8 or less than 12"); }
        Debug.Log("                                                                            ");
    }

    public int as05GuessingNumber;
    public int as05RandomNumber;
    public void As05_GuessingNumberExample()
    {
        as05RandomNumber = 5;
        as05GuessingNumber = 5;
        Debug.Log("Guess number " + as05GuessingNumber);
        if (as05GuessingNumber == as05RandomNumber)
        {
            Debug.Log("Congratulations! You guessed the correct number.");
        }
        else
        {
            Debug.Log("I guess we can just agree to disagree.");   
        }
        Debug.Log("----------------------------------------------------------------");

        as05GuessingNumber = 3;
        Debug.Log("Guess number " + as05GuessingNumber);
        if (as05GuessingNumber == as05RandomNumber)
        {
            Debug.Log("Congratulations! You guessed the correct number.");
        }
        else
        {
            Debug.Log("I guess we can just agree to disagree.");   
        }
        Debug.Log("                                                                            ");
    }

    public int as06GuessingNumber;
    public int as06RandomNumber;
    public void As06_GuessingNumberMoreOrLessExample()
    {
        as06RandomNumber = 5;
        as06GuessingNumber = 3;
        Debug.Log("Guess number " + as06RandomNumber);
        if (as06GuessingNumber == as06RandomNumber)
        {
            Debug.Log("Congratulations! We are same mind.");
        }
        else if (as06GuessingNumber > as06RandomNumber)
        {
            Debug.Log("Too high! Try again.");
        }
        else
        {
            Debug.Log("Too low! Try again.");   
        }
        Debug.Log("----------------------------------------------------------------");
        
        as06GuessingNumber = 7;
        Debug.Log("Guess number " + as06RandomNumber);
        if (as06GuessingNumber == as06RandomNumber)
        {
            Debug.Log("Congratulations! We are same mind.");
        }
        else if (as06GuessingNumber > as06RandomNumber)
        {
            Debug.Log("Too high! Try again.");
        }
        else
        {
            Debug.Log("Too low! Try again.");   
        }
        Debug.Log("----------------------------------------------------------------");
        
        as06GuessingNumber = 5;
        Debug.Log("Guess number " + as06RandomNumber);
        if (as06GuessingNumber == as06RandomNumber)
        {
            Debug.Log("Congratulations! We are same mind.");
        }
        else if (as06GuessingNumber > as06RandomNumber)
        {
            Debug.Log("Too high! Try again.");
        }
        else
        {
            Debug.Log("Too low! Try again.");   
        }
        Debug.Log("                                                                            ");
    }

    public string as07Username;
    public string as07Password;
    public int as07Age;
    public bool as07IsPaid;
    public void As07_VerifyIdentityExample()
    {
        as07Username = "user";
        as07Password = "user123";
        as07Age = 20;
        as07IsPaid = true;
        if (as07Username == "user" && as07Password == "user123" && as07Age == 20 && as07IsPaid == true)
        {
            Debug.Log("You have user access.");
            Debug.Log("welcome vip member.");
            Debug.Log("You have access to exclusive content.");
        }
        else if (as07Username == "user" && as07Password == "user123")
        {
            Debug.Log("You have user access.");
            if (as07IsPaid == true)
            {
                Debug.Log("welcome vip member.");
            }
            else
            {
                Debug.Log("welcome free member.");
            }
            if (as07Age >= 18 && as07IsPaid == true)
            {
                Debug.Log("You have access to exclusive content.");
            }
        }
        else
        {
            Debug.Log("You have guest access.");
        }
        Debug.Log("----------------------------------------------------------------");
        
        as07Age = 15;
        if (as07Username == "user" && as07Password == "user123" && as07Age == 20 && as07IsPaid == true)
        {
            Debug.Log("You have user access.");
            Debug.Log("welcome vip member.");
            Debug.Log("You have access to exclusive content.");
        }
        else if (as07Username == "user" && as07Password == "user123")
        {
            Debug.Log("You have user access.");
            if (as07IsPaid == true)
            {
                Debug.Log("welcome vip member.");
            }
            else
            {
                Debug.Log("welcome free member.");
            }
            if (as07Age >= 18 && as07IsPaid == true)
            {
                Debug.Log("You have access to exclusive content.");
            }
        }
        else
        {
            Debug.Log("You have guest access.");
        }
        Debug.Log("----------------------------------------------------------------");
        
        as07Age = 20;
        as07IsPaid = false;
        if (as07Username == "user" && as07Password == "user123" && as07Age == 20 && as07IsPaid == true)
        {
            Debug.Log("You have user access.");
            Debug.Log("welcome vip member.");
            Debug.Log("You have access to exclusive content.");
        }
        else if (as07Username == "user" && as07Password == "user123")
        {
            Debug.Log("You have user access.");
            if (as07IsPaid == true)
            {
                Debug.Log("welcome vip member.");
            }
            else
            {
                Debug.Log("welcome free member.");
            }
            if (as07Age >= 18 && as07IsPaid == true)
            {
                Debug.Log("You have access to exclusive content.");
            }
        }
        else
        {
            Debug.Log("You have guest access.");
        }
        Debug.Log("----------------------------------------------------------------");
        
        as07Username = "guest";
        as07Password = "pass";
        as07Age = 20;
        as07IsPaid = false;
        if (as07Username == "user" && as07Password == "user123" && as07Age == 20 && as07IsPaid == true)
        {
            Debug.Log("You have user access.");
            Debug.Log("welcome vip member.");
            Debug.Log("You have access to exclusive content.");
        }
        else if (as07Username == "user" && as07Password == "user123")
        {
            Debug.Log("You have user access.");
            if (as07IsPaid == true)
            {
                Debug.Log("welcome vip member.");
            }
            else
            {
                Debug.Log("welcome free member.");
            }
            if (as07Age >= 18 && as07IsPaid == true)
            {
                Debug.Log("You have access to exclusive content.");
            }
        }
        else
        {
            Debug.Log("You have guest access.");
        }
        Debug.Log("----------------------------------------------------------------");
    }
}
