---
title: POST Agents/Diagnostics/ChangeLogSettings
uid: v1DiagnosticsAgent_ChangeLogSettings
generated: true
---

# POST Agents/Diagnostics/ChangeLogSettings

```http
POST /api/v1/Agents/Diagnostics/ChangeLogSettings
```

Change NetServer log settings.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Diagnostics/ChangeLogSettings?$select=name,department,category/id
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

LogWarning, LogInformation, LogSuccessAudit, LogFailureAudit, LogToEventLog, LogToSuperOffice, LogToFile, LogToTrace 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LogWarning | Boolean |  |
| LogInformation | Boolean |  |
| LogSuccessAudit | Boolean |  |
| LogFailureAudit | Boolean |  |
| LogToEventLog | Boolean |  |
| LogToSuperOffice | Boolean |  |
| LogToFile | Boolean |  |
| LogToTrace | Boolean |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Diagnostics/ChangeLogSettings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "LogWarning": true,
  "LogInformation": false,
  "LogSuccessAudit": true,
  "LogFailureAudit": false,
  "LogToEventLog": false,
  "LogToSuperOffice": false,
  "LogToFile": false,
  "LogToTrace": false
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```