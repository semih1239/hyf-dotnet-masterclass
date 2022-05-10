public class Shared
{
  public static string ConnectionString = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQLCONNSTR_dotnet_meal_sharing")) ?
 "Server=localhost;Database=final-semih;Uid=root;Pwd=compl3xPassWrd;SslMode=Required;Convert Zero Datetime=True"   :
 Environment.GetEnvironmentVariable("MYSQLCONNSTR_dotnet_meal_sharing");
}