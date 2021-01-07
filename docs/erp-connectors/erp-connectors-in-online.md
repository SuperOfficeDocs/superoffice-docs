---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: erp_connectors_in_online       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: ERP connectors in Online # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so.date: 17 Jun 2016
keywords: sync
so.topic: article              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# ERP connectors in Online

Describes how to secure and configure ERP Connectors in SuperOffice Online.

## ERP Sync Connectors in SuperOffice Online

The SuperOffice ERP Integration Server (EIS) was introduced in SuperOffice CRM in version 7.5, and provides partners an API to create Sync Connectors that handle the synchronization of data between SuperOffice and an ERP system.

While this article is not an instruction on how to build an ERP Sync Connector, the [existing documentation does a great job of that][1], it is an instructional read that defines and additional requirement when building ERP Connectors for SuperOffice Online.

The standard architecture for ERP synchronization includes the ERP Integration Server (EIS), hosted as a service that facilitates all synchronization tasks. In the middle layer are the administrative aspects of the architecture; where consultants or administrators register connectors and establish connections.

![x][img1]

On the right is the remote ERP Connector, a remote web site that exposes the web service that implements the IErpConnector interface. This is where SuperOffice will connect in order to obtain ERP data.

When administrators configure an ERP Sync Connector inside SuperOffice today, they must fill in a Sync Connector name and a Sync Connector URL.

![x][img2]

The Sync Connector name will be used as a reference for all connections created to this connector, and the Sync Connector URL specifies where SuperOffice EIS will contact to synchronize data.

SuperOffice EIS will periodically invoke the web services to conduct data synchronization. This invocation is a blind call, meaning that no exchange of credentials or security layers exist between SuperOffice and the web site hosting the web services. This configuration works great for onsite customer installations where both SuperOffice CRM and the ERP system reside inside the secure network, but leaves much to be desired in the online environment.

## Securing ERP Connectors for SuperOffice Online

In 2017, SuperOffice expanded its online API offering and announced the availability of the [Database Mirroring API][1]. This new API performs database replication-like functionality – mirroring a subset of the online tenants' database through a web services to remote database.

This new capability, which operates in a very similar fashion as ERP Sync Connectors, has an added layer of security by demanding that the web service first authenticate the calling SuperOffice service before executing pending tasks.

Authentication begins with [PKI][2] at SuperOffice. Prior to beginning the mirroring operation, SuperOffice creates a security **JSON Web Token (JWT)** and signs it with a certificate. The security token is then sent as a request to the database mirror web service where the token must be validated by the Database Mirroring implementation. Once validated, the Database Mirroring service creates and signs its' own JWT security token, using the customers private key, and sends the signed token back to SuperOffice. Once the response is validated by SuperOffice with the customers public key, the Database Mirroring cycle begins. Only JWT tokens are supported for this process. **SAML** tokens are **not** supported.

![x][img3]

With more and more ERP Connectors now becoming available in SuperOffice Online, SuperOffice has released the same secure way to work with ERP Connectors. The way forward does require a small change in online tenant ERP Sync Connector settings, which is to simply change the Sync Connector URL property.

No longer should the Sync Connector URL property define an actual URL, but instead be prefixed with app:// followed by an application identifier.

![x][img4]

The way the infrastructure works is as follows:

1. EIS sends the customer tenants ERP Connector URL setting (`App://[applicationid]`) to the Application Authorization Service (AAS).
2. AAS creates a signed JWT security token and sends it to be authenticated by the ERP Connector.
3. The ERP Connector replies with a signed JWT token and is validated by the AAS.
4. AAS sends the customer tenant the ERP Connectors URL.
5. EIS begins to synchronize data with the ERP Connector.

![x][img5]

So what is an application identifier? An application identifier is a unique ID that represents an application in the SuperOffice Online App Store. There are standard apps that use ERP Connectors, and there are custom apps that use ERP Connectors as well. Both types of App Store applications have a unique application identifier associated with each one.

Read more about application identifiers and our [App Store on our community site][4].

## ERP Connector API Changes

When it comes to the ERP Connector web service, the latest API changes do not affect the existing ERP Connector APIs. Rather, the API has added a new interface, IIntegrationServiceConnectorAuth that has one method, Authenticate.

```csharp
public interface IIntegrationServiceConnectorAuth
{
    AuthenticationResponse Authenticate(AuthenticationRequest request);
}
```

The IIntegrationServiceConnectorAuth interface exists in SuperOffice.SuperID.Contracts.dll, and a clean implementation exists in the SuperOffice.SuperID.Client.dll assembly, both of which are located is in the latest [SuperOffice.Crm.Online.Core.nuget][6] package.

