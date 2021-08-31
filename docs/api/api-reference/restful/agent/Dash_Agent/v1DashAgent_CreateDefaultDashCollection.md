---
title: CreateDefaultDashCollection
id: v1DashAgent_CreateDefaultDashCollection
---

# CreateDefaultDashCollection

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


## Response: object

Collection of dashboards for an associate



Carrier object for DashCollection.
Services for the DashCollection Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDashAgent">Dash Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 7,
      "Name": "Mitchell-Howe",
      "Description": "Ergonomic mobile functionalities",
      "AssociateId": 576,
      "Columns": 708,
      "Theme": {},
      "VisibleForAll": 66,
      "VisibleForAssociates": [
        836,
        801
      ],
      "VisibleForGroups": [
        282,
        534
      ],
      "PinForAll": 188,
      "PinForAssociates": [
        674,
        815
      ],
      "PinForGroups": [
        365,
        972
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 835
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 388,
      "Name": "Christiansen-Renner",
      "Description": "Vision-oriented mobile help-desk",
      "AssociateId": 643,
      "Columns": 826,
      "Theme": {},
      "VisibleForAll": 96,
      "VisibleForAssociates": [
        521,
        330
      ],
      "VisibleForGroups": [
        15,
        234
      ],
      "PinForAll": 772,
      "PinForAssociates": [
        868,
        529
      ],
      "PinForGroups": [
        40,
        75
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 696,
      "Name": "Crona, Douglas and Sipes",
      "Description": "Total systematic definition",
      "AssociateId": 867,
      "Columns": 273,
      "Theme": {},
      "VisibleForAll": 527,
      "VisibleForAssociates": [
        220,
        789
      ],
      "VisibleForGroups": [
        114,
        891
      ],
      "PinForAll": 397,
      "PinForAssociates": [
        958,
        267
      ],
      "PinForGroups": [
        424,
        11
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 504
    }
  }
}
```