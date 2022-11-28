using System;
using System.Collections.Generic;
enum ForUnlogin{
    Login=1,
    Register
}
class MainMenu{

    private RegisterController registerController;
    private LoginController loginController;
    private List<User> users;

    public void ShowMainMenuScreen() {
        PrepareListUsersWhenMainScreenIsLoaded();
        ShowMenuScreenInformation();
    }

    private void ShowMenuScreenInformation() {
        UnLoginMenu(InputSelectedMenuFromKeyboard());
    }

    private void PrepareListUsersWhenMainScreenIsLoaded() {
        this.users = new List<User>();
    }
    public ForUnlogin InputSelectedMenuFromKeyboard() {
        Console.WriteLine("----Welcome to JFC restaurant----");
        Console.WriteLine("Please select menu");
        Console.WriteLine("1.Login");
        Console.WriteLine("2.Register");
        Console.Write("Please select menu: ");
        Console.Write("Select Menu: ");

        return (ForUnlogin)(int.Parse)(Console.ReadLine());        
    }
    private void UnLoginMenu(ForUnlogin selMenu){
        if(selMenu == ForUnlogin.Login){
            Console.Clear();
            ShowLoginScreen();
            bool status = this.loginController.InputLoginFromKeyboard(this.users);
            ShowMenuScreenWhenAccountInCorrect(status);
        }
        else if(selMenu == ForUnlogin.Register){
            Console.Clear();
            ShowRegisterScreen();
            this.users.Add(this.registerController.InputNewUserFromKeyboard());
            ShowMenuScreenInformation();
        }
    }

        private void ShowMenuScreenWhenAccountInCorrect(bool authenStatus) {
        if (!authenStatus) {
            Console.WriteLine("This account is incorrect Please try again.");
            ShowMenuScreenInformation();
        }
    }

    private void ShowLoginScreen() {
        this.loginController = new LoginController();
        this.loginController.ShowLoginScreen();
    }

    private void ShowRegisterScreen() {
        this.registerController = new RegisterController();
        this.registerController.ShowRegisterScreen();
    }
}