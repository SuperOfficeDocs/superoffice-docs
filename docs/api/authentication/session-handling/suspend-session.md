---
title: ns_suspend_session
description: How to suspend a session
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Suspending a Session

You can suspend a running session.

* You can suspend the session by calling `Suspend()`, which returns a string containing the session ID.
* When a session is suspended, the `CurrentIdentity` will be set to null.
* If you need to continue this session, you can pass the session ID to the `Continue` method of the `SoSession` class and it returns the former session.
* At the end, the session is closed by calling `Close()`, and thereby the `CurrentIdentity` is once again set to null.

In the following example, we have demonstrated how this is done.

```csharp
using SuperOffice;

SoSession newSession = SoSession.Authenticate("SAL0", "");
using(newSession)
{
  if (SoContext.CurrentIdentity != null)
  {
    MessageBox.Show("Logged on user is : " + SoContext.CurrentIdentity.Name);
  }
  else
    MessageBox.Show("Pending a Session");
  //Suspending the session
  //Note that we keep the return value so that we can continue the session later on
  string state = newSession.Suspend();
  if (SoContext.CurrentIdentity == null)
  {
    MessageBox.Show("Session is suspened");
  }
  else
  {
    MessageBox.Show("The user " + SoContext.CurrentIdentity.Name + " is not yet suspended");
  }
  //continue the session
  newSession = SoSession.Continue(state);
  if (SoContext.CurrentIdentity == null)
  {
    MessageBox.Show("Session is still suspended");
  }
  else
  {
    MessageBox.Show("The user " + SoContext.CurrentIdentity.Name + " is Continued");
  }
  //Close the session
  newSession.Close();
}
```

Initially, we create a new session for the user with username SAL0. If authentication fails, the current identity property of the `SoContext` class will be set to null.
