---
title: PATCH DashboardTile/{id}
id: v1DashboardTile_PatchDashboardTile
---

# PATCH DashboardTile/{id}

```http
PATCH /api/v1/DashboardTile/{id}
```

Update a DashboardTile with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IDashboardAgent} service SaveDashboardTile.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashboardTile  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/DashboardTile/{id}?$select=name,department,category/id
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



DashboardTile entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DashboardTile  updated. |
| 404 | DashboardTile with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because DashboardTile has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | The tile id |
| Caption | string | The tile caption |
| Description | string | The tile description |
| ChartName | string | The original chart name |
| ChartId | string | The original chart Id |
| IsDefault | bool | True if this is one of the default tiles |
| AssociateId | int32 | Id of the associate who owns this tile |
| GroupId | int32 | Id of the associates primary group at storage time |
| SelectionId | int32 | The selection that defines the data filter/restrictions |
| Config | string | The tile config |
| Type | string | The tile type, what kind of tile this is |
| EntityType | string | The tile entity type |
| Options | array | The tile options |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/DashboardTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "ut",
    "value": {
      "value1": {
        "PrimaryKey": 5041,
        "EntityName": "sale",
        "saleId": 5041,
        "contactId": 1561,
        "name": "Kiehn, Kub and Lakin"
      },
      "value2": {
        "PrimaryKey": 4406,
        "EntityName": "person",
        "personId": 4406,
        "fullName": "Zachery Simonis"
      }
    }
  },
  {
    "op": "add",
    "path": "ut",
    "value": {
      "value1": {
        "PrimaryKey": 5041,
        "EntityName": "sale",
        "saleId": 5041,
        "contactId": 1561,
        "name": "Kiehn, Kub and Lakin"
      },
      "value2": {
        "PrimaryKey": 4406,
        "EntityName": "person",
        "personId": 4406,
        "fullName": "Zachery Simonis"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 DashboardTile  updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 922,
  "Caption": "occaecati",
  "Description": "Synchronised background focus group",
  "ChartName": "Gutkowski, Williamson and Hayes",
  "ChartId": "incidunt",
  "IsDefault": false,
  "AssociateId": 753,
  "GroupId": 534,
  "SelectionId": 441,
  "Config": "maxime",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Grady Group",
      "Description": "Adaptive composite benchmark",
      "Type": "Boolean",
      "ListName": "Walsh, Schneider and O'Hara",
      "ListItems": [
        {},
        {}
      ],
      "Value": "maxime",
      "DefaultDataOption": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 656
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 19,
      "Visibility": "All",
      "DisplayValue": "cupiditate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 879
        }
      }
    },
    {
      "VisibleId": 19,
      "Visibility": "All",
      "DisplayValue": "cupiditate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 879
        }
      }
    }
  ],
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
      "FieldLength": 375
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```