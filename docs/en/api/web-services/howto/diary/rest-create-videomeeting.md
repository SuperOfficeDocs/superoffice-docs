---
uid: api-rest-videomeeting-create
title: Create a VideoMeeting
description: Create a VideoMeeting
keywords: flow, VideoMeeting, Create
author: Eivind Fasting
date: 07.05.2024
version: 10.5.5
topic: howto
audience: api
audience_tooltip: SuperOffice APIs and database
---

# Create a VideoMeeting

The **CreateVideoMeetingReservation Agent** REST endpoint returns a VideoMeeting Reservation.

> [!NOTE]
> A user creating a VideoMeeting reservation needs to be configured[1] for VideoMeetings, and therefore a SystemUsers is *NOT* allowed to create or delete a VideoMeeting.

## Request

```http
POST https://{{env}}.superoffice.com/{{tenant}}/v1/Agents/Appointment/CreateVideoMeetingReservation HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json
```

## Response

```json
{
  "VideoMeetingId": "c0791ad9-6562-45...",
  "VideoMeetingUrl": "https://foo.meetings-sod.superoffice.com/join/c0791ad9-6562-45...",
  "TableRight": null,
  "FieldProperties": {}
}
```

### Key flow properties

| Property | Description |
|---|---|
| VideoMeetingId | Unique identifier for the reservation |
| VideoMeetingUrl | Join MeetingUrl, normally stored on the appointment. |

Additional documentation can be found in the [CreateVideoMeetingReservation Agent reference][2].

<!-- Referenced links -->
[1]: ../../../../admin/preferences/learn/video-meetings/configure-video-meetings.md
[2]: ../../../reference/restful/agent/Appointment_Agent/v1AppointmentAgent_CreateVideoMeetingReservation.md
