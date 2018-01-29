namespace wizard
{
    public class Ninja : Human
    {
        public Ninja(string n) : base(n)
        {
            dexterity = 175;
        }

        public void steal(Human enemy)
        {
            attack(enemy);
            health+=10;
            System.Console.WriteLine("{0} health is now {1}", name, health);
        }
        public void get_away()
        {
            health-=15;
            System.Console.WriteLine("{0} health is now {1}", name, health);
        }
    }
}