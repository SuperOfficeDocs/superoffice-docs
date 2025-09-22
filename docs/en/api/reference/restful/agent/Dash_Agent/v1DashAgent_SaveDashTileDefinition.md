---
title: POST Agents/Dash/SaveDashTileDefinition
uid: v1DashAgent_SaveDashTileDefinition
generated: true
content_type: reference
---

# POST Agents/Dash/SaveDashTileDefinition

```http
POST /api/v1/Agents/Dash/SaveDashTileDefinition
```

Updates the existing DashTileDefinition or creates a new DashTileDefinition if the id parameter is 0.








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

## Request Body: dashTileDefinition 

The DashTileDefinition that is saved 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DashTileDefinition

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

## Sample request

```http!
POST /api/v1/Agents/Dash/SaveDashTileDefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 473,
  "Name": "Cronin LLC",
  "Description": "Upgradable directional secured line",
  "DefaultHeight": 126,
  "DefaultWidth": 201,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Jaskolski LLC",
  "SelectionId": 164,
  "CurrencyMode": "Base",
  "CurrencyCode": "perferendis",
  "Measure": "Average",
  "MeasureField": "deserunt",
  "SortBy": "omnis",
  "LayoutConfig": "et",
  "SecondarySelectionId": 219,
  "MeasureByField": "accusamus",
  "Usage": "Dashboard",
  "ProviderName": "Walter, Rutherford and Senger"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 16,
  "Name": "Legros, Kub and Gutmann",
  "Description": "Horizontal bi-directional software",
  "DefaultHeight": 704,
  "DefaultWidth": 17,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Jast, Reynolds and Powlowski",
  "SelectionId": 874,
  "CurrencyMode": "Base",
  "CurrencyCode": "est",
  "Measure": "Average",
  "MeasureField": "et",
  "SortBy": "repellendus",
  "LayoutConfig": "expedita",
  "SecondarySelectionId": 543,
  "MeasureByField": "sit",
  "Usage": "Dashboard",
  "ProviderName": "Mills Inc and Sons",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 312
    }
  }
}
```