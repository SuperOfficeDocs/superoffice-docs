---
uid: enum-appointmentexternalowner
title: Enum values for AppointmentExternalOwner
description: Lists the enum values for AppointmentExternalOwner.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# AppointmentExternalOwner Enum

Set if an external system owns this appointment.

| Name | Value | Description |
|------|-------|-------------|
|None|0|No external owner|
|Other|1|An external system owns the appointment|
|Outlook|2|Outlook owns the appointment|
|Google|3|Google owns the appointment|

## Usage

* [appointment](../appointment.md).owned_externally - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
