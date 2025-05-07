---
uid: api-rest-videomeeting-delete
title: Delete a VideoMeeting
description: Delete a VideoMeeting
keywords: flow, VideoMeeting, Delete
author: Eivind Fasting
date: 07.05.2024
version: 10.5.5
topic: howto
audience: api
audience_tooltip: SuperOffice APIs and database
---

# Delete a VideoMeeting

The **DeleteVideoMeetingReservation Agent** REST endpoint removes/deletes a VideoMeeting reservation.

> [!NOTE]
> A user creating a VideoMeeting reservation needs to be configured[1] for VideoMeetings, and therefore a SystemUsers is *NOT* allowed to create or delete a VideoMeeting.

## Request

```http
POST https://{{env}}.superoffice.com/{{tenant}}/v1/Agents/Appointment/DeleteVideoMeetingReservation HTTP/1.1
Authorization: Bearer {{access_token}}
Content-Type: application/json

{
  "VideoMeetingId": "f1098b4e-e506-4fb..."
}
```

## Response

`HTTP/1.1 204 No Content`

Additional documentation can be found in the [DeleteVideoMeetingReservation Agent reference][2].

<!-- Referenced links -->
[1]: ../../../../admin/preferences/learn/video-meetings/configure-video-meetings.md
[2]: ../../../reference/restful/agent/Appointment_Agent/v1AppointmentAgent_DeleteVideoMeetingReservation.md
