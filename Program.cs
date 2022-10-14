using System;
enum Menu
{
    Registerfortheevent = 1 ,
    Showattendancemember  ,
    Login ,
}
enum Nextmenu
{
    Registerfortheeventagain = 1 ,
    Showallscholarsparticipatingintheprogram  ,
    Showallstudentsparticipatingintheprogram  ,
    Showallteachersparticipatingintheprogram  ,
    logout  ,
}
enum Menuregis
{
    RegisnewScholar = 1 ,
    RegisnewStudent ,
    RegisnewTeacher , 
}

class Program
{
    static PersonList personList;
    static void Main(string[] args) 
    {
        PreparePersonListWhenProgramstartLoad();
        InputMenuFromKeyboard();
        
    }
    
    static void PreparePersonListWhenProgramstartLoad()
    {
        Program.personList = new PersonList();
    }
    static void InputMenuFromKeyboard()
    {
        Console.WriteLine("Welcome to the Idia camp 2022 Registration ");
        PrintListMenu();
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));
        ChooseMenuSwtich(menu);        
    }
    static void InputMenuFromKeyboard2()
    {
        Console.WriteLine("Welcome to the Idia camp 2022 Registration ");
        PrintListMenu();
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));
        ChooseMenuSwtich2(menu);
    }
    static void ChooseMenuSwtich(Menu select)
    {
        if(select == Menu.Registerfortheevent)
        {
            InputRoleFromKeyboard();
        }
        else if(select == Menu.Showattendancemember)
        {
            PrintNumber();
        }
        else if(select == Menu.Login)
        {
            Login();
        }      
    }
    static void ChooseMenuSwtich2(Menu select)
    {
        if(select == Menu.Registerfortheevent)
        {
            InputRoleFromKeyboard();
        }
        else if(select == Menu.Showattendancemember)
        {
            PrintNumber();
        }
        else if(select == Menu.Login)
        {
            Console.Clear();
            PrintlistNextmenu();
            Nextmenu login = (Nextmenu)(int.Parse(Console.ReadLine()));
            LoginSwitchMenu(login);
        }      
    }
    public static void InputRoleFromKeyboard()
    {
        Console.WriteLine("Pls Choose your role ");
        RoleInEvent();
        Menuregis register = (Menuregis)(int.Parse(Console.ReadLine()));
        RoleChooseMenu(register);
    }
    
    static void RoleChooseMenu(Menuregis register)
    {
        switch(register)
        {
            case Menuregis.RegisnewScholar:
            ScholarRegister();
            break;
            case Menuregis.RegisnewStudent:
            StudentRegister();
            break;
            case Menuregis.RegisnewTeacher:
            TeacherRegister();
            break;
        }
    }
    static void LoginSwitchMenu(Nextmenu login)
        {
            switch(login)
            {
                case Nextmenu.Registerfortheeventagain:
                InputMenuFromKeyboard2();
                break;
                case Nextmenu.Showallscholarsparticipatingintheprogram:
                PrintAllScolarInfo();
                break;
                case Nextmenu.Showallstudentsparticipatingintheprogram:
                PrintAllStudentInfo();
                break;
                case Nextmenu.Showallteachersparticipatingintheprogram:
                PrintAllTeacherInfo();
                break;
                case Nextmenu.logout:
                BackToStart();
                break; 
            }
        }
    static void ScholarRegister()
    {       
        PrintHeaderRegisterScholar();
        Scholar scholar = new Scholar(ChoiceTitle(),InputMainName(),InputSurname(),InputAge(),selectdegree(),InputAllergy(),InputReligion(),InputSchool());
        Scholar CheckError =  personList.CheckScholar(scholar);
        if(CheckError != null)
        {
            Program.personList.AddNewPerson(scholar);
            BackToStart();
        }
        else if(CheckError == null)
        {
            Console.Clear();
            Console.WriteLine("User is already registered. Please try again.");
            ScholarRegister();
        }        
    }
    static void StudentRegister()
    {
        bool Adminchecker;
        PrintHeaderRegisterScholar();
        Student student = new Student(ChoiceTitle(),InputMainName(),InputSurname(),InputStudentid(),InputAge(),InputAllergy(),InputReligion(),Adminchecker=AdminPast(),InputadminEmail(Adminchecker),InputadminPassword(Adminchecker));
        Student Error = personList.CheckStudent(student);
        if(Error != null)
        {
            Program.personList.AddNewPerson(student); 
            BackToStart();
        }
        else if(Error == null)
        {
            Console.Clear();
            Console.WriteLine("User is already registered. Please try again.");
            StudentRegister();
        }        
    }
    static void TeacherRegister()
    {
         bool Adminchecker;
        PrintHeaderRegisterTeacher();
        Teacher teacher = new Teacher(ChoiceTitle(),InputMainName(),InputSurname(),InputAge(),selectRole(),InputAllergy(),InputReligion(),CarNumber(),Adminchecker=AdminPast(),InputadminEmail(Adminchecker),InputadminPassword(Adminchecker));
        Teacher Error = personList.CheckTeacher(teacher);
        if(Error != null)
        {
            Program.personList.AddNewPerson(teacher);
            BackToStart();
        }
        else if(Error == null)
        {
            Console.Clear();
            Console.WriteLine("User is already registered. Please try again.");
            TeacherRegister();
        }       
    }
    static void PrintAllScolarInfo()
        {
            personList.pullScholar();
            Console.ReadLine();
            Console.Clear();
        }
        static void PrintAllStudentInfo()
        {
            personList.pullStudent();
            Console.ReadLine();
            Console.Clear();
        }
        static void PrintAllTeacherInfo()
        {
            personList.pullTeacher();
            Console.ReadLine();
            Console.Clear();
        }
    
    static void BackToStart()
    {
     InputMenuFromKeyboard();   
    }
    static void BackToStart2()
    {
     InputMenuFromKeyboard2();
    }
    
    public static void PrintHeaderRegisterStudent()
    {
         
        Console.WriteLine("Register New Student");
        Console.WriteLine("****************************************************");
    }
    public static void PrintHeaderRegisterScholar()
    {
        
        Console.WriteLine("Register New Scholar");
        Console.WriteLine("****************************************************");
    }
     public static void PrintHeaderRegisterTeacher()
    {
        Console.Clear();
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("****************************************************");
    }
    
    static void PrintListMenu()
    {
        Console.WriteLine("Welcome to registration for the event Idia camp 2022");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Register For The Event");
        Console.WriteLine("2. Show Attendance Member");
        Console.WriteLine("3. Log In");
        Console.WriteLine("****************************************************");
    }
    static void PrintlistNextmenu()
    {
        Console.WriteLine("Welcome to register");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Register Menu");
        Console.WriteLine("2. ShowAllScholarInformation");
        Console.WriteLine("3. ShowAllStudentInformation");
        Console.WriteLine("4. ShowAllTeacherInformation");
        Console.WriteLine("5. Logout");
        Console.WriteLine("****************************************************");
    }    
    static string ChoiceTitle()
    {
        Console.WriteLine("****************************************************");
        Console.WriteLine("Choose your Title");
        Console.WriteLine("1. Mr.");
        Console.WriteLine("2. Ms.");
        Console.WriteLine("3. Mrs.");
        Console.WriteLine("****************************************************");
        int Choiceselect = int.Parse(Console.ReadLine());
        return ChoiceTitle(Choiceselect);
    }
    static string ChoiceTitle(int select)
    {
        if(select == 1)
        {
            return "Mr.";
        }
        else if(select == 2)
        {
            return "Ms.";
        }
        else if(select == 3)
        {
            return "Mrs.";
        }
        else
        {
            Console.WriteLine("Pls select again");
            return ChoiceTitle();
        }       
    }
    static string InputMainName()
    {
        Console.Write("MainName : ");
        return Console.ReadLine();
    }
    static string InputSurname()
    {
        Console.Write("Surname : ");
        return Console.ReadLine();
    }
    static string InputStudentid()
    {
        Console.Write("Studentid : ");
        return Console.ReadLine();
    }
    static int InputAge()
    {
        Console.Write("Age : ");
        return int.Parse(Console.ReadLine());
    }
    static string InputAllergy()
    {
        Console.Write("Allergy : ");
        return Console.ReadLine();
    }
    static string InputSchool()
    {
        Console.Write("School : ");
        return Console.ReadLine();
    }
    static string InputReligion()
    {
        Console.Clear();
        Console.WriteLine("Pls select Religion ");
        Console.WriteLine("***********************");
        Console.WriteLine("1. Buddha");
        Console.WriteLine("2. Christian ");
        Console.WriteLine("3. Muslim ");
        Console.WriteLine("4. Other ");
        Console.WriteLine("***********************");
        int Choiceselect = int.Parse(Console.ReadLine());
        return ChoiceReligion(Choiceselect);
    }
    static string ChoiceReligion(int select)
    {
        if(select == 1)
        {
            return "Buddha" ;
        }
        else if(select == 2)
        {
            return "Christian";
        }
        else if(select == 3)
        {
            return "Muslim";
        }
        else if(select == 4)
        {
            Console.Write("Other: ");
            return Console.ReadLine();
        }
        else
        {
            Console.Write("Please Input your religion: ");
            return InputReligion();
        }
    }
    static string selectdegree()
    {
        Console.Clear();
        Console.WriteLine("Pls select your degree ");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Matayomsuksa 4 ");
        Console.WriteLine("2. Matayomsuksa 5 ");
        Console.WriteLine("3. Matayomsuksa 6 ");
        Console.WriteLine("****************************************************"); 
        int Choiceselect = int.Parse(Console.ReadLine());
        return Choicedegree(Choiceselect);
    }
    static string Choicedegree(int select)
    {
        if(select == 1)
        {
            return "Matayomsuksa 4";
        }
        else if(select == 2)
        {
            return "Matayomsuksa 5";
        }
        else if(select == 3)
        {
            return "Matayomsuksa 6";
        }
        else
        {
            Console.WriteLine("Pls select degree again");
            return selectdegree();
        }       
    }
    static bool TeacherCar()
    {
        Console.Write("Are you admin? (Y/N): ");
       char chose = char.Parse(Console.ReadLine());
       if(chose == 'Y' || chose == 'y')
        {
            return true; 
            
        }
        else if(chose == 'N' || chose == 'n')
        {
            return false;
            
        }
        else 
        {    
            Console.WriteLine("Can't");
            return TeacherCar();
        }
    }
    static string CarNumber()
    {
        if(TeacherCar())
        {
            Console.WriteLine("Your Car regis: ");
            return Console.ReadLine();     
        }
        return null;               
    }
    static bool AdminPast()
    {
       Console.Write("Are you admin? (Y/N): ");
       char chose = char.Parse(Console.ReadLine());
       if(chose == 'Y' || chose == 'y')
        {
            return true; 
            
        }
        else if(chose == 'N' || chose == 'n')
        {
            return false;
            
        }
        else 
        {     
            Console.WriteLine("Can't");
            return AdminPast();
        }
    }
    static string EmailLogin()
    {
        Console.Write("Pls input your email:  ");
        return Console.ReadLine();
    }
    static string PasswordLogin()
    {
        Console.Write("Pls input your password:  ");
        return Console.ReadLine();
    }
    static string InputadminEmail(bool adcheck)
    {
        if(adcheck)
        {
            Console.Write("Pls input Your Email: ");
            return Console.ReadLine();                        
        }
        return null;       
    }
    static string InputadminPassword(bool adcheck)
    {
        if(adcheck)
        {
            Console.Write("Pls input Your Password: ");
            return Console.ReadLine();            
        }
        return null;      
    }
    
    static void RoleInEvent()
    {
        Console.Clear();
        Console.WriteLine("Choose your Role");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Scholar");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Teacher ");
        Console.WriteLine("****************************************************");
    }
    static string selectRole()
    {
        Console.Clear();
        Console.WriteLine("Pls Choose Role");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Dean");
        Console.WriteLine("2. Head Department");
        Console.WriteLine("3. Full-time Teacher");
        Console.WriteLine("****************************************************"); 
        int Choiceselect = int.Parse(Console.ReadLine());
        return Choicedegree(Choiceselect);
        
    }
        
    static string RoleInput (int select)
    {
        if(select == 1)
        {
            return "Dean";
        }
        else if(select == 2)
        {
            return "Head Department";
        }
        else if(select == 3)
        {
            return "Full-time Teacher";
        }
        else
        {
            Console.WriteLine("Pls select role again");
            return selectRole();
        }
    }
    static void PrintNumber()
    {
        Console.WriteLine("Teacher Amount : {0}",personList.teacherCount());
        Console.WriteLine("Student Amount : {0}",personList.studentCount());
        Console.WriteLine("Schorlar Amount : {0}",personList.scholarCount());
        Console.WriteLine("Matayomsuksa 4 Amount : {0}",personList.Matayomsuksa4Count());
        Console.WriteLine("Matayomsuksa 5 Amount : {0}",personList.Matayomsuksa5Count());
        Console.WriteLine("Matayomsuksa 6 Amount : {0}",personList.Matayomsuksa6Count());
        Console.ReadLine();
        BackToStart();         
    }
    static void Login()
    {        
        Console.WriteLine("** Pls login **");
        Console.WriteLine("*********************************************");
        Console.WriteLine("You can input (exit) for return to main menu");
        Console.WriteLine("*********************************************");
        string email = EmailLogin();
        string password = PasswordLogin();
        if(personList.Cheaklogin(email,password))
        {
            Console.Clear();
            PrintlistNextmenu();
            Nextmenu login = (Nextmenu)(int.Parse(Console.ReadLine()));
            LoginSwitchMenu(login);
            
        }
        else if(email.Equals ("exit"))
        {
         Console.Clear();
         InputMenuFromKeyboard();
        }
       else 
       {
        Console.WriteLine("Incorrect email or password. Please try again.");
        Console.ReadLine();
        Console.Clear();
        Login();
       }                
    }
}
