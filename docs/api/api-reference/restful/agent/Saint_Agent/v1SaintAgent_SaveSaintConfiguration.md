---
title: SaveSaintConfiguration
id: v1SaintAgent_SaveSaintConfiguration
---

# SaveSaintConfiguration

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
| OwnerTable | int32 | The table that is the owning entity |
| Enabled | bool | On/off switch for Saint functionality for this entity |
| Period1 | int32 | Length of the first counter period |
| Period2 | int32 | Length of the second counter period |
| Period3 | int32 | Length of the third counter period |
| GenerationStart | date-time | When was the last regeneration started |
| GenerationEnd | date-time | When was the last regeneration finished |
| RowsGenerated | int32 | Number of CounterValue rows generated for this entity |


## Response: object

Definition of the three perionds for status monitors and some other settings per saint entity



Carrier object for SaintConfiguration.
Services for the SaintConfiguration Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ISaintAgent">Saint Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Saint/SaveSaintConfiguration
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 295,
  "Enabled": false,
  "Period1": 851,
  "Period2": 575,
  "Period3": 479,
  "GenerationStart": "2017-08-23T14:58:05.1046294+02:00",
  "GenerationEnd": "2016-03-04T14:58:05.1046294+01:00",
  "RowsGenerated": 135
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 801,
  "Enabled": false,
  "Period1": 991,
  "Period2": 907,
  "Period3": 787,
  "GenerationStart": "1994-10-16T14:58:05.1046294+02:00",
  "GenerationEnd": "2015-11-07T14:58:05.1046294+01:00",
  "RowsGenerated": 507,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "benchmark B2C technologies"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 72
    }
  }
}
```