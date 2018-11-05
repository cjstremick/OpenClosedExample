using System;
using System.Linq;

namespace OpenClosedExample.Processors
{
    public abstract class MoveProcessor
    {
        /// <summary>
        ///     Gets the type of move the concrete processor is capable of performing.
        /// </summary>
        public abstract string MoveType { get; }

        /// <summary>
        ///     Perform a move for the concrete type, of the given distance
        /// </summary>
        /// <param name="distance">The distance to move.</param>
        /// <returns>A value showing the specific move results.</returns>
        public abstract string PerformMove(int distance);
    }
}