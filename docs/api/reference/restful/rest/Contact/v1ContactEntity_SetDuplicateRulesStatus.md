---
title: PUT Contact/DuplicateRules
uid: v1ContactEntity_SetDuplicateRulesStatus
---

# PUT Contact/DuplicateRules

```http
PUT /api/v1/Contact/DuplicateRules
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
| Name | string | Identifying name for rule |
| DisplayName | string | Short name of rule to display to user |
| DisplayTooltip | string | Description of the rule |
| IsActive | bool | Indicating if a rule is current active, and should included in the duplicate detection |

## Response

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

Response body:

## Sample request

```http!
PUT /api/v1/Contact/DuplicateRules
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Lockman Inc and Sons",
    "DisplayName": "Powlowski, Quitzon and Streich",
    "DisplayTooltip": "dolorum",
    "IsActive": false
  },
  {
    "Name": "Lockman Inc and Sons",
    "DisplayName": "Powlowski, Quitzon and Streich",
    "DisplayTooltip": "dolorum",
    "IsActive": false
  }
]
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
