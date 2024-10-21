---
uid: crmscript-create-appointment
title: Create appointment
description: How to create appointments with CRMScript
keywords: CRMScript, calendar, diary, appointments, follow-up
author: Bergfrid Skaara Dias
date: 03.18.2022
version: 10
topic: howto
---

# Create appointment

You'll need an [NSAppointmentAgent][1] to create, populate, and save a new appointment. Use one of these methods as a starting point, and look up more options in the API reference.

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

## Delegation

Delegation is the act of assigning a follow-up **to someone else**. This means that the creator and owner of the appointment are two different persons. Common scenarios:

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

| Status | Description |
|:-:|:---|
| 11 | Appointment has been assigned to a user (initial status) |
| 12 | User has seen, but not accepted or declined the appointment |
| 13 | User has declined the assigned appointment |

<!-- Referenced links -->
[1]: <xref:CRMScript.NetServer.NSAppointmentAgent>
