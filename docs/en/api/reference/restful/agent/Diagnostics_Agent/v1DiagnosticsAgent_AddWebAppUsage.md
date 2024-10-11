---
title: POST Agents/Diagnostics/AddWebAppUsage
uid: v1DiagnosticsAgent_AddWebAppUsage
generated: true
---

# POST Agents/Diagnostics/AddWebAppUsage

```http
POST /api/v1/Agents/Diagnostics/AddWebAppUsage
```

Adds WebApp usage to existing log







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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebAppUsages": [
    {
      "WebAppUsageId": 947,
      "AssocId": 218,
      "Timestamp": "2002-05-03T03:44:52.417768+02:00",
      "ViewState": "quas",
      "AggregateCount": 201,
      "AggregateBin": 921,
      "Version": 301
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