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
| to | array | **Required** The To-recipients. Each recipient must be in correct format: e-mail address or phone number |
| cc | array | **Required** The Cc-recipients. Each recipient must be in correct format |
| bcc | array | **Required** The Bcc-recipients. Each recipient must be in correct format |
| subject | string |  The subject |
| replyTemplateId | int32 |  Optional ID of reply template to merge message with. &lt;= 0 to skip. |
| gdprSource | string |  Obsolete |

```http
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?to=esse,dolore
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?cc=repellat,dolorem
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?bcc=est,occaecati
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?subject=eius
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?replyTemplateId=324
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?gdprSource=et
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