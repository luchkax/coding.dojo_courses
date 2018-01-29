namespace wizard
{   
    public class Samurai : Human
    {
        public int counter;
        public Samurai(string n) : base(n)
        {
            health = 200;
            counter ++;
        }
        public void death_blow(Human enemy)
        {
            if(enemy.health < 50)
            {
                enemy.health = 0;
                System.Console.WriteLine("{0} is dead!", name);
            }
            else
            {
                System.Console.WriteLine("Enemy {0} is Strong enough to Die!", name);
            }
        }
        public void meditate()
        {
            health = 200;
            System.Console.WriteLine("{0} is back to full health {1}", name, health);
        }
        public void howmany()
        {
            System.Console.WriteLine("There are {0} samurais", counter);
        }
    }
}