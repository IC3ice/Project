class get_orders{
    order order;
    order_add order_Add = new order_add();
    /*Cookingtime cookingtime = new Cookingtime();*/
    Todate todate = new Todate();
    private int order_check = 0;
    private int total_cost_order = 0;
    private int FinalMinCal = 0;
    private int FinalHourCal = 0;
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
        ShowFinishCook();
    }
    public int get_total_cost(){
        return this.total_cost_order;
    }

    public void ShowFinishCook(){
        Console.Write("Your order will finish in 20 = ");
        CalTime();
        Console.WriteLine("Press enter to continue.");
        Console.WriteLine("----------------");
        Console.ReadLine();
    }

    public void CalTime(){

        double FinalTimeCal = todate.get_this_minute()+20;
        if(FinalTimeCal >= 60){
            Console.WriteLine("{0}:{1}",todate.get_this_hour() + 1 , FinalTimeCal - 60);
        }
        else if(FinalTimeCal < 60){
            Console.WriteLine("{0}:{1}",todate.get_this_hour() , FinalTimeCal); 
        }
    }

}