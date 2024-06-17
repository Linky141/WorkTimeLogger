namespace WorkTimeLogger.Models;

public class MeanDay
{
    public DateTime day { get; set; }
    public string description { get; set; }
    public List<DateTimePeriod> workedHours { get; set; } = new();
}
