using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace WorldOfZuul;

public class NPC
{
    private string Name  {get; set;}
    private string Description{get; set;}
    public string Q1{get; set;}
    public string? Q2{get; set;}
    public string? Q3{get; set;}
    public string T1{get; set;}
    public string? T2{get; set;}
    public string? T3{get; set;}


    public NPC(string name,string description, string q1, string? q2, string? q3,string t1, string? t2, string? t3)
    {
        Name=name;
        Description=description;
        Q1=q1;
        Q2=q2;
        Q3=q3;
        T1=t1;
        T2=t2;
        T3=t3;
    }

    public void TalkNPC()
    {
        Console.WriteLine("1. " + Q1 );
        Console.WriteLine("2. " + Q2 );
        Console.WriteLine("3. " + Q3 );

    }
    public void Case1()
    {
        Console.WriteLine(T1);
    }
    public void Case2()
    {
        Console.WriteLine(T2);
    }
    public void Case3()
    {
        Console.WriteLine(T3);
    }


}


