---
title: diary      
description: Diary
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept
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
* [Create an Appointment through raw SQL][7]

## Appointment owner

`Associate` acts as the owner of the appointment. If you don't assign an associate to the `Associate` property of the appointment, the current user will become the owner of the appointment and only one row will be added to the `appointment` table when the appointment is saved.

<!-- Referenced links -->
[1]: entity/create-apt-entity.md
[2]: entity/create-apt-entity-in-entity.md
[3]: entity/create-apt-entity-in-collection.md
[4]: row/create-apt-row.md
[5]: row/create-apt-rows.md
[6]: osql/create-apt-osql.md
[7]: sql/create-apt-sql.md
