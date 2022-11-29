class Todate{
    private int NowADay;
    private int NowAMonth;
    private int NowAYear;
    private int NowAHour;
    private int NowAMinute;
    private void SetDate(){
        DateTime TodayDate = DateTime.Now;
        this.NowADay = TodayDate.Day;
        this.NowAMonth = TodayDate.Month;
        this.NowAYear = TodayDate.Year;
    }
    public int GetDay(){
        SetDate();
        return this.NowADay;
    }
    public int get_this_month(){
        SetDate();
        return NowAMonth;
    }
    public int get_this_year(){
        SetDate();
        return NowAYear;
    }
    private void set_time_now(){
        DateTime TodayDate = DateTime.Now;
        this.NowAHour = TodayDate.Hour;
        this.NowAMinute = TodayDate.Minute;
    }
    public int get_this_hour(){
        set_time_now();
        return NowAHour;
    }
    public int get_this_minute(){
        set_time_now();
        return NowAMinute;
    }
}