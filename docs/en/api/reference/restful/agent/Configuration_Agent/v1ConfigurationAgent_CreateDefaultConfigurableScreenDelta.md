---
title: POST Agents/Configuration/CreateDefaultConfigurableScreenDelta
uid: v1ConfigurationAgent_CreateDefaultConfigurableScreenDelta
generated: true
content_type: reference
---

# POST Agents/Configuration/CreateDefaultConfigurableScreenDelta

```http
POST /api/v1/Agents/Configuration/CreateDefaultConfigurableScreenDelta
```

Loading default values into a new ConfigurableScreenDelta.








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

### Response body: TimeZoneData

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConfigurableScreenDeltaId | int32 |  |
| Name | string |  |
| Description | string |  |
| DeltaJson | string |  |
| DeltaType | string |  |
| DeltaState | string |  |
| RecipeId | string |  |
| UpdatedDate | date-time |  |
| CreatedDate | date-time |  |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| AppliesToIds | array |  |
| AppliesToKey | string |  |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Configuration/CreateDefaultConfigurableScreenDelta
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 215,
  "Name": "Kunde Inc and Sons",
  "Description": "Team-oriented systematic database",
  "DeltaJson": "voluptate",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "ut",
  "UpdatedDate": "2022-05-26T03:46:54.4570178+02:00",
  "CreatedDate": "2003-07-08T03:46:54.4570178+02:00",
  "UpdatedBy": null,
  "CreatedBy": null,
  "AppliesToIds": [
    496,
    391
  ],
  "AppliesToKey": "aut",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 271
    }
  }
}
```