namespace DesignPattern_Lab2;

static class Program {
    public static void Main(string[] args) {
        Weapon fireSword = new Fire(new Sword());
        Console.WriteLine(fireSword.GetName());
        Console.WriteLine(fireSword.Attack());

        Enemy boss = new Boss(100, 500);
        Enemy goblin = new Goblin(50, 200);


        Console.WriteLine("Enemy is boss");
        Console.WriteLine("Upgrade your weapon");
        Console.WriteLine("Enter 1 for legendary flame");
        Console.WriteLine("Enter 2 for dragon breath");

        Console.WriteLine("Enter your choice");
        int input = int.Parse(Console.ReadLine());

        if(input == 1) {
            fireSword = new LegendaryFlame(fireSword);
        }

        if (input == 2) {
            fireSword = new DragonBreath(fireSword);
        }

        Console.WriteLine("Your weapon is upgraded");
        Console.WriteLine("Best of luck");

    }
}

