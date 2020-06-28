namespace Capstone_Proj.Models
{
   
    public class PostalCodeSearch
    {
        [Keyless]
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public Administrativearea AdministrativeArea { get; set; }
        public Timezone TimeZone { get; set; }
        public Geoposition GeoPosition { get; set; }

    }
    public class Administrativearea
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string CountryID { get; set; }
    }

    public class Timezone
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int GmtOffset { get; set; }
    }

    public class Geoposition
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }

    }
}