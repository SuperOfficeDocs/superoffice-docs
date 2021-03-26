---
title: POST Agents/Saint/SaveSaintConfiguration
id: v1SaintAgent_SaveSaintConfiguration
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 227,
  "Enabled": true,
  "Period1": 495,
  "Period2": 575,
  "Period3": 329,
  "GenerationStart": "2015-05-02T16:48:30.5019427+02:00",
  "GenerationEnd": "2004-07-08T16:48:30.5019427+02:00",
  "RowsGenerated": 299
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 46,
  "Enabled": true,
  "Period1": 806,
  "Period2": 175,
  "Period3": 127,
  "GenerationStart": "2011-03-11T16:48:30.5029399+01:00",
  "GenerationEnd": "2010-01-21T16:48:30.5029399+01:00",
  "RowsGenerated": 607,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "seize enterprise methodologies"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 725
    }
  }
}
```