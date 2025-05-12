namespace DO;

[Serializable]
public class DalIdNotExist:Exception
{
    public DalIdNotExist(string error)
    {
     throw new Exception(error);
    }
}

[Serializable]
public class DalIdExist : Exception
{
    public DalIdExist(string error)
    {
        throw new Exception(error);
    }
}


