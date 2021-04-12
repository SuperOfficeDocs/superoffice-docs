---
uid: IFindAgent-SaveRestrictions
title: IFindAgent.SaveRestrictions event method
description: Scripting events called on the SaveRestrictions method on the IFindAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IFindAgent.SaveRestrictions

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IFindAgent.SaveRestrictions'>SaveRestrictions</see> method on the <see cref='IFindAgent'>IFindAgent</see>  service agent.

## BeforeSaveRestrictions
```cs
    static void BeforeSaveRestrictions(
       String  storageType,
       String  providerName,
       String  storageKey,
       ArchiveRestrictionInfo[]  restrictions,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSaveRestrictions
```cs
    static void AfterSaveRestrictions(
       String  storageType,
       String  providerName,
       String  storageKey,
       ArchiveRestrictionInfo[]  restrictions,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSaveRestrictionsAsync
```cs
    static void AfterSaveRestrictionsAsync(
       String  storageType,
       String  providerName,
       String  storageKey,
       ArchiveRestrictionInfo[]  restrictions,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

