class Show_Menu{
    order order;
    get_orders get_Orders = new get_orders();
    order_add order_Add = new order_add();
    public void Show_Menu_normal_order(){
        order_Add.add_order();
        List<order> orders = order_Add.orders;
        int i = 0;
        
        Console.WriteLine("----Here is the Food menu----");
        foreach (order order in orders)
        {   
            if (i <7){
            Console.WriteLine("{0} {1} {2}",order.get_order_id(),order.get_ordername(),order.get_cost());
            }
            i++;
        }
        Console.WriteLine("----------------------------");
        Console.WriteLine("Type Food number to order.");
        Console.WriteLine("Type zero to stop order.");
        Console.WriteLine("----------------------------");
        get_Orders.get_order();
        get_Orders.get_total_cost();
    }

    public void Show_Menu_Promo_order(){
        order_Add.add_order();
        List<order> orders = order_Add.orders;
        Console.WriteLine("----Here is the Promotion menu----");
        foreach (order order in orders)
        {   
            if (order.get_order_id() >= 8 ){
            Console.WriteLine("{0} {1} {2}",order.get_order_id(),order.get_ordername(),order.get_cost());
            }
        }
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Type Promotion number to order.");
        Console.WriteLine("Type zero to stop order.");
        Console.WriteLine("---------------------------------");
        get_Orders.get_order();
        get_Orders.get_total_cost();
    }
}