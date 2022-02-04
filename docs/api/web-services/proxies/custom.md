---
title: Calling through a custom SOAP proxy
uid: call_soap_custom_proxy
description: Calling through a custom SOAP proxy
author: Bergfrid Dias
so.date: 11.19.2021
keywords: API, web services, proxy, SOAP, NetServer, WSDL
so.topic: howto
# so.envir:
# so.client:
---

# Calling SOAP through a custom proxy

To call a NetServer service through a custom proxy as a web service you have to set up the web services as an application in IIS.

## Alternative .NET Solutions

There are two immediate alternatives to using the SuperOffice.Services.dll for .NET developers.

* Simply add a **Service Reference** to the specific web service and make calls through that proxy.

* Use Microsoft's **SVCUTIL** tool to generate a client proxy for each web service you're interesting in, such as **Appointment.svc** or **Contact.svc**.

After giving a name to the added web service you can use that web service name in the `using` section of your code file in the following manner:

[!code-csharp[CS](includes/testnewwcfapi.cs)]

Having multiple services that share the same carrier objects is a scenario that is not well supported in Visual Studio.

### Direct authentication with SoCredentials

The following example demonstrates how to call the web service through a **Visual Studio WebReference** proxy object.

```csharp
public ContactEntity GetContact()
{
  Contact ws = new Contact();
  ws.SoCredentials = new SoCredentialsHeader();
  // Get the ticket from the principal web service.
  ws.SoCredentials.Secret = GetTicket("JR", "password");
  ContactEntity contactEntity = ws.GetContact(3);
  return contactEntity;
}

public string GetTicket(string username, string password)
{
  SoPrincipalClient client = new SoPrincipalClient();
  SoTimeZone timezone;
  SoExtraInfo extraInfo;
  SoCredentials credentials;
  SOPrincipalCarrier principal;
  bool authSuccess = false;
  bool success = false;
  SoExceptionInfo exInfo = pc.AuthenticateUsernamePassword(
    "",
    username,
    password,
    out extraInfo,
    out success,
    out timezone,
    out principal,
    out credentials,
    out authSuccess
    );
  if (exInfo != null)
    throw new SoServiceException(exInfo);
  return credentials.Ticket;
```

The first thing is to instantiate a `Contact` proxy object. Next, before any methods are called, the `SoCredentials` proxy property is set to a new `SoCredentialsHeader` instance, and then set accordingly.

SoCredentials is an object representation of the SoCredentialsHeader element, which is an element in the SOAP message header. Each time a method is called against the web service, these credentials are sent along with it. This is mandatory the order to successfully authenticate against the web service.

> [!NOTE]
> If any one of these values is wrong, the most likely result will be a `SoapHeaderException`, accompanied by the "Server unavailable, please try later" message.

### Connection management

Both alternatives **generate method stubs** to make asynchronous calls.However, there are still system limitations imposed when making more than two simultaneous calls. To remedy that you'll need to look further into how the .Net framework manages connections.

The following configuration snippet allows you to configure your application to allow more than two, the default, simultaneous connections. Otherwise, when there are more than two, they are queued and executed synchronously.

**Example connectionManagement section:**

```xml
<configuration>
  <system.net>
    <connectionManagement>
      <add address="http://www.mysrv.com/websvc/"maxconnection = "4" />
      <add address="*"maxconnection = "2" />
    </connectionManagement>
  </system.net>
</configuration>
```

## Alternative Java solutions

When consuming .NET web services from other platforms, like Java and PHP, there is additional complexity as well.

For Java developers, there is, an excellent section explaining [how to create a proxy class for Java clients][1] on Sun's website.

When it comes to authentication and authorization, each web request requires an `SoCredentialsHeader` element. In that element is a `Ticket` element. Because the ticket is a composite of data, it can be tricky to generate one correctly. Also, the ticket needs to be prepacked with the UTF-8 Byte Order Mark (BOM).

<!-- Referenced links -->
[1]: https://www.oracle.com/technical-resources/articles/javaee/j2ee-ws.html#use

<!-- Referenced images -->
[img2]: media/add-service-reference.png
