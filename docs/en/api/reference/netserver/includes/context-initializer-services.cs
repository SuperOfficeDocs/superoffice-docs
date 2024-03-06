using SuperOffice.Configuration;
using SuperOffice.Security.Principal;

public class  ExampleContextInitializer : IContextInitializer
{
    public void InitializeContext(string contextIdentifier)
    {
        /*
        * Different options for setting the remote services URL
        * See the following link for more information:
        * https://docs.superoffice.com/en/api/netserver/config/services.html
        */
        
       ConfigFile.Services.RemoveBaseUrl = "http://www.mydomain.com/superoffice/remote/services88";

       /*
       * Different options for setting the remote services URL in a multi-tenant environment, like SuperOffice Online 
       * See the following link for more information: https://docs.superoffice.com/en/api/netserver/config/webservices.html
       *
       * ConfigFile.WebServices.RemoveBaseUrl = $"http://online.superoffice.com/{contextIdentifier}/remote/services88";
       */
    }
}