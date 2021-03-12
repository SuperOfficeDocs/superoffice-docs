---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tenant_notifications_example       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tenant status change notifications # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Tenant status change notifications

While there are several ways to accomplish processing tenant status changes notification, the following is a short example of what that might look like using .NET and C#.

## CustomerStateChangeNotificationType Enumeration

```csharp
public enum CustomerStateChangeNotificationType
{
    Upgrade = 0,
    BackupRestored = 1,
    Suspend = 2,
    Resume = 3,
    Delete = 4
}
```

## Notification Message

```csharp
public class NotificationMessage 
{ 
    public CustomerStateChangeNotificationType ChangeType { get; set; } 
    public string ContextIdentifier { get; set; } 
    public string VersionName { get; set; } 
    public string FileVersion { get; set; } 
    public string Token { get; set; } 
} 
```

## API Controller and JWT Validation

```csharp
public class NotifyCustomerStateChangeController : ApiController 
{ 
    public void Post([FromBody]NotificationMessage message) 
    { 
       try
       {
           // SuperIdTokenHandler is available in 
           // nuget package: SuperOffice.Crm.Online.Core

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
```
