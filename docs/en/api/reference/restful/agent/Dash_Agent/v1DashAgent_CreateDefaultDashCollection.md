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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 468,
      "UniqueId": "est",
      "Name": "Mills Group",
      "Description": "Innovative eco-centric synergy",
      "AssociateId": 868,
      "Columns": 598,
      "Theme": null,
      "VisibleForAll": 904,
      "VisibleForAssociates": [
        339,
        493
      ],
      "VisibleForGroups": [
        588,
        638
      ],
      "PinForAll": 788,
      "PinForAssociates": [
        573,
        932
      ],
      "PinForGroups": [
        267,
        217
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 939
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 314,
      "UniqueId": "praesentium",
      "Name": "Ondricka Inc and Sons",
      "Description": "Ameliorated optimal algorithm",
      "AssociateId": 670,
      "Columns": 687,
      "Theme": null,
      "VisibleForAll": 109,
      "VisibleForAssociates": [
        226,
        373
      ],
      "VisibleForGroups": [
        225,
        534
      ],
      "PinForAll": 284,
      "PinForAssociates": [
        4,
        264
      ],
      "PinForGroups": [
        781,
        268
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 985
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 342,
      "UniqueId": "autem",
      "Name": "Heaney-Schinner",
      "Description": "De-engineered next generation installation",
      "AssociateId": 495,
      "Columns": 792,
      "Theme": null,
      "VisibleForAll": 923,
      "VisibleForAssociates": [
        645,
        396
      ],
      "VisibleForGroups": [
        839,
        493
      ],
      "PinForAll": 826,
      "PinForAssociates": [
        667,
        810
      ],
      "PinForGroups": [
        485,
        135
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 285
    }
  }
}
```