---
title: POST Agents/Dashboard/SaveDashboardTile
id: v1DashboardAgent_SaveDashboardTile
---

# POST Agents/Dashboard/SaveDashboardTile

```http
POST /api/v1/Agents/Dashboard/SaveDashboardTile
```

Updates the existing DashboardTile or creates a new DashboardTile if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity  

The DashboardTile to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | The tile id |
| Caption | string | The tile caption |
| Description | string | The tile description |
| ChartName | string | The original chart name |
| ChartId | string | The original chart Id |
| IsDefault | bool | True if this is one of the default tiles |
| AssociateId | int32 | Id of the associate who owns this tile |
| GroupId | int32 | Id of the associates primary group at storage time |
| SelectionId | int32 | The selection that defines the data filter/restrictions |
| Config | string | The tile config |
| Type | string | The tile type, what kind of tile this is |
| EntityType | string | The tile entity type |
| Options | array | The tile options |
| VisibleFor | array | The set of users or groups the record is visible for |


## Response: object

Dashboard Tile configuration



Carrier object for DashboardTile.
Services for the DashboardTile Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDashboardAgent">Dashboard Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | The tile id |
| Caption | string | The tile caption |
| Description | string | The tile description |
| ChartName | string | The original chart name |
| ChartId | string | The original chart Id |
| IsDefault | bool | True if this is one of the default tiles |
| AssociateId | int32 | Id of the associate who owns this tile |
| GroupId | int32 | Id of the associates primary group at storage time |
| SelectionId | int32 | The selection that defines the data filter/restrictions |
| Config | string | The tile config |
| Type | string | The tile type, what kind of tile this is |
| EntityType | string | The tile entity type |
| Options | array | The tile options |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Dashboard/SaveDashboardTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 390,
  "Caption": "omnis",
  "Description": "Multi-channelled assymetric productivity",
  "ChartName": "Borer LLC",
  "ChartId": "natus",
  "IsDefault": true,
  "AssociateId": 805,
  "GroupId": 247,
  "SelectionId": 679,
  "Config": "eos",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Baumbach-Legros",
      "Description": "Cloned system-worthy portal",
      "Type": "Boolean",
      "ListName": "Treutel LLC",
      "ListItems": [
        {},
        {}
      ],
      "Value": "architecto",
      "DefaultDataOption": true
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 907,
      "Visibility": "All",
      "DisplayValue": "debitis"
    },
    {
      "VisibleId": 907,
      "Visibility": "All",
      "DisplayValue": "debitis"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 38,
  "Caption": "autem",
  "Description": "Diverse neutral application",
  "ChartName": "Hane Group",
  "ChartId": "quisquam",
  "IsDefault": false,
  "AssociateId": 836,
  "GroupId": 427,
  "SelectionId": 422,
  "Config": "aliquid",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Mosciski, Herman and Kuhlman",
      "Description": "Realigned maximized portal",
      "Type": "Boolean",
      "ListName": "Gulgowski-Kris",
      "ListItems": [
        {},
        {}
      ],
      "Value": "earum",
      "DefaultDataOption": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 802
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 597,
      "Visibility": "All",
      "DisplayValue": "in",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 427
        }
      }
    },
    {
      "VisibleId": 597,
      "Visibility": "All",
      "DisplayValue": "in",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 427
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "engage user-centric markets"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 594
    }
  }
}
```