---
uid: crmscript-call-incoming
title: Register an incoming call
description: How to register an incoming call with CRMScript
keywords: CRMScript, calendar, diary, call, follow-up
author: Bergfrid Skaara Dias
date: 03.21.2022
version: 10
content_type: howto
redirect_from: /en/diary/howto/crmscript/register-incoming-call
---

# Register an incoming call

The **activity type** for phone calls is 5. By default, the direction is *incoming*.

This example code will register an incoming call with a description, starting now, and lasting 10 minutes.

```crmscript
DateTime start;
DateTime end;
end.addMin(10);

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity incomingCall = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(5, 1);

incomingCall.SetActiveDate(start);
incomingCall.SetStartDate(start);
incomingCall.SetEndDate(end);
incomingCall.SetDescription("My favorite customer calling re migration.");

incomingCall = appointmentAgent.SaveAppointmentEntity(incomingCall);
```

## Related topics

* [NSAppointmentAgent][1]
* [NSAppointmentEntity][2]
* [About phone calls][3]

<!-- Referenced links -->
[1]: <xref:CRMScript.NetServer.NSAppointmentAgent>
[2]: <xref:CRMScript.NetServer.NSAppointmentEntity>
[3]: ../../../../diary/learn/follow-ups.md#call
