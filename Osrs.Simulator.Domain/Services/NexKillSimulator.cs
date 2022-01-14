using System.Runtime.CompilerServices;
using Osrs.Simulator.Domain.Interfaces;
using Osrs.Simulator.Domain.Models.Bosses;
using Osrs.Simulator.Domain.Models.Uniques;
using Osrs.Simulator.Domain.Models.Uniques.Nex;

namespace Osrs.Simulator.Domain.Services;

public class NexKillSimulator : KillSimulator<Nex>
{
    public NexKillSimulator(IRandomNumberGenerator rng) : base(rng)
    {
    }

    protected override int UniqueDropRateDenominator => 53;
    protected override BossUnique<Nex> GetRandomUnique()
    {
        {
            var uniqueRoll = Rng.GetRandomInt(1, 12);
            return uniqueRoll switch
            {
                1 => new AncientHilt(),
                <= 3 => new NihilHorn(),
                <= 5 => new TorvaFullHelmet(),
                <= 7 => new TorvaPlateBody(),
                <= 9 => new TorvaPlateLegs(),
                <= 12 => new ZaryteVambraces(),
                _ => throw new SwitchExpressionException(uniqueRoll)
            };
        }
    }
}