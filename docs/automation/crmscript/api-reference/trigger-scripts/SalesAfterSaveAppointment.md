---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# SalesAfterSaveAppointment (1101)

Called after an appointment is saved. EventData contains all variables passed by datahandler in Sales client. It is also possible to create and pass custom variables from BeforeSave event trigger.

## Input values

[!include[AppointmentEntity input values](includes/appointment-var.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("AppointmentEntity.AppointmentId");
```
