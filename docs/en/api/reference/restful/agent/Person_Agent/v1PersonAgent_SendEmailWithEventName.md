---
title: POST Agents/Person/SendEmailWithEventName
uid: v1PersonAgent_SendEmailWithEventName
generated: true
---

# POST Agents/Person/SendEmailWithEventName

```http
POST /api/v1/Agents/Person/SendEmailWithEventName
```

Inserts into outbox an email with specified details and event name.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/SendEmailWithEventName?$select=name,department,category/id
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

From, To, Subject, PlainBody, HtmlBody, AttachmentIds, EventName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| From | String |  |
| To | String |  |
| Subject | String |  |
| PlainBody | String |  |
| HtmlBody | String |  |
| AttachmentIds | Array |  |
| EventName | String |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Person/SendEmailWithEventName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "From": "numquam",
  "To": "molestias",
  "Subject": "ipsam",
  "PlainBody": "sapiente",
  "HtmlBody": "quia",
  "AttachmentIds": [
    902,
    672
  ],
  "EventName": "Barrows LLC"
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```