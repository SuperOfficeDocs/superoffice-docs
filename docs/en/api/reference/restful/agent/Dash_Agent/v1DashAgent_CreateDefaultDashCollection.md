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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 395,
      "UniqueId": "inventore",
      "Name": "Trantow, Bailey and Kuvalis",
      "Description": "Front-line bi-directional complexity",
      "AssociateId": 769,
      "Columns": 155,
      "Theme": null,
      "VisibleForAll": 916,
      "VisibleForAssociates": [
        202,
        721
      ],
      "VisibleForGroups": [
        51,
        919
      ],
      "PinForAll": 681,
      "PinForAssociates": [
        314,
        508
      ],
      "PinForGroups": [
        338,
        770
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 176,
      "UniqueId": "est",
      "Name": "Mayer-Torp",
      "Description": "Future-proofed solution-oriented Graphic Interface",
      "AssociateId": 205,
      "Columns": 741,
      "Theme": null,
      "VisibleForAll": 862,
      "VisibleForAssociates": [
        597,
        485
      ],
      "VisibleForGroups": [
        777,
        757
      ],
      "PinForAll": 834,
      "PinForAssociates": [
        268,
        361
      ],
      "PinForGroups": [
        948,
        684
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 654
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 247,
      "UniqueId": "id",
      "Name": "Harris Group",
      "Description": "Phased eco-centric matrix",
      "AssociateId": 811,
      "Columns": 335,
      "Theme": null,
      "VisibleForAll": 993,
      "VisibleForAssociates": [
        411,
        732
      ],
      "VisibleForGroups": [
        641,
        885
      ],
      "PinForAll": 719,
      "PinForAssociates": [
        574,
        841
      ],
      "PinForGroups": [
        312,
        568
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 216
    }
  }
}
```