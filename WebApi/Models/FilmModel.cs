using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class FilmModel
    {
        public Sys sys { get; set; }
        public Banner banner { get; set; }
        public string title { get; set; }
        public List<string> eventType { get; set; }
        public string slug { get; set; }
        public bool dev { get; set; }
        public bool @event { get; set; }
        public List<string> countries { get; set; }
        public List<string> languages { get; set; }
        public int runtime { get; set; }
        public string year { get; set; }
        public TempCredits tempCredits { get; set; }
        public List<string> infoTags { get; set; }
        public string content { get; set; }
        public string notes { get; set; }
        public string pitch { get; set; }
        public List<Programme> programmes { get; set; }
        public List<ParentEvent> parentEvents { get; set; }
        public string contentAdvisory { get; set; }
        public string rating { get; set; }
        public int? agesMin { get; set; }
        public int? agesMax { get; set; }
        public int? gradesMin { get; set; }
        public int? gradesMax { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string website { get; set; }
        public string festivalPremiere { get; set; }
        public string nextWavePremiere { get; set; }
        public string titleOfOriginalWork { get; set; }
        public string titleSecond { get; set; }
        public List<string> seasonId { get; set; }
        public string sortableTitle { get; set; }
        public List<SeriesLink> seriesLinks { get; set; }
        public List<string> contentTags { get; set; }
        public List<ScheduleItem> scheduleItems { get; set; }
        public List<Medium> media { get; set; }
        public string tiffKidsPremiere { get; set; }
        public string mastheadCaption { get; set; }
        public List<Sponsor> sponsors { get; set; }
    }

    public class Sys2
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Space
    {
        public Sys2 sys { get; set; }
    }

    public class Sys3
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class ContentType
    {
        public Sys3 sys { get; set; }
    }

    public class Sys
    {
        public string id { get; set; }
        public int revision { get; set; }
        public string type { get; set; }
        public string locale { get; set; }
        public Space space { get; set; }
        public ContentType contentType { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

    public class Sys4
    {
        public string type { get; set; }
        public string linkType { get; set; }
        public string id { get; set; }
    }

    public class Banner
    {
        public Sys4 sys { get; set; }
    }

    public class Sys5
    {
        public string type { get; set; }
        public string linkType { get; set; }
        public string id { get; set; }
    }

    public class TempCredits
    {
        public Sys5 sys { get; set; }
    }

    public class Sys6
    {
        public string type { get; set; }
        public string linkType { get; set; }
        public string id { get; set; }
    }

    public class Programme
    {
        public Sys6 sys { get; set; }
    }

    public class Sys7
    {
        public string type { get; set; }
        public string linkType { get; set; }
        public string id { get; set; }
    }

    public class ParentEvent
    {
        public Sys7 sys { get; set; }
    }

    public class Sys8
    {
        public string type { get; set; }
        public string linkType { get; set; }
        public string id { get; set; }
    }

    public class SeriesLink
    {
        public Sys8 sys { get; set; }
    }

    public class Sys9
    {
        public string type { get; set; }
        public string linkType { get; set; }
        public string id { get; set; }
    }

    public class ScheduleItem
    {
        public Sys9 sys { get; set; }
    }

    public class Sys10
    {
        public string type { get; set; }
        public string linkType { get; set; }
        public string id { get; set; }
    }

    public class Medium
    {
        public Sys10 sys { get; set; }
    }

    public class Sys11
    {
        public string type { get; set; }
        public string linkType { get; set; }
        public string id { get; set; }
    }

    public class Sponsor
    {
        public Sys11 sys { get; set; }
    }
}
