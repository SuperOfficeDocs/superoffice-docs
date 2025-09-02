---
uid: documentagent-getpublishedpersondocumentsbydateasync
title: DocumentAgent.GetPublishedPersonDocumentsByDateAsync event method
description: Scripting events called on the GetPublishedPersonDocumentsByDateAsync method on the DocumentAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# DocumentAgent.GetPublishedPersonDocumentsByDateAsync

Scripting events called on the <see cref='M:IDocumentAgent.GetPublishedPersonDocumentsByDateAsync'>GetPublishedPersonDocumentsByDateAsync</see> method on the <see cref='IDocumentAgent'>IDocumentAgent</see>  service agent.

## BeforeGetPublishedPersonDocumentsByDateAsync
```cs
    static void BeforeGetPublishedPersonDocumentsByDateAsync(
       Int32  personId,
       Boolean  includeProjectDocuments,
       DateTime  startTime,
       DateTime  endTime,
       Int32  count,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetPublishedPersonDocumentsByDateAsync
```cs
    static void AfterGetPublishedPersonDocumentsByDateAsync(
       Int32  personId,
       Boolean  includeProjectDocuments,
       DateTime  startTime,
       DateTime  endTime,
       Int32  count,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetPublishedPersonDocumentsByDateAsyncAsync
```cs
    static void AfterGetPublishedPersonDocumentsByDateAsyncAsync(
       Int32  personId,
       Boolean  includeProjectDocuments,
       DateTime  startTime,
       DateTime  endTime,
       Int32  count,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

