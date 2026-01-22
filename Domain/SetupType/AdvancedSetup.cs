using Domain.SetupArea.Tabs;

namespace Domain.SetupType;

public sealed record AdvancedSetup(
    MechanicalBalanceTab MechanicalBalance,
    DampersTab Dampers,
    AeroBalanceTab AeroBalance,
    DrivetrainTab Drivetrain
);