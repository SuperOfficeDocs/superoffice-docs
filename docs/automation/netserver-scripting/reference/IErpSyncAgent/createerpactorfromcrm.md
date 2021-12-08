---
uid: IErpSyncAgent-CreateErpActorFromCrm
title: IErpSyncAgent.CreateErpActorFromCrm event method
description: Scripting events called on the CreateErpActorFromCrm method on the IErpSyncAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IErpSyncAgent.CreateErpActorFromCrm

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IErpSyncAgent.CreateErpActorFromCrm'>CreateErpActorFromCrm</see> method on the <see cref='IErpSyncAgent'>IErpSyncAgent</see>  service agent.

## BeforeCreateErpActorFromCrm
```cs
    static void BeforeCreateErpActorFromCrm(
       Int32  connectionId,
       Int32  crmEntityId,
       ErpActorType  erpActorType,
       CrmActorType  crmActorType,
       StringDictionary  erpFieldKeyValues,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterCreateErpActorFromCrm
```cs
    static void AfterCreateErpActorFromCrm(
       Int32  connectionId,
       Int32  crmEntityId,
       ErpActorType  erpActorType,
       CrmActorType  crmActorType,
       StringDictionary  erpFieldKeyValues,
       ref Boolean  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterCreateErpActorFromCrmAsync
```cs
    static void AfterCreateErpActorFromCrmAsync(
       Int32  connectionId,
       Int32  crmEntityId,
       ErpActorType  erpActorType,
       CrmActorType  crmActorType,
       StringDictionary  erpFieldKeyValues,
       ref Boolean  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

