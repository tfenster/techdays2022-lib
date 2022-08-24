namespace techdays2022_lib;
public class TechConferenceLib
{
    public string GetBCTechConferenceRating(string conferenceName)
    {
        if (string.Equals("BC TechDays", conferenceName, StringComparison.InvariantCultureIgnoreCase))
            return "awesome";
        else
            return "meh";
    }
}
