namespace human 
{
    public class Human 
    {
        public string name;
        public int strength = 3;
        public int dexterity = 3;
        public int intelligence = 3;
        public int health = 100;
        
        public Human(string newName)
        {
            name = newName;
        }
        public Human(string n, int s, int i, int d, int h)
        {
            name = n;
            strength = s;
            intelligence = i;
            dexterity = d;
            health = h;
        }
        public void attack(Human attacked)
        {
            attacked.health -= this.strength * 5;
            System.Console.WriteLine($"{attacked.name} was attacked by {this.name}! {attacked.name}'s health is now {attacked.health}");
        }
        public void status()
        {
            System.Console.WriteLine($"{this.name}, your current status is: Strength = {this.strength}, Intelligence = {this.intelligence}, Dexterity = {this.dexterity} and Health = {this.health}");
        }
    }
}