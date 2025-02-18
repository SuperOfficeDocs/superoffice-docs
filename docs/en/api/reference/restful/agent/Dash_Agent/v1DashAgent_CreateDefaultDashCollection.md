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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 680,
      "UniqueId": "voluptate",
      "Name": "Ullrich-Willms",
      "Description": "Universal attitude-oriented open system",
      "AssociateId": 491,
      "Columns": 971,
      "Theme": null,
      "VisibleForAll": 748,
      "VisibleForAssociates": [
        784,
        781
      ],
      "VisibleForGroups": [
        482,
        478
      ],
      "PinForAll": 274,
      "PinForAssociates": [
        767,
        750
      ],
      "PinForGroups": [
        30,
        932
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 657,
      "UniqueId": "harum",
      "Name": "Medhurst, Orn and Ruecker",
      "Description": "Persevering bandwidth-monitored emulation",
      "AssociateId": 896,
      "Columns": 833,
      "Theme": null,
      "VisibleForAll": 543,
      "VisibleForAssociates": [
        320,
        218
      ],
      "VisibleForGroups": [
        391,
        383
      ],
      "PinForAll": 161,
      "PinForAssociates": [
        97,
        156
      ],
      "PinForGroups": [
        29,
        240
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 890,
      "UniqueId": "fuga",
      "Name": "Heaney LLC",
      "Description": "Total discrete project",
      "AssociateId": 125,
      "Columns": 14,
      "Theme": null,
      "VisibleForAll": 830,
      "VisibleForAssociates": [
        934,
        373
      ],
      "VisibleForGroups": [
        277,
        355
      ],
      "PinForAll": 659,
      "PinForAssociates": [
        385,
        404
      ],
      "PinForGroups": [
        950,
        341
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 674
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 447
    }
  }
}
```