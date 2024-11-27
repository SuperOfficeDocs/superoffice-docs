---
title: POST Agents/Configuration/SaveConfigurableScreenDelta
uid: v1ConfigurationAgent_SaveConfigurableScreenDelta
generated: true
---

# POST Agents/Configuration/SaveConfigurableScreenDelta

```http
POST /api/v1/Agents/Configuration/SaveConfigurableScreenDelta
```

Updates the existing ConfigurableScreenDelta or creates a new ConfigurableScreenDelta if the id parameter is empty








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

The ConfigurableScreenDelta to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConfigurableScreenDeltaId | Integer |  |
| Name | String |  |
| Description | String |  |
| DeltaJson | String |  |
| DeltaType | String |  |
| DeltaState | String |  |
| RecipeId | String |  |
| UpdatedDate | String |  |
| CreatedDate | String |  |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| AppliesToIds | Array |  |
| AppliesToKey | String |  |

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
POST /api/v1/Agents/Configuration/SaveConfigurableScreenDelta
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 932,
  "Name": "Haag-Emard",
  "Description": "Re-contextualized intermediate database",
  "DeltaJson": "suscipit",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "est",
  "UpdatedDate": "2022-01-03T14:45:05.0221142+01:00",
  "CreatedDate": "2013-01-21T14:45:05.0221142+01:00",
  "UpdatedBy": null,
  "CreatedBy": null,
  "AppliesToIds": [
    233,
    397
  ],
  "AppliesToKey": "odio"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 752,
  "Name": "Ruecker, Veum and Reichert",
  "Description": "Integrated mobile leverage",
  "DeltaJson": "et",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "neque",
  "UpdatedDate": "2014-01-30T14:45:05.0221142+01:00",
  "CreatedDate": "1998-06-26T14:45:05.0221142+02:00",
  "UpdatedBy": null,
  "CreatedBy": null,
  "AppliesToIds": [
    960,
    91
  ],
  "AppliesToKey": "aspernatur",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 950
    }
  }
}
```