using Domain.SetupSetting;

namespace Domain.SetupArea;

public sealed record AlignmentTab(
    PerCorner<DualSetting<int, decimal>> Camber,      
    PerCorner<DualSetting<int, decimal>> Toe,         
    int CasterLF,
    int CasterRF,
    int SteerRatio
);