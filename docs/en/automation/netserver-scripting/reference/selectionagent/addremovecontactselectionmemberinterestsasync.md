---
uid: selectionagent-addremovecontactselectionmemberinterestsasync
title: SelectionAgent.AddRemoveContactSelectionMemberInterestsAsync event method
description: Scripting events called on the AddRemoveContactSelectionMemberInterestsAsync method on the SelectionAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# SelectionAgent.AddRemoveContactSelectionMemberInterestsAsync

Scripting events called on the <see cref='M:ISelectionAgent.AddRemoveContactSelectionMemberInterestsAsync'>AddRemoveContactSelectionMemberInterestsAsync</see> method on the <see cref='ISelectionAgent'>ISelectionAgent</see>  service agent.

## BeforeAddRemoveContactSelectionMemberInterestsAsync
```cs
    static void BeforeAddRemoveContactSelectionMemberInterestsAsync(
       Int32  selectionId,
       Int32[]  addCompanyInterests,
       Int32[]  removeCompanyInterests,
       Int32[]  addContactInterests,
       Int32[]  removeContactInterests,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterAddRemoveContactSelectionMemberInterestsAsync
```cs
    static void AfterAddRemoveContactSelectionMemberInterestsAsync(
       Int32  selectionId,
       Int32[]  addCompanyInterests,
       Int32[]  removeCompanyInterests,
       Int32[]  addContactInterests,
       Int32[]  removeContactInterests,
       CancellationToken  cancellationToken,
       ref Task  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterAddRemoveContactSelectionMemberInterestsAsyncAsync
```cs
    static void AfterAddRemoveContactSelectionMemberInterestsAsyncAsync(
       Int32  selectionId,
       Int32[]  addCompanyInterests,
       Int32[]  removeCompanyInterests,
       Int32[]  addContactInterests,
       Int32[]  removeContactInterests,
       CancellationToken  cancellationToken,
       ref Task  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

