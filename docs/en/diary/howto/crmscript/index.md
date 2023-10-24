---
uid: crmscript_followups
title: Calendar and todo list
description: Working with the SuperOffice diary and follow-ups in CRMScript.
author: Bergfrid Skaara Dias
so.date: 03.21.2022
keywords: CRMScript, calendar, diary, appointment, follow-up
so.topic: concept
---

# Calendar and todo list

> [!NOTE]
> It is important to understand the distinction between **activities** and **follow-ups**.
>
> When you get data from the [appointment table][4] or use the CRMScript [NSAppointment class][5], pay attention to the **type** field.

## Follow-ups

* [Create appointment][6]
* [Get appointment][7]
* [Update and delete appointment][8]
* [Book a resource][9]
* [Register incoming call][15]
* [Plan outgoing call][16]
* [Working with to-dos][17]

## Recurrence

* [View recurrence info of a follow-up][10]
* [Get follow-ups belonging to a series][11]
* [Create repeating follow-ups][12]
* [Edit repeating follow-ups][13]
* [Stop repeating follow-ups][14]

## Meeting invitations

**The host:**

* [Create invitation][1]
* [Track responses][2]

**The attendee:**

* [Show follow-ups you are invited to][3]
* [Accept invitation][3]

<!-- Referenced links -->
[1]: create-invitation.md
[2]: track-responses.md
[3]: accept-invitation.md
[4]: ../../../database/tables/appointment.md
[5]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSAppointment.yml
[6]: create-appointment.md
[7]: get-appointment.md
[8]: update-appointment.md
[9]: book-resource.md
[10]: get-recurrence-info.md
[11]: get-appointments-in-series.md
[12]: create-recurring-appointment.md
[13]: update-recurrence.md
[14]: stop-recurrence.md
[15]: register-incoming-call.md
[16]: plan-outgoing-call.md
[17]: task.md
