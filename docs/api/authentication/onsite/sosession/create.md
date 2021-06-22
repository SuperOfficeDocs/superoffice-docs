---
title: How to create a new session
uid: ns_create_session
description: How to create a new session for NetServer Core & Service proxy
author: {github-id}
so.date: 11.05.2016
keywords: authentication, SoSession
so.topic: howto
so.envir: onsite
---

# How to create a new session

When someone signs in, a new session is created. Sessions are created through the `SoSession` class.

The following example demonstrates how to authenticate a user through the `SoSession` class.

```csharp
using SuperOffice;

SoSession newSession = SoSession.Authenticate("SAL0", "");
using(newSession)
{
  if (newSession == null)
  {
    MessageBox.Show("No session is created");
  }
  else
    MessageBox.Show("Session is successfully created. Logged on UserName is " + SoContext.CurrentIdentity.Name);
  newSession.Close();
}
```

Here we have created a new session via `SoSession` class. If the authentication data is correct, an instance of the `SoSession` is created.

You can also write the test like this:

```csharp
if (newSession.Equals(null))
```

We have retrieved some data about the currently signed-in user through the `SoContext`, class which holds information about the currently signed-in user.

The `Authenticate` method has **3 overloads**. If you don't pass any parameters, it authenticates the user based on the currently signed-in Windows user.
