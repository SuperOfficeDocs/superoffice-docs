---
title: PUT DashTileDefinition/{id}
id: v1DashTileDefinition_PutDashTileDefinition
---

# PUT DashTileDefinition/{id}

```http
PUT /api/v1/DashTileDefinition/{id}
```

Updates the existing DashTileDefinition






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
| ProviderName | string | Name of provider to use with this entity type - read only property |


## Response: object

Dashboard Tile definition



DashTileDefinition entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DashTileDefinition updated. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| ProviderName | string | Name of provider to use with this entity type - read only property |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/DashTileDefinition/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 165,
  "Name": "Schowalter-Greenfelder",
  "Description": "Visionary web-enabled standardization",
  "DefaultHeight": 958,
  "DefaultWidth": 399,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Lubowitz LLC",
  "SelectionId": 152,
  "CurrencyMode": "Base",
  "CurrencyCode": "cumque",
  "Measure": "Average",
  "MeasureField": "et",
  "SortBy": "eius",
  "LayoutConfig": "commodi",
  "SecondarySelectionId": 243,
  "MeasureByField": "dolorem",
  "ProviderName": "Herman, Lind and Lockman"
}
```

```http_
HTTP/1.1 200 DashTileDefinition updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 541,
  "Name": "Breitenberg-Davis",
  "Description": "Vision-oriented stable adapter",
  "DefaultHeight": 274,
  "DefaultWidth": 788,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Tromp LLC",
  "SelectionId": 225,
  "CurrencyMode": "Base",
  "CurrencyCode": "rerum",
  "Measure": "Average",
  "MeasureField": "iusto",
  "SortBy": "omnis",
  "LayoutConfig": "quo",
  "SecondarySelectionId": 53,
  "MeasureByField": "omnis",
  "ProviderName": "Smitham, Nicolas and Braun",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "deploy next-generation niches"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 904
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```