---
title: GET Copilot/default
uid: v1CopilotEntity_DefaultCopilotEntity
generated: true
content_type: reference
---

# GET Copilot/default

```http
GET /api/v1/Copilot/default
```

Set default values into a new CopilotEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners. Calls the AI agent service CreateDefaultCopilotEntity.
NsApiSlow threshold: 1000 ms.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CopilotEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopilotId | int32 | Primary key |
| Name | string | The name of copilot |
| CopilotDataSources | array | Data sources |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/rest/request/v1CopilotEntity_DefaultCopilotEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CopilotEntity_DefaultCopilotEntity.md)]