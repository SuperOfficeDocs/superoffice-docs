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
  "HierarchyId": 88,
  "Domain": "Dashboards",
  "Name": "Emard-Bednar",
  "Fullname": "labore",
  "ParentId": 510,
  "Children": [
    {
      "HierarchyId": 27,
      "Domain": "Dashboards",
      "Name": "Kerluke, Sawayn and Runte",
      "Fullname": "dolor",
      "ParentId": 328,
      "Children": [
        {},
        {}
      ],
      "Registered": "2000-12-22T14:23:46.8942625+01:00",
      "RegisteredAssociateId": 89,
      "Updated": "1996-12-12T14:23:46.8942625+01:00",
      "UpdatedAssociateId": 462
    }
  ],
  "Registered": "2014-11-27T14:23:46.8942625+01:00",
  "RegisteredAssociateId": 373,
  "Updated": "2020-09-14T14:23:46.8942625+02:00",
  "UpdatedAssociateId": 63
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 584,
  "Domain": "Dashboards",
  "Name": "Shanahan, Senger and Dietrich",
  "Fullname": "quis",
  "ParentId": 310,
  "Children": [
    {
      "HierarchyId": 694,
      "Domain": "Dashboards",
      "Name": "Kovacek, Beahan and Boehm",
      "Fullname": "quo",
      "ParentId": 634,
      "Children": [
        {},
        {}
      ],
      "Registered": "2023-05-09T14:23:46.8942625+02:00",
      "RegisteredAssociateId": 811,
      "Updated": "2022-04-24T14:23:46.8942625+02:00",
      "UpdatedAssociateId": 122,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    }
  ],
  "Registered": "2003-02-08T14:23:46.8942625+01:00",
  "RegisteredAssociateId": 249,
  "Updated": "2000-05-09T14:23:46.8942625+02:00",
  "UpdatedAssociateId": 831,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 604
    }
  }
}
```