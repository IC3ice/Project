class order{
    private int orderid;
    private string ordername;
    private int cost;
    public order(int orderid,string ordername,int cost){
        this.orderid = orderid;
        this.ordername = ordername;
        this.cost = cost;
    }
    public string get_ordername(){
        return this.ordername;
    }
    public int get_order_id(){
        return this.orderid;
    }
    public int get_cost(){
        return this.cost;
    }
}