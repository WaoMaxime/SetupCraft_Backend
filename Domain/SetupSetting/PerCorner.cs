namespace Domain.SetupSetting;

public sealed record PerCorner<T>(T FL, T FR, T RL, T RR)
{
    public T Get(Corner c) => c switch { Corner.FL => FL, Corner.FR => FR, Corner.RL => RL, _ => RR };
    public PerCorner<T> With(Corner c, T v) => c switch
    {
        Corner.FL => this with { FL = v },
        Corner.FR => this with { FR = v },
        Corner.RL => this with { RL = v },
        _ => this with { RR = v }
    };
}