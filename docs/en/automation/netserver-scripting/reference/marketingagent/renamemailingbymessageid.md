---
uid: marketingagent-renamemailingbymessageid
title: MarketingAgent.RenameMailingByMessageId event method
description: Scripting events called on the RenameMailingByMessageId method on the MarketingAgent service agent.
generated: true
keywords: netserver scripting
topic: reference
envir: onsite
---
# MarketingAgent.RenameMailingByMessageId

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IMarketingAgent.RenameMailingByMessageId'>RenameMailingByMessageId</see> method on the <see cref='IMarketingAgent'>IMarketingAgent</see>  service agent.

## BeforeRenameMailingByMessageId
```cs
    static void BeforeRenameMailingByMessageId(
       Int32  messageId,
       String  name,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterRenameMailingByMessageId
```cs
    static void AfterRenameMailingByMessageId(
       Int32  messageId,
       String  name,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterRenameMailingByMessageIdAsync
```cs
    static void AfterRenameMailingByMessageIdAsync(
       Int32  messageId,
       String  name,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

