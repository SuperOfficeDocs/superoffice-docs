---
uid: useragent-getalldatarightsasync
title: UserAgent.GetAllDataRightsAsync event method
description: Scripting events called on the GetAllDataRightsAsync method on the UserAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# UserAgent.GetAllDataRightsAsync

Scripting events called on the <see cref='M:IUserAgent.GetAllDataRightsAsync'>GetAllDataRightsAsync</see> method on the <see cref='IUserAgent'>IUserAgent</see>  service agent.

## BeforeGetAllDataRightsAsync
```cs
    static void BeforeGetAllDataRightsAsync(
       Int32  roleId,
       RoleRelationToOwner  relationToOwner,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetAllDataRightsAsync
```cs
    static void AfterGetAllDataRightsAsync(
       Int32  roleId,
       RoleRelationToOwner  relationToOwner,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetAllDataRightsAsyncAsync
```cs
    static void AfterGetAllDataRightsAsyncAsync(
       Int32  roleId,
       RoleRelationToOwner  relationToOwner,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

