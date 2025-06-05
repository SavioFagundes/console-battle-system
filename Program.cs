using Unity;

Unit player = new Unit("Player", 100, 20, 10);
Unit enemy = new Unit("Enemy", 80, 15, 5);
while (!player.IsDead && !enemy.IsDead)
{
    System.Console.WriteLine(player.UnitName + "HP: " + player.Hp + ".  " + enemy.UnitName + "HP: " + enemy.Hp);
    System.Console.WriteLine("Player turn! What will you do?");
    string choice = System.Console.ReadLine()?.ToLower();

    if (choice == "a")
    {
        player.Attack(enemy);
    }
    else
    {
        player.Heal();
    }
    if (player.IsDead || enemy.IsDead) break;
    System.Console.WriteLine(player.UnitName + "HP: " + player.Hp + ".  " + enemy.UnitName + "HP: " + enemy.Hp);
    System.Console.WriteLine("Enemy turn!");

    int rand = new Random().Next(0, 2);

    if (rand == 0)
    {
        enemy.Attack(player);
    }
    else
    {
        enemy.Heal();
    }
}
