---
uid: ICRMScriptAgent-DeleteCRMScriptByUniqueIdentifier
title: ICRMScriptAgent.DeleteCRMScriptByUniqueIdentifier event method
description: Scripting events called on the DeleteCRMScriptByUniqueIdentifier method on the ICRMScriptAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# ICRMScriptAgent.DeleteCRMScriptByUniqueIdentifier

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.ICRMScriptAgent.DeleteCRMScriptByUniqueIdentifier'>DeleteCRMScriptByUniqueIdentifier</see> method on the <see cref='ICRMScriptAgent'>ICRMScriptAgent</see>  service agent.

## BeforeDeleteCRMScriptByUniqueIdentifier
```cs
    static void BeforeDeleteCRMScriptByUniqueIdentifier(
       String  uniqueIdentifier,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteCRMScriptByUniqueIdentifier
```cs
    static void AfterDeleteCRMScriptByUniqueIdentifier(
       String  uniqueIdentifier,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteCRMScriptByUniqueIdentifierAsync
```cs
    static void AfterDeleteCRMScriptByUniqueIdentifierAsync(
       String  uniqueIdentifier,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

