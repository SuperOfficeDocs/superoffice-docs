---
uid: api-rest-videomeeting-delete
title: Delete a video meeting
description: Delete a video meeting
keywords: Video meeting, Delete
author: Eivind Fasting
date: 05.08.2024
version: 10.5.5
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/api/netserver/web-services/howto/diary/rest-delete-videomeeting
---

# Delete a video meeting

The **DeleteVideoMeetingReservation Agent** REST endpoint removes/deletes a video meeting reservation.

> [!NOTE]
> A user creating a video meeting needs to be [configured][1], and therefore a SystemUsers is *NOT* allowed to create or delete a video meeting.

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
[1]: ../../../../../../integrations/video-meetings/howto/connect-provider.md
[2]: ../../../reference/restful/agent/Appointment_Agent/v1AppointmentAgent_DeleteVideoMeetingReservation.md
