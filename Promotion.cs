class Promotion{
    public int promotionID;
    public string promotion;
    public double cost;
    public Promotion(int promotionID, string promotion, double cost){
        this.promotionID = promotionID;
        this.promotion = promotion;
        this.cost = cost;
    }
    public int GetProMotionID(){
        return this.promotionID;
    }
    public string GetProMotion(){
        return this.promotion;
    }
    public double GetProCost(){
        return this.cost;
    }
}