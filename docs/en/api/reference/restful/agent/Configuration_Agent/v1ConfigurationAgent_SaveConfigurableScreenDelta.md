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
  "ConfigurableScreenDeltaId": 923,
  "Name": "Tremblay-McDermott",
  "Description": "Expanded zero defect protocol",
  "DeltaJson": "autem",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "voluptatem",
  "UpdatedDate": "2013-05-03T14:23:46.0480845+02:00",
  "CreatedDate": "2009-04-26T14:23:46.0480845+02:00",
  "UpdatedBy": null,
  "CreatedBy": null,
  "AppliesToIds": [
    776,
    361
  ],
  "AppliesToKey": "dolorum"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 571,
  "Name": "O'Connell LLC",
  "Description": "Multi-lateral directional algorithm",
  "DeltaJson": "similique",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "praesentium",
  "UpdatedDate": "2011-12-11T14:23:46.0480845+01:00",
  "CreatedDate": "2019-02-25T14:23:46.0480845+01:00",
  "UpdatedBy": null,
  "CreatedBy": null,
  "AppliesToIds": [
    717,
    419
  ],
  "AppliesToKey": "voluptatem",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 99
    }
  }
}
```