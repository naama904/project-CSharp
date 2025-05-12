
namespace BO;

[Serializable]
public class BlIdNotExist : Exception
{
    public BlIdNotExist()
     : base("The product does not exist.") { }

    //public BlIdNotExist(string message) : base(message) { }

    public BlIdNotExist(string? message) : base(message)
    {
    }

    public BlIdNotExist(string message, Exception innerException)
        : base(message, innerException) { }

}
[Serializable]
public class BlIdExist : Exception
{
    public BlIdExist(string? message) : base(message) { }
    public BlIdExist(string message, Exception innerException)
                : base(message, innerException) { }
}

public class BlNotEnoughInStock : Exception
{
    public BlNotEnoughInStock(string message) : base(message) { }
    public BlNotEnoughInStock(string message, Exception innerException) : base(message, innerException) { }
}



