using System;

public enum Rating
{
    Good, Great, Excellent
}
public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    public Dog(string aname, float aage, string aowner, Rating arating)
    {
        name = aname;
        age = aage;
        owner = aowner;
        rating = arating;
    }

    public override string ToString()
    {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
}