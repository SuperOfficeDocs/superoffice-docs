---
title: GET DashTileDefinition/default
uid: v1DashTileDefinition_DefaultDashTileDefinition
---

# GET DashTileDefinition/default

```http
GET /api/v1/DashTileDefinition/default
```

Set default values into a new DashTileDefinition.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Dash agent service CreateDefaultDashTileDefinition.







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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/DashTileDefinition/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 966,
  "Name": "Schuppe-Metz",
  "Description": "Exclusive stable moderator",
  "DefaultHeight": 971,
  "DefaultWidth": 72,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Effertz, Witting and Dare",
  "SelectionId": 663,
  "CurrencyMode": "Base",
  "CurrencyCode": "consequatur",
  "Measure": "Average",
  "MeasureField": "culpa",
  "SortBy": "sed",
  "LayoutConfig": "maxime",
  "SecondarySelectionId": 583,
  "MeasureByField": "reprehenderit",
  "Usage": "Dashboard",
  "ProviderName": "Mante-Prosacco",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 508
    }
  }
}
```