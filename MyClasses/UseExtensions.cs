namespace MyClasses;

using System.Reflection;
public class UseExtensions
{
    public static string? GetLogMessageForObject(Object obj)
    {
        MethodInfo? getLogMessage = Type.GetType("MyClasses.Extensions")?.GetMethod("GetLogMessage", BindingFlags.Public | BindingFlags.Static, new Type[] { obj.GetType() });
        if (getLogMessage is MethodInfo method)
        {
            return (string?)method.Invoke(null, new object[] { obj });
            throw new NotImplementedException("could not invoke extension method");
        }
        throw new NotImplementedException("could not find extension method");
    }
}