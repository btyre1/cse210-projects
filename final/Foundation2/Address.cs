class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _state = state;
        _city = city;
        _country = country;
    }
    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}