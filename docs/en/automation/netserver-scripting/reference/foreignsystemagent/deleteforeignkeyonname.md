---
uid: foreignsystemagent-deleteforeignkeyonname
title: ForeignSystemAgent.DeleteForeignKeyOnName event method
description: Scripting events called on the DeleteForeignKeyOnName method on the ForeignSystemAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# ForeignSystemAgent.DeleteForeignKeyOnName

Scripting events called on the <see cref='M:IForeignSystemAgent.DeleteForeignKeyOnName'>DeleteForeignKeyOnName</see> method on the <see cref='IForeignSystemAgent'>IForeignSystemAgent</see>  service agent.

## BeforeDeleteForeignKeyOnName
```cs
    static void BeforeDeleteForeignKeyOnName(
       String  applicationName,
       String  deviceName,
       String  deviceIdentifier,
       String  keyName,
       String  tableName,
       Int32  recordId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteForeignKeyOnName
```cs
    static void AfterDeleteForeignKeyOnName(
       String  applicationName,
       String  deviceName,
       String  deviceIdentifier,
       String  keyName,
       String  tableName,
       Int32  recordId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteForeignKeyOnNameAsync
```cs
    static void AfterDeleteForeignKeyOnNameAsync(
       String  applicationName,
       String  deviceName,
       String  deviceIdentifier,
       String  keyName,
       String  tableName,
       Int32  recordId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

