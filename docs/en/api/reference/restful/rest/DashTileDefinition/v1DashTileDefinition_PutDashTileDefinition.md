---
title: PUT DashTileDefinition/{id}
uid: v1DashTileDefinition_PutDashTileDefinition
generated: true
content_type: reference
---

# PUT DashTileDefinition/{id}

```http
PUT /api/v1/DashTileDefinition/{id}
```

Updates the existing DashTileDefinition


NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTileDefinition id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/DashTileDefinition/{id}?$select=name,department,category/id
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

## Request Body: entity 

The DashTileDefinition to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileDefinitionId | Integer | Primary key |
| Name | String | The name of the tile |
| Description | String | Detailed description |
| DefaultHeight | Integer | Default height when added to a dashboard |
| DefaultWidth | Integer | Default width when added to a dashboard |
| TileType | String | Dashboard tile type |
| EntityType | String | Dashboard entity type |
| EntityName | String | The entity measured by this tile, defines what provider to use |
| SelectionId | Integer | Selection holding the criterias for the tile definition |
| CurrencyMode | String | Dashboard currency mode |
| CurrencyCode | String | Currency code |
| Measure | String | Dashboard measure type (Count, Sum, Avg, etc.) |
| MeasureField | String | Field to be measured |
| SortBy | String | Sort by field |
| LayoutConfig | String | The JSON formatted layout config |
| SecondarySelectionId | Integer | Selection holding the replaced or changed criterias (period comparisons etc) |
| MeasureByField | String | Field to group by |
| Usage | String | Where this tile can be used |
| ProviderName | String | Name of provider to use with this entity type - read only property |

## Response:

DashTileDefinition updated.

| Response | Description |
|----------------|-------------|
| 200 | DashTileDefinition updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: DashTileDefinitionWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileDefinitionId | int32 | Primary key |
| Name | string | The name of the tile |
| Description | string | Detailed description |
| DefaultHeight | int32 | Default height when added to a dashboard |
| DefaultWidth | int32 | Default width when added to a dashboard |
| TileType | string | Dashboard tile type |
| EntityType | string | Dashboard entity type |
| EntityName | string | The entity measured by this tile, defines what provider to use |
| SelectionId | int32 | Selection holding the criterias for the tile definition |
| CurrencyMode | string | Dashboard currency mode |
| CurrencyCode | string | Currency code |
| Measure | string | Dashboard measure type (Count, Sum, Avg, etc.) |
| MeasureField | string | Field to be measured |
| SortBy | string | Sort by field |
| LayoutConfig | string | The JSON formatted layout config |
| SecondarySelectionId | int32 | Selection holding the replaced or changed criterias (period comparisons etc) |
| MeasureByField | string | Field to group by |
| Usage | string | Where this tile can be used |
| ProviderName | string | Name of provider to use with this entity type - read only property |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/DashTileDefinition/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 376,
  "Name": "Stamm, Krajcik and Blanda",
  "Description": "Persistent discrete portal",
  "DefaultHeight": 529,
  "DefaultWidth": 516,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Dach Group",
  "SelectionId": 780,
  "CurrencyMode": "Base",
  "CurrencyCode": "consectetur",
  "Measure": "Average",
  "MeasureField": "sed",
  "SortBy": "sit",
  "LayoutConfig": "rerum",
  "SecondarySelectionId": 401,
  "MeasureByField": "quod",
  "Usage": "Dashboard",
  "ProviderName": "Farrell-Bernhard"
}
```

## Sample response

```http_
HTTP/1.1 200 DashTileDefinition updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 414,
  "Name": "Maggio-Raynor",
  "Description": "Optimized context-sensitive framework",
  "DefaultHeight": 988,
  "DefaultWidth": 484,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Marks-Hettinger",
  "SelectionId": 382,
  "CurrencyMode": "Base",
  "CurrencyCode": "corrupti",
  "Measure": "Average",
  "MeasureField": "voluptas",
  "SortBy": "omnis",
  "LayoutConfig": "et",
  "SecondarySelectionId": 526,
  "MeasureByField": "nihil",
  "Usage": "Dashboard",
  "ProviderName": "Abbott, Homenick and Hahn",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 418
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```