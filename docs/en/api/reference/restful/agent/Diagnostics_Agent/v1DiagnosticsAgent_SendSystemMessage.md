---
title: POST Agents/Diagnostics/SendSystemMessage
uid: v1DiagnosticsAgent_SendSystemMessage
generated: true
---

# POST Agents/Diagnostics/SendSystemMessage

```http
POST /api/v1/Agents/Diagnostics/SendSystemMessage
```

Adds a system message for a specific associate.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Diagnostics/SendSystemMessage?$select=name,department,category/id
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

SystemMessageId, AssociateId, MarkdownMessage, Expire, Type 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SystemMessageId | String |  |
| AssociateId | Integer |  |
| MarkdownMessage | String |  |
| Expire | String |  |
| Type | String |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Diagnostics/SendSystemMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SystemMessageId": "sint",
  "AssociateId": 360,
  "MarkdownMessage": "ipsam",
  "Expire": "2007-09-25T17:54:02.9452152+02:00",
  "Type": "Error"
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```