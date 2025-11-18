namespace Week4Practical
{
    class Player
    {
        public string? playerName;
        public int level;
        public int health;

        public Player()
        {
            Console.WriteLine("Default constructor has been called");
        }

        public Player(string playerName, int level, int health)
        {
            this.playerName = playerName;
            this.level = level;
            this.health = health;
        }
    }
}
