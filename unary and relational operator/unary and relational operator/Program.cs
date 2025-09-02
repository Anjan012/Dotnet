using System;

class Counter
{
    private int count;

    // Constructor to initialize count
    public Counter(int value)
    {
        count = value;
    }

    // Display method to show current value
    public void Display()
    {
        Console.WriteLine("Count = " + count);
    }

    // Overload ++ operator (Unary Increment)
    public static Counter operator ++(Counter c)
    {
        // Increment the internal count and return updated object
        c.count++;
        return c;
    }

    // Overload == operator (Relational Equality)
    public static bool operator ==(Counter c1, Counter c2)
    {
        // If both null, return true
        if (ReferenceEquals(c1, c2))
            return true;

        // If one is null, return false
        if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
            return false;

        // Compare internal count values
        return c1.count == c2.count;
    }

    // Overload != because == must be paired with !=
    public static bool operator !=(Counter c1, Counter c2)
    {
        return !(c1 == c2);
    }

    // Override Equals and GetHashCode for proper == support
    public override bool Equals(object obj)
    {
        if (obj is Counter)
        {
            return this == (Counter)obj;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return count.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        // Create two Counter objects
        Counter c1 = new Counter(5);
        Counter c2 = new Counter(5);

        // Display original values
        Console.WriteLine("Original Values:");
        c1.Display();
        c2.Display();

        // Test relational (==) operator
        Console.WriteLine("\nAre c1 and c2 equal? " + (c1 == c2));  // true

        // Use overloaded ++ operator
        ++c1;

        Console.WriteLine("\nAfter incrementing c1:");
        c1.Display();

        // Test relational (==) operator again
        Console.WriteLine("\nAre c1 and c2 equal now? " + (c1 == c2));  // false
    }
}
