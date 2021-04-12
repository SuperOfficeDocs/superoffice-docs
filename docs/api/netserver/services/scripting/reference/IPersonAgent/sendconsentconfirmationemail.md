---
uid: IPersonAgent-SendConsentConfirmationEmail
title: IPersonAgent.SendConsentConfirmationEmail event method
description: Scripting events called on the SendConsentConfirmationEmail method on the IPersonAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IPersonAgent.SendConsentConfirmationEmail

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IPersonAgent.SendConsentConfirmationEmail'>SendConsentConfirmationEmail</see> method on the <see cref='IPersonAgent'>IPersonAgent</see>  service agent.

## BeforeSendConsentConfirmationEmail
```cs
    static void BeforeSendConsentConfirmationEmail(
       Int32  personId,
       String  emailAddress,
       Int32  emailTemplateId,
       Int32  cultureLcidId,
       String  subject,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSendConsentConfirmationEmail
```cs
    static void AfterSendConsentConfirmationEmail(
       Int32  personId,
       String  emailAddress,
       Int32  emailTemplateId,
       Int32  cultureLcidId,
       String  subject,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSendConsentConfirmationEmailAsync
```cs
    static void AfterSendConsentConfirmationEmailAsync(
       Int32  personId,
       String  emailAddress,
       Int32  emailTemplateId,
       Int32  cultureLcidId,
       String  subject,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

