public class Game {

public Game () {
    Health.power = 100;
    Health.message = "You are getting stronger.";
    Ammo.message = "You have more ammo";
    Cave.StartMessage = "You have entered a cave";

}
    //Runs at the start of the game
    public void Start (){
    Console.WriteLine("Please type in your name:");
    name = Console.ReadLine();
    Console.WriteLine("Your player name is " + myGame.name);
    while(Program.canPlay) {
        Walk();
    }
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

private void Walk (){
    Random randomNum = new Random();
    Cave.Enter();
    Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
}

//Game Levels
private LevelBase Cave = new LevelBase();
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