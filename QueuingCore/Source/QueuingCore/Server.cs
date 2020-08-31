using System;

namespace QueuingCore
{
    /// <summary>
    /// Represents a service processor
    /// </summary>
    public class Server : IId
    {
        public Server(Node node, int id, double startDate = 0.0)
        {
            Node = node ?? throw new ArgumentNullException(nameof(node));
            Id = id;
            StartDate = startDate;
            NextEndServiceDate = double.PositiveInfinity;
        }

        public int Id { get; set; }
        
        public Node Node { get; set; }

        public double Cust { get; set; }

        public bool Busy { get; set; }

        public double OffDuty { get; set; }

        public double AllTime { get; set; }

        public double StartDate { get; set; }

        public double BusyTime { get; set; }

        public double TotalTime { get; set; }

        public double ShiftEnd { get; set; }

        public double NextEndServiceDate { get; set; }

        public double Utilization => BusyTime / TotalTime;

        public override string ToString()
        {
            return $"Server {Id} is at Node {Node.Id}";
        }
    }
}