namespace BirdWatchers; 

public class BlindBirdWatcher : BirdWatcher {
    public BlindBirdWatcher(int id) : base(id) {
    }

    public override void ReactToBird(string birdBehaviour) {
        string tabPrefix = "";
        for (int i = 0; i < Id; i++) {
            tabPrefix += "\t\t";
        }

        string result = $"{tabPrefix} BlindBirdwatcher {Id} reacts ";

        switch (birdBehaviour) {
            case "Bird flap wings":
                result += " What happened.. Why is everyone freaking out...";
                break;
            case "Bird sings":
                result += " Wow what a pleasant sound...";
                break;
            case "Bird does mating dance":
                result += " What moves ?? Is there a tiger in front of us ??";
                break;
            case "Bird runs away":
                result += " Haha.....Nothing changed for me ..";
                break;
        }

        Console.WriteLine(result);
    }
}