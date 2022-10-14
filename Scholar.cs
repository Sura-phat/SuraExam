using System;
public class Scholar : Person
{
    private string Degree;
    private string School;
    public Scholar (string Title, string MainName , string Surname , int Age , string Degree , string Allergy ,string Religion , string School ) 
    : base(Title,MainName ,Surname ,Age ,Allergy ,Religion)
    {
        this.Degree = Degree;
        this.School = School;
    }

    public string GetDegree()
    {
        return this.Degree;
    }

    public string GetSchool()
    {
        return this.School;
    }
}