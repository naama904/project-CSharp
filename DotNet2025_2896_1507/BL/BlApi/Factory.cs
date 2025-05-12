
using DalApi;
using System.Reflection;

namespace BlApi;

public static class Factory
{
    public static IBl Get()=>new BlImplementation.Bl();

}
