---
title: PATCH DashTileDefinition/{id}
uid: v1DashTileDefinition_PatchDashTileDefinition
---

# PATCH DashTileDefinition/{id}

```http
PATCH /api/v1/DashTileDefinition/{id}
```

Update a DashTileDefinition with changes, as described in a JSON Patch or a JSON Merge Patch document.


See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IDashAgent} service SaveDashTileDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTileDefinition  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/DashTileDefinition/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: 

DashTileDefinition  updated.

| Response | Description |
|----------------|-------------|
| 200 | DashTileDefinition  updated. |
| 404 | DashTileDefinition with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because DashTileDefinition has changed since the requested If-Unmodified-Since timestamp. |

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
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/DashTileDefinition/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "esse",
    "value": {}
  },
  {
    "op": "add",
    "path": "esse",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 DashTileDefinition  updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 237,
  "Name": "Wolf LLC",
  "Description": "User-centric interactive migration",
  "DefaultHeight": 53,
  "DefaultWidth": 217,
  "TileType": "Area",
  "EntityType": "Appointment",
  "EntityName": "Schaden-Ondricka",
  "SelectionId": 564,
  "CurrencyMode": "Base",
  "CurrencyCode": "placeat",
  "Measure": "Average",
  "MeasureField": "rem",
  "SortBy": "expedita",
  "LayoutConfig": "labore",
  "SecondarySelectionId": 413,
  "MeasureByField": "in",
  "Usage": "Dashboard",
  "ProviderName": "Breitenberg-Crona",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 848
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```