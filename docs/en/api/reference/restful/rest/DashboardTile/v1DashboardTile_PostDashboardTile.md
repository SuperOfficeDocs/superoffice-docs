---
title: POST DashboardTile
uid: v1DashboardTile_PostDashboardTile
generated: true
---

# POST DashboardTile

```http
POST /api/v1/DashboardTile
```

Creates a new DashboardTile


Calls the Dashboard agent service SaveDashboardTile.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/DashboardTile?$select=name,department,category/id
```


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

## Request Body: newEntity 

The DashboardTile to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | Integer | The tile id |
| Caption | String | The tile caption |
| Description | String | The tile description |
| ChartName | String | The original chart name |
| ChartId | String | The original chart Id |
| IsDefault | Boolean | True if this is one of the default tiles |
| AssociateId | Integer | Id of the associate who owns this tile |
| GroupId | Integer | Id of the associates primary group at storage time |
| SelectionId | Integer | The selection that defines the data filter/restrictions |
| Config | String | The tile config |
| Type | String | The tile type, what kind of tile this is |
| EntityType | String | The tile entity type |
| Options | Array | The tile options |
| VisibleFor | Array | The set of users or groups the record is visible for |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DashboardTileWithLinks

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/DashboardTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 416,
  "Caption": "cupiditate",
  "Description": "Cross-platform 4th generation conglomeration",
  "ChartName": "Roob Inc and Sons",
  "ChartId": "et",
  "IsDefault": false,
  "AssociateId": 796,
  "GroupId": 190,
  "SelectionId": 527,
  "Config": "labore",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Boyer Group",
      "Description": "Polarised logistical customer loyalty",
      "Type": "Boolean",
      "ListName": "Runte-Reinger",
      "ListItems": [
        {},
        {}
      ],
      "Value": "ipsum",
      "DefaultDataOption": true
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 416,
      "Visibility": "All",
      "DisplayValue": "laborum"
    },
    {
      "VisibleId": 416,
      "Visibility": "All",
      "DisplayValue": "laborum"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 58,
  "Caption": "ipsa",
  "Description": "Profit-focused responsive middleware",
  "ChartName": "Cole-Pacocha",
  "ChartId": "velit",
  "IsDefault": false,
  "AssociateId": 476,
  "GroupId": 427,
  "SelectionId": 292,
  "Config": "est",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Walter, Howe and Turcotte",
      "Description": "Decentralized background throughput",
      "Type": "Boolean",
      "ListName": "Jewess, Daniel and Donnelly",
      "ListItems": [
        {},
        {}
      ],
      "Value": "qui",
      "DefaultDataOption": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 321
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 285,
      "Visibility": "All",
      "DisplayValue": "eius",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 954
        }
      }
    },
    {
      "VisibleId": 285,
      "Visibility": "All",
      "DisplayValue": "eius",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 954
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 481
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```