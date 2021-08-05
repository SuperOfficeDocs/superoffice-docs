---
uid: IReportAgent-DeleteReportLabelLayoutEntity
title: IReportAgent.DeleteReportLabelLayoutEntity event method
description: Scripting events called on the DeleteReportLabelLayoutEntity method on the IReportAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IReportAgent.DeleteReportLabelLayoutEntity

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IReportAgent.DeleteReportLabelLayoutEntity'>DeleteReportLabelLayoutEntity</see> method on the <see cref='IReportAgent'>IReportAgent</see>  service agent.

## BeforeDeleteReportLabelLayoutEntity
```cs
    static void BeforeDeleteReportLabelLayoutEntity(
       Int32  reportLabelLayoutEntityId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteReportLabelLayoutEntity
```cs
    static void AfterDeleteReportLabelLayoutEntity(
       Int32  reportLabelLayoutEntityId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteReportLabelLayoutEntityAsync
```cs
    static void AfterDeleteReportLabelLayoutEntityAsync(
       Int32  reportLabelLayoutEntityId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

