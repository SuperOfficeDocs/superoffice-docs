---
uid: crmscript_tasks
title: Todo list
author:
so.date:
keywords:
so.topic:
---

# Todo list

A **task** is a follow-up without a start time. It usually doesn't have a duration either, but it always has a **deadline**.
Tasks are typically used for things you have to remember to do by a certain time.

By default, you'll find tasks in the diary todo list, where they can be checked off when completed.

## Create a to-do

The following code sample will create a to-do (task ID = 6) due at the end of the current day. It applies to associate with ID 1.

```crmscript
Integer owner = 1; // associate.associate_id

NSContact myCompany;
myCompany.SetContactId(2); // contact.contact_id

DateTime deadline;
deadline.moveToDayEnd();

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity newTask = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(6, owner);

newTask.SetDescription("Remember to turn off the lights when you leave the office.");
newTask.SetContact(myCompany);
newTask.SetAssignmentStatus(11);
newTask.SetEndDate(deadline);

newTask = appointmentAgent.SaveAppointmentEntity(newTask);
```

> [!NOTE]
> While the task technically doesn't have a start time, that field will be set with a default value. For example, noon the current day. Don't assume that the start time is empty.

## Complete a to-do

To mark a task as completed is essentially just to set the **status** to 3.

This example completes the task with ID 88, with end-time = now and start-time = 5 minutes ago.

```crmscript
DateTime start;
DateTime end;
NSAppointmentAgent appointmentAgent;
appointmentAgent.UpdateAppointment(88, start.addMin(-5), end, 3, 2, 5);
```

## List overdue to-dos

```crmscript
DateTime now;
SearchEngine se;
se.addFields("appointment", "appointment_id,task_idx,status,endDate");
se.addCriteria("appointment.task_idx.record_type", "OperatorEquals", "6","OperatorAnd", 0);
se.addCriteria("appointment.status", "OperatorEquals", "1","OperatorAnd", 0);
se.addCriteria("appointment.endDate", "OperatorLt", now.toString(), "OperatorAnd", 0);
printLine(se.executeTextTable());
```

This sample will list all tasks of type 6 that have not been started and a deadline in the past.
