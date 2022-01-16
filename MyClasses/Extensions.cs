namespace MyClasses;
public static class Extensions
{
    public static string GetLogMessage(this Class1 instance) {
        return $"LOG >>> {instance.Name} is the name of the Class1 object";
    }
}