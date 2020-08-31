using System;

namespace QueuingCore
{
    public class Node : IId
    {
        private readonly Simulation simulation;

        public Node(int id, Simulation sim)
        {
            simulation = sim ?? throw new ArgumentNullException(nameof(sim));
            Id = id;
        }

        public int Id { get; set; }


    }





}
