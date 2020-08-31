namespace QueuingCore
{
    public class ServiceCentre
    {

        public ServiceCentre(int numberOfServers,int queueingCapacity, bool preempt)
        {
            NumberOfServers = numberOfServers;
            QueueingCapacity = queueingCapacity;
            Preempt = preempt;
        }
        
        public int NumberOfServers { get; set; }

        public int QueueingCapacity { get; set; }

        public bool Preempt { get; set; }

        //todo: class_change_matrix
        //todo: schedule   



    }

}
