---
title: POST Agents/Saint/SaveSaintConfiguration
uid: v1SaintAgent_SaveSaintConfiguration
generated: true
---

# POST Agents/Saint/SaveSaintConfiguration

```http
POST /api/v1/Agents/Saint/SaveSaintConfiguration
```

Updates the existing SaintConfiguration or creates a new SaintConfiguration if the id parameter is empty








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

The SaintConfiguration to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| OwnerTable | Integer | The table that is the owning entity |
| Enabled | Boolean | On/off switch for Saint functionality for this entity |
| Period1 | Integer | Length of the first counter period |
| Period2 | Integer | Length of the second counter period |
| Period3 | Integer | Length of the third counter period |
| GenerationStart | String | When was the last regeneration started |
| GenerationEnd | String | When was the last regeneration finished |
| RowsGenerated | Integer | Number of CounterValue rows generated for this entity |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SaintConfiguration

| Property Name | Type |  Description |
|----------------|------|--------------|
| OwnerTable | int32 | The table that is the owning entity |
| Enabled | bool | On/off switch for Saint functionality for this entity |
| Period1 | int32 | Length of the first counter period |
| Period2 | int32 | Length of the second counter period |
| Period3 | int32 | Length of the third counter period |
| GenerationStart | date-time | When was the last regeneration started |
| GenerationEnd | date-time | When was the last regeneration finished |
| RowsGenerated | int32 | Number of CounterValue rows generated for this entity |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Saint/SaveSaintConfiguration
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 363,
  "Enabled": true,
  "Period1": 573,
  "Period2": 901,
  "Period3": 529,
  "GenerationStart": "2006-12-02T11:06:35.2708148+01:00",
  "GenerationEnd": "2012-07-07T11:06:35.2708148+02:00",
  "RowsGenerated": 12
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 84,
  "Enabled": false,
  "Period1": 519,
  "Period2": 307,
  "Period3": 722,
  "GenerationStart": "2022-03-11T11:06:35.2708148+01:00",
  "GenerationEnd": "2009-05-19T11:06:35.2708148+02:00",
  "RowsGenerated": 688,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 657
    }
  }
}
```