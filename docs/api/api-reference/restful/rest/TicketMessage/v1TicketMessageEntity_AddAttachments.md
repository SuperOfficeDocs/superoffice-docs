---
title: POST TicketMessage/{id}/Attachment
id: v1TicketMessageEntity_AddAttachments
---

# POST TicketMessage/{id}/Attachment

```http
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Attachment
```

Connect existing attachments with this TicketMessage.

Can connect multiple attachments




| Path Part | Type | Description |
|-----------|------|-------------|
| ticketMessageEntityId | int32 | The id of the ticket message to connect the attachments to **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: attachmentIds  

An array of attachments to connect to this TicketMessage 



## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |