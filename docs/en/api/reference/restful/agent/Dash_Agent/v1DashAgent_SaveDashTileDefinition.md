---
title: POST Agents/Dash/SaveDashTileDefinition
uid: v1DashAgent_SaveDashTileDefinition
generated: true
---

# POST Agents/Dash/SaveDashTileDefinition

```http
POST /api/v1/Agents/Dash/SaveDashTileDefinition
```

Updates the existing DashTileDefinition or creates a new DashTileDefinition if the id parameter is empty








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
  "DashboardTileDefinitionId": 635,
  "Name": "Goodwin-Harber",
  "Description": "Horizontal 24/7 Graphic Interface",
  "DefaultHeight": 817,
  "DefaultWidth": 933,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Reichert, Wintheiser and Lueilwitz",
  "SelectionId": 911,
  "CurrencyMode": "Base",
  "CurrencyCode": "ut",
  "Measure": "Average",
  "MeasureField": "tenetur",
  "SortBy": "perferendis",
  "LayoutConfig": "debitis",
  "SecondarySelectionId": 510,
  "MeasureByField": "iusto",
  "Usage": "Dashboard",
  "ProviderName": "Crona LLC"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 590,
  "Name": "Zemlak, Vandervort and Kshlerin",
  "Description": "Self-enabling background knowledge user",
  "DefaultHeight": 667,
  "DefaultWidth": 417,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Hickle Inc and Sons",
  "SelectionId": 593,
  "CurrencyMode": "Base",
  "CurrencyCode": "laboriosam",
  "Measure": "Average",
  "MeasureField": "nesciunt",
  "SortBy": "velit",
  "LayoutConfig": "non",
  "SecondarySelectionId": 46,
  "MeasureByField": "consequatur",
  "Usage": "Dashboard",
  "ProviderName": "Tillman Group",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 847
    }
  }
}
```