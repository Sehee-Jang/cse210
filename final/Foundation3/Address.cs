public class Address
{
    private string _street;
    private string _city;
    private string _country;
    private string _zipcode;

    public Address(string street, string city, string country, string zipcode)
    {
        _street = street;
        _city = city;
        _country = country;
        _zipcode = zipcode;
    }

    public string toString()
    {
        return "${_street}, {_city}, {_state}, {_zipcode}";
    }

}