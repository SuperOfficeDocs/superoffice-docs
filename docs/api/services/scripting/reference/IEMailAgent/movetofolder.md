---
uid: IEMailAgent-MoveToFolder
title: IEMailAgent.MoveToFolder event method
description: Scripting events called on the MoveToFolder method on the IEMailAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IEMailAgent.MoveToFolder

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IEMailAgent.MoveToFolder'>MoveToFolder</see> method on the <see cref='IEMailAgent'>IEMailAgent</see>  service agent.

## BeforeMoveToFolder
```cs
    static void BeforeMoveToFolder(
       EMailConnectionInfo  connectionInfo,
       Int32[]  messageServerIds,
       String  targetFolder,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterMoveToFolder
```cs
    static void AfterMoveToFolder(
       EMailConnectionInfo  connectionInfo,
       Int32[]  messageServerIds,
       String  targetFolder,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterMoveToFolderAsync
```cs
    static void AfterMoveToFolderAsync(
       EMailConnectionInfo  connectionInfo,
       Int32[]  messageServerIds,
       String  targetFolder,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

