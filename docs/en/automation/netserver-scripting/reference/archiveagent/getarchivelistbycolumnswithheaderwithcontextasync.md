---
uid: archiveagent-getarchivelistbycolumnswithheaderwithcontextasync
title: ArchiveAgent.GetArchiveListByColumnsWithHeaderWithContextAsync event method
description: Scripting events called on the GetArchiveListByColumnsWithHeaderWithContextAsync method on the ArchiveAgent service agent.
keywords: netserver scripting
author: SuperOffice Product and Engineering
date: 06.12.2025
generated: true
category: automation
topic: NetServer scripting
content_type: reference
deployment: onsite
---
# ArchiveAgent.GetArchiveListByColumnsWithHeaderWithContextAsync

Scripting events called on the <see cref='M:IArchiveAgent.GetArchiveListByColumnsWithHeaderWithContextAsync'>GetArchiveListByColumnsWithHeaderWithContextAsync</see> method on the <see cref='IArchiveAgent'>IArchiveAgent</see>  service agent.

## BeforeGetArchiveListByColumnsWithHeaderWithContextAsync

```cs
    static void BeforeGetArchiveListByColumnsWithHeaderWithContextAsync(
       String  providerName,
       String[]  columns,
       ArchiveOrderByInfo[]  sortOrder,
       ArchiveRestrictionInfo[]  restriction,
       String[]  entities,
       Int32  page,
       Int32  pageSize,
       String  options,
       String  context,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```

Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.

## AfterGetArchiveListByColumnsWithHeaderWithContextAsync

```cs
    static void AfterGetArchiveListByColumnsWithHeaderWithContextAsync(
       String  providerName,
       String[]  columns,
       ArchiveOrderByInfo[]  sortOrder,
       ArchiveRestrictionInfo[]  restriction,
       String[]  entities,
       Int32  page,
       Int32  pageSize,
       String  options,
       String  context,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```

Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

## AfterGetArchiveListByColumnsWithHeaderWithContextAsyncAsync

```cs
    static void AfterGetArchiveListByColumnsWithHeaderWithContextAsyncAsync(
       String  providerName,
       String[]  columns,
       ArchiveOrderByInfo[]  sortOrder,
       ArchiveRestrictionInfo[]  restriction,
       String[]  entities,
       Int32  page,
       Int32  pageSize,
       String  options,
       String  context,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```

Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
