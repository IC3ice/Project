using System;

class AfterLoginMenuController {

    private User user;
    static ProductList productList;

    public void ShowAfterLoginMenuController(User user) {
        SetupUser(user);
        PrintHeaderScreen();
        PrintListMenuScreen();
        InputSelectedMenuFromKeyboard();
    }

    private void PrintHeaderScreen() {
        Console.Clear();
        Console.WriteLine("User Account");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Name: {0} {1}", this.user.GetFirstName() , this.user.GetLastName());
        Console.WriteLine("-------------------------------");
    }

    private void PrintListMenuScreen() {
        Console.WriteLine("1.Food Menu");
        Console.WriteLine("2.Promotion Menu");
        Console.WriteLine("3.Fanchise");
    }

   private void InputSelectedMenuFromKeyboard() {
        Console.Write("Input Menu: ");
        int input = int.Parse(Console.ReadLine());
        int FoodMenu = 1;
        int PromotionMenu = 2;
        int FanchiseMenu = 3;

        if (input == FoodMenu) {
            productList.FetchFoodList();
        }
        else if(input == PromotionMenu){
            
        }
        else if(input == FanchiseMenu){
            
        }
    }

    private void SetupUser(User user) {
        this.user = (User)user;
    }
}