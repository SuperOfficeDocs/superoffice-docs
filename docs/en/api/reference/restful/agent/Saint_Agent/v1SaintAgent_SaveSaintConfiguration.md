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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 510,
  "Enabled": false,
  "Period1": 597,
  "Period2": 914,
  "Period3": 992,
  "GenerationStart": "2021-08-20T13:38:14.0615788+02:00",
  "GenerationEnd": "2000-03-04T13:38:14.0615788+01:00",
  "RowsGenerated": 767
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 986,
  "Enabled": false,
  "Period1": 939,
  "Period2": 194,
  "Period3": 232,
  "GenerationStart": "2001-12-04T13:38:14.0615788+01:00",
  "GenerationEnd": "1999-11-11T13:38:14.0615788+01:00",
  "RowsGenerated": 377,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 297
    }
  }
}
```