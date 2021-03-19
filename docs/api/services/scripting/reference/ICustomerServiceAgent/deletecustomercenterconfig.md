---
uid: ICustomerServiceAgent-DeleteCustomerCenterConfig
title: ICustomerServiceAgent.DeleteCustomerCenterConfig event method
description: Scripting events called on the DeleteCustomerCenterConfig method on the ICustomerServiceAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# ICustomerServiceAgent.DeleteCustomerCenterConfig

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.ICustomerServiceAgent.DeleteCustomerCenterConfig'>DeleteCustomerCenterConfig</see> method on the <see cref='ICustomerServiceAgent'>ICustomerServiceAgent</see>  service agent.

## BeforeDeleteCustomerCenterConfig
```cs
    static void BeforeDeleteCustomerCenterConfig(
       Int32  customerCenterConfigId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteCustomerCenterConfig
```cs
    static void AfterDeleteCustomerCenterConfig(
       Int32  customerCenterConfigId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteCustomerCenterConfigAsync
```cs
    static void AfterDeleteCustomerCenterConfigAsync(
       Int32  customerCenterConfigId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

