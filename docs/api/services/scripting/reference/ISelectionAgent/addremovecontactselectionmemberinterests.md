---
uid: ISelectionAgent-AddRemoveContactSelectionMemberInterests
title: ISelectionAgent.AddRemoveContactSelectionMemberInterests event method
description: Scripting events called on the AddRemoveContactSelectionMemberInterests method on the ISelectionAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# ISelectionAgent.AddRemoveContactSelectionMemberInterests

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.ISelectionAgent.AddRemoveContactSelectionMemberInterests'>AddRemoveContactSelectionMemberInterests</see> method on the <see cref='ISelectionAgent'>ISelectionAgent</see>  service agent.

## BeforeAddRemoveContactSelectionMemberInterests
```cs
    static void BeforeAddRemoveContactSelectionMemberInterests(
       Int32  selectionId,
       Int32[]  addCompanyInterests,
       Int32[]  removeCompanyInterests,
       Int32[]  addContactInterests,
       Int32[]  removeContactInterests,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterAddRemoveContactSelectionMemberInterests
```cs
    static void AfterAddRemoveContactSelectionMemberInterests(
       Int32  selectionId,
       Int32[]  addCompanyInterests,
       Int32[]  removeCompanyInterests,
       Int32[]  addContactInterests,
       Int32[]  removeContactInterests,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterAddRemoveContactSelectionMemberInterestsAsync
```cs
    static void AfterAddRemoveContactSelectionMemberInterestsAsync(
       Int32  selectionId,
       Int32[]  addCompanyInterests,
       Int32[]  removeCompanyInterests,
       Int32[]  addContactInterests,
       Int32[]  removeContactInterests,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

