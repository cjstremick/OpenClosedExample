using System;
using System.Linq;

namespace OpenClosedExample.Processors
{
    public class JetMoveProcessor : MoveProcessor
    {
        public override string MoveType => "JET";

        public override string PerformMove(int distance)
        {
            return "Whoosh" + new string('!', distance);
        }
    }
}