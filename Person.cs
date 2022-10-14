using System;
public class Person
{
    private string Title = "";
    private string MainName = "";
    private string Surname = "";
    private int Age;
    private string Allergy = "";
    private string Religion = "";

    public Person(string Title, string MainName , string Surname , int Age , string Allergy ,string Religion)
    {
        this.Title = Title;
        this.MainName = MainName;
        this.Surname = Surname;
        this.Age = Age;
        this.Allergy = Allergy;
        this.Religion = Religion;
    }

    public string GetTitle()
    {
        return this.Title;
    }

    public string GetMainName()
    {
        return this.MainName;
    }

    public string GetSurname()
    {
        return this.Surname;
    }

    public int GetAge()
    {
        return this.Age;
    }

    public string GetAllergy()
    {
        return this.Allergy;
    }

    public string GetReligion()
    {
        return this.Religion;
    }
}