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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 343,
  "Domain": "Dashboards",
  "Name": "Dibbert-Balistreri",
  "Fullname": "accusantium",
  "ParentId": 39,
  "Children": [
    {
      "HierarchyId": 463,
      "Domain": "Dashboards",
      "Name": "Hoppe, Spencer and Rempel",
      "Fullname": "voluptatem",
      "ParentId": 175,
      "Children": [
        {},
        {}
      ],
      "Registered": "1997-03-14T16:00:41.2112045+01:00",
      "RegisteredAssociateId": 97,
      "Updated": "1996-11-19T16:00:41.2112045+01:00",
      "UpdatedAssociateId": 401
    }
  ],
  "Registered": "2022-01-08T16:00:41.2112045+01:00",
  "RegisteredAssociateId": 306,
  "Updated": "2014-03-19T16:00:41.2112045+01:00",
  "UpdatedAssociateId": 978
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 796,
  "Domain": "Dashboards",
  "Name": "Torp Inc and Sons",
  "Fullname": "illo",
  "ParentId": 422,
  "Children": [
    {
      "HierarchyId": 96,
      "Domain": "Dashboards",
      "Name": "Schoen-Nikolaus",
      "Fullname": "recusandae",
      "ParentId": 55,
      "Children": [
        {},
        {}
      ],
      "Registered": "2002-02-11T16:00:41.2112045+01:00",
      "RegisteredAssociateId": 633,
      "Updated": "2002-12-28T16:00:41.2112045+01:00",
      "UpdatedAssociateId": 42,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "Registered": "2008-04-19T16:00:41.2112045+02:00",
  "RegisteredAssociateId": 318,
  "Updated": "1996-06-16T16:00:41.2112045+02:00",
  "UpdatedAssociateId": 276,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 648
    }
  }
}
```