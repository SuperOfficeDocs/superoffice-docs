---
title: POST Agents/Dash/CreateDefaultDashCollection
uid: v1DashAgent_CreateDefaultDashCollection
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 489,
      "UniqueId": "ratione",
      "Name": "Langosh, Miller and Aufderhar",
      "Description": "De-engineered multi-state system engine",
      "AssociateId": 304,
      "Columns": 180,
      "Theme": null,
      "VisibleForAll": 439,
      "VisibleForAssociates": [
        170,
        311
      ],
      "VisibleForGroups": [
        6,
        803
      ],
      "PinForAll": 994,
      "PinForAssociates": [
        95,
        741
      ],
      "PinForGroups": [
        811,
        215
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 120
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 694,
      "UniqueId": "ut",
      "Name": "Goyette, Wuckert and Considine",
      "Description": "Versatile fresh-thinking instruction set",
      "AssociateId": 375,
      "Columns": 417,
      "Theme": null,
      "VisibleForAll": 210,
      "VisibleForAssociates": [
        705,
        696
      ],
      "VisibleForGroups": [
        560,
        391
      ],
      "PinForAll": 480,
      "PinForAssociates": [
        696,
        680
      ],
      "PinForGroups": [
        593,
        495
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 630
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 155,
      "UniqueId": "ullam",
      "Name": "Moore, Dach and Brown",
      "Description": "Profit-focused grid-enabled approach",
      "AssociateId": 560,
      "Columns": 245,
      "Theme": null,
      "VisibleForAll": 174,
      "VisibleForAssociates": [
        673,
        865
      ],
      "VisibleForGroups": [
        485,
        61
      ],
      "PinForAll": 489,
      "PinForAssociates": [
        806,
        369
      ],
      "PinForGroups": [
        472,
        819
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 971
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 528
    }
  }
}
```