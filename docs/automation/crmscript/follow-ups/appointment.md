---
title: crmscript_appointments
description: Calendar appointments
author:
so.date:
keywords:
so.topic:
---

# Calendar appointments

An *appointment* is a type of **follow-up** with a defined start and end time, such as a meeting. It will be shown in the calendar of the owner's diary.

## Common scenarios

| scenario          | resource | 2+ participants | description                                         |
|-------------------|:--------:|:---------------:|-----------------------------------------------------|
| own time reserved |          |                 | you have set aside time to work on something, alone |
| own time and resource reserved   | x           |                 | as above + need room or equipment |
| meeting w/ multiple participants | x   | x     | a meeting, commonly also w/ a resource or location  |

**Also:**

* Appointments can be single events or part of a recurring series.
* Overdue and completed appointments will be in the todo list in addition to in the calendar.
* Appointments involving a resource and/or additional participants are called **bookings** (or group reservation).
* Appointments can be created by the owner or assigned/delegated to an associate.

## Get appointments

> [!TIP]
> You can only retrieve appointments for persons that are SuperOffice users ([associates](../persons-and-organizations/employees.md)). The signed-in user must also have permission to view those appointments. Otherwise, an exception is thrown.

### NSAppointment[] GetAppointmentList(Integer[] p0)

Fetches a collection of appointments corresponding to a list of IDs.

```crmscript!
Integer[] appointmentIDs;
appointmentIDs.pushFront(84);
appointmentIDs.pushFront(86);
appointmentIDs.pushFront(88);
NSAppointmentAgent appointmentAgent;
NSAppointment[] appointmentList = appointmentAgent.GetAppointmentList(appointmentIDs);

for(Integer i = 0; i < appointmentList.length(); i++) {
  print("ID: " + appointmentList[i].GetAppointmentId().toString());
  printLine("\t At: " + appointmentList[i].GetStartDate().toString() + " to " + appointmentList[i].GetEndDate().toString());
}
```

> [!TIP]
> You can also use the [archive agent](../crmscript-archiveagent.md) to fetch appointments.

### NSAppointment[] GetPersonDiary(Integer personId, DateTime startTime, DateTime endTime, Integer count)

Fetches a limited number of appointments within a time range for the given person.
`GetPersonDiary()` will ignore appointments not shown in the user's diary.

```crmscript!
NSAppointmentAgent appointmentAgent;
DateTime start;
DateTime end;

NSAppointment[] appointmentList = appointmentAgent.GetPersonDiary(5, start.addMonth(-6), end, 10);

for(Integer i = 0; i < appointmentList.length(); i++) {
  print("ID: " + appointmentList[i].GetAppointmentId().toString());
  printLine("\t At: " + appointmentList[i].GetStartDate().toString() + " to " + appointmentList[i].GetEndDate().toString());
}
```

> [!TIP]
> Set `count` to -1 to not restrict the collection of appointments retrieved.

### NSAppointment[] GetPersonAppointments(Integer personId, Bool includeProjectAppointments, DateTime startTime, DateTime endTime, Integer count)

Same as `GetPersonDiary()`, but will also include all appointments in projects that the user is a member of if set to **true**.

```crmscript!
NSAppointmentAgent appointmentAgent;
DateTime start;
DateTime end;

NSAppointment[] appointmentList = appointmentAgent.GetPersonAppointments(5, true, start.addMonth(-6), end, 5);

for(Integer i = 0; i < appointmentList.length(); i++) {
  printLine("ID: " + appointmentList[i].GetAppointmentId().toString());
}
```

## Create appointment

You'll need an **NSAppointmentAgent** to create, populate, and save a new appointment. Use 1 of these methods as a starting point, and look up more options in the API reference.

* `CreateDefaultAppointmentEntity()`
* `CreateDefaultAppointmentEntityByType(Integer type)`
* `CreateDefaultAppointmentEntityByTypeAndAssociate(Integer type, Integer associateId)`

Example: block out 2 hours starting now for a team lunch.

```crmscript
DateTime start;
DateTime end;
end.addHour(2);

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity newAppointment = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(7, 1);

newAppointment.SetActiveDate(start);
newAppointment.SetStartDate(start);
newAppointment.SetEndDate(end);
newAppointment.SetDescription("Team lunch");

newAppointment = appointmentAgent.SaveAppointmentEntity(newAppointment);
```

## Update appointment

### NSAppointment UpdateAppointment(Integer p0, DateTime p1, DateTime p2, Integer p3, Integer p4, Integer associateId)

Change the description, for example, to add an agenda:

```crmscript
NSAppointmentAgent appointmentAgent;
NSAppointmentEntity appointment = appointmentAgent.GetAppointmentEntity(146);

appointment.SetDescription("Agenda: 1. Welcome 2. Annual report 3. Election 4. Misc");
appointmentAgent.SaveAppointmentEntity(appointment);
```

## Move appointment

Postpone an existing appointment by 1 week (reschedule):

```crmscript
NSAppointmentAgent appointmentAgent;

NSAppointmentEntity a = appointmentAgent.GetAppointmentEntity(146);

DateTime start = a.GetStartDate();
a.SetStartDate(start.addDay(7));

DateTime end = a.GetEndDate();
a.SetEndDate(end.addDay(7));

a = appointmentAgent.SaveAppointmentEntity(a);
```

