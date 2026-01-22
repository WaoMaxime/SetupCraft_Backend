using System.ComponentModel.DataAnnotations;
using Domain.Cases;
using Domain.Logging.Events;
using Domain.Shared;

namespace Domain.Logging;

public class CaseLog : Entity
{
    public CaseLogId Id { get; init; }
    public CaseId CaseId { get; init; }
    public LogAction Action { get; init; }
    [StringLength(999)] public string Type { get; init; }
    [StringLength(9999)] public string Message { get; init; }
    public IEnumerable<LogDiff>? Diffs { get; init; }
    [StringLength(999)] public string? TargetUrl { get; init; }
    public DateTimeOffset CreatedAt { get; init; }

    private CaseLog(CaseId caseId, LogAction action, string type, string message, IEnumerable<LogDiff>? diffs,
        string? targetUrl)
    {
        Id = CaseLogId.New();
        CaseId = caseId;
        Action = action;
        Type = type;
        Message = message;
        Diffs = diffs;
        TargetUrl = targetUrl;
        CreatedAt = DateTimeOffset.Now;
    }

    public static CaseLog Create(CaseId caseId, LogAction action, string type, string message,
        IEnumerable<LogDiff>? diffs, string? targetUrl)
    {
        return new CaseLog(caseId, action, type, message, diffs, targetUrl);
    }
}