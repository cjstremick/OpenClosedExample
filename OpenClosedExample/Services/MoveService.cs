using System;
using System.Collections.Generic;
using System.Linq;
using OpenClosedExample.Processors;

namespace OpenClosedExample.Services
{
    public class MoveService : IMoveService
    {
        private readonly IEnumerable<MoveProcessor> _moveProcessors;

        /// <summary>
        ///     Creates a move service which can perform moves for the specific types supported by the list of move processors.
        /// </summary>
        /// <param name="moveProcessors">
        ///     A list of move processors that are available to this application.
        ///     It would also be appropriate to receive a factory or a purpose-build service locator.  But we need something that
        ///     gives us access to the available types of move processors.
        /// </param>
        public MoveService(IEnumerable<MoveProcessor> moveProcessors)
        {
            _moveProcessors = moveProcessors;
        }

        /// <summary>
        ///     Perform a move specific to the type being requested.
        /// </summary>
        /// <param name="moveType">The type of move to perform.</param>
        /// <param name="distance">The distance to travel.</param>
        /// <returns>A string showing how a move was performed.</returns>
        public string ProcessMove(string moveType, int distance)
        {
            var processor = GetMoveProcessor(moveType);
            return processor.PerformMove(distance);
        }

        /// <summary>
        ///     Pseudo-factory method to get a move processor that's appropriate for the given move type.
        /// </summary>
        /// <param name="moveType">The type move we need a processor to handle.</param>
        /// <returns>A move processor</returns>
        /// <exception cref="InvalidOperationException">Thrown when a suitable processor is not available.</exception>
        private MoveProcessor GetMoveProcessor(string moveType)
        {
            var processor = _moveProcessors
                .SingleOrDefault(p => p.MoveType.Equals(moveType, StringComparison.InvariantCultureIgnoreCase));
            if (processor == null)
                throw new InvalidOperationException($"No suitable processor for move type '{moveType}'.");

            return processor;
        }
    }
}