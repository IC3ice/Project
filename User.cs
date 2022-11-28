class User{
    public string email;
    public string password;
    public string firstname;
    public string lastname;

    public User(string email, string password, string firstname, string lastname){
        this.email = email;
        this.password = password;
        this.firstname = firstname;
        this.lastname = lastname;
    }
    public string Getemail(){
        return this.email;
    }
    public string GetPassword() {
        return this.password;
    }
    public string GetFirstName(){
        return this.firstname;
    }
    public string GetLastName(){
        return this.lastname;
    }
}