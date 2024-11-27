---
uid: documentmigrationagent-getfordaterange
title: DocumentMigrationAgent.GetForDateRange event method
description: Scripting events called on the GetForDateRange method on the DocumentMigrationAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# DocumentMigrationAgent.GetForDateRange

Scripting events called on the <see cref='M:IDocumentMigrationAgent.GetForDateRange'>GetForDateRange</see> method on the <see cref='IDocumentMigrationAgent'>IDocumentMigrationAgent</see>  service agent.

## BeforeGetForDateRange
```cs
    static void BeforeGetForDateRange(
       Int32  documentPluginId,
       DateTime  minDate,
       DateTime  maxDate,
       Boolean  includeEmails,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetForDateRange
```cs
    static void AfterGetForDateRange(
       Int32  documentPluginId,
       DateTime  minDate,
       DateTime  maxDate,
       Boolean  includeEmails,
       ref DocumentMigrationItemList  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetForDateRangeAsync
```cs
    static void AfterGetForDateRangeAsync(
       Int32  documentPluginId,
       DateTime  minDate,
       DateTime  maxDate,
       Boolean  includeEmails,
       ref DocumentMigrationItemList  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

