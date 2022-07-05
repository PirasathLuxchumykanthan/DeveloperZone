namespace E_A;

public interface Unit
{
    public unit.Type Type { get; }
    public string TwoLetterISOLanguageName { get; }
    public double LocalUTCMinutesAddOn { get; }
    public string LocalTimezoneId { get; }
}