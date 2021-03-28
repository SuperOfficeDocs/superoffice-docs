---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: epr_api       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: ERP Connector API # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# ERP Connector API Changes

When it comes to the ERP Connector web service, the latest API changes do not affect the existing ERP Connector APIs. Rather, the API has added a new interface, `IIntegrationServiceConnectorAuth` that has one method, `Authenticate`.

```csharp
public interface IIntegrationServiceConnectorAuth
{
  AuthenticationResponse Authenticate(AuthenticationRequest request);
}
```

The interface exists in *SuperOffice.SuperID.Contracts.dll*, and a clean implementation exists in the *SuperOffice.SuperID.Client.dll* assembly, both of which are located is in the latest [SuperOffice.Crm.Online.Core.nuget][1] package.

## IIntegrationServiceConnectorAuth Interface

The `IIntegrationServiceConnectorAuth` interface declares one method, `Authenticate`. It accepts one parameter, an `AuthenticationRequest`, which contains the signed JWT security token that must be validated by the ERP Connector web service.

```csharp
public class AuthenticationRequest
public class AuthenticationRequest
{
  public string SignedToken { get; set; }
}
```

The `Authenticate` method must return an `AuthenticationResponse`, which contains three properties:

| Property | Description |
|----------|-------------|
| SignedApplicationToken | represents the ERPConnectors signed JWT security token |
| Succeeded | indicates whether validation was successful or not
| Reason | contains a message only if Succeeded is false, indicating why validation failed |

```csharp
public class AuthenticationResponse
public class AuthenticationResponse
{
  public string Reason { get; set; }
  public string SignedApplicationToken { get; set; }
  public bool Succeeded { get; set; }
}
```

## Using the IntegrationServiceConnectorAuth Implementation

The biggest challenges with leveraging the new interface are:

* Adding the NuGet package.
* Specifying an application identifier.
* Reading in the private certificate key from a file.

Lucky for you, that's already been done in our examples and is readily available for you to copy. Here's the code:

```csharp
public class ErpConnectorWS : IErpConnectorWS, SuperOffice.SuperID.Contracts.IIntegrationServiceConnectorAuth
{
  AuthenticationResponse IIntegrationServiceConnectorAuth.Authenticate(AuthenticationRequest request)
  {
    var applicationIdentifier = ConfigurationManager.AppSettin["ApplicationIdentifier"];
    var applicationPrivateKey = GetPrivateKey();
    var auth = new IntegrationServiceConnectorAu(applicationIdentifier, applicationPrivateKey);
    var result = auth.Authenticate(request);
    return result;
  }
  
  public string GetPrivateKey()
  { 
    var fileName = ConfigurationManager.AppSettin["ApplicationPrivateKeyFile"];
    if (!Path.IsPathRooted(fileName))
      fileName = Path.Combine(HostingEnvironment.MapPath(@"~")fileName);
    return File.ReadAllText(fileName);
  }
  //...Remaining code left out for brevity
} 
```

The first thing you will noticed is a call to `AppSettings` to get the application identifier for the ERP Sync Connector. Next is a call to a helper method to read in the private key file associated with the ERP Syn Connector app. Those two pieces of information are passed into the `IntegrationServiceConnectorAuth` constructor and the `IntegrationServiceConnectorAuth.Authenticate` method is called to validate the request. Finally, the result is returned and that's all there is to it.

As you can see, implementing the new interface to support ERP Connectors in SuperOffice Online is very easy. SuperOffice providers all of the bits necessary to made it work, you just need to add a few lines of code in your new or existing connectors and that's about it.

## To the cloud

As SuperOffice moves more and more capabilities into the cloud, we must ensure the security of all parties involved. With respect to ERP Connectors we are playing a bit of a catchup game, however, this latest addition works today and it works well.

We expect all existing ERP Connector providers to adopt this new interface and update clients accordingly.

We are constantly trying to improve out APIs and capabilities, and while this step is an easy one, we are looking at alternatives ways to make creating ERP Connectors even more simple. Stay tuned for more about that in future ERP Sync articles.

<!-- Referenced links -->
[1]: http://www.nuget.org/packages/SuperOffice.Crm.Online.Core/