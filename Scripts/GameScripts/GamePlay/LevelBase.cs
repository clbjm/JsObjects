using System;
public class LevelBase
{
    public bool entranceOpen = true;
    public string[] enveriment = {"Cold", "Wet", "Dark"};

    public string[] objects = {"Rocks", "Ravine", "River", "Lava"};

    public void Encounter (int i){
        if(i < objects.Length) {
            Console.WriteLine("You've walked into " + objects[i]);
        } else {
            Console.WriteLine("Your path is clear");
}

    }
}