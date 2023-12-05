---
title: NetServer authentication
uid: authentication_sosession
description: NetServer Core & NetServer Service proxy authentication using SoSession, session handling
author: AnthonyYates
so.date: 03.25.2022
keywords: security, authentication, SoSession, IPrincipal, SoSession.Principal, SoCredentials, SoCredentials.Ticket
so.topic: concept
so.envir: onsite
so.client: 
---

# NetServer authentication

While most data access layers require only database credentials to access to database resources, SuperOffice requires a valid licensed SuperOffice user for authentication.

> [!NOTE]
> Every application using NetServer for data access must have a .NET app|web.config with a configured SuperOffice section. See [NetServer configuration][4] for more details.

The application must use the `SuperOffice.SoSession` class, which is an `IPrincipal` container with overloaded static `Authenticate` methods to perform authentication.

## SoSession.Authenticate Overloads

* SoSession.Authenticate()
* SoSession.Authenticate("username", "password")
* SoSession.Authenticate(new SoCredentials("ticket"))

A new session is created when a user signs in and is successfully authenticated. **Session Cache** holds authentication information about the signed-in user, the associate of the user, a business ID of the company that the user belongs to, reference data, and so on. You can obtain the data held in the session cache through a property named `Principal` in the session object.

## Authenticate with Windows user

Another common scenario is single sign-on using the current Windows user's credentials. There are 2 ways this can be accomplished, implicitly and explicitly.

Active Directory authentication requires startup configuration. See [NetServer configuration section][4] for details.

```csharp
//Implicit Windows user authentication
using (var session = SoSession.Authenticate())
{
  Console.WriteLine($"Authenticated {session.Principal.Associate} using implicit Windows Identity.");
}


// or...Explicit Windows user authentication
WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
using (var session = SoSession.Authenticate(identity))
{
  Console.WriteLine($"Authenticated {session.Principal.Associate} using implicit Windows Identity.");
}
```

When performing Windows single sign-on and NetServer [Services DefaultMode][5] is configured for `Remote` mode, include the following configuration settings in the app|web.config file.

```xml
<system.serviceModel>
    <bindings>
      <basicHttpBinding>
        <binding name="SoWcfClient">
          <security mode="TransportCredentialOnly">
            <transport clientCredentialType="Windows" proxyCredentialType="Windows" />
          </security>
        </binding>
      </basicHttpBinding>
    </bindings>
  </system.serviceModel>
```

## Authenticate with username and password

```csharp
//Explicit User Authentication
using (SoSession session = SoSession.Authenticate("UserName","P@55w0rd"))
{
  Console.WriteLine($"Successfully authenticated {session.Principal.Associate} using credentials.");
}
```

## Authenticate with SoCredentials

SoCredentials contains only one property, Ticket. **Ticket** represents a stored credential record that can be used to authenticate a user. Tickets have the "7T:" prefix, and is generated in onsite by the [\<usec\>][6] template variable.

In the online environment, tickets are issues by the [System User flow][7].

The code below demonstrates authentication using `SoCredentials`. The code first authenticates using a username and password, obtains the users Ticket from the users `session.Principal.GetSafeCredentials()` method.

The first `using` statement disposes the first SoSession instance, and the second `using` statement creates a new one using the `SoCredentials` saved from the first part of code.

The third `using` statement demonstrates how it's acceptable to pass a Ticket into the `SoSession.Authenticate` method in place of a username and a blank password.

```csharp
SoCredentials credentials = null;

//Explicit User Authentication
using (var session = SoSession.Authenticate("TY",""))
{
  //Save the SoCredentials...
  credentials = session.Principal.GetSafeCredentials();

  Console.WriteLine($"Authenticated {session.Principal.Associate} using implicit Windows Identity.");
  );
}

//SoCredentials Authentication
using (var session = SoSession.Authenticate(credentials))
{
  Console.WriteLine($"Authenticated {session.Principal.Associate} using implicit Windows Identity.");
  );
}

//Ticket as user Authentication
using (var session = SoSession.Authenticate(credentials.Ticket, ""))
{
  Console.WriteLine($"Authenticated {session.Principal.Associate} using implicit Windows Identity.");
  );
}
```

## Session handling

SoSession is a **disposable instance**, and when out of scope it will automatically close the connection and invalidates the current `SoSession.Principal`. Attempts to use the API calls without a valid session will throw an exception.

So the next question is usually "Do I need to authenticate every time I want to use the API?" The answer is no. In a Windows application, you can keep the authenticated `SoSession` instance for the lifetime of your application. For example, the `SoSession` instance can be stored as a variable at the process scope. Then call `SoSession.Dispose` method when your application is closing.

### Suspending a Session

A common session management routine to overcome having to keep an active session for the duration of the applications lifetime is to use `Suspend()` and `Continue()`.

The Suspend method returns an encrypted string that must be stored for later, to pass to the `SoSession.Continue()` method to return a valid session instance.

When suspended, the sessions `CurrentIdentity` is set to null.

When the application needs another session instance, pass the encrypted string into the `SoSession.Continue` method and it returns a session instance.

When done using the session, either close it by calling `Close()` or `Dispose()`, and the `CurrentIdentity` is once again set to null.

```csharp
string sessionString = string.Empty;

//Suspend and Continue user Authentication
using (var session = SoSession.Authenticate("SAL0", "P@55w0rD"))
{
  sessionString = session.Suspend();
}

//no valid session exists...

using (var newSession = SoSession.Continue(sessionString))
{
  //Valid session exists.
}
```

Initially, we create a new session with username SAL0. If authentication fails an exception is thrown.

> [!NOTE]
> The `Continue` method uses the value returned from `Suspend`. This allows continuing a session without login in again. This can be very useful in web servers.

* [Switching between Sessions][3]

<!-- Referenced links -->
[3]: switch.md
[4]: ../../../config/index.md
[5]: ../../../config/services.md
[6]: ../../../../document/templates/variables/for-web-app.md
[7]: ../../../authentication/online/auth-application/index.md

<!-- Referenced images -->
