using System;

[Serializable]
public class PersonData
{    
    public string Username;
    public string AvatarUrl;
    public int Points;

    public static bool operator >(PersonData personData1, PersonData personData2)
    {
        return personData1.Points > personData2.Points;
    }
    public static bool operator <(PersonData personData1, PersonData personData2)
    {
        return personData1.Points < personData2.Points;
    }
}