---
title: GET CustomObjectDefinition/{definitionName}/Screen
uid: v1CustomObjectDefinition_HasScreenChooser
generated: true
content_type: reference
---

# GET CustomObjectDefinition/{definitionName}/Screen

```http
GET /api/v1/CustomObjectDefinition/{definitionName}/Screen
```

Returns true if a screen chooser is configured for the given Custom Object Definition and mode.






| Path Part | Type | Description |
|-----------|------|-------------|
| definitionName | string | Database table name of the Custom Object Definition. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| edit | bool | **Required** True to check for a custom edit screen; false to check for a custom view screen. |

```http
GET /api/v1/CustomObjectDefinition/{definitionName}/Screen?edit=False
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


## Response:bool

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: bool


## Sample request

[!include[sample request](../../samples/rest/request/v1CustomObjectDefinition_HasScreenChooser.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CustomObjectDefinition_HasScreenChooser.md)]