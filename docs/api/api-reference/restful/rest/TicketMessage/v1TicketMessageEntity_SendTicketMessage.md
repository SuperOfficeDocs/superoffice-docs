---
title: POST TicketMessage/{id}/Send
id: v1TicketMessageEntity_SendTicketMessage
---

# POST TicketMessage/{id}/Send

```http
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send
```

Send a message to recipients, e.

g. by email or sms




| Path Part | Type | Description |
|-----------|------|-------------|
| ticketMessageEntityId | int32 | The id of the ticket message to send **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| to | array | **Required** The To-recipients. Each recipient must be in correct format |
| cc | array | **Required** The Cc-recipients. Each recipient must be in correct format |
| bcc | array | **Required** The Bcc-recipients. Each recipient must be in correct format |
| subject | string | **Required** The subject |
| replyTemplateId | int32 | **Required** Optional ID of reply template to merge message with. &lt;= 0 to skip. |
| gdprSource | string | **Required** Optional GdprSource string which will be stored for newly created Persons. Blank value will give Gdpr source: API. |

```http
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?to=illum,quidem
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?cc=aperiam,non
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?bcc=consequatur,et
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?subject=magni
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?replyTemplateId=838
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?gdprSource=iste
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |