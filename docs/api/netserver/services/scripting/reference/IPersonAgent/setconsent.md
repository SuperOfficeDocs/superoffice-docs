---
uid: IPersonAgent-SetConsent
title: IPersonAgent.SetConsent event method
description: Scripting events called on the SetConsent method on the IPersonAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IPersonAgent.SetConsent

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IPersonAgent.SetConsent'>SetConsent</see> method on the <see cref='IPersonAgent'>IPersonAgent</see>  service agent.

## BeforeSetConsent
```cs
    static void BeforeSetConsent(
       Int32  personId,
       String  purpose,
       String  source,
       String  legalBase,
       String  comment,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetConsent
```cs
    static void AfterSetConsent(
       Int32  personId,
       String  purpose,
       String  source,
       String  legalBase,
       String  comment,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetConsentAsync
```cs
    static void AfterSetConsentAsync(
       Int32  personId,
       String  purpose,
       String  source,
       String  legalBase,
       String  comment,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

