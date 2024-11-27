---
title: POST Agents/List/SaveHierarchyEntity
uid: v1ListAgent_SaveHierarchyEntity
generated: true
---

# POST Agents/List/SaveHierarchyEntity

```http
POST /api/v1/Agents/List/SaveHierarchyEntity
```

Updates the existing HierarchyEntity or creates a new HierarchyEntity if the id parameter is empty








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

The HierarchyEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| HierarchyId | Integer | The primary key (auto-incremented) |
| Domain | String | Domain seperating the different hierarchy |
| Name | String | Name of this hierarchy folder. |
| Fullname | String | The full name of this category, i.e. Foo/bar/test. |
| ParentId | Integer | Parent table |
| Children | Array | Sub-items, if any. |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: HierarchyEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| HierarchyId | int32 | The primary key (auto-incremented) |
| Domain | string | Domain seperating the different hierarchy |
| Name | string | Name of this hierarchy folder. |
| Fullname | string | The full name of this category, i.e. Foo/bar/test. |
| ParentId | int32 | Parent table |
| Children | array | Sub-items, if any. |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 285,
  "Domain": "Dashboards",
  "Name": "Runte Inc and Sons",
  "Fullname": "vel",
  "ParentId": 637,
  "Children": [
    {
      "HierarchyId": 463,
      "Domain": "Dashboards",
      "Name": "Waters Group",
      "Fullname": "consequatur",
      "ParentId": 669,
      "Children": [
        {},
        {}
      ],
      "Registered": "2012-02-12T14:45:05.7563266+01:00",
      "RegisteredAssociateId": 304,
      "Updated": "2012-12-12T14:45:05.7563266+01:00",
      "UpdatedAssociateId": 84
    }
  ],
  "Registered": "2007-12-04T14:45:05.7563266+01:00",
  "RegisteredAssociateId": 631,
  "Updated": "2010-04-23T14:45:05.7563266+02:00",
  "UpdatedAssociateId": 7
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 887,
  "Domain": "Dashboards",
  "Name": "Jerde, Hilpert and Ankunding",
  "Fullname": "sequi",
  "ParentId": 675,
  "Children": [
    {
      "HierarchyId": 703,
      "Domain": "Dashboards",
      "Name": "Emmerich LLC",
      "Fullname": "ducimus",
      "ParentId": 403,
      "Children": [
        {},
        {}
      ],
      "Registered": "2010-01-24T14:45:05.7563266+01:00",
      "RegisteredAssociateId": 934,
      "Updated": "1999-09-24T14:45:05.7563266+02:00",
      "UpdatedAssociateId": 311,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 236
        }
      }
    }
  ],
  "Registered": "2011-04-06T14:45:05.7563266+02:00",
  "RegisteredAssociateId": 596,
  "Updated": "2023-06-25T14:45:05.7563266+02:00",
  "UpdatedAssociateId": 986,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 393
    }
  }
}
```