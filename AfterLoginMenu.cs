using System;

class AfterLoginMenuController {
    Show_Menu show_Menu = new Show_Menu();
    MainMenu mainMenu = new MainMenu();
    Todate todate = new Todate();
    /*Cookingtime cookingtime = new Cookingtime();*/

    private User user;

    public void ShowAfterLoginMenuController(User user) {
        SetupUser(user);
        PrintHeaderScreen();
        PrintListMenuScreen();
        InputSelectedMenuFromKeyboard();
    }

    private void PrintHeaderScreen() {
        Console.Clear();
        ShowTime();
        Console.WriteLine("User Account");
        Console.WriteLine("Name: {0} {1}", this.user.GetFirstName() , this.user.GetLastName());
        Console.WriteLine("--------------------------");
    }

    public void ShowTime(){
        Console.WriteLine("---------------------------------");
        Console.Write("|   Time {0}:{1}", todate.get_this_hour() , todate.get_this_minute());
        Console.WriteLine(" Date {0}/{1}/{2}   |", todate.GetDay() , todate.get_this_month() , todate.get_this_year());
        Console.WriteLine("---------------------------------");
    }
    private void PrintListMenuScreen() {
        Console.WriteLine("1.Food Menu");
        Console.WriteLine("2.Promotion Menu");
        Console.WriteLine("3.Fanchise");
        Console.WriteLine("4.Log-out");
    }

   private void InputSelectedMenuFromKeyboard() {
        Console.Write("Input Menu: ");
        int input = int.Parse(Console.ReadLine());
        int FoodMenu = 1;
        int PromotionMenu = 2;
        int FanchiseMenu = 3;
        int LOGOut = 4;

        if (input == FoodMenu) {
            Console.Clear();
            PrintHeaderScreen();
            show_Menu.Show_Menu_normal_order();
            ShowAfterLoginMenuController(user);
        }
        else if(input == PromotionMenu){
            Console.Clear();
            PrintHeaderScreen();
            show_Menu.Show_Menu_Promo_order();
            ShowAfterLoginMenuController(user);
        }
        else if(input == FanchiseMenu){
            Console.Clear();
            PrintHeaderScreen();
            ShowFanchiseMenu();
        }
        else if(input == LOGOut){
            Console.Clear();
            PrintHeaderScreen();
            mainMenu.ShowMainMenuScreen();
        }
    }

    public void ShowFanchiseMenu(){
        Console.Clear();
        Console.WriteLine("-------Fanchise-------");
        Console.WriteLine("1.JFC Bangmod");
        Console.WriteLine("2.JFC Bang Khun tien");
        Console.WriteLine("3.JFC Bangbon");
        Console.WriteLine("4.JFC Thapra");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Press enter to go back to menu");
        Console.ReadLine();
        ShowAfterLoginMenuController(user);
    }

    private void SetupUser(User user) {
        this.user = (User)user;
    }
}