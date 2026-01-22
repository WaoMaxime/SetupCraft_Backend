using Domain.Cases;
using MediatR;

namespace Domain.Logging.Events;

public sealed record CaseLogEvent(
    CaseId CaseId,
    LogAction Action,
    string Type,
    string Message,
    IEnumerable<LogDiff>? Diffs = null,
    string? TargetUrl = null
) : INotification;