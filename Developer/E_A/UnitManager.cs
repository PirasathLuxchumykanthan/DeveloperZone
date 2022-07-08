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

    private E_B.task.Service Service => this.Tasks.Get(this.GetType());
    private readonly E_B.Tasks Tasks;
    public UnitManager(E_E.Entrance Entrance,E_A.Credential Credential, E_B.Tasks Tasks)
    {
        this.Tasks = Tasks;
        this.Service.Start(E_B.task.service.Status.Install);
        Entrance.Build(this.Service, Credential.Service);
        Entrance.Header("E_A.Type", ((int)this.Type).ToString());
        Entrance.Header("E_A.TwoLetterISOLanguageName", this.TwoLetterISOLanguageName);
        Entrance.Header("E_A.LocalUTCMinutesAddOn", this.LocalUTCMinutesAddOn.ToString());
        Entrance.Header("E_A.LocalTimezoneId", this.LocalTimezoneId);
        this.Service.Stop(E_B.task.service.Status.Install);
    }
}
