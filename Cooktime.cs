/*class Cookingtime{
    Todate todate = new Todate();
    public TimeOnly timeOnly;
    public double GetTime(){
       timeOnly = TimeOnly.FromDateTime(DateTime.Now);
       double MinToCal = timeOnly.Minute; 
       return MinToCal/100;
    }

    public void CalTime(){
        double FinalTimeCal = GetTime()+20;
        if(FinalTimeCal >= 60){
            Console.WriteLine("{0}",FinalTimeCal - 60);
        }
    }*/

    /*public void CalTime(){
        double FinalTimeCal = todate.get_this_minute()+20;
        if(FinalTimeCal >= 60){
            Console.WriteLine("{0}:{1}",todate.get_this_hour() + 1 , FinalTimeCal - 60);
        }
        else if(FinalTimeCal < 60){
            Console.WriteLine("{0}:{1}",todate.get_this_hour() , FinalTimeCal); 
        }
    }
}*/