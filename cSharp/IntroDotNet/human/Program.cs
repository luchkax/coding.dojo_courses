using System;


namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Me = new Human("Nazar");
            Human Other = new Human("Peter");
            // System.Console.WriteLine(Me.intelligence);
            // System.Console.WriteLine(Me.name);
            // System.Console.WriteLine(Other.intelligence);
            // System.Console.WriteLine(Other.name);
            // Me.attack(Other);
            // System.Console.WriteLine(Other.health);
            Me.status();
            Other.status();
        }
    }
}
