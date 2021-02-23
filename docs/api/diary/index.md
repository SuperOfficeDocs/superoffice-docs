---
title: diary      
description: Diary
author: {github-id}             # Your GitHub alias.
keywords:
---

# Diary

Appointments are the foundation of the SuperOffice diary.

## Create appointments

You can create an appointment at multiple levels of NetServer:

* [Create an Appointment entity][1]
* [Create an Appointment entity through an entity][2]
* [Create an Appointment entity through an entity collection][3]
* [Create an Appointment row][4]
* [Create an Appointment through row collection (Rows)][5]
* [Create an Appointment through OSQL][6]

## Appointment owner

`Associate` acts as the owner of the appointment. If you don't assign an associate to the `Associate` property of the appointment, the current user will become the owner of the appointment and only one row will be added to the `appointment` table when the appointment is saved.

<!-- Referenced links -->
[1]: create-apt-entity.md
[2]: create-apt-entity-in-entity.md
[3]: create-apt-entity-in-collection.md
[4]: create-apt-row.md
[5]: create-apt-rows.md
[6]: create-apt-osql.md
