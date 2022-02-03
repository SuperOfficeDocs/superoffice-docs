---
title: POST Agents/Dash/CreateDefaultDashCollection
id: v1DashAgent_CreateDefaultDashCollection
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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 742,
      "UniqueId": "totam",
      "Name": "Mohr Inc and Sons",
      "Description": "Pre-emptive background workforce",
      "AssociateId": 85,
      "Columns": 201,
      "Theme": {},
      "VisibleForAll": 411,
      "VisibleForAssociates": [
        492,
        887
      ],
      "VisibleForGroups": [
        771,
        840
      ],
      "PinForAll": 910,
      "PinForAssociates": [
        769,
        806
      ],
      "PinForGroups": [
        679,
        610
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 707,
      "UniqueId": "dolor",
      "Name": "Mohr Group",
      "Description": "Upgradable disintermediate help-desk",
      "AssociateId": 677,
      "Columns": 462,
      "Theme": {},
      "VisibleForAll": 137,
      "VisibleForAssociates": [
        364,
        848
      ],
      "VisibleForGroups": [
        342,
        509
      ],
      "PinForAll": 42,
      "PinForAssociates": [
        734,
        81
      ],
      "PinForGroups": [
        727,
        995
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 371,
      "UniqueId": "tempore",
      "Name": "Bahringer LLC",
      "Description": "Enterprise-wide homogeneous local area network",
      "AssociateId": 905,
      "Columns": 200,
      "Theme": {},
      "VisibleForAll": 844,
      "VisibleForAssociates": [
        99,
        389
      ],
      "VisibleForGroups": [
        385,
        270
      ],
      "PinForAll": 107,
      "PinForAssociates": [
        54,
        212
      ],
      "PinForGroups": [
        310,
        705
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 171
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
      "FieldLength": 334
    }
  }
}
```