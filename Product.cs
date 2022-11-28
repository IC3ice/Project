public class Product {
    private int productID;
    private string name;
    private int cost;

    public Product(int productID, string name, int cost) {
        this.productID = productID;
        this.name = name;
        this.cost = cost;
    }

    public int GetProductID() {
        return this.productID;
    }
    public string GetProductName() {
        return this.name;
    }

    public int Getcost() {
        return this.cost;
    }

    public void SetID(){
        this.productID = int.Parse(Console.ReadLine());
    }
}