---
uid: sop-open-appointment
title: Open appointment
description: Open appointment
keywords: soprotocol, appointment, open
author: Eivind Fasting
date: 11.26.2024
topic: howto
---

# Open appointment

The soprotocol should be on the format: `soprotocol:appointment.main?appointment_id={{id}}`

## How to open the appointment dialog

The following example shows how to open an Appointment dialog in the current context based on a given `appointment_id`: `appointment_id = 124`. If the current context is displaying the company page, the appointment dialog will appear over the company page.

`soprotocol:appointment.main?appointment_id=124`

![in-context -screenshot][img1]

To view the appointment in the context of the diary, use SoProtocol to navigate to the diary page and then use the appointment_id to view the day where the appointment appears.

`soprotocol:diary.main?appointment_id=124`

![diary-context -screenshot][img2]

<!-- Referenced images -->
[img1]: ../media/appointment-default.png
[img2]: ../media/appointment-diary.png
