namespace QueuingCore
{
    public class DataRecord
    {
        public int Id { get; set; }

        public string CustomerClass { get; set; }

        //todo: int type correct?
        public int NodeId { get; set; }

        public double ArrivalDate { get; set; }

        public double WaitingTime { get; set; }
        
        public double ServiceStartDate { get; set; }

        public double ServiceTime { get; set; }

        public double ServiceEndDate { get; set; }

        public double BlockedTime { get; set; }

        public double ExitDate { get; set; }

        //todo: string type correct?!
        public string Destination { get; set; }

        public int QueueSizeAtArrival { get; set; }

        public int QueueSizeAtDeparture { get; set; }

    }
}
