---
uid: databasetableagent-deleterow
title: DatabaseTableAgent.DeleteRow event method
description: Scripting events called on the DeleteRow method on the DatabaseTableAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# DatabaseTableAgent.DeleteRow

Scripting events called on the <see cref='M:IDatabaseTableAgent.DeleteRow'>DeleteRow</see> method on the <see cref='IDatabaseTableAgent'>IDatabaseTableAgent</see>  service agent.

## BeforeDeleteRow
```cs
    static void BeforeDeleteRow(
       String  tableName,
       Int32  id,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteRow
```cs
    static void AfterDeleteRow(
       String  tableName,
       Int32  id,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteRowAsync
```cs
    static void AfterDeleteRowAsync(
       String  tableName,
       Int32  id,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

