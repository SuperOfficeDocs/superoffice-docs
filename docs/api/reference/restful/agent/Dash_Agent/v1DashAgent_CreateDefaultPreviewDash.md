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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| OwnedByFullName | string | Full name of dashboard owner |
| Registered | date-time | Registered when  in UTC. |
| Tiles | array | Dashboard tiles |
| TableRight |  |  |
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
  "Name": "Stroman Inc and Sons",
  "Description": "Quality-focused human-resource definition",
  "OwnedByFullName": "Florian Huel",
  "Registered": "1998-03-20T11:10:26.4194528+01:00",
  "Tiles": [
    {
      "Name": "Murazik, Littel and Emard",
      "TileType": "Area",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    },
    {
      "Name": "Murazik, Littel and Emard",
      "TileType": "Area",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 9
    }
  }
}
```
