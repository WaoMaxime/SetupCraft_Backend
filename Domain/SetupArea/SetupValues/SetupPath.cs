using Domain.SetupSetting;

namespace Domain.SetupArea;

public sealed record SetupPath(
    SetupSection Section,
    string Parameter,          
    Corner? Corner = null,     
    Axle? Axle = null          
);