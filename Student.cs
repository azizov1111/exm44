class Student
{ 
    public int Id {get;set;}
    public string Fullname {get;set;}
    public int Age {get;set;}
    public string Group{get;set;}

    public Student (int id,string fullname,int age,string group)
    {
        Id=id;
        Fullname=fullname;
        Age=age;
        Group=group;
    }
}