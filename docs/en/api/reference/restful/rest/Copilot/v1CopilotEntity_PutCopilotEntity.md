---
title: PUT Copilot/{id}
uid: v1CopilotEntity_PutCopilotEntity
generated: true
content_type: reference
---

# PUT Copilot/{id}

```http
PUT /api/v1/Copilot/{id}
```

Updates the existing CopilotEntity


NsApiSlow threshold: 1000 ms.


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The CopilotEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Copilot/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The CopilotEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopilotId | Integer | Primary key |
| Name | String | The name of copilot |
| CopilotDataSources | Array | Data sources |

## Response:

CopilotEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | CopilotEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: CopilotEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopilotId | int32 | Primary key |
| Name | string | The name of copilot |
| CopilotDataSources | array | Data sources |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

[!include[sample request](../../samples/rest/request/v1CopilotEntity_PutCopilotEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CopilotEntity_PutCopilotEntity.md)]