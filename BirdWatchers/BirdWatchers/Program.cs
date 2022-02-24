// See https://aka.ms/new-console-template for more information

using BirdWatchers;

Bird bird = new Bird();
BirdWatcher birdWatcher1 = new BirdWatcher(1);
BirdWatcher birdWatcher2 = new BlindBirdWatcher(2);
BirdWatcher birdWatcher3 = new DeafBirdWatcher(3);

bird.BehaviourChange += birdWatcher1.ReactToBird;
bird.BehaviourChange += birdWatcher2.ReactToBird;
bird.BehaviourChange += birdWatcher3.ReactToBird;

bird.BirdChangesBehaviour();