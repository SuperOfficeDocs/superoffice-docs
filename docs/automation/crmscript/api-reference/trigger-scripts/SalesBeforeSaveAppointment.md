---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# SalesBeforeSaveAppointment (1001)

Called before an appointment is saved.

## Input values

* `IsNew` = the appointment new?
* `Location` = location
* `suggestedappointment_id` = suggested appointment ID
* `project_id` = the project ID
* `sale_id` = the sale ID

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("ticketId");
```
