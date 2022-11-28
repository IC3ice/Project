class Cookingtime{
    public int date;
    public int hour;
    public int minute;
    public int cooktime;
    public Cookingtime(int date, int hour, int minute, int cooktime){
        this.date = date;
        this.hour = hour;
        this.minute = minute;
        this.cooktime = cooktime;
    }
    public int GetDate(){
        return this.date;
    }
    public int GetHour(){
        return this.hour;
    }
    public int GetMinute(){
        return this.minute;
    }
    public int GetCooKTime(){
        return this.cooktime;
    }
    public int GetFinishCookTime(){
        return this.cooktime;
    }
}