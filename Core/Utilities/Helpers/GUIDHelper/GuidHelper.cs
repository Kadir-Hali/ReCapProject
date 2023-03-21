namespace Core.Utilities.Helpers.GUIDHelper;

public class GuidHelper
{
    public static string CreateGuid()
    { 
        return Guid.NewGuid().ToString(); 
    }
}