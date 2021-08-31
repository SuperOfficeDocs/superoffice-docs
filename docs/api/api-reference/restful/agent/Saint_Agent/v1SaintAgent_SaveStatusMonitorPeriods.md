---
title: SaveStatusMonitorPeriods
id: v1SaintAgent_SaveStatusMonitorPeriods
---

# SaveStatusMonitorPeriods

```http
POST /api/v1/Agents/Saint/SaveStatusMonitorPeriods
```

Updates the existing StatusMonitorPeriods or creates a new StatusMonitorPeriods if the id parameter is empty








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

The StatusMonitorPeriods to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Period1 | int32 | Days in the first period |
| Period2 | int32 | Days in the second period |
| Period3 | int32 | Days in the third period |


## Response: object

Obsolete, use SaintConfiguration carrier and methods instead. Was:Definition of the three perionds for status monitors



Carrier object for StatusMonitorPeriods.
Services for the StatusMonitorPeriods Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ISaintAgent">Saint Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Period1 | int32 | Days in the first period |
| Period2 | int32 | Days in the second period |
| Period3 | int32 | Days in the third period |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Saint/SaveStatusMonitorPeriods
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Period1": 831,
  "Period2": 566,
  "Period3": 6
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Period1": 431,
  "Period2": 746,
  "Period3": 884,
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
      "FieldLength": 386
    }
  }
}
```