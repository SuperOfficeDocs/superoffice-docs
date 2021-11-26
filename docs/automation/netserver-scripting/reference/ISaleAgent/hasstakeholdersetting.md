---
uid: ISaleAgent-HasStakeholderSetting
title: ISaleAgent.HasStakeholderSetting event method
description: Scripting events called on the HasStakeholderSetting method on the ISaleAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# ISaleAgent.HasStakeholderSetting

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.ISaleAgent.HasStakeholderSetting'>HasStakeholderSetting</see> method on the <see cref='ISaleAgent'>ISaleAgent</see>  service agent.

## BeforeHasStakeholderSetting
```cs
    static void BeforeHasStakeholderSetting(
       Int32  saleId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterHasStakeholderSetting
```cs
    static void AfterHasStakeholderSetting(
       Int32  saleId,
       ref Boolean  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterHasStakeholderSettingAsync
```cs
    static void AfterHasStakeholderSettingAsync(
       Int32  saleId,
       ref Boolean  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

