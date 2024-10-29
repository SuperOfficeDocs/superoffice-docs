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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 871,
  "Domain": "Dashboards",
  "Name": "Koss, Jacobi and Krajcik",
  "Fullname": "et",
  "ParentId": 555,
  "Children": [
    {
      "HierarchyId": 786,
      "Domain": "Dashboards",
      "Name": "Morar-Prosacco",
      "Fullname": "et",
      "ParentId": 558,
      "Children": [
        {},
        {}
      ],
      "Registered": "2000-05-30T13:14:06.1164195+02:00",
      "RegisteredAssociateId": 388,
      "Updated": "2009-05-31T13:14:06.1164195+02:00",
      "UpdatedAssociateId": 616
    }
  ],
  "Registered": "2002-10-18T13:14:06.1164195+02:00",
  "RegisteredAssociateId": 383,
  "Updated": "2000-12-13T13:14:06.1164195+01:00",
  "UpdatedAssociateId": 667
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 489,
  "Domain": "Dashboards",
  "Name": "Hudson, Streich and Daugherty",
  "Fullname": "voluptatem",
  "ParentId": 63,
  "Children": [
    {
      "HierarchyId": 584,
      "Domain": "Dashboards",
      "Name": "Effertz-Kovacek",
      "Fullname": "ad",
      "ParentId": 351,
      "Children": [
        {},
        {}
      ],
      "Registered": "2003-07-22T13:14:06.1164195+02:00",
      "RegisteredAssociateId": 773,
      "Updated": "2014-07-16T13:14:06.1164195+02:00",
      "UpdatedAssociateId": 320,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "Registered": "2009-11-07T13:14:06.1164195+01:00",
  "RegisteredAssociateId": 844,
  "Updated": "2013-02-24T13:14:06.1164195+01:00",
  "UpdatedAssociateId": 659,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 408
    }
  }
}
```