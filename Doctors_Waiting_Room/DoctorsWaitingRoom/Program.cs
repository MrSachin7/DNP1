// See https://aka.ms/new-console-template for more information

using DoctorsWaitingRoom;

List<Patient> allPatients = new();
WaitingRoom waitingRoom = new WaitingRoom();

for (int i = 0; i < 5; i++) {
    allPatients.Add(new Patient(waitingRoom));
    Thread.Sleep(1000);
}
// TODO ask Troels if I have to run them in different threads because i did in different threads in JAVA last semester....
waitingRoom.RunWaitingRoom();
