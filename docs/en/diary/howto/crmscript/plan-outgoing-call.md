---
uid: crmscript-call-outgoing
title: Plan an outgoing call
description: How to plan an outgoing call with CRMScript
author: Bergfrid Skaara Dias
so.date: 03.21.2022
keywords: CRMScript, calendar, diary, call, follow-up, direction
so.topic: howto
---

# Plan an outgoing call

The type is 5 for outgoing calls (same as incoming). However, to control the direction, you need to use the [Task MDO list table][5].

## List available task types

```crmscript
SearchEngine se;
se.addFields("Task", "Task_id,name");
printLine(se.executeTextTable());
```

## Add call to the todo list

```crmscript
DateTime deadline;
deadline.addDay(2);

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity newCall = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(5, 1);

newCall.SetDescription("Call to book rental car");
newCall.SetAssignmentStatus(11);
newCall.SetEndDate(deadline);

NSTaskListItem task;
task.SetTaskListItemId(3);
newCall.SetTask(task);

newCall = appointmentAgent.SaveAppointmentEntity(newCall);
```

## Update when you do make the call

Parameters to [UpdateAppointment()][4]:

* appointment_id
* start time
* end time
* status
* type
* owner (associate_id)

```crmscript
DateTime start;
DateTime end;
NSAppointmentAgent appointmentAgent;
appointmentAgent.UpdateAppointment(88, start, end.addMin(20), 0, 0, 5);
```

## Related topics

* [NSAppointmentAgent][1]
* [NSAppointmentEntity][2]
* [NSTaskListItem][3]
* [About phone calls][6]

<!-- Referenced links -->
[1]: <xref:CRMScript.NetServer.NSAppointmentAgent>
[2]: <xref:CRMScript.NetServer.NSAppointmentEntity>
[3]: <xref:CRMScript.NetServer.NSTaskListItem>
[4]: <xref:CRMScript.NetServer.NSAppointmentAgent.UpdateAppointment(Integer,Integer,Integer,Integer)>
[5]: ../../../database/tables/task.md
[6]: ../../learn/follow-ups.md#call
