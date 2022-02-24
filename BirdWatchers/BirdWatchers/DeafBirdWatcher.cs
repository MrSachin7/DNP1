namespace BirdWatchers; 

public class DeafBirdWatcher : BirdWatcher {

    public DeafBirdWatcher(int id) : base(id) {
    }

    public override void ReactToBird(string birdBehaviour) {
        string tabPrefix = "";
        for (int i = 0; i < Id; i++) {
            tabPrefix += "\t\t";
        }

        string result = $"{tabPrefix} DeafBirdwatcher {Id} reacts ";

        switch (birdBehaviour) {
            case "Bird flap wings":
                result += " Look at those flapped wings...";
                break;
            case "Bird sings":
                result += " What is going on ??... I am confused...";
                break;
            case "Bird does mating dance":
                result += " Holy moly , those are some dope moves...";
                break;
            case "Bird runs away":
                result += " Okie dokie boizz and galz ... the show is over..";
                break;
        }

        Console.WriteLine(result);
    }
}