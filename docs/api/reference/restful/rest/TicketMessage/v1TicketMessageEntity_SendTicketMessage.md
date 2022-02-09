---
title: POST TicketMessage/{id}/Send
id: v1TicketMessageEntity_SendTicketMessage
---

# POST TicketMessage/{id}/Send

```http
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send
```

Send a message to recipients, for example by email.




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
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?to=praesentium,aspernatur
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?cc=iste,impedit
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?bcc=reprehenderit,ratione
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?subject=sed
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?replyTemplateId=51
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?gdprSource=cum
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