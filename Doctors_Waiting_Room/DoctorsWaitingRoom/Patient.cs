namespace DoctorsWaitingRoom; 

public class Patient {
    private int numberInQueue;
    private WaitingRoom waitingRoom;

    public Patient(WaitingRoom waitingRoom) {
        this.waitingRoom = waitingRoom;
        this.waitingRoom.NumberChange += ReactToNumber;
        numberInQueue = this.waitingRoom.DrawNumber();
        Console.WriteLine($"Patient {numberInQueue} enters the waiting room..");
    }

    public void ReactToNumber(int number) {
        Console.WriteLine($"Patient {numberInQueue} looks up .....");
        if (numberInQueue ==number) {
           Console.WriteLine($"Patient {numberInQueue} enters doctor's room"); 
        }
        else {
            Console.WriteLine($"Patient {numberInQueue} goes back to play phone..");
        }

    }
}