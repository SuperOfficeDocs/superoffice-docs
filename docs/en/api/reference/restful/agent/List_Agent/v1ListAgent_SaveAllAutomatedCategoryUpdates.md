---
title: POST Agents/List/SaveAllAutomatedCategoryUpdates
uid: v1ListAgent_SaveAllAutomatedCategoryUpdates
generated: true
content_type: reference
---

# POST Agents/List/SaveAllAutomatedCategoryUpdates

```http
POST /api/v1/Agents/List/SaveAllAutomatedCategoryUpdates
```

Save the automated category update settings


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveAllAutomatedCategoryUpdates?$select=name,department,category/id
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

## Request Body: request 

Settings 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Settings | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Enabled | bool | Indicates whether the automated category update is enabled for this trigger. |
| TriggerType | string | The type of change to trigger the auto update |
| UserConfirmation | bool | Whether to ask the user for confirmation before applying the autoupdate |
| DefaultCategory | int32 | The default category id to update to, and the actual new value if no user confirmation is needed |
| LeadstatusId | int32 | The leadstatus id to match on person, to trigger autoupdate of category |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1ListAgent_SaveAllAutomatedCategoryUpdates.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ListAgent_SaveAllAutomatedCategoryUpdates.md)]