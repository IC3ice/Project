class get_orders{
    order order;
    order_add order_Add = new order_add();
    private int order_check = 0;
    private int total_cost_order = 0;
    public void get_order(){
        order_Add.add_order();
        List<order> orders = order_Add.orders;
        while(true){
        this.order_check = int.Parse(Console.ReadLine());
            foreach (order order in orders){   
                if (order.get_order_id() == order_check){
                    this.total_cost_order+=order.get_cost();
                    break;
                }
            }
            if (order_check == 0){
                this.order_check=0;
                break;
            }
        }
        Console.Clear();
        Console.WriteLine("----------------");
        Console.Write("Total price : ");
        Console.WriteLine(total_cost_order);
        Console.WriteLine("----------------");
        Console.Write("Press enter to get back to menu");
    }
    public int get_total_cost(){
        return this.total_cost_order;
    }
}