using Osrs.Simulator.Domain.Models.Bosses;
using Osrs.Simulator.Domain.Models.Uniques;

namespace Osrs.Simulator.Domain.Models;

public record SimulationResult<T>(int Kills, IEnumerable<UniqueItemName<T>> Uniques) where T: Boss<T>;
