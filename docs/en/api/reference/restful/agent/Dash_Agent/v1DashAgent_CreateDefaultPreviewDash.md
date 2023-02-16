---
title: POST Agents/Dash/CreateDefaultPreviewDash
uid: v1DashAgent_CreateDefaultPreviewDash
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
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| OwnedByFullName | string | Full name of dashboard owner |
| Registered | date-time | Registered when  in UTC. |
| Tiles | array | Dashboard tiles |
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
  "Name": "Jewess-Stark",
  "Description": "Multi-tiered value-added circuit",
  "OwnedByFullName": "Dr. Jonathon Kassandra Johnston MD",
  "Registered": "1997-02-28T14:19:03.1042793+01:00",
  "Tiles": [
    {
      "Name": "Koss-Powlowski",
      "TileType": "Area",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 462
        }
      }
    },
    {
      "Name": "Koss-Powlowski",
      "TileType": "Area",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 462
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 943
    }
  }
}
```