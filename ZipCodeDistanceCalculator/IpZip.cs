using MongoDB.Bson;

namespace ZipCodeDistanceCalculator
{
    public class IpZip
    {
       public ObjectId _id { get; set; }
        public string ip { get; set; }
        public string ValidatedZipCode { get; set; }
        public int zip { get; set; }
        public int zip4 { get; set; }
        public int pulsepluspostalcode { get; set; }
        public int pulsepluspostalext { get; set; }
        public int Zip5Correct { get; set; }
        public int Zip4Correct { get; set; }
        public string pulsepluscountry { get; set; }
        public string pulseplusregion { get; set; }
        public string pulsepluscity { get; set; }
        public string pulseplusconnspeed { get; set; }
        public string pulseplusconntype { get; set; }
        public int pulseplusmetrocode { get; set; }
        public double pulsepluslatitude { get; set; }
        public double pulsepluslongitude { get; set; }
        public int pulsepluscountrycode { get; set; }
        public int pulseplusregioncode { get; set; }
        public int pulsepluscitycode { get; set; }
        public int pulsepluscontinentcode { get; set; }
        public string pulseplustwolettercountry { get; set; }
        public int pulseplusinternalcode { get; set; }
        public string pulseplusareacodes { get; set; }
        public int pulsepluscountryconf { get; set; }
        public int pulseplusregionconf { get; set; }
        public int pulsepluscityconf { get; set; }
        public int pulsepluspostalconf { get; set; }
        public int pulseplusgmtoffset { get; set; }
        public string pulseplusindst { get; set; }
    }
}