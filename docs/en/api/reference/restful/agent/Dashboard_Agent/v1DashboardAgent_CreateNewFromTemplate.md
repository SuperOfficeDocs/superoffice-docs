---
title: POST Agents/Dashboard/CreateNewFromTemplate
uid: v1DashboardAgent_CreateNewFromTemplate
generated: true
---

# POST Agents/Dashboard/CreateNewFromTemplate

```http
POST /api/v1/Agents/Dashboard/CreateNewFromTemplate
```

Create new tile from another tile used as template







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dashboard/CreateNewFromTemplate?$select=name,department,category/id
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

## Request Body: request 

DashboardTileId, Caption, Description, SelectionId, VisibleFor 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | Integer |  |
| Caption | String |  |
| Description | String |  |
| SelectionId | Integer |  |
| VisibleFor | Array |  |

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
POST /api/v1/Agents/Dashboard/CreateNewFromTemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 225,
  "Caption": "quia",
  "Description": "Exclusive fault-tolerant task-force",
  "SelectionId": 419,
  "VisibleFor": [
    {
      "VisibleId": 856,
      "Visibility": "All",
      "DisplayValue": "occaecati"
    },
    {
      "VisibleId": 856,
      "Visibility": "All",
      "DisplayValue": "occaecati"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 716,
  "Caption": "illum",
  "Description": "Versatile static focus group",
  "ChartName": "Kulas Group",
  "ChartId": "quibusdam",
  "IsDefault": true,
  "AssociateId": 359,
  "GroupId": 731,
  "SelectionId": 199,
  "Config": "quis",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Treutel-Purdy",
      "Description": "Persevering 24/7 model",
      "Type": "Boolean",
      "ListName": "Robel-Schuster",
      "ListItems": [
        {},
        {}
      ],
      "Value": "iusto",
      "DefaultDataOption": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 774,
      "Visibility": "All",
      "DisplayValue": "culpa",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    },
    {
      "VisibleId": 774,
      "Visibility": "All",
      "DisplayValue": "culpa",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 530
    }
  }
}
```