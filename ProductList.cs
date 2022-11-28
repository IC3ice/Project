using System.Collections.Generic;
using System;
class ProductList{
    private List<Product> products;
    static Product product;
    public ProductList(){

        Product[] products = {new Product(001,"French frie", 40),
        new Product(002,"Garlic bread", 40),
        new Product(003,"Chicken frie", 60),
        new Product(004,"Spicy chicken frie", 65),
        new Product(005,"Green Curry with Fried Chicken", 60),
        new Product(006,"Ramen", 80),
        new Product(007,"Pizza", 120),};
    }

    public void FetchFoodList() {
        Console.Clear();
        Console.WriteLine("Food List");
        Console.WriteLine("---------");

        foreach (Product product in this.products) {
            Console.Write("ID: {0} ", product.GetProductID());
            Console.Write("Name: {0} ", product.GetProductName());
            Console.WriteLine("Price: {0} ", product.Getcost());
        }
    }

    public Product OrderMenu(int productID) {
        List<int> ordermenu = new List<int>();
        foreach (Product product in this.products) {
            if (productID == product.GetProductID()) {
                ordermenu.Add(int.Parse(Console.ReadLine()));
                return product;
            }
        }
        return new Product(0, "Don't have this Food", 0);
    }

    /*public void InputProductID(){
        product.SetID();
    }*/
}