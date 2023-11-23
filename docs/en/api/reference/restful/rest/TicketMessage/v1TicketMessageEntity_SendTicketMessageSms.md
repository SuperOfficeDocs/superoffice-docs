---
title: POST TicketMessage/{id}/SendSms
uid: v1TicketMessageEntity_SendTicketMessageSms
generated: true
---

# POST TicketMessage/{id}/SendSms

```http
POST /api/v1/TicketMessage/{ticketMessageEntityId}/SendSms
```

Send a message to recipients by sms






| Path Part | Type | Description |
|-----------|------|-------------|
| ticketMessageEntityId | int32 | The id of the ticket message to send **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| sms | array | **Required** The Sms-recipients. Each recipient must be in correct format |
| replyTemplateId | int32 |  Optional ID of reply template to merge message with. &lt;= 0 to skip. |

```http
POST /api/v1/TicketMessage/{ticketMessageEntityId}/SendSms?sms=cumque,eos
POST /api/v1/TicketMessage/{ticketMessageEntityId}/SendSms?replyTemplateId=76
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
POST /api/v1/TicketMessage/{ticketMessageEntityId}/SendSms
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