---
uid: quoteagent-approvequoteversionasync
title: QuoteAgent.ApproveQuoteVersionAsync event method
description: Scripting events called on the ApproveQuoteVersionAsync method on the QuoteAgent service agent.
keywords: netserver scripting
author: SuperOffice Product and Engineering
date: 06.12.2025
generated: true
category: automation
topic: NetServer scripting
content_type: reference
deployment: onsite
---
# QuoteAgent.ApproveQuoteVersionAsync

Scripting events called on the <see cref='M:IQuoteAgent.ApproveQuoteVersionAsync'>ApproveQuoteVersionAsync</see> method on the <see cref='IQuoteAgent'>IQuoteAgent</see>  service agent.

## BeforeApproveQuoteVersionAsync

```cs
    static void BeforeApproveQuoteVersionAsync(
       Int32  quoteVersionId,
       String  approvedByText,
       Int32  approvedByAssociateId,
       String  approvalText,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```

Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.

## AfterApproveQuoteVersionAsync

```cs
    static void AfterApproveQuoteVersionAsync(
       Int32  quoteVersionId,
       String  approvedByText,
       Int32  approvedByAssociateId,
       String  approvalText,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```

Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

## AfterApproveQuoteVersionAsyncAsync

```cs
    static void AfterApproveQuoteVersionAsyncAsync(
       Int32  quoteVersionId,
       String  approvedByText,
       Int32  approvedByAssociateId,
       String  approvalText,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```

Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
