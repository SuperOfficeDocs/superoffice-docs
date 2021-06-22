---
title: NetServer Core & Service proxy
uid: authentication_sosession
description: NetServer Core & Service proxy authentication using SoSession, session handling
author: AnthonyYates
so.date: 05.08.2018
keywords: security, authentication, SoSession, IPrincipal, SoSession.Principal
so.topic: concept
so.envir: onsite
so.client: 
---

# NetServer Core & Service proxy authentication using SoSession

While most data access layers require only database credentials for access database resources, SuperOffice requires a valid SuperOffice user too when authenticating using NetServer.

The user must establish an **SoSession**, which is an `IPrincipal` container and has several overloads for authentication. Using explicit credentials is one of the most common ways to instantiate an `SoSession`.

A new session is created when a user signs in and is successfully authenticated. **Session Cache** holds authentication information about the signed-in user, the associate of the user, a business ID of the company that the user belongs to, reference data, and so on. You can obtain the data held in the session cache through a property named `Principal` in the session object.

## Authenticate with username and password

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

## Single sign-on using the current Windows user's credentials

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

## Authenticate with SoCredentials

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

## Session handling

SoSession is a **disposable instance**, and when out of scope it will automatically close the connection and then invalidate the current `SoSession.Principal`. If your code tried to make API calls to the database after this, NetServer will throw an exception.

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

* [How to create a new session][1]
* [Suspending a session][2]
* [Switching between Sessions][3]

<!-- Referenced links -->
[1]: create.md
[2]: suspend.md
[3]: switch.md

<!-- Referenced images -->