## Delete appointment

### Void DeleteAppointmentEntity(Integer appointmentEntityId)

```crmscript
NSAppointmentAgent appointmentAgent;
appointmentAgent.DeleteAppointmentEntity(142);
```

## Mark as complete

*Completed* means that the status is **3**.

### Void SetCompleted(Integer Completed)

```crmscript
NSAppointmentAgent appointmentAgent;

NSAppointmentEntity a = appointmentAgent.GetAppointmentEntity(77);
a.SetCompleted(3);
appointmentAgent.SaveAppointmentEntity(a);
```

### Integer GetCompleted()

You can't edit completed follow-ups until you have undone their Completed status!

Use `GetCompleted()` to check the status. Toggle it to **0** to do your edits and then toggle it back if applicable.

```crmscript
NSAppointmentAgent appointmentAgent;

NSAppointmentEntity e = appointmentAgent.GetAppointmentEntity(77);

if (e.GetCompleted() == 3) {
  e.SetCompleted(0);
  appointmentAgent.SaveAppointmentEntity(e);
}
```

## Red-letter days

Ever tried to set up an appointment around Christmas and wondered if it's a red-letter day or not? Here's how to check:

```crmscript!
NSAppointmentAgent appointmentAgent;

DateTime start = String("2020-12-22").toDateTime();
DateTime end = start;
end.addDay(10);

Integer associateId = 0;

NSRedLetterInformationListItem[] redLetterDays = appointmentAgent.GetRedLetterInformationListByDatesAndAssociate(start, end, associateId);

for (Integer i = 0; i < redLetterDays.length(); i++)
{
  print(start.toString() + " is holiday: " + redLetterDays[i].GetRedLetterInformation().GetIsOwnCountryHoliday().toString() + "\n");
  start.addDay(1);
}
```

## Resources

The `location` field is either a custom string or info from a booked resource.

> [!TIP]
> Remember that a **resource is an [associate of type 1](../persons-and-organizations/employees.md)** and that you should disregard the `person_id`.

When you book a resource, it's appointment is linked to the person's appointment using the `mother_id` field. There will be 2 distinct appointment IDs: 1 for the person and 1 for the resource!

### List resources

```crmscript!
SearchEngine se;
se.addFields("associate", "associate_id,name,isLocation");
se.addCriteria("associate.type", "OperatorEquals", "1","OperatorAnd", 0);
printLine(se.executeTextTable());
```

### Check if a resource is available

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

### Book a resource

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
> You can also [invite persons to the meeting](./invitations.md)).

## Delegation

Delegation is the act of assigning a follow-up **to someone else**. This means that the creator and owner of the appointment are 2 different persons. Common scenarios:

* A personal assistant manages the CEO's diary on their behalf.
* HR is onboarding a new hire and sets up the introductory program for the employee ahead of time.
* A team lead is charged with calling 20 customers and delegates 4 calls to each of their 5 direct reports.
* A colleague is on vacation, but they need to phone a client when they get back.
* A consultant has arranged a meeting with a client, but has become ill and needs to send someone else.

**To delegate an appointment:**

1. Create or update the follow-up as usual.
2. Set `owner` to the associate ID you are delegating to.
3. Set `AssignedBy` to the previous owner.
4. Save.

> [!NOTE]
> `AssignedBy` is set when you change the owner, but not before.

### Relevant statuses

| Status | Description                                                 |
|:------:|:------------------------------------------------------------|
| 11     | Appointment has been assigned to a user (initial status)    |
| 12     | User has seen, but not accepted or declined the appointment |
| 13     | User has declined the assigned appointment                  |

## Reference

### Appointment types

| Type | Description                                     |
|:----:|:------------------------------------------------|
| 0    | Undefined/initializing                          |
| 1    | In calendar, if overdue or done today, also in todo list |
| 2    | In todo list (no start time)                    |
| 6    | Meeting invite (changes to 1 when accepted)     |
| 7    | Pending assignment (changes to 2 when accepted) |

### Status

| Status | Description        |
|:------:|:-------------------|
| 0      | Unknown/ a post-it |
| 1      | Not started        |
| 2      | Started            |
| 3      | Completed          |
| 4      | Hidden             |
| 5-10   | Booking            |
| 11-13  | Assignment         |

### Frequently used fields

| Field          | Description                                  |
|:---------------|:---------------------------------------------|
| appointment_id | ID                                           |
| associate_id   | owner                                        |
| contact_id     | company                                      |
| person_id      | participant if a meeting                     |
| task_idx       | FK Task list                                 |
| type           | EnumAppointmentType                          |
| status         | EnumAppointmentStatus                        |
| mother_id      | For group reservations and invites           |
| location       | Custom string or info from a booked resource |
| alldayEvent    | 0 = no; 1 = yes                              |
| freeBusy       | 0 = busy; 1 =  free                          |

For a complete list of fields, see the [database reference](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-appointment.htm).

### Timestamp values

| Field         | Description                          |
|:--------------|:-------------------------------------|
| registered    | UtcDateTime of registration          |
| updated       | UtcDateTime of last update           |
| done          | When a task was completed (DateTime) |
| do_by         | Planned deadline for task (DateTime) |
| activeDate    | Display date (DateTime)              |
| endDate       | Planned completion time (DateTime)   |
