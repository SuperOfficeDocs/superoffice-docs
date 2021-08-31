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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 736,
  "Domain": "Dashboards",
  "Name": "Roob-Bartell",
  "Fullname": "assumenda",
  "ParentId": 805,
  "Children": [
    {
      "HierarchyId": 273,
      "Domain": "Dashboards",
      "Name": "Davis, Dare and Lueilwitz",
      "Fullname": "corporis",
      "ParentId": 117,
      "Children": [
        {},
        {}
      ],
      "Registered": "2013-08-22T15:05:42.250668+02:00",
      "RegisteredAssociateId": 478,
      "Updated": "2003-05-20T15:05:42.250668+02:00",
      "UpdatedAssociateId": 770
    }
  ],
  "Registered": "2004-10-29T15:05:42.250668+02:00",
  "RegisteredAssociateId": 820,
  "Updated": "2015-02-18T15:05:42.250668+01:00",
  "UpdatedAssociateId": 490
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 698,
  "Domain": "Dashboards",
  "Name": "Hermiston, Harris and Crist",
  "Fullname": "praesentium",
  "ParentId": 42,
  "Children": [
    {
      "HierarchyId": 52,
      "Domain": "Dashboards",
      "Name": "Mante LLC",
      "Fullname": "nesciunt",
      "ParentId": 202,
      "Children": [
        {},
        {}
      ],
      "Registered": "2019-01-16T15:05:42.250668+01:00",
      "RegisteredAssociateId": 490,
      "Updated": "2014-05-07T15:05:42.250668+02:00",
      "UpdatedAssociateId": 104,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engineer revolutionary communities"
          },
          "FieldType": "System.Int32",
          "FieldLength": 281
        }
      }
    }
  ],
  "Registered": "2002-10-07T15:05:42.250668+02:00",
  "RegisteredAssociateId": 687,
  "Updated": "1999-04-03T15:05:42.250668+02:00",
  "UpdatedAssociateId": 828,
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
      "FieldType": "System.String",
      "FieldLength": 20
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```