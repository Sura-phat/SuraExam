using System;
public class Student: Person
{
    private string Studentid = "";
    private string Email = "";
    private string Password = "";
    private bool AdminChecker;

    public Student (string Title, string MainName , string Surname , string Studentid , int Age , string Allergy ,string Religion , bool AdminChecker , string Email , string Password) 
    : base(Title,MainName ,Surname ,Age ,Allergy ,Religion)
    {
        this.Studentid = Studentid;
        this.Email = Email;
        this.Password = Password;
        this.AdminChecker = false;
    }

    public string GetStudentid()
    {
        return this.Studentid;
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