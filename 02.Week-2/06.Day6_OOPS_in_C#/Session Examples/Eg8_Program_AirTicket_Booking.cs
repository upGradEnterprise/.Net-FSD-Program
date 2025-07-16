namespace ConsoleApp39
{
    
    class AirlineTicket
    {
        public string PassengerName { get; set; }
        public string FlightNumber {  get; set; }
        public int SeatNumber {  get; set; }
        public DateTime BookingTime { get; set; }
        public int TicketNumber { get; set; }   
        public string BookingStatus {  get; set; }

        public AirlineTicket(string passengerName, string flightNumber, int seatNumber) {
            BookingStatus = "Not Booked";
            PassengerName = passengerName;
            FlightNumber = flightNumber;
            SeatNumber = seatNumber;    
        }

        public void ShowTicketDetails()
        {
            Console.WriteLine($"{TicketNumber}, {PassengerName}, {FlightNumber}, {SeatNumber}, {BookingTime.ToString()}, {BookingStatus}");
        }
    }
    
    class AirlineTicketUtility
    {
        // Validate the data
        // Book the ticket
        public static void BookTicket(AirlineTicket ticket)
        {
            // ValidateTicketInfo(ticket);

            Random rnd = new Random();

            ticket.BookingTime = DateTime.Now;
            ticket.BookingStatus = "Booked";
            ticket.TicketNumber = rnd.Next(100,1000);
        }

        // Cancel the ticket
        public static void CancelTicket(AirlineTicket ticket)
        {
            // ValidateTicketInfo(ticket);            
            ticket.BookingStatus = "Canceled";
            
        }
    }

    internal class Program
    {  
        static void Main(string[] args)
        {

            AirlineTicket ticket = new AirlineTicket("Scott","6E 4569", 25);

            AirlineTicketUtility.BookTicket(ticket);    

            ticket.ShowTicketDetails(); 

            AirlineTicketUtility.CancelTicket(ticket);

            ticket.ShowTicketDetails();

            Console.ReadLine();         
        } 
    }
}
