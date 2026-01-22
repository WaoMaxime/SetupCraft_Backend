namespace Domain.SetupSetting;

public sealed record DualSetting<TSteps, TValue>(TSteps Steps, TValue Value);
