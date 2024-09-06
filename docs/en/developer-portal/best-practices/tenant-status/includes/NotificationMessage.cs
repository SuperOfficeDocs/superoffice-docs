public class NotificationMessage 
{ 
  public CustomerStateChangeNotificationType ChangeType { get; set; } 
  public string ContextIdentifier { get; set; } 
  public string VersionName { get; set; } 
  public string FileVersion { get; set; } 
  public string Token { get; set; } 
  public string PublicEndpoint { get; set; }
}