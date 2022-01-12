namespace AccuWeather.Web.SkillsTest.Models.Data.Locations
{
	public class Location
	{
		public Area? AdministrativeArea { get; set; }
		public Area? Country { get; set; }

		public string? DisplayName
		{
			get
			{
				if (Country?.ID == "US" && AdministrativeArea != null)
				{
					return $"{LocalizedName}, {AdministrativeArea.ID}";
				}
				else if (!string.IsNullOrEmpty(AdministrativeArea?.LocalizedName))
				{
					return $"{LocalizedName}, {AdministrativeArea.LocalizedName}";
				}
				else if (!string.IsNullOrEmpty(Country?.LocalizedName))
				{
					return $"{LocalizedName}, {Country.LocalizedName}";
				}
				else
				{
					return LocalizedName;
				}
			}
		}

		public string? Key { get; set; }
		public string? LocalizedName { get; set; }
		public Area? Region { get; set; }
	}
}
