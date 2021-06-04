---
title: SuperOffice Authentication
uid: authentication_overview
description: Overview of SuperOffice API authentication.
author: AnthonyYates
so.date: 05.08.2018
keywords: security, identity
so.topic: concept
so.envir: onsite, online
# so.client:
---

# SuperOffice Authentication

## Introduction

One of the hardest things about getting started with new technologies is knowing where to begin. When it comes to application development and integrations, the obvious place is authentication.

SuperOffice has multiple data access layers, so let's start with an overview of what the SuperOffice APIs have to offer.

**Overview of common SuperOffice API surface:**

![auth][img1]

SuperOffice **COM APIs** have been around the longest. The 2 main interfaces, **IApplication** and **IDatabase**, facilitate access to the Windows client application and the database. While `IApplication` exposes the capabilities to drive the application, `IDatabase` provides the capability to read and write to and from the SuperOffice database without having the Windows client running.

While SuperOffice Customer Service (CS) capabilities are vast, most of the functionality revolves around processing support tickets and internal processes using script automation. The CS SOAP services are limited, whereas the NetServer web services surface is much larger and the primary target for interacting with SuperOffice business entities. This article will not cover any more information about CS.

SuperOffice **NetServer SOAP web services** are a complete set of service endpoints that support 100% of the SuperOffice web-client functionality - which is more than the Windows client and COM could ever claim. CS depends on NetServer web services, as well as all the quote functionality in the Window client!

NetServer code, comprised of business entity classes, as well as row & row collections, supports the entire web services stack. All of this functionality gets pushed through NetServer's [Objectified SQL (OSQL)][2] classes for database-vendor-specific SQL generation.

The objective of this article is to introduce you to how to get past the first hurdle, authentication. All of the following sections assume you have access to a correctly configured SuperOffice database.

Each section will define all of the dependencies required to be in place for you to be able to successfully authenticate with the corresponding API.

> [!NOTE]
> The development environment used in these examples is Visual Studio and the language used C#.
>
> If you don't have one of the SuperOffice clients installed (Windows or Web), you will want to **download the Expander SDK** to have the necessary DLLs and COM interop libraries to complete the code examples below. The latest available for download at the time of this article was SuperOffice 7.5.

## SuperOffice Online

Read about online authentication in the [online environment][3] documentation.

## COM

This section assumes that you have a working installation of the SuperOffice Windows client on your development machine. If not, perhaps you want to [try the NetServer sections below][4].

In contrast to NetServer-based development, COM-based SuperOffice development is the one case where you don't need to worry about configuration files. The only thing you need to decide at this point is whether you will interact with the Windows client or not.

### COM IApplication interface

If you are required to interact with the **Windows client**, you will need only to make a COM reference to the SuperOffice Application Server 1.0 Type Library. Alternatively, you could reference the SuperOffice-generated COM interop DLL.

**COM Reference Dialog - filtered to see SuperOffice libraries:**

![com-app][img2]

With a reference made, and the **SuperOffice.COM.Application using** statement declared, all it takes to instantiate the `IApplication` interface is to instantiate a new object of the `SoApplication` class:

![com-app][img3]

* If the SuperOffice application was not already open, it will open now.
* If the application is not configured for single sign-on, you will be prompted for credentials now.

Using the `SoApplication` type, you have complete access to both the SuperOffice Windows client, as well as access to the `IDatabase` interface, exposed in the `SoApplication.Database` property.

> [!TIP]
> There are multiple examples of how to use `IApplication` in the SDK Help file, located in the SDK download or online.

### COM IDatabase interface

> [!NOTE]
> Use the `IDatabase` interface when you must use COM and don't want to interact with the Windows client application.

1. Make a COM reference to the SuperOfficeDB 7.0 Type Library.

    Alternatively, you could reference the SuperOffice-generated COM interop DLL *SuperOfficeDB.Interop.dll* located in the SDK Interop folder (*C:\Program Files (x86)\SuperOffice\Expander SDK\7.5.5154.200\Interop*).

