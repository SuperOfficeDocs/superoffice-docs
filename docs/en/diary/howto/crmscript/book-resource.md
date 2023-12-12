---
uid: crmscript-book-resource
title: How to book a resource
description: How to book a resource with CRMScript
author: Bergfrid Skaara Dias
so.date: 03.18.2022
keywords: CRMScript, calendar, diary, appointments, follow-up, resource, location
so.topic: howto
---

# Resources

The `location` field is either a custom string or info from a booked resource.

> [!TIP]
> Remember that a **resource is an associate of type 1** and that you should disregard the `person_id`.

When you book a resource, its appointment is linked to the person's appointment using the `mother_id` field. There will be two distinct appointment IDs: one for the person and one for the resource!

## List resources

```crmscript!
SearchEngine se;
se.addFields("associate", "associate_id,name,isLocation");
se.addCriteria("associate.type", "OperatorEquals", "1","OperatorAnd", 0);
printLine(se.executeTextTable());
```

## Check if a resource is available

It is good practice to always check availability before booking a resource to avoid double booking.

```crmscript!
NSAppointmentAgent appointmentAgent;
DateTime start;
DateTime end;
end.moveToDayEnd();

NSAppointment[] appointmentList = appointmentAgent.GetAssociateDiary(37, start, end, -1);

if (appointmentList.length() > 0) {

  printLine("The resource is booked at the following times:\n");

  for(Integer i = 0; i < appointmentList.length(); i++) {
    print("ID: " + appointmentList[i].GetAppointmentId().toString());
    printLine("\t At: " + appointmentList[i].GetStartDate().toString() + " to " + appointmentList[i].GetEndDate().toString());
  }
}
else {
  printLine("The resource is free for the rest of today.");
}
```

## Book a resource

By calling `SetParticipants()`, you can book the resource without the overhead of cloning and linking appointments. Here's how:

1. Create a new appointment for the person **or** retrieve an existing, uncompleted appointment.
2. Create an NSParticipantInfo list and add the associate ID of the resource to it.
3. Call `SetParticipants()`.
4. Save the appointment.

The following example sets up a review meeting at 14:15-15:00 on the last day of the current month and reserves the meeting room with ID 37.

```crmscript
DateTime start;
start.moveToMonthEnd();
start.setTime(String("14:15:00").toTime());
DateTime end = start;
end.addMin(45);

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity newAppointment = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(7, 1);

newAppointment.SetActiveDate(start);
newAppointment.SetStartDate(start);
newAppointment.SetEndDate(end);
newAppointment.SetDescription("End-of-month review");

NSParticipantInfo p;
p.SetAssociateId(37); // meeting room
NSParticipantInfo[] participants;
participants.pushBack(p);

newAppointment.SetParticipants(participants);

newAppointment = appointmentAgent.SaveAppointmentEntity(newAppointment);
```

> [!TIP]
> You can also [invite persons to the meeting][3]).

<!-- Referenced links -->
[3]: ../../learn/invitation/index.md
