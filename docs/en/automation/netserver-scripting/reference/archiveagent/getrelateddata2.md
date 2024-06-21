---
uid: archiveagent-getrelateddata2
title: ArchiveAgent.GetRelatedData2 event method
description: Scripting events called on the GetRelatedData2 method on the ArchiveAgent service agent.
generated: true
keywords: netserver scripting
topic: reference
envir: onsite
---
# ArchiveAgent.GetRelatedData2

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IArchiveAgent.GetRelatedData2'>GetRelatedData2</see> method on the <see cref='IArchiveAgent'>IArchiveAgent</see>  service agent.

## BeforeGetRelatedData2
```cs
    static void BeforeGetRelatedData2(
       String  table,
       Int32  recordId,
       String  fields,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetRelatedData2
```cs
    static void AfterGetRelatedData2(
       String  table,
       Int32  recordId,
       String  fields,
       ref RelatedData[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetRelatedData2Async
```cs
    static void AfterGetRelatedData2Async(
       String  table,
       Int32  recordId,
       String  fields,
       ref RelatedData[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

