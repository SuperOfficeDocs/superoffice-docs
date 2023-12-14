---
title: POST Agents/Dash/CreateDefaultDashCollection
uid: v1DashAgent_CreateDefaultDashCollection
generated: true
---

# POST Agents/Dash/CreateDefaultDashCollection

```http
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
```

Set default values into a new DashCollection.


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

### Response body: DashCollection

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 657,
      "UniqueId": "facilis",
      "Name": "Wisozk-Crona",
      "Description": "Universal hybrid analyzer",
      "AssociateId": 183,
      "Columns": 982,
      "Theme": null,
      "VisibleForAll": 825,
      "VisibleForAssociates": [
        521,
        960
      ],
      "VisibleForGroups": [
        990,
        212
      ],
      "PinForAll": 105,
      "PinForAssociates": [
        791,
        915
      ],
      "PinForGroups": [
        985,
        179
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 792,
      "UniqueId": "expedita",
      "Name": "Luettgen, Ryan and Bruen",
      "Description": "User-friendly hybrid protocol",
      "AssociateId": 764,
      "Columns": 725,
      "Theme": null,
      "VisibleForAll": 342,
      "VisibleForAssociates": [
        151,
        234
      ],
      "VisibleForGroups": [
        807,
        294
      ],
      "PinForAll": 474,
      "PinForAssociates": [
        922,
        938
      ],
      "PinForGroups": [
        231,
        548
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 880
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 926,
      "UniqueId": "incidunt",
      "Name": "Yundt-Treutel",
      "Description": "Future-proofed analyzing secured line",
      "AssociateId": 400,
      "Columns": 167,
      "Theme": null,
      "VisibleForAll": 521,
      "VisibleForAssociates": [
        968,
        128
      ],
      "VisibleForGroups": [
        971,
        542
      ],
      "PinForAll": 848,
      "PinForAssociates": [
        678,
        844
      ],
      "PinForGroups": [
        605,
        1002
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 245
    }
  }
}
```