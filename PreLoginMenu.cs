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
    Todate todate = new Todate();

    public void ShowMainMenuScreen() {
        PrepareListUsersWhenMainScreenIsLoaded();
        ShowMenuScreenInformation();
    }

    public void ShowMainMenuScreenFromLogOut() {
        ShowMenuScreenInformation();
    }

    private void ShowMenuScreenInformation() {
        UnLoginMenu(InputSelectedMenuFromKeyboard());
    }

    private void PrepareListUsersWhenMainScreenIsLoaded() {
        this.users = new List<User>();
    }
    public ForUnlogin InputSelectedMenuFromKeyboard() {
        ShowTime();
        Console.WriteLine("----Welcome to JFC restaurant----");
        Console.WriteLine("Please select menu");
        Console.WriteLine("1.Login");
        Console.WriteLine("2.Register");
        Console.WriteLine("----Please select menu---- ");
        Console.WriteLine("Type 1 or 2 to select menu.");
        Console.Write("Select Menu: ");

        return (ForUnlogin)(int.Parse)(Console.ReadLine());        
    }
    public void ShowTime(){
        Console.WriteLine("---------------------------------");
        Console.Write("|   Time {0}:{1}", todate.get_this_hour() , todate.get_this_minute());
        Console.WriteLine(" Date {0}/{1}/{2}   |", todate.GetDay() , todate.get_this_month() , todate.get_this_year());
        Console.WriteLine("---------------------------------");
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
            Console.Clear();
            ShowMenuScreenInformation();
        }
    }

        private void ShowMenuScreenWhenAccountInCorrect(bool authenStatus) {
        if (!authenStatus) {
            Console.WriteLine("This account is incorrect Please try again.");
            Console.WriteLine("Press enter to get back to menu.");
            Console.WriteLine("-------------------------------------------");
            Console.ReadLine();
            Console.Clear();
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