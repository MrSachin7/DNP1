namespace MultiThreadedServer; 

public class Message {
    public string MessageBody { get; set; }
    public DateTime TimeStamp { get; set; }

    public Message(string messageBody, DateTime dateTime) {
        this.MessageBody = messageBody;
        this.TimeStamp = dateTime;
    }
}