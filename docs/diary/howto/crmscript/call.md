---
uid: crmscript_calls
title: Phone calls
author:
so.date:
keywords:
so.topic:
---

# Phone calls

## Register an incoming call

The activity type for phone calls is 5. By default, the direction is *incoming*.

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

## Plan an outgoing call

The type is 5 for outgoing calls as well. However, to control the direction, you need to use the **Task** MDO list table.

**List available task types:**

```crmscript
SearchEngine se;
se.addFields("Task", "Task_id,name");
printLine(se.executeTextTable());
```

**Add call to the todo list:**

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

**Parameters:**

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
