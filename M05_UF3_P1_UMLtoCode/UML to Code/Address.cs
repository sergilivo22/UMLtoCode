using System;


public struct Address
{
    public string street;
    public string city;
    public string state;
    public int Postal Code;
	public string Country;

    public bool Validate()
    {
        return true; 
    }
}