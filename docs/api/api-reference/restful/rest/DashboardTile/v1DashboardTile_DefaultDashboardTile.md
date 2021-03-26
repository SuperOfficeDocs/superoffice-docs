---
title: GET DashboardTile/default
id: v1DashboardTile_DefaultDashboardTile
---

# GET DashboardTile/default

```http
GET /api/v1/DashboardTile/default
```

Set default values into a new DashboardTile.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Dashboard agent service CreateDefaultDashboardTile.






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
GET /api/v1/DashboardTile/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 800,
  "Caption": "voluptas",
  "Description": "Universal zero defect capacity",
  "ChartName": "Lesch-Bins",
  "ChartId": "et",
  "IsDefault": false,
  "AssociateId": 908,
  "GroupId": 265,
  "SelectionId": 937,
  "Config": "corporis",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Medhurst-Marquardt",
      "Description": "Function-based even-keeled complexity",
      "Type": "Boolean",
      "ListName": "Jewess Inc and Sons",
      "ListItems": [
        {},
        {}
      ],
      "Value": "tenetur",
      "DefaultDataOption": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 847,
      "Visibility": "All",
      "DisplayValue": "quis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 960
        }
      }
    },
    {
      "VisibleId": 847,
      "Visibility": "All",
      "DisplayValue": "quis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 960
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
      "FieldLength": 248
    }
  }
}
```