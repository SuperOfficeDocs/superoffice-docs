---
title: POST DashTileDefinition
uid: v1DashTileDefinition_PostDashTileDefinition
---

# POST DashTileDefinition

```http
POST /api/v1/DashTileDefinition
```

Creates a new DashTileDefinition


Calls the Dash agent service SaveDashTileDefinition.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/DashTileDefinition?$select=name,department,category/id
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/DashTileDefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 998,
  "Name": "Leffler, Gibson and Kub",
  "Description": "Multi-tiered 24/7 encoding",
  "DefaultHeight": 910,
  "DefaultWidth": 806,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Gerlach Group",
  "SelectionId": 633,
  "CurrencyMode": "Base",
  "CurrencyCode": "qui",
  "Measure": "Average",
  "MeasureField": "possimus",
  "SortBy": "et",
  "LayoutConfig": "quas",
  "SecondarySelectionId": 13,
  "MeasureByField": "impedit",
  "Usage": "Dashboard",
  "ProviderName": "Nienow-Monahan"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 421,
  "Name": "Conroy-Boyer",
  "Description": "Operative system-worthy array",
  "DefaultHeight": 887,
  "DefaultWidth": 904,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Muller LLC",
  "SelectionId": 580,
  "CurrencyMode": "Base",
  "CurrencyCode": "ex",
  "Measure": "Average",
  "MeasureField": "repellendus",
  "SortBy": "dolor",
  "LayoutConfig": "optio",
  "SecondarySelectionId": 233,
  "MeasureByField": "rerum",
  "Usage": "Dashboard",
  "ProviderName": "Hayes, Raynor and Tromp",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 244
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```