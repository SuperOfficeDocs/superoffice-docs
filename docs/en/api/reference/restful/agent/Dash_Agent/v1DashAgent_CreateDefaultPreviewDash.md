---
title: POST Agents/Dash/CreateDefaultPreviewDash
uid: v1DashAgent_CreateDefaultPreviewDash
generated: true
---

# POST Agents/Dash/CreateDefaultPreviewDash

```http
POST /api/v1/Agents/Dash/CreateDefaultPreviewDash
```

Set default values into a new PreviewDash.


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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PreviewDash

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | Primary key |
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| OwnedByFullName | string | Full name of dashboard owner |
| Registered | date-time | Registered when  in UTC. |
| Tiles | array | Dashboard tiles |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Dash/CreateDefaultPreviewDash
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 594,
  "Name": "Emmerich, Stamm and Ratke",
  "Description": "Organic exuding customer loyalty",
  "OwnedByFullName": "Marina Stephon Legros MD",
  "Registered": "2019-02-05T03:45:23.264209+01:00",
  "Tiles": [
    {
      "Name": "Kautzer-Denesik",
      "TileType": "Area",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    },
    {
      "Name": "Kautzer-Denesik",
      "TileType": "Area",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 784
    }
  }
}
```