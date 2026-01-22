---
title: POST Agents/AI/SaveCopilotDataSourceEntity
uid: v1AIAgent_SaveCopilotDataSourceEntity
generated: true
content_type: reference
---

# POST Agents/AI/SaveCopilotDataSourceEntity

```http
POST /api/v1/Agents/AI/SaveCopilotDataSourceEntity
```

Updates the existing CopilotDataSourceEntity or creates a new CopilotDataSourceEntity if the id parameter is 0.


NsApiSlow threshold: 1000 ms.


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners.







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

## Request Body: copilotDataSourceEntity 

The CopilotDataSourceEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopilotDataSourceId | Integer | Primary key |
| CopilotDataSourceType | String | Type of copilot data source |
| CopilotId | Integer | The associated copilot |
| Description | String | Description of data source |
| Name | String | Name of data source |
| Settings | Array | Collection of data source settings - each setting has key + value |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CopilotDataSourceEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopilotDataSourceId | int32 | Primary key |
| CopilotDataSourceType | string | Type of copilot data source |
| CopilotId | int32 | The associated copilot |
| Description | string | Description of data source |
| Name | string | Name of data source |
| Settings | array | Collection of data source settings - each setting has key + value |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1AIAgent_SaveCopilotDataSourceEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1AIAgent_SaveCopilotDataSourceEntity.md)]