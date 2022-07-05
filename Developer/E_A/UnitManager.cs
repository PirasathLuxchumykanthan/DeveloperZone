using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_A;

public class UnitManager : Unit
{
    public virtual unit.Type Type => throw new NotImplementedException();
    public string TwoLetterISOLanguageName => System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
    public double LocalUTCMinutesAddOn => TimeZoneInfo.Local.GetUtcOffset(DateTime.Now).TotalMinutes;
    public string LocalTimezoneId => TimeZoneInfo.Local.Id;
}