2. With a reference made, and the **SuperOffice.COM.SuperOfficeDB using** statement declared, it's possible to instantiate a new object of the `Database` class:

    ![com-app][img4]

3. Using the `Database` class instance, call the `Login` method with either a normal user, external user, or system user credentials.

4. When login is successful, you have a wide range of methods for reading and writing data to the SuperOffice database.

Please read more about the `IDatabase` APIs, either in the SDK download or here online.

## <a name="skip-to-netserver"></a>NetServer configuration

All NetServer integrations **that use SuperOffice assemblies** require settings in an application's configuration file, *app.config* or *web.config*. This is not the case for custom web service proxies or REST. This applies only when an application makes a file reference to *SOCore.dll*, *SoDatabase.dll*, and other required SuperOffice DLLs.

Below is a configuration file with only the bare essential SuperOffice sections defined:

[!code-xml[XML](includes/idatabase-config.xml)]

> [!NOTE]
> The **Data element** contains the session, database, and explicit sections. Often, the cause of connectivity problems lays here.

### Session

`Session` determines how the authenticated session will exist at runtime. There are 3 options by default: Process, Context, and Thread. Each session option determines where in memory the authenticated session will be available from.

| Session option | Availability of authenticated SoSession |
|---|---|
| Process | to all synchronization contexts and threads |
| Context | only to routines passed to the same synchronization context |
| Thread  | only on that thread - if another non-authenticated thread tried to use the SuperOffice API to get data, NetServer would throw an exception. |

### Database

The `Database` section is used to define your database-specific details and will look slightly different than the example if you are targeting DB2 or Oracle. More information about the database section can be found in the [NetServer configuration reference][5].

### Explicit

The `Explicit` section allows an application to determine what type of users are authorized to use this application, as well as must set the database credentials, which map to both a database server user and a SuperOffice system user.

## NetServer Core & Service proxy authentication using SoSession

While most data access layers require only database credentials for access database resources, SuperOffice requires a valid SuperOffice user too when authenticating using NetServer.

The user must establish an **SoSession**, which is an `IPrincipal` container and has several overloads for authentication. Using explicit credentials is one of the most common ways to instantiate an `SoSession`.

### Authenticate with username and password

```csharp
//Explicit User Authentication
using (var session = SoSession.Authenticate("TY",""))
{
  Console.WriteLine(
    string.Format("Successfully authenticated {0} using credentials...",
    session.Principal.Associate)
  );
}
```

### Single sign-on using the current Windows user's credentials

Another common scenario is single sign-on using the current Windows user's credentials. There are 2 ways this can be accomplished, implicitly and explicitly:

```csharp
//Implicit Windows user authentication
using (var session = SoSession.Authenticate())
{
  Console.WriteLine(
    string.Format("Authenticated {0} using implicit Windows Identity...", 
    session.Principal.Associate)
  );
}


// or...Explicit Windows user authentication
WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
using (var session = SoSession.Authenticate(identity))
{
  Console.WriteLine(string.Format("Successfully authenticated {0} using explicit Windows Identity...", 
    session.Principal.Associate));
}
```

### Authenticate with SoCredentials

Now let's look at the final authentication overloads, using an `SoCredentials` or `SoCredentials.Ticket`. SoCredentials only contains one property, Ticket. Ticket represents a stored credential record that can be used to authenticate a user.

The code below demonstrates a user authenticating, getting an SoCredentials, and then using the credential to authenticate.

```csharp
SoCredentials credentials = null;

//Explicit User Authentication
using (var session = SoSession.Authenticate("TY",""))
{
  //Save the SoCredentials...
  credentials = session.Principal.GetSafeCredentials();

  Console.WriteLine(
    string.Format("Successfully authenticated {0} using credentials...",
    session.Principal.Associate)
  );
}

//SoCredentials Authentication
using (var session = SoSession.Authenticate(credentials))
{
  Console.WriteLine(
    string.Format("Successfully authenticated {0} using credentials...",
    session.Principal.Associate)
  );
}

//Ticket as user Authentication
using (var session = SoSession.Authenticate(credentials.Ticket, ""))
{
  Console.WriteLine(
    string.Format("Successfully authenticated {0} using credentials...",
    session.Principal.Associate)
  );
}
```

