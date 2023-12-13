---
uid: crmscript-create-task
title: Working with todo lists
description: How to create and complete to-dos with CRMScript
author: Bergfrid Skaara Dias
so.date: 03.18.2022
keywords: CRMScript, calendar, diary, to-do, task, follow-up
so.topic: howto
---

# Todo list

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
> While the to-do technically doesn't have a start time, that field will be set with a default value. For example, noon the current day. Don't assume that the start time is empty.

## Complete a to-do

To mark a to-do as completed is essentially just to set the **status** to 3.

This example completes the to-do with ID 88, with end-time = now and start-time = 5 minutes ago.

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

This sample will list all follow-ups of type 6 that have not been started and a deadline in the past.

## Related topics

* [NSAppointmentAgent][1]
* [NSAppointmentEntity][2]
* [Working with CRMScript SearchEngine][3]
* [Create appointment][4]
* [About todo lists][5]

<!-- Referenced links -->
[1]: <xref:CRMScript.NetServer.NSAppointmentAgent>
[2]: <xref:CRMScript.NetServer.NSAppointmentEntity>
[3]: ../../../automation/crmscript/searchengine/index.md
[4]: create-appointment.md
[5]: ../../learn/follow-ups.md#todo
