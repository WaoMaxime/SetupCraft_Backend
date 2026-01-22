using Domain.SetupArea;
using Domain.SetupArea.Tabs;

namespace Domain.SetupType;

public sealed record BasicSetup(
    TyresTab Tyres,
    AlignmentTab Alignment,
    ElectronicsTab Electronics,
    StrategyTab Strategy
);