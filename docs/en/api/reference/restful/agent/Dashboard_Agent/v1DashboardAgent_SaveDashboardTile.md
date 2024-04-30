---
title: POST Agents/Dashboard/SaveDashboardTile
uid: v1DashboardAgent_SaveDashboardTile
generated: true
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

### Response body: DashboardTile

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

## Sample request

```http!
POST /api/v1/Agents/Dashboard/SaveDashboardTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 739,
  "Caption": "nisi",
  "Description": "Stand-alone coherent Graphic Interface",
  "ChartName": "McGlynn, Powlowski and Cole",
  "ChartId": "aut",
  "IsDefault": false,
  "AssociateId": 808,
  "GroupId": 941,
  "SelectionId": 961,
  "Config": "iusto",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Wisozk LLC",
      "Description": "Cross-group zero administration conglomeration",
      "Type": "Boolean",
      "ListName": "Nolan, Carroll and Gaylord",
      "ListItems": [
        {},
        {}
      ],
      "Value": "nesciunt",
      "DefaultDataOption": false
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 603,
      "Visibility": "All",
      "DisplayValue": "vitae"
    },
    {
      "VisibleId": 603,
      "Visibility": "All",
      "DisplayValue": "vitae"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 983,
  "Caption": "ad",
  "Description": "Organized systemic help-desk",
  "ChartName": "Parker, Konopelski and Rogahn",
  "ChartId": "ex",
  "IsDefault": false,
  "AssociateId": 649,
  "GroupId": 720,
  "SelectionId": 531,
  "Config": "aut",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Oberbrunner-Towne",
      "Description": "Managed encompassing process improvement",
      "Type": "Boolean",
      "ListName": "Ebert, Friesen and Metz",
      "ListItems": [
        {},
        {}
      ],
      "Value": "aperiam",
      "DefaultDataOption": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 109
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 508,
      "Visibility": "All",
      "DisplayValue": "voluptas",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    },
    {
      "VisibleId": 508,
      "Visibility": "All",
      "DisplayValue": "voluptas",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 26
    }
  }
}
```