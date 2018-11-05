using System;
using System.Linq;

namespace OpenClosedExample.Processors
{
    public class HorseMoveProcessor : MoveProcessor
    {
        public override string MoveType => "HORSE";

        public override string PerformMove(int distance)
        {
            return string.Join(" ", Enumerable.Repeat("Clip-clop", distance));
        }
    }
}