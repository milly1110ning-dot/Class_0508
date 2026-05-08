using System;
using System.Reflection.Metadata.Ecma335;

public class Person
{
	public virtual string GetName()
	{
        return "Person";
	}
}
public class  Student : Person
{
    public override string GetName()
    {
        return "Student";
    }
}

public class People
{
    public string GetName()
    {
        return "People";
    }
}


public class Teacher : People
{
    public new string GetName()
    {
        return "Teacher";
    }
}

