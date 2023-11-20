---
title: PUT Project/DuplicateRules
uid: v1ProjectEntity_SetDuplicateRulesStatus
generated: true
---

# PUT Project/DuplicateRules

```http
PUT /api/v1/Project/DuplicateRules
```

Set which duplicate rules should be active or not








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: rules 

Duplicate rules to update active status for 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | String | Identifying name for rule |
| DisplayName | String | Short name of rule to display to user |
| DisplayTooltip | String | Description of the rule |
| IsActive | Boolean | Indicating if a rule is current active, and should included in the duplicate detection |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
PUT /api/v1/Project/DuplicateRules
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Crist-Kovacek",
    "DisplayName": "Powlowski, Douglas and D'Amore",
    "DisplayTooltip": "molestias",
    "IsActive": true
  },
  {
    "Name": "Crist-Kovacek",
    "DisplayName": "Powlowski, Douglas and D'Amore",
    "DisplayTooltip": "molestias",
    "IsActive": true
  }
]
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```