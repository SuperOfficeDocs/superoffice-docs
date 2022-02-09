---
title: PUT Project/DuplicateRules
id: v1ProjectEntity_SetDuplicateRulesStatus
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


| Response | Description |
|----------------|-------------|
| 204 | No Content |