---
uid: api-rest-videomeeting-create
title: Create a video meeting
description: Create a video meeting
keywords: Video meeting, Create
author: Eivind Fasting
date: 05.08.2024
version: 10.5.5
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/api/netserver/web-services/howto/diary/rest-create-videomeeting
---

# Create a video meeting

The **CreateVideoMeetingReservation Agent** REST endpoint returns a video meeting Reservation.

> [!NOTE]
> A user creating a video meeting needs to be [configured][1], and therefore a SystemUsers is *NOT* allowed to create or delete a video meeting.

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

### Key properties

| Property | Description |
|---|---|
| VideoMeetingId | Unique identifier for the reservation |
| VideoMeetingUrl | Join MeetingUrl, normally stored on the appointment. |

Additional documentation can be found in the [CreateVideoMeetingReservation Agent reference][2].

<!-- Referenced links -->
[1]: ../../../../../../integrations/video-meetings/howto/connect-provider.md
[2]: ../../../reference/restful/agent/Appointment_Agent/v1AppointmentAgent_CreateVideoMeetingReservation.md
