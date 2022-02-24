namespace BirdWatchers;

public class Bird {
    public Action<string> BehaviourChange { get; set; }

    private string[] behaviours = new[] {"Bird flap wings", "Bird sings", "Bird does mating dance", "Bird runs away"};

    public void BirdChangesBehaviour() {
        Random random = new Random();
        for (int i = 0; i < 16; i++) {
            int index = random.Next(4);
            Console.WriteLine(behaviours[index]);
            BehaviourChange?.Invoke(behaviours[index]);
            Thread.Sleep(2000);
        }
    }
}