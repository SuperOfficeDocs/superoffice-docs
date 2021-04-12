public class NotifyCustomerStateChangeController : ApiController 
{
  public void Post([FromBody]NotificationMessage message) 
  {
    try
    {
      // SuperIdTokenHandler is available in NuGet package: SuperOffice.Crm.Online.Core
      SuperIdToken validated = ValidateToken(message.Token);
      // process accordingly...
    }
    catch (Exception ex)
    {
      // handle invalid token...
      throw;
    }
  }
  public static SuperIdToken ValidateToken(string token)
  {
    var path = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/") + "SOD_SuperOfficeFederatedLogin.crt";
    var tokenHandler = new SuperIdTokenHandler();
    tokenHandler.JwtIssuerSigningCertificate = new X509Certificate2(path);
    tokenHandler.CertificateValidator = X509CertificateValidator.ChainTrust;
    tokenHandler.ValidIssuer = "https://sod.superoffice.com";

    return tokenHandler.ValidateToken(token, TokenType.Jwt);
  }
}