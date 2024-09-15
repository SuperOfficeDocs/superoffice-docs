---
uid: enum-appointmentprivate
title: Enum values for AppointmentPrivate
description: Lists the enum values for AppointmentPrivate.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# AppointmentPrivate Enum

Obsolete, but still maintained field for appointment privacy; denormalization of visiblefor status

| Name | Value | Description |
|------|-------|-------------|
|Public|0|This appointment can be read by anyone|
|PrivateUser|1|This appointment can only be read/seen by the owner|
|PrivateGroup|2|This appointment can only be read by members of the owners group|

## Usage

* [appointment](../appointment.md).private - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
