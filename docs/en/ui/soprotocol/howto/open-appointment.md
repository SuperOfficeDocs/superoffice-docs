---
title: Open Appointment
uid: open-appointment
description: Open Appointment
author: Eivind Fasting
date: 11.26.2024
keywords: soprotocol, appointment, open
topic: howto
---

# Open Appointment

The soprotocol should be on the format: `soprotocol:appointment.main?appointment_id={{id}}`

## How to open the Appointment dialog

The following example shows how to open an Appointment dialog in the current context based on a given appointment\_id, "appointment\_id = 124". If the current context is displaying the company page, the appointment dialog will appear over the company page.

`soprotocol:appointment.main?appointment_id=124`

![in-context][img1]

To view the appointment in the context of the diary, use SoProtocol to navigate to the diary page and then use the appointment_id to view the day where the appointment appears.

`soprotocol:diary.main?appointment_id=124`

![diary-context][img2]

<!-- Referenced images -->
[img1]: ../media/appointment-default.png
[img2]: ../media/appointment-diary.png
