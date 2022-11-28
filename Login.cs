using System.Collections.Generic;
using System;

class LoginController {

    public void ShowLoginScreen() {
        Console.Clear();
        PrintHeaderLoginScreen();
    }

    public bool InputLoginFromKeyboard(List<User> listUsers) {
        string email = InputEmailFromKeyboard();
        string password = InputPasswordFromKeyboard();

        foreach (User user in listUsers) {
            Console.WriteLine(user.Getemail());
            if (user.Getemail() == email && user.GetPassword() == password) {
                ShowAfterLoginMenu(user);

                return true;
            }
        }

        return false;
    }

    private void ShowAfterLoginMenu(User user) {
        AfterLoginMenuController afterLoginMenuController = new AfterLoginMenuController();
        afterLoginMenuController.ShowAfterLoginMenuController(user);
    }


    public string InputEmailFromKeyboard() {
        Console.Write("Input Email: ");

        return Console.ReadLine();
    }

    public string InputPasswordFromKeyboard() {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    private void PrintHeaderLoginScreen() {
        Console.WriteLine("Login Screen");
        Console.WriteLine("------------"); 
    }

}