### IIntegrationServiceConnectorAuth Interface

The IIntegrationServiceConnectorAuth interface declares one method, Authenticate. It accepts one parameter, an AuthenticationRequest, which contains the signed JWT security token that must be validated by the ERP Connector web service.

```csharp
public class AuthenticationRequest
public class AuthenticationRequest
{
    public string SignedToken { get; set; }
}
```

The Authenticate method must return an AuthenticationResponse, which contains three properties: SignedApplicationToken, Succeeded, and Reason.

SignedApplicationToken represents the ERPConnectors signed JWT security token. The Succeeded property indicates whether validation was successful or not, and Reason contains a message only if Succeeded is false, indicating why validation failed.

```csharp
public class AuthenticationResponse
public class AuthenticationResponse
{
    public string Reason { get; set; }
    public string SignedApplicationToken { get; set; }
    public bool Succeeded { get; set; }
}
```

### Using the IntegrationServiceConnectorAuth Implementation

The biggest challenges with leveraging the new interface are:

1. Adding the nuget package.
2. Specifying an application identifier.
3. Reading in the private certificate key from a file.

Lucky for you that's already been done in our examples and is readily available for you to copy. Here's the code:

```csharp
public class ErpConnectorWS : IErpConnectorWS, SuperOffice.SuperID.Contracts.IIntegrationServiceConnectorAuth
{
    AuthenticationResponse IIntegrationServiceConnectorAuth.Authenticate(AuthenticationRequest request)
    {
        var applicationIdentifier = ConfigurationManager.AppSettings["ApplicationIdentifier"];
        var applicationPrivateKey = GetPrivateKey();

        var auth = new IntegrationServiceConnectorAuth(applicationIdentifier,  applicationPrivateKey);
        var result = auth.Authenticate(request);

        return result;
    }
    
    public string GetPrivateKey()
    { 
        var fileName = ConfigurationManager.AppSettings["ApplicationPrivateKeyFile"];
        if (!Path.IsPathRooted(fileName))
            fileName = Path.Combine(HostingEnvironment.MapPath(@"~"), fileName);
        return File.ReadAllText(fileName);
    }

    //...Remaining code left out for brevity
}   
```

The first thing you will noticed is a call to AppSettings to get the application identifier for the ERP Sync Connector. Next is a call to a helper method to read in the private key file associated with the ERP Syn Connector app. Those two pieces of information are passed into the IntegrationServiceConnectorAuth constructor and the IntegrationServiceConnectorAuth.Authenticate method is called to validate the request. Finally, the result is returned and that's all there is to it.

As you can see, implementing the new interface to support ERP Connectors in SuperOffice Online is very easy. SuperOffice providers all of the bits necessary to made it work, you just need to add a few lines of code in your new or existing connectors and that's about it.

## Conclusion

As SuperOffice moves more and more capabilities into the cloud, we must ensure the security of all parties involved. With respect to ERP Connectors we are playing a bit of a catchup game, however, this latest addition works today and it works well.

We expect all existing ERP Connector providers to adopt this new interface and update clients accordingly.

We are constantly trying to improve out APIs and capabilities, and while this step is an easy one, we are looking at alternatives ways to make creating ERP Connectors even more simple. Stay tuned for more about that in future ERP Sync articles.

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/SDK/SO.NetServer.Data.Access/html/DevelopersGuide-ERPConnectors-ERPSyncConnectorInterface-ERPSyncConnectorInterface.htm
[2]: ../mirroring/index.md
[3]: https://en.wikipedia.org/wiki/Public_key_infrastructure
[4]: https://community.superoffice.com/link/8aa3a1a5bcda4f40bcdee65ae3d12fd2.aspx
[5]: http://www.nuget.org/packages/SuperOffice.Crm.Online.Core/

<!-- Referenced images -->
[img1]: https://community.superoffice.com/globalassets/developer-club/articles/erpconnectors/architecture-simplified.png
[img2]: https://community.superoffice.com/globalassets/developer-club/articles/erpconnectors/editsyncconnector.png
[img3]: https://community.superoffice.com/globalassets/developer-club/articles/erpconnectors/authenticationsequencediagram.png
[img4]: https://community.superoffice.com/globalassets/developer-club/articles/erpconnectors/editsyncconnector-new.png
[img4]: https://community.superoffice.com/globalassets/developer-club/articles/erpconnectors/autherpsyncconnector_600px.png