### SoSession

**SoSession** is a disposable instance, and when out of scope it will automatically close the connection and then invalidate the current `SoSession.Principal`. If your code tried to make API calls to the database after this, NetServer will throw an exception.

So the next question is usually "Do I need to authenticate every time I want to use the API?" The answer is no. Most common in the Windows client application, you want to keep the `SoSession` open and valid for the lifetime of your application. You can store the `SoSession` variable as a global instance, just remember to call the `SoSession.Dispose` method to close any open connection when your application is closing.

Alternatively, another common scenario is to use `Suspend()` and `Continue()`.

```csharp
string sessionString = string.Empty;

//Suspend and Continue user Authentication
using (var session = SoSession.Authenticate(credentials.Ticket, ""))
{
  sessionString = session.Suspend();
}

//no valid session exists...

using (var newSession = SoSession.Continue(sessionString))
{
  //Valid session exists.
}
```

## NetServer web service custom proxies

For those who are not developing solutions using Microsoft .NET, and can't reference the SuperOffice assemblies, they must rely on their own technology stacks to either generate SOAP proxies or roll their own.

In many cases, such as PHP and Python, applications depend on loading the WSDL file for interacting with SuperOffice web services. We make those files available for downloads along in the [SOAP web services API reference][1].

With the WSDL files and using a tool like SOAPUI raw SOAP requests are sent to SuperOffice endpoints for testing. You can, for example, use SOAPUI or compose the SOAP request manually with Fiddler2:

### [SOAPUI](#tab/wsdl-1)

![soapui][img5]

### [Fiddler2](#tab/wsdl-2)

![fiddler][img6]

***

## SuperOffice REST / WebAPI web services

To successfully use the REST APIs (introduced in SuperOffice version 8) you must pass along credentials in each request header.

Below is an HTML page that contains a few text boxes for determining where, or what version of, the services reside, user name, and password. With this required information, the user can specify a project ID and click the **Get** button to execute an XMLHttpRequest.

![request-page][img7]

### Basic

As seen earlier, the `setRequestHeader` method is used to add the Authorization header key entry with a value equal to "Basic " plus a base64 encoded representation of the user name, plus a colon, and password. Note the space following the word *Basic*. In the JavaScript code, we use the built-in DOM `window.btoa(...)` method to convert the value to base64.

### SOTicket

Alternatively, if the HTML page is running in the context of a SuperOffice web panel, and the application passes in the user's `SoCredential.Ticket`, the REST request header also supports SOTicket, instead of Basic. In that case, the Authentication header value is "SOTicket " plus the ticket string. Once again, notice the space following *SOTicket*.

[!code-html[HTML](includes/rest-auth.html)]

> [!NOTE]
> In this case, don't use the `window.btos(...)` method to convert a Ticket to base64 because the **ticket value is already base64 encoded**.

## Conclusion

SuperOffice supports several different access points to SuperOffice APIs. Without knowing where to begin, it makes it almost impossible to successfully build an integration. The first place most applications must begin with is authentication, Once authentication is understood, and understanding at what data access level your application will integrate with SuperOffice, the remaining tasks should just be learning about the various entity and service APIs for reading and writing data to the SuperOffice database.

<!-- Referenced links -->

[1]: ../api-reference/soap/index.md
[2]: ../netserver/osql/index.md
[3]: online/federated-auth.md
[4]: #skip-to-netserver
[5]: ../netserver/config/data.md

<!-- Referenced images -->
[img1]: media/authenticate-overview.png
[img2]: media/com-add-reference.png
[img3]: media/com-application-code.png
[img4]: media/com-database-code.png
[img5]: media/services-authenticate-soapui.png
[img6]: media/services-authenticate-fiddler.png
[img7]: media/simple-rest-page.png
