namespace Domain.SetupArea;

public sealed record SetupAdjustment(
    SetupPath Path,
    decimal OldValue,
    decimal NewValue
);