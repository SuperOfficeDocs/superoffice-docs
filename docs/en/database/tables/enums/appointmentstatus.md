---
uid: enum-appointmentstatus
title: Enum values for AppointmentStatus
description: Lists the enum values for AppointmentStatus.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# AppointmentStatus Enum

status=done,started, not started, hidden

| Name | Value | Description |
|------|-------|-------------|
|UnknownOrPostIt|0|Appointment is not initialized or it is a Post-IT for users diary, used together with ApointmentType.Note only|
|NotStarted|1|Appointment has not been started|
|Started|2|Appointment has been started, but not completed|
|Completed|3|Appointment is completed|
|Hidden|4|Appointment is hidden|
|Booking|5|Appointment is a booking invitation (initial status for a booking)|
|BookingMoved|6|Appointment is a booking that has been moved since it was seen by the invitee|
|BookingSeen|7|Appointment is a booking and has been seen, but neither accepted nor rejected|
|BookingMovedSeen|8|Appointment is a booking that has been moved. The movement has been seen but neither accepted nor rejected|
|BookingDeclined|9|Appointment is a booking that has been seen and declined|
|BookingDeleted|10|Status of "child" appointment whose "mother" has been deleted (the meeting is cancelled)|
|Assignment|11|You are assigned this appointment (initial status, like Booking(5) )|
|AssignmentSeen|12|You have seen the assignment, but not yet declined or accepted it|
|AssignmentDeclined|13|You have declined the appointment assigned to you|

## Usage

* [appointment](../appointment.md).status - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
