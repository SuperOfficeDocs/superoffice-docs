---
uid: IAppointmentAgent-Delete
title: IAppointmentAgent.Delete event method
description: Scripting events called on the Delete method on the IAppointmentAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IAppointmentAgent.Delete

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IAppointmentAgent.Delete'>Delete</see> method on the <see cref='IAppointmentAgent'>IAppointmentAgent</see>  service agent.

## BeforeDelete
```cs
    static void BeforeDelete(
       Int32  appointmentId,
       RecurrenceUpdateMode  updateMode,
       Boolean  sendEmailToParticipants,
       EMailConnectionInfo  smtpEMailConnectionInfo,
       EMailConnectionInfo  imapEMailConnectionInfo,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDelete
```cs
    static void AfterDelete(
       Int32  appointmentId,
       RecurrenceUpdateMode  updateMode,
       Boolean  sendEmailToParticipants,
       EMailConnectionInfo  smtpEMailConnectionInfo,
       EMailConnectionInfo  imapEMailConnectionInfo,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteAsync
```cs
    static void AfterDeleteAsync(
       Int32  appointmentId,
       RecurrenceUpdateMode  updateMode,
       Boolean  sendEmailToParticipants,
       EMailConnectionInfo  smtpEMailConnectionInfo,
       EMailConnectionInfo  imapEMailConnectionInfo,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

