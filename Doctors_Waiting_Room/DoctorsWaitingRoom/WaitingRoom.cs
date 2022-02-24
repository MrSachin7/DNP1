namespace DoctorsWaitingRoom;

public class WaitingRoom {
    public Action<int> NumberChange { get; set; }
    private int currentNumber;
    private int ticketCount;

    public WaitingRoom() {
        currentNumber = 0;
        ticketCount = 0;
    }

    public void RunWaitingRoom() {
        while (currentNumber<ticketCount) {
            Console.WriteLine("Dingggggg.....");
            NumberChange.Invoke(currentNumber);
            currentNumber++;
            Console.WriteLine($"Patient Number {currentNumber} can now enter..");
            Thread.Sleep(2000);
        }
    }

    public int DrawNumber() {
        return ++ticketCount;
    }
}