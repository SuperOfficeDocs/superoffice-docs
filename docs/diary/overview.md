---
title: Diary
uid: diary_overview
description: Introduction to the diary and working with appointments.
author: Bergfrid Skaara Dias
so.date: 03.18.2022
keywords: diary, calendar, appointment, associate
so.topic: concept
---

# Diary

Appointments are the foundation of the SuperOffice diary.

![Diary screen -screenshot][img1]

## Appointment owner

[Associate][9] acts as the owner of the appointment. If you don't assign an associate to the `Associate` property of the appointment, the current user will become the owner of the appointment and only one row will be added to the [appointment][5] table when the appointment is saved.

## Follow-ups vs. other entities

When working with follow-ups, data will often intersect with the following entities:

* [company][1] (contact table)
* [contact][2] (person table)
* [project][4]
* [sale][3]

## See also

* [Recurring appointments][6]
* [Invitations][7]
* [Working with appointments in API][8]

<!-- Referenced links -->
[1]: ../company/index.yml
[2]: ../contact/index.yml
[3]: ../sale/index.yml
[4]: ../project/index.yml
[5]: ../database/tables/appointment.md
[6]: recurring-appointments.md
[7]: invitations.md
[8]: howto/index.md
[9]: ../contact/associate.md

<!-- Referenced images -->
[img1]: media/diary-screen.png
