using System;

public struct Transaction
{
    public string From { get; set; }
    public string To { get; set; }
    public float Amount { get; set; }
    public DateTime Request { get; set; }

    public Transaction(string from, string to, float amount, DateTime request)
    {
        From = from;
        To = to;
        Amount = amount;
        Request = request;
    }
    //esto último sería para que si introduces valores, los asigne a su propiedad correspondiente
}
