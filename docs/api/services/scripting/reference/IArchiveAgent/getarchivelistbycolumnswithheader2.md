---
uid: IArchiveAgent-GetArchiveListByColumnsWithHeader2
title: IArchiveAgent.GetArchiveListByColumnsWithHeader2 event method
description: Scripting events called on the GetArchiveListByColumnsWithHeader2 method on the IArchiveAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IArchiveAgent.GetArchiveListByColumnsWithHeader2

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IArchiveAgent.GetArchiveListByColumnsWithHeader2'>GetArchiveListByColumnsWithHeader2</see> method on the <see cref='IArchiveAgent'>IArchiveAgent</see>  service agent.

## BeforeGetArchiveListByColumnsWithHeader2
```cs
    static void BeforeGetArchiveListByColumnsWithHeader2(
       String  providerName,
       String  columns,
       String  sortOrder,
       String  restriction,
       String  entities,
       Int32  page,
       Int32  pageSize,
       String  options,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetArchiveListByColumnsWithHeader2
```cs
    static void AfterGetArchiveListByColumnsWithHeader2(
       String  providerName,
       String  columns,
       String  sortOrder,
       String  restriction,
       String  entities,
       Int32  page,
       Int32  pageSize,
       String  options,
       ref ArchiveListResult  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetArchiveListByColumnsWithHeader2Async
```cs
    static void AfterGetArchiveListByColumnsWithHeader2Async(
       String  providerName,
       String  columns,
       String  sortOrder,
       String  restriction,
       String  entities,
       Int32  page,
       Int32  pageSize,
       String  options,
       ref ArchiveListResult  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

