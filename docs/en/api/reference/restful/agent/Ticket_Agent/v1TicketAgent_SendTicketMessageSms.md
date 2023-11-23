---
title: POST Agents/Ticket/SendTicketMessageSms
uid: v1TicketAgent_SendTicketMessageSms
generated: true
---

# POST Agents/Ticket/SendTicketMessageSms

```http
POST /api/v1/Agents/Ticket/SendTicketMessageSms
```

Send a message to recipients by sms







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SendTicketMessageSms?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

TicketMessageEntityId, ReplyTemplateId, Sms 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketMessageEntityId | Integer |  |
| ReplyTemplateId | Integer |  |
| Sms | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Ticket/SendTicketMessageSms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketMessageEntityId": 705,
  "ReplyTemplateId": 310,
  "Sms": [
    "aut",
    "voluptate"
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```