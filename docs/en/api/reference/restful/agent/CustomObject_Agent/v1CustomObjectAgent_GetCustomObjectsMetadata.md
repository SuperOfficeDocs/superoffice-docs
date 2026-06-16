---
title: POST Agents/CustomObject/GetCustomObjectsMetadata
uid: v1CustomObjectAgent_GetCustomObjectsMetadata
generated: true
content_type: reference
---

# POST Agents/CustomObject/GetCustomObjectsMetadata

```http
POST /api/v1/Agents/CustomObject/GetCustomObjectsMetadata
```

Returns bootstrap metadata for all Custom Object tables.


NsApiSlow threshold: 5000 ms.


## Experimental: ## The CustomObject agent is experimental, subject to change, and not intended for partners.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomObject/GetCustomObjectsMetadata?$select=name,department,category/id
```


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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | User-visible name of the Custom Object. |
| TableName | string | Database table name, e.g. 'y_equipment'. |
| IconHint | string | Icon hint string for the UI. |
| FlagHideId | bool | True if the primary key field should be hidden in the UI. |
| FlagHidden | bool | True if the Custom Object is hidden from the navigator. |
| FlagShowInFind | bool | True if the Custom Object should appear in the Find dialog. |
| FlagShowInNavigator | bool | True if the Custom Object should appear in the navigator. |
| Relations | array | Relations to other entities. |
| HasWebPanels | bool | True if the Custom Object has web panel archives configured. |

## Sample request

[!include[sample request](../../samples/agent/request/v1CustomObjectAgent_GetCustomObjectsMetadata.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1CustomObjectAgent_GetCustomObjectsMetadata.md)]