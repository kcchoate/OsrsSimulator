namespace Nex.Simulator.Domain.Models;

public record NihilHorn : NexUnique
{
    public override string Name { get; } = "Nihil Horn";
    public override decimal DropRate { get; } = new decimal(2) / new decimal(12);
}
