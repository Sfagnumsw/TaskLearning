namespace Inheritance.MapObjects
{
    public class Army
    {
        public int Power { get; set; }
    }
}



namespace Inheritance.MapObjects
{
    public class Player
    {
        public int Gold { get; private set; }
        public bool Dead { get; private set; }


        public bool CanBeat(Army army)
        {
            return army.Power < 5;
        }
            
        public int Id { get; set; }

        public void Consume(Treasure treasure)
        {
            Gold += treasure.Amount;
        }

        public void Die()
        {
            Dead = true;
        }
    }
}



namespace Inheritance.MapObjects
{
    public class Treasure
    {
        public int Amount { get; set; }
    }
}


