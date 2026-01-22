namespace Domain.Logging.Events;

public sealed record LogDiff(
    string Property,
    string Old,
    string New
);