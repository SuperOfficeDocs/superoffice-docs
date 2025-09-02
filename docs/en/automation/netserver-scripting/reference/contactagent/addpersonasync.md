---
uid: contactagent-addpersonasync
title: ContactAgent.AddPersonAsync event method
description: Scripting events called on the AddPersonAsync method on the ContactAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# ContactAgent.AddPersonAsync

Scripting events called on the <see cref='M:IContactAgent.AddPersonAsync'>AddPersonAsync</see> method on the <see cref='IContactAgent'>IContactAgent</see>  service agent.

## BeforeAddPersonAsync
```cs
    static void BeforeAddPersonAsync(
       Int32  contactId,
       PersonEntity  newPersonEntity,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterAddPersonAsync
```cs
    static void AfterAddPersonAsync(
       Int32  contactId,
       PersonEntity  newPersonEntity,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterAddPersonAsyncAsync
```cs
    static void AfterAddPersonAsyncAsync(
       Int32  contactId,
       PersonEntity  newPersonEntity,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

