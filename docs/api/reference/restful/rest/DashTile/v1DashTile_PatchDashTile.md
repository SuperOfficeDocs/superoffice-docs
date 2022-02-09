---
title: PATCH DashTile/{id}
id: v1DashTile_PatchDashTile
---

# PATCH DashTile/{id}

```http
PATCH /api/v1/DashTile/{id}
```

Update a DashTile with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IDashAgent} service SaveDashTile.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTile  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/DashTile/{id}?$select=name,department,category/id
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


## Response: object

Dashboard Tile configuration



DashTile entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DashTile  updated. |
| 404 | DashTile with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because DashTile has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | Primary key |
| DashboardId | int32 | The associated dashboard |
| Height | int32 | Height used by this tile in the dashboard |
| Width | int32 | Width used by this tile in the dashboard |
| Rank | int32 | Rank order |
| DashTileDefinition |  | The tile definition entity |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/DashTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "doloribus",
    "value": {
      "value1": {
        "PrimaryKey": 1296,
        "EntityName": "sale",
        "saleId": 1296,
        "contactId": 9955,
        "name": "Lebsack Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 5028,
        "EntityName": "person",
        "personId": 5028,
        "fullName": "Ms. Logan Bailey"
      }
    }
  },
  {
    "op": "add",
    "path": "doloribus",
    "value": {
      "value1": {
        "PrimaryKey": 1296,
        "EntityName": "sale",
        "saleId": 1296,
        "contactId": 9955,
        "name": "Lebsack Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 5028,
        "EntityName": "person",
        "personId": 5028,
        "fullName": "Ms. Logan Bailey"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 DashTile  updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 764,
  "DashboardId": 129,
  "Height": 857,
  "Width": 230,
  "Rank": 163,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 406,
    "Name": "Braun-Dibbert",
    "Description": "Persistent context-sensitive initiative",
    "DefaultHeight": 944,
    "DefaultWidth": 552,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Weimann, Dickinson and Parker",
    "SelectionId": 524,
    "CurrencyMode": "Base",
    "CurrencyCode": "voluptas",
    "Measure": "Average",
    "MeasureField": "nulla",
    "SortBy": "aut",
    "LayoutConfig": "quis",
    "SecondarySelectionId": 699,
    "MeasureByField": "qui",
    "ProviderName": "Cummerata-Jacobi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 951
      }
    }
  },
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
      "FieldLength": 80
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```