---
title: PUT CopilotDataSource/{id}
uid: v1CopilotDataSourceEntity_PutCopilotDataSourceEntity
generated: true
content_type: reference
---

# PUT CopilotDataSource/{id}

```http
PUT /api/v1/CopilotDataSource/{id}
```

Updates the existing CopilotDataSourceEntity


NsApiSlow threshold: 1000 ms.


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The CopilotDataSourceEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/CopilotDataSource/{id}?$select=name,department,category/id
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

The CopilotDataSourceEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopilotDataSourceId | Integer | Primary key |
| CopilotDataSourceType | String | Type of copilot data source |
| CopilotId | Integer | The associated copilot |
| Description | String | Description of data source |
| Name | String | Name of data source |
| Settings | Array | Collection of data source settings |

## Response:

CopilotDataSourceEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | CopilotDataSourceEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: CopilotDataSourceEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopilotDataSourceId | int32 | Primary key |
| CopilotDataSourceType | string | Type of copilot data source |
| CopilotId | int32 | The associated copilot |
| Description | string | Description of data source |
| Name | string | Name of data source |
| Settings | array | Collection of data source settings |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

[!include[sample request](../../samples/rest/request/v1CopilotDataSourceEntity_PutCopilotDataSourceEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CopilotDataSourceEntity_PutCopilotDataSourceEntity.md)]