using System;

namespace wizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Joe = new Human("Joe");
            Ninja Naruto = new Ninja("Naruto");
            Samurai Leo = new Samurai("Leo");
            Wizard Nazar = new Wizard("Nazar");
            Naruto.steal(Leo);
        }
    }
}
