---
title: POST Agents/List/SaveHierarchyEntity
uid: v1ListAgent_SaveHierarchyEntity
generated: true
content_type: reference
---

# POST Agents/List/SaveHierarchyEntity

```http
POST /api/v1/Agents/List/SaveHierarchyEntity
```

Updates the existing HierarchyEntity or creates a new HierarchyEntity if the id parameter is 0.


NsApiSlow threshold: 5000 ms.







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

## Request Body: hierarchyEntity 

The HierarchyEntity that is saved 

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
  "HierarchyId": 189,
  "Domain": "Dashboards",
  "Name": "Funk-Schoen",
  "Fullname": "incidunt",
  "ParentId": 255,
  "Children": [
    {
      "HierarchyId": 922,
      "Domain": "Dashboards",
      "Name": "McKenzie Inc and Sons",
      "Fullname": "quam",
      "ParentId": 530,
      "Children": [
        {},
        {}
      ],
      "Registered": "2019-06-27T03:40:47.2030415+02:00",
      "RegisteredAssociateId": 296,
      "Updated": "2011-08-18T03:40:47.2030415+02:00",
      "UpdatedAssociateId": 740
    }
  ],
  "Registered": "2014-02-27T03:40:47.2030415+01:00",
  "RegisteredAssociateId": 803,
  "Updated": "2010-01-20T03:40:47.2030415+01:00",
  "UpdatedAssociateId": 776
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 42,
  "Domain": "Dashboards",
  "Name": "Rutherford, Yost and Schamberger",
  "Fullname": "quidem",
  "ParentId": 467,
  "Children": [
    {
      "HierarchyId": 91,
      "Domain": "Dashboards",
      "Name": "Kertzmann, Goldner and Buckridge",
      "Fullname": "adipisci",
      "ParentId": 248,
      "Children": [
        {},
        {}
      ],
      "Registered": "2001-07-22T03:40:47.2030415+02:00",
      "RegisteredAssociateId": 7,
      "Updated": "2023-01-20T03:40:47.2030415+01:00",
      "UpdatedAssociateId": 789,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 247
        }
      }
    }
  ],
  "Registered": "2005-11-06T03:40:47.2030415+01:00",
  "RegisteredAssociateId": 533,
  "Updated": "2016-02-22T03:40:47.2030415+01:00",
  "UpdatedAssociateId": 220,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 441
    }
  }
}
```