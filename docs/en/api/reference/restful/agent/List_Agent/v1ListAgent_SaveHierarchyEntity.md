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
  "HierarchyId": 598,
  "Domain": "Dashboards",
  "Name": "Zulauf-Langosh",
  "Fullname": "ut",
  "ParentId": 476,
  "Children": [
    {
      "HierarchyId": 119,
      "Domain": "Dashboards",
      "Name": "Waters-Pfannerstill",
      "Fullname": "fugit",
      "ParentId": 877,
      "Children": [
        {},
        {}
      ],
      "Registered": "2007-08-02T12:57:34.2117122+02:00",
      "RegisteredAssociateId": 120,
      "Updated": "2010-09-17T12:57:34.2117122+02:00",
      "UpdatedAssociateId": 933
    }
  ],
  "Registered": "2006-12-14T12:57:34.2117122+01:00",
  "RegisteredAssociateId": 164,
  "Updated": "2015-02-14T12:57:34.2117122+01:00",
  "UpdatedAssociateId": 406
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 760,
  "Domain": "Dashboards",
  "Name": "Orn, Aufderhar and Bernier",
  "Fullname": "aperiam",
  "ParentId": 941,
  "Children": [
    {
      "HierarchyId": 128,
      "Domain": "Dashboards",
      "Name": "Smitham-Deckow",
      "Fullname": "dolorum",
      "ParentId": 683,
      "Children": [
        {},
        {}
      ],
      "Registered": "2024-01-23T12:57:34.2117122+01:00",
      "RegisteredAssociateId": 606,
      "Updated": "2008-07-24T12:57:34.2117122+02:00",
      "UpdatedAssociateId": 547,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 68
        }
      }
    }
  ],
  "Registered": "2005-09-18T12:57:34.2117122+02:00",
  "RegisteredAssociateId": 304,
  "Updated": "2004-12-17T12:57:34.2117122+01:00",
  "UpdatedAssociateId": 201,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 870
    }
  }
}
```