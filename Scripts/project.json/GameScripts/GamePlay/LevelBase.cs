using System;
public class LevelBase
{
    public string StartMessage
    public bool entranceOpen = true;
    public string[] enveriment = {"Cold", "Wet", "Dark"};

    public string[] objects = {"Rocks", "Ravine", "River", "Lava"};
public void Enter (){
    Console.WriteLine(StartMessage)
}

    public void Encounter (int i){
        if(i < objects.Length) {

            switch (i)
            {
                case 0:
                
                break;


                case 1:


                break;

                case 2:


                break;

                case 3:
                //Lava kills us and ends the game
                    Game.canPlay = false;
                break;

                case 4:

                break;

                default:
                    Console.WriteLine("Your path is clear");
                    break;
            }
            Console.WriteLine("You've walked into " + objects[i]);
            if(objects[i] == "Lava") {
            
            }
        } else {
            
}

    }
}