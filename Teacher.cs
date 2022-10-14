using System;
public class Teacher: Person
{
    private string CarNumber = "";
    private string Role = "";
    private string Email = "";
    private string Password = "";
    private bool AdminChecker;

    public Teacher (string Title, string MainName , string Surname ,  int Age , string Role , string Allergy ,string Religion , string CarNumber ,bool AdminChecker, string Password ,string Email) 
    : base(Title,MainName ,Surname ,Age ,Allergy ,Religion)
    {
        this.CarNumber = CarNumber;
        this.Role = Role;
        this.Email = Email;
        this.Password = Password;
        this.AdminChecker = false;
    }

    public string GetCarNumber()
    {
        return this.CarNumber;
    }
    public string GetRole()
    {
        return this.Role;
    }
    public string GetEmail()
    {
        return this.Email;
    }
    public string GetPassword()
    {
        return this.Password;
    }
}