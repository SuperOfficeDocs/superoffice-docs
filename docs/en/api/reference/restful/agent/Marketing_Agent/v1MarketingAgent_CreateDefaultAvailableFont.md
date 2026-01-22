---
title: POST Agents/Marketing/CreateDefaultAvailableFont
uid: v1MarketingAgent_CreateDefaultAvailableFont
generated: true
content_type: reference
---

# POST Agents/Marketing/CreateDefaultAvailableFont

```http
POST /api/v1/Agents/Marketing/CreateDefaultAvailableFont
```

Create an return an empty font


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Marketing/CreateDefaultAvailableFont?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: AvailableFont

| Property Name | Type |  Description |
|----------------|------|--------------|
| AvailableFontsId | int32 | Primary key |
| DisplayName | string | The display name of the font |
| FontFamily | string | The font family name |
| CssPath | string | The path to the CSS for the font |
| Rank | int32 | The rank of the font in the list |
| Deleted | bool | True if font is deleted from available fonts |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1MarketingAgent_CreateDefaultAvailableFont.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1MarketingAgent_CreateDefaultAvailableFont.md)]