---
title: POST Hierarchy
uid: v1HierarchyEntity_PostHierarchyEntity
---

# POST Hierarchy

```http
POST /api/v1/Hierarchy
```

Creates a new HierarchyEntity

Calls the List agent service SaveHierarchyEntity.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Hierarchy?$select=name,department,category/id
```

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

## Request Body: newEntity

The HierarchyEntity to be saved.

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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Hierarchy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 211,
  "Domain": "Dashboards",
  "Name": "Towne-Lowe",
  "Fullname": "eligendi",
  "ParentId": 67,
  "Children": [
    {
      "HierarchyId": 764,
      "Domain": "Dashboards",
      "Name": "Schowalter, Block and Pouros",
      "Fullname": "ipsa",
      "ParentId": 660,
      "Children": [
        {},
        {}
      ],
      "Registered": "2011-10-15T11:10:52.9141798+02:00",
      "RegisteredAssociateId": 191,
      "Updated": "2009-10-13T11:10:52.9141798+02:00",
      "UpdatedAssociateId": 44
    }
  ],
  "Registered": "2008-04-24T11:10:52.9141798+02:00",
  "RegisteredAssociateId": 272,
  "Updated": "2008-04-15T11:10:52.9141798+02:00",
  "UpdatedAssociateId": 561
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 927,
  "Domain": "Dashboards",
  "Name": "Adams, Grant and Bogan",
  "Fullname": "aut",
  "ParentId": 257,
  "Children": [
    {
      "HierarchyId": 112,
      "Domain": "Dashboards",
      "Name": "Smith, Mayer and Monahan",
      "Fullname": "sint",
      "ParentId": 698,
      "Children": [
        {},
        {}
      ],
      "Registered": "2002-06-12T11:10:52.9141798+02:00",
      "RegisteredAssociateId": 913,
      "Updated": "1998-01-18T11:10:52.9141798+01:00",
      "UpdatedAssociateId": 988,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 567
        }
      }
    }
  ],
  "Registered": "2018-09-20T11:10:52.9141798+02:00",
  "RegisteredAssociateId": 120,
  "Updated": "2010-09-02T11:10:52.9141798+02:00",
  "UpdatedAssociateId": 898,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 344
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
