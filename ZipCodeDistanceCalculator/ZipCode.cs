using MongoDB.Bson;

namespace ZipCodeDistanceCalculator
{
    public class TheZipCode
    {
        public ObjectId _id { get; set; }
        public int ZipCode { get; set; }
        public string PrimaryRecord { get; set; }
        public int Population { get; set; }
        public int HouseholdsPerZipCode { get; set; }
        public int WhitePopulation { get; set; }
        public int BlackPopulation { get; set; }
        public int HispanicPopulation { get; set; }
        public int AsianPopulation { get; set; }
        public int HawaiianPopulation { get; set; }
        public int IndianPopulation { get; set; }
        public int OtherPopulation { get; set; }
        public int MalePopulation { get; set; }
        public int FemalePopulation { get; set; }
        public double PersonsPerHousehold { get; set; }
        public int AverageHouseValue { get; set; }
        public int IncomePerHousehold { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Elevation { get; set; }
        public string State { get; set; }
        public string StateFullName { get; set; }
        public string CityType { get; set; }
        public string CityAliasAbbreviation { get; set; }
        public string AreaCode { get; set; }
        public string City { get; set; }
        public string CityAliasName { get; set; }
        public string County { get; set; }
        public int CountyFIPS { get; set; }
        public int StateFIPS { get; set; }
        public int TimeZone { get; set; }
        public string DayLightSaving { get; set; }
        public string MSA { get; set; }
        public string PMSA { get; set; }
        public int CSA { get; set; }
        public int CBSA { get; set; }
        public string CBSA_Div { get; set; }
        public string CBSA_Type { get; set; }
        public string CBSA_Name { get; set; }
        public string MSA_Name { get; set; }
        public string PMSA_Name { get; set; }
        public string Region { get; set; }
        public string Division { get; set; }
        public string MailingName { get; set; }
        public string PreferredLastLineKey { get; set; }
        public string ClassificationCode { get; set; }
        public string MultiCounty { get; set; }
        public string CSAName { get; set; }
        public string CBSA_Div_Name { get; set; }
        public string CityStateKey { get; set; }
        public string CityAliasCode { get; set; }
        public string CityMixedCase { get; set; }
        public string CityAliasMixedCase { get; set; }
        public int StateANSI { get; set; }
        public int CountyANSI { get; set; }
        public string FacilityCode { get; set; }
        public string CityDeliveryIndicator { get; set; }
        public string CarrierRouteRateSortation { get; set; }
        public int FinanceNumber { get; set; }
        public string UniqueZIPName { get; set; }
    }
}