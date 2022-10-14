using System.Collections.Generic;
using System;
class PersonList 
{
    private List<Person> personList;
    static Program program;
    public PersonList() 
    {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) 
    {
        this.personList.Add(person);
    }

    public Scholar CheckScholar(Scholar Information)
    {
        if(personList is Scholar)
        {
            foreach(Scholar scholar in personList)
            {
                string Title = Information.GetTitle();
                string MainName = Information.GetMainName();
                string Surname = Information.GetSurname();
                if(scholar.GetTitle().Equals(Title) && scholar.GetMainName().Equals(MainName)&& scholar.GetSurname().Equals(Surname))
                {
                    return null; 
                }
            }
        }
        return Information;    
    }
    public Student CheckStudent(Student Information)
    {
        if(personList is Student)
        {
            foreach(Student student in personList)
            {
                string Title = Information.GetTitle();
                string MainName = Information.GetMainName();
                string Surname = Information.GetSurname();
                string Email = Information.GetEmail();
                if(student.GetTitle().Equals(Title) && student.GetMainName().Equals(MainName)&& student.GetSurname().Equals(Surname)&&student.GetEmail().Equals(Email))
                {
                    return null; 
                }
            }
        }
        return Information;      
    }
    public Teacher CheckTeacher(Teacher Information)
    {   
        if(personList is Teacher)
    {
        foreach(Teacher teacher in personList)
        {
            string Title = Information.GetTitle();
            string MainName = Information.GetMainName();
            string Surname = Information.GetSurname();
            string Email = Information.GetEmail();
            if(teacher.GetTitle().Equals(Title) && teacher.GetMainName().Equals(MainName)&& teacher.GetSurname().Equals(Surname)&&teacher.GetEmail().Equals(Email))
            {
                return null; 
            }
        }
    }        
        return Information;   
    }
    public void pullStudent()
    {
        Console.WriteLine("Student");       
        foreach(Person person in personList)
        {
            if(person is Student)
            {
                Console.WriteLine("{0} {1} {2}",person.GetTitle(),person.GetMainName(),person.GetSurname());        
            }           
        }
    }
    public void pullScholar()
    {
        Console.WriteLine("Scholar");      
        foreach(Person person in personList)
        {            
            if(person is Scholar)
            {
                Console.WriteLine("{0} {1} {2}",person.GetTitle(),person.GetMainName(),person.GetSurname());
            }            
        }
    }
    public void pullTeacher()
    {
         Console.WriteLine("Teacher");
        foreach(Person person in personList)
        {            
            if(person is Teacher)
            {
                Console.WriteLine("{0} {1} {2}",person.GetTitle(),person.GetMainName(),person.GetSurname());
            }            
        }
    }
    public bool Cheaklogin(string Email, string Password)
    {  
        foreach(Person person in personList)
        {
            if(person is Student student)
            {
                if(Email.Equals(student.GetEmail()) && Password.Equals(student.GetPassword()))
                {
                    return true;
                }  
            }         
        }        
            foreach(Person person in personList)
        {
            if(person is Teacher teacher)
            {
                if(Email.Equals(teacher.GetEmail()) && Password.Equals(teacher.GetPassword()))
                {
                    return true;
                }
            }
        }                
    return false;     
    }
    public int scholarCount()
    {
        int countforscholar = 0;        
        {
            foreach(Person person in personList)  
            { 
                if(person is Scholar)
                {
                    countforscholar ++;
                }         
            } 
            return countforscholar;
        }
       
    }
    public int studentCount()
    {
        int countforstudent = 0;
        {         
            foreach(Person person in personList)
            {
                if(person is Student)
                {
                    countforstudent ++; 
                }                
            } 
            return countforstudent;
        }        
    } 
    public int teacherCount()
    {
        int countforteacher = 0;
        {          
            foreach(Person person in personList)
            {
                if(person is Teacher)
                {
                    countforteacher ++;
                }           
            }
            return countforteacher;
        }                   
    }   
    public int Matayomsuksa4Count()
    {   
        int countforgradeelevenMatayomsuksafour = 0;        
        {
            foreach(Person person in personList)
            {
                if(person is Scholar scholar)
                {
                    if(scholar.GetDegree() == "Matayomsuksa 4")
                    {
                        countforgradeelevenMatayomsuksafour ++;                    
                    }
                }     
            }
            return countforgradeelevenMatayomsuksafour;
        }        
    }
    public int Matayomsuksa5Count()
    {   
        int countforgradeelevenMatayomsuksafive = 0;        
        {
            foreach(Person person in personList)
            {
                if(person is Scholar scholar)
                {
                    if(scholar.GetDegree() == "Matayomsuksa 5")
                    {
                        countforgradeelevenMatayomsuksafive ++;                    
                    }
                }     
            }
            return countforgradeelevenMatayomsuksafive;
        }       
    }
    public int Matayomsuksa6Count()
    {   
        int countforMatayomsuksasix = 0;        
        {
            foreach(Person person in personList)
            {
                if(person is Scholar scholar)
                {
                    if(scholar.GetDegree() == "Matayomsuksa 6")
                    {   
                        countforMatayomsuksasix ++;                    
                    }
                }     
            }
            return countforMatayomsuksasix;
        }        
    }
}