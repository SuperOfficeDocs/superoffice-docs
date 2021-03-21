---
uid: enum-appointmentstatus
title: Enum values for AppointmentStatus
description: Lists the enum values for AppointmentStatus.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# AppointmentStatus Enum

status=done,started, not started, hidden

* UnknownOrPostIt = 0
* NotStarted = 1
* Started = 2
* Completed = 3
* Hidden = 4
* Booking = 5
* BookingMoved = 6
* BookingSeen = 7
* BookingMovedSeen = 8
* BookingDeclined = 9
* BookingDeleted = 10
* Assignment = 11
* AssignmentSeen = 12
* AssignmentDeclined = 13

## Usage

* [appointment](../appointment.md).status - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
