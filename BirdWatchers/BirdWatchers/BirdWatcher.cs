namespace BirdWatchers;

public class BirdWatcher {
    public int Id { set; get; }

    public BirdWatcher(int id) {
        this.Id = id;
    }

    public virtual void ReactToBird(string birdBehaviour) {
        string tabPrefix = "";
        for (int i = 0; i < Id; i++) {
            tabPrefix += "\t\t";
        }

        string result = $"{tabPrefix} NormalBirdwatcher {Id} reacts ";

        switch (birdBehaviour) {
            case "Bird flap wings":
                result += " Look at those flapped wings...";
                break;
            case "Bird sings":
                result += " Wow what a pleasant sound...";
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