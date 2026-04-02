namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger();
            SendMSG msg_log = logger.Logger;
            publisher.OnSend += msg_log;
            for (int i = 0; i < 4; i++) { 
                publisher.Send(Console.ReadLine());
            }
        }
    }
}
