using System;

class RegisterController {

    public void ShowRegisterScreen() {
        Console.Clear();
        PrintHeaderRegisterScreen();
    }

    public User InputNewUserFromKeyboard() {
        string email = InputEmailFromKeyboard();
        string password = InputPasswordFromKeyboard();
        string firstname = InputNameFromKeyboard();
        string lastname = InputLastNameFromKeyboard();

        return new User(email, password, firstname, lastname);
    }

    private string InputNameFromKeyboard() {
        Console.Write("Input firstname: ");

        return Console.ReadLine();
    }

    private string InputPasswordFromKeyboard() {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    private string InputLastNameFromKeyboard() {
        Console.Write("Input Lastname: ");

        return Console.ReadLine();
    }

    private string InputEmailFromKeyboard() {
        Console.Write("Input Email: ");

        return Console.ReadLine();
    }

    private void PrintHeaderRegisterScreen() {
        Console.WriteLine("Register new Person");
        Console.WriteLine("-------------------");
    }
    
}