---
title: POST Agents/List/SaveHierarchyEntity
uid: v1ListAgent_SaveHierarchyEntity
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/SaveHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 226,
  "Domain": "Dashboards",
  "Name": "Jakubowski, Bartoletti and Herzog",
  "Fullname": "qui",
  "ParentId": 321,
  "Children": [
    {
      "HierarchyId": 300,
      "Domain": "Dashboards",
      "Name": "Schmeler-Kshlerin",
      "Fullname": "eos",
      "ParentId": 599,
      "Children": [
        {},
        {}
      ],
      "Registered": "2007-07-31T11:22:38.5240368+02:00",
      "RegisteredAssociateId": 759,
      "Updated": "2015-05-29T11:22:38.5240368+02:00",
      "UpdatedAssociateId": 224
    }
  ],
  "Registered": "2000-03-10T11:22:38.5240368+01:00",
  "RegisteredAssociateId": 131,
  "Updated": "2006-11-18T11:22:38.5240368+01:00",
  "UpdatedAssociateId": 290
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 37,
  "Domain": "Dashboards",
  "Name": "Herzog, Kub and Graham",
  "Fullname": "in",
  "ParentId": 401,
  "Children": [
    {
      "HierarchyId": 840,
      "Domain": "Dashboards",
      "Name": "Hettinger-Bradtke",
      "Fullname": "dolores",
      "ParentId": 338,
      "Children": [
        {},
        {}
      ],
      "Registered": "2016-08-23T11:22:38.5240368+02:00",
      "RegisteredAssociateId": 223,
      "Updated": "1999-11-29T11:22:38.5240368+01:00",
      "UpdatedAssociateId": 461,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    }
  ],
  "Registered": "2005-12-13T11:22:38.5240368+01:00",
  "RegisteredAssociateId": 53,
  "Updated": "1998-08-20T11:22:38.5240368+02:00",
  "UpdatedAssociateId": 54,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 762
    }
  }
}
```