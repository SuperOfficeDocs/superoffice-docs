---
title: POST TicketMessage/{id}/Send
uid: v1TicketMessageEntity_SendTicketMessage
generated: true
---

# POST TicketMessage/{id}/Send

```http
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send
```

Send a message to recipients by email






| Path Part | Type | Description |
|-----------|------|-------------|
| ticketMessageEntityId | int32 | The id of the ticket message to send **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| to | array | **Required** The To-recipients. Each recipient must be in correct format |
| cc | array | **Required** The Cc-recipients. Each recipient must be in correct format |
| bcc | array | **Required** The Bcc-recipients. Each recipient must be in correct format |
| subject | string |  The subject |
| replyTemplateId | int32 |  Optional ID of reply template to merge message with. &lt;= 0 to skip. |
| gdprSource | string |  Obsolete |

```http
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?to=labore,eos
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?cc=ut,ut
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?bcc=tenetur,rerum
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?subject=ducimus
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?replyTemplateId=20
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send?gdprSource=provident
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/TicketMessage/{ticketMessageEntityId}/Send
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```