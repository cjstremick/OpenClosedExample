using System;
using System.Linq;

namespace OpenClosedExample.Processors
{
    public class TrainMoveProcessor : MoveProcessor
    {
        public override string MoveType => "TRAIN";

        public override string PerformMove(int distance)
        {
            return string.Join(" ", Enumerable.Repeat("Chug", distance));
        }
    }
}