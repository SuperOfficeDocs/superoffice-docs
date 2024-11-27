---
uid: quoteagent-deletequotealternative
title: QuoteAgent.DeleteQuoteAlternative event method
description: Scripting events called on the DeleteQuoteAlternative method on the QuoteAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# QuoteAgent.DeleteQuoteAlternative

Scripting events called on the <see cref='M:IQuoteAgent.DeleteQuoteAlternative'>DeleteQuoteAlternative</see> method on the <see cref='IQuoteAgent'>IQuoteAgent</see>  service agent.

## BeforeDeleteQuoteAlternative
```cs
    static void BeforeDeleteQuoteAlternative(
       Int32  quoteAlternativeId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteQuoteAlternative
```cs
    static void AfterDeleteQuoteAlternative(
       Int32  quoteAlternativeId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteQuoteAlternativeAsync
```cs
    static void AfterDeleteQuoteAlternativeAsync(
       Int32  quoteAlternativeId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

