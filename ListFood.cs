using System;

class ListFoodController {
    static ProductList productList;

    public void ShowListFoodScreen() {
        PrintHeaderScreen();
        
        Console.Clear();
        PrintFoodList();
    }

    private void PrintHeaderScreen() {
        Console.WriteLine("Food List");
        Console.WriteLine("---------");
    }

    private void PrintFoodList() {
        ProductList productList = new ProductList();

        productList.OrderMenu(int.Parse(Console.ReadLine()));
    }
}