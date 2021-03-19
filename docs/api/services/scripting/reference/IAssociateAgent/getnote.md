---
uid: IAssociateAgent-GetNote
title: IAssociateAgent.GetNote event method
description: Scripting events called on the GetNote method on the IAssociateAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IAssociateAgent.GetNote

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IAssociateAgent.GetNote'>GetNote</see> method on the <see cref='IAssociateAgent'>IAssociateAgent</see>  service agent.

## BeforeGetNote
```cs
    static void BeforeGetNote(
       Int32  associateId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetNote
```cs
    static void AfterGetNote(
       Int32  associateId,
       ref String[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetNoteAsync
```cs
    static void AfterGetNoteAsync(
       Int32  associateId,
       ref String[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

