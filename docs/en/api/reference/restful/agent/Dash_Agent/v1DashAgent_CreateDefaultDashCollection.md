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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
      "DashboardId": 950,
      "UniqueId": "esse",
      "Name": "Kerluke-Cormier",
      "Description": "Automated even-keeled info-mediaries",
      "AssociateId": 707,
      "Columns": 823,
      "Theme": null,
      "VisibleForAll": 628,
      "VisibleForAssociates": [
        134,
        859
      ],
      "VisibleForGroups": [
        148,
        52
      ],
      "PinForAll": 557,
      "PinForAssociates": [
        325,
        707
      ],
      "PinForGroups": [
        924,
        789
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 285
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 678,
      "UniqueId": "vel",
      "Name": "Walsh-Stroman",
      "Description": "Advanced demand-driven Graphical User Interface",
      "AssociateId": 329,
      "Columns": 895,
      "Theme": null,
      "VisibleForAll": 592,
      "VisibleForAssociates": [
        164,
        610
      ],
      "VisibleForGroups": [
        889,
        904
      ],
      "PinForAll": 677,
      "PinForAssociates": [
        604,
        58
      ],
      "PinForGroups": [
        602,
        534
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 239
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 655,
      "UniqueId": "et",
      "Name": "Kulas-Crist",
      "Description": "Persistent executive solution",
      "AssociateId": 450,
      "Columns": 215,
      "Theme": null,
      "VisibleForAll": 221,
      "VisibleForAssociates": [
        913,
        627
      ],
      "VisibleForGroups": [
        586,
        34
      ],
      "PinForAll": 33,
      "PinForAssociates": [
        878,
        786
      ],
      "PinForGroups": [
        12,
        532
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 585
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 622
    }
  }
}
```