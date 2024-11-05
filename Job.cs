namespace Classes
{
    public class Job
    {
        public string Name { get; }
        public int HP { get; }
        public int ATK { get; }
        public int Speed { get; }


        public Job(string name, int hp, int atk, int speed)
        {
            Name = name;
            HP = hp;
            ATK = atk;
            Speed = speed;
        }
    }
}