---
title: GET DashTileDefinition/{id}
uid: v1DashTileDefinition_GetDashTileDefinition
---

# GET DashTileDefinition/{id}

```http
GET /api/v1/DashTileDefinition/{id}
```

Gets a DashTileDefinition object.


Calls the Dash agent service GetDashTileDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the DashTileDefinition to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/DashTileDefinition/{id}?$select=name,department,category/id
```


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

DashTileDefinition found.

| Response | Description |
|----------------|-------------|
| 200 | DashTileDefinition found. |
| 404 | Not Found. |

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
GET /api/v1/DashTileDefinition/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 DashTileDefinition found.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 817,
  "Name": "Sawayn-Ortiz",
  "Description": "Optional transitional attitude",
  "DefaultHeight": 918,
  "DefaultWidth": 231,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "DuBuque, Green and Hodkiewicz",
  "SelectionId": 756,
  "CurrencyMode": "Base",
  "CurrencyCode": "et",
  "Measure": "Average",
  "MeasureField": "perferendis",
  "SortBy": "quibusdam",
  "LayoutConfig": "molestias",
  "SecondarySelectionId": 48,
  "MeasureByField": "maxime",
  "Usage": "Dashboard",
  "ProviderName": "Ullrich, Beer and Kulas",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 322
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```