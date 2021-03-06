using System;
public class Game {
public static bool canPlay = true;
public Game () {
    Health.power = 100;
    Health.message = "You are getting stronger.";
    Ammo.message = "You have more ammo";
    Cave.StartMessage = "You have entered a cave";
    UnderWater.objects = new string[] {"SeaWead", "Coral", "Fish", "Shark"};

}
    //Runs at the start of the game
    public void Start (){
    Console.WriteLine("Please type in your name:");
    name = Console.ReadLine();
    Console.WriteLine("Your player name is " + myGame.name);
    while(Game.canPlay) {
        GameTimer();
        Play();
    }
    Console.WriteLine("You died");
    Console.WriteLine("Game Over");
    Walk();

    /*
    After prompt the game for a name we:
    Enter a cave
    find Health.
    Meet a dragon. (need an enemy class)
    pick a weapon.
    Battle Dragon.
    If we win: get Health and Ammo
    If dragon wins: loose Health.
    */
}
public string gameState;

private void Play (){
    Random randomNum = new Random();
    Cave.Enter();
    Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
    Console.WriteLine("Play commands: play, end, help");
    gameState = Console.ReadLine();
    if(gameState == "end") {
        Console.WriteLine("Game Over");
        Environment.Exit(0);
    }

    if(gameState == "help") {
        Console.WriteLine("What do you need help for. If you can't play this game, you have issues.");
        Play();
    }
    if(gameState != "help" && gameState != "play" && gameState != "end") {
        Console.WriteLine(gameState + " is not a valid option.");
        Play();
    }
}


}
public static void GameTimer () {
        System.Threading.Thread.Sleep(2000);
}
//Game Levels
private LevelBase Cave = new LevelBase();
public static LevelBase UnderWater = new LevelBase();
//Game PowerUps
public PowerUpBase Health = new PowerUpBase();
public PowerUpBase Ammo = new PowerUpBase();

private bool canPlay = true;
//Game Weapons
private WeaponBase Gun = new WeaponBase();
private WeaponBase Rifle = new WeaponBase();
private WeaponBase Knife = new WeaponBase();

    public string name;

    private int score;


}