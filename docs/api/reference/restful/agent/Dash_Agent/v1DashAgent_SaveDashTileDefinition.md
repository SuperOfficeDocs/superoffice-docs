---
title: POST Agents/Dash/SaveDashTileDefinition
id: v1DashAgent_SaveDashTileDefinition
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

Carrier object for DashTileDefinition.
Services for the DashTileDefinition Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDashAgent">Dash Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample Request

```http!
POST /api/v1/Agents/Dash/SaveDashTileDefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 4,
  "Name": "Considine LLC",
  "Description": "Horizontal upward-trending flexibility",
  "DefaultHeight": 97,
  "DefaultWidth": 630,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Turner-Trantow",
  "SelectionId": 937,
  "CurrencyMode": "Base",
  "CurrencyCode": "qui",
  "Measure": "Average",
  "MeasureField": "non",
  "SortBy": "qui",
  "LayoutConfig": "molestiae",
  "SecondarySelectionId": 770,
  "MeasureByField": "iure",
  "ProviderName": "McGlynn, Prohaska and Nader"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 753,
  "Name": "Toy LLC",
  "Description": "Inverse bottom-line methodology",
  "DefaultHeight": 150,
  "DefaultWidth": 129,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Senger, Harber and Beer",
  "SelectionId": 337,
  "CurrencyMode": "Base",
  "CurrencyCode": "ducimus",
  "Measure": "Average",
  "MeasureField": "similique",
  "SortBy": "voluptas",
  "LayoutConfig": "optio",
  "SecondarySelectionId": 604,
  "MeasureByField": "sed",
  "ProviderName": "Skiles-Emmerich",
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
      "FieldType": "System.Int32",
      "FieldLength": 778
    }
  }
}
```
