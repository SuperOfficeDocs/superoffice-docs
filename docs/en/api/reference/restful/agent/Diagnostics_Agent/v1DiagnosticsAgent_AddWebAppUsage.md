---
title: POST Agents/Diagnostics/AddWebAppUsage
uid: v1DiagnosticsAgent_AddWebAppUsage
generated: true
content_type: reference
---

# POST Agents/Diagnostics/AddWebAppUsage

```http
POST /api/v1/Agents/Diagnostics/AddWebAppUsage
```

Adds WebApp usage to existing log


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Diagnostics/AddWebAppUsage?$select=name,department,category/id
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

WebAppUsages 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WebAppUsages | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Diagnostics/AddWebAppUsage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "WebAppUsages": [
    {
      "WebAppUsageId": 889,
      "AssocId": 505,
      "Timestamp": "2000-05-02T03:40:46.5780122+02:00",
      "ViewState": "enim",
      "AggregateCount": 211,
      "AggregateBin": 848,
      "Version": 292
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```