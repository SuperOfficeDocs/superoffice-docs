---
title: POST Hierarchy
id: v1HierarchyEntity_PostHierarchyEntity
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


## Response: object

Folder structures



HierarchyEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Hierarchy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 777,
  "Domain": "Dashboards",
  "Name": "Haley, Schulist and Barrows",
  "Fullname": "voluptas",
  "ParentId": 561,
  "Children": [
    {
      "HierarchyId": 19,
      "Domain": "Dashboards",
      "Name": "Hilpert-Dibbert",
      "Fullname": "assumenda",
      "ParentId": 200,
      "Children": [
        {},
        {}
      ],
      "Registered": "1994-05-30T09:40:59.2346629+02:00",
      "RegisteredAssociateId": 466,
      "Updated": "2001-04-17T09:40:59.2346629+02:00",
      "UpdatedAssociateId": 731
    }
  ],
  "Registered": "2016-07-17T09:40:59.2346629+02:00",
  "RegisteredAssociateId": 430,
  "Updated": "2003-11-16T09:40:59.2346629+01:00",
  "UpdatedAssociateId": 135
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 322,
  "Domain": "Dashboards",
  "Name": "Reichel, Orn and Cummerata",
  "Fullname": "omnis",
  "ParentId": 255,
  "Children": [
    {
      "HierarchyId": 755,
      "Domain": "Dashboards",
      "Name": "Kirlin-Sporer",
      "Fullname": "molestiae",
      "ParentId": 852,
      "Children": [
        {},
        {}
      ],
      "Registered": "2003-03-31T09:40:59.2346629+02:00",
      "RegisteredAssociateId": 784,
      "Updated": "1997-12-09T09:40:59.2346629+01:00",
      "UpdatedAssociateId": 546,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 155
        }
      }
    }
  ],
  "Registered": "2013-01-15T09:40:59.2346629+01:00",
  "RegisteredAssociateId": 220,
  "Updated": "2001-07-21T09:40:59.2346629+02:00",
  "UpdatedAssociateId": 30,
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
      "FieldLength": 563
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```