---
title: POST Agents/Saint/SaveStatusMonitorPeriods
uid: v1SaintAgent_SaveStatusMonitorPeriods
generated: true
---

# POST Agents/Saint/SaveStatusMonitorPeriods

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
| Period1 | Integer | Days in the first period |
| Period2 | Integer | Days in the second period |
| Period3 | Integer | Days in the third period |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: StatusMonitorPeriods

| Property Name | Type |  Description |
|----------------|------|--------------|
| Period1 | int32 | Days in the first period |
| Period2 | int32 | Days in the second period |
| Period3 | int32 | Days in the third period |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Saint/SaveStatusMonitorPeriods
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Period1": 135,
  "Period2": 509,
  "Period3": 268
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Period1": 688,
  "Period2": 950,
  "Period3": 159,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 340
    }
  }
}
```