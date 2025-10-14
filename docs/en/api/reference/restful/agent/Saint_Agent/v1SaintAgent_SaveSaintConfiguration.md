---
title: POST Agents/Saint/SaveSaintConfiguration
uid: v1SaintAgent_SaveSaintConfiguration
generated: true
content_type: reference
---

# POST Agents/Saint/SaveSaintConfiguration

```http
POST /api/v1/Agents/Saint/SaveSaintConfiguration
```

Updates the existing SaintConfiguration or creates a new SaintConfiguration if the id parameter is 0.


NsApiSlow threshold: 1000 ms.







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

## Request Body: saintConfiguration 

The SaintConfiguration that is saved 

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 437,
  "Enabled": false,
  "Period1": 269,
  "Period2": 427,
  "Period3": 433,
  "GenerationStart": "2000-11-17T03:40:47.5942106+01:00",
  "GenerationEnd": "1999-08-02T03:40:47.5942106+02:00",
  "RowsGenerated": 26
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 311,
  "Enabled": true,
  "Period1": 782,
  "Period2": 491,
  "Period3": 750,
  "GenerationStart": "2014-01-29T03:40:47.5942106+01:00",
  "GenerationEnd": "2021-07-17T03:40:47.5942106+02:00",
  "RowsGenerated": 312,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 678
    }
  }
}
```