public class Game {

public Game () {
    Health.power = 100;
    Console.WriteLine(Health.power);
    Console.WriteLine(Ammo.power);
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