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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 926,
  "Domain": "Dashboards",
  "Name": "McDermott Group",
  "Fullname": "recusandae",
  "ParentId": 516,
  "Children": [
    {
      "HierarchyId": 356,
      "Domain": "Dashboards",
      "Name": "Fisher-Volkman",
      "Fullname": "amet",
      "ParentId": 204,
      "Children": [
        {},
        {}
      ],
      "Registered": "1997-12-08T16:54:55.6199845+01:00",
      "RegisteredAssociateId": 175,
      "Updated": "2002-10-15T16:54:55.6199845+02:00",
      "UpdatedAssociateId": 923
    }
  ],
  "Registered": "2001-10-28T16:54:55.6199845+01:00",
  "RegisteredAssociateId": 78,
  "Updated": "2010-10-21T16:54:55.6199845+02:00",
  "UpdatedAssociateId": 275
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 678,
  "Domain": "Dashboards",
  "Name": "Murray Inc and Sons",
  "Fullname": "iste",
  "ParentId": 150,
  "Children": [
    {
      "HierarchyId": 412,
      "Domain": "Dashboards",
      "Name": "Spinka-Cruickshank",
      "Fullname": "officiis",
      "ParentId": 692,
      "Children": [
        {},
        {}
      ],
      "Registered": "2020-04-10T16:54:55.6199845+02:00",
      "RegisteredAssociateId": 65,
      "Updated": "2016-02-17T16:54:55.6199845+01:00",
      "UpdatedAssociateId": 610,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "Registered": "2019-11-14T16:54:55.6199845+01:00",
  "RegisteredAssociateId": 212,
  "Updated": "2002-09-13T16:54:55.6199845+02:00",
  "UpdatedAssociateId": 684,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 177
    }
  }
}
```