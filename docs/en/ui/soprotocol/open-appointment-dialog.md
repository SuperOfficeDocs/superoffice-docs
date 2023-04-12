---
title: How to open the Appointment dialog
uid: sop_open_apt_dialog
description: How to open the appointment dialog
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to open the Appointment dialog

The following example shows how to open an Appointment dialog in the current context based on a given appointment\_id, "appointment\_id = 124". If the current context is displaying the company page, the appointment dialog will appear over the company page.

`www.example.com/Default.aspx?appointment?appointment_id=124`

![in-context][img1]

To view the appointment in the context of the diary, use SoProtocol to navigate to the diary page and then use the appointment_id to view the day where the appointment appears.

`www.example.com/Default.aspx?diary.main?appointment_id=124`

![diary-context][img3]

Use the \[dialog=stop\] parameter to open the appointment dialog in the whole window.

`www.example.com/Default.aspx?appointment[dialog=stop]?appointment_id=10`

![whole-window -screenshot][img2]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/appointment-default.png
[img2]: media/appointment-whole-window.png
[img3]: media/appointment-diary.png
