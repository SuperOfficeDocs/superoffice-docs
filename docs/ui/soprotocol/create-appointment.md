---
title: sop_create_appointment
description: How to create a new appointment with SoProtocol
author: Tony Yates
so.date: 06.24.2016
keywords: soprotocol
so.topic: howto
so.client: web
so.envir: onsite
---

# How to create a new appointment with SoProtocol

To create a new appointment in SuperOffice the user may either click **File – New - Appointment** or use the appointment button. The user can directly open it on the same browser by using the following SoProtocol.

> [!NOTE]
> `http://localhost/SuperOfficeWeb/` is just an example. Your local SuperOffice installation may be in a different location.

`http://localhost/SuperOfficeWeb/default.aspx?appointment[mode=edit&new=true]?appointment_id=0`

![11][img1]

We can select the start, end times, and the description regarding an appointment. We can also enter the details if needed and there is a special feature to invite others to the same appointment.

Here is a more complete SO Protocol string for creating an appointment:

```html
appointment[dialogwinname=appointment]?appointment_id=0 
&appointment_type=1&doby=2009.08.14&length=undefined 
&enddate=2009.08.14&calendarassociate_id=316&usedefaulttime=true
```

For opening an existing appointment, we don’t have to specify so much in the URL:

```html
appointment[dialogwinname=appointment]?appointment_id=2659419
```

Just the appointment ID, which tells us where to get the rest of the information in the database.

<!-- **See Also:** AppointmentEntity -->

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image011.jpg
