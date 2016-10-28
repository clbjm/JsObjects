public class Game {

public Game () {
    Health.power = 100;
    Health.message = "You are getting stronger.";
    Ammo.message = "You have more ammo";

}
public void Start (){
    Console.WriteLine("Please type in your name:");
    name = Console.ReadLine();
    Console.WriteLine("Your player name is " + myGame.name);
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
//Game PowerUps
public PowerUpBase Health = new PowerUpBase();
public PowerUpBase Ammo = new PowerUpBase();

//Game Weapons
private WeaponBase Gun = new WeaponBase();
private WeaponBase Rifle = new WeaponBase();
private WeaponBase Knife = new WeaponBase();

    public string name;

    private int score;


}