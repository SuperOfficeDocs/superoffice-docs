---
title: POST Agents/Saint/CreateDefaultSaintConfiguration
id: v1SaintAgent_CreateDefaultSaintConfiguration
---

# POST Agents/Saint/CreateDefaultSaintConfiguration

```http
POST /api/v1/Agents/Saint/CreateDefaultSaintConfiguration
```

Set default values into a new SaintConfiguration.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Saint/CreateDefaultSaintConfiguration
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 652,
  "Enabled": true,
  "Period1": 229,
  "Period2": 390,
  "Period3": 241,
  "GenerationStart": "2006-07-12T16:48:30.5019427+02:00",
  "GenerationEnd": "2001-10-19T16:48:30.5019427+02:00",
  "RowsGenerated": 482,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 320
    }
  }
}
```