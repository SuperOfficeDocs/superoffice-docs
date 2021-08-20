---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# SalesBeforeSaveAppointment (1001)

Called before an appointment is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[AppointmentEntity input values](includes/appointment-var.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("AppointmentEntity.AppointmentId");
```
