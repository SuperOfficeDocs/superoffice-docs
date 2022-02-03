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
  "HierarchyId": 451,
  "Domain": "Dashboards",
  "Name": "Wolff-Zboncak",
  "Fullname": "ut",
  "ParentId": 173,
  "Children": [
    {
      "HierarchyId": 177,
      "Domain": "Dashboards",
      "Name": "Howell, Koss and Dooley",
      "Fullname": "consequatur",
      "ParentId": 722,
      "Children": [
        {},
        {}
      ],
      "Registered": "2010-06-16T18:25:50.5785973+02:00",
      "RegisteredAssociateId": 17,
      "Updated": "2001-10-29T18:25:50.5785973+01:00",
      "UpdatedAssociateId": 45
    }
  ],
  "Registered": "2002-04-14T18:25:50.5785973+02:00",
  "RegisteredAssociateId": 769,
  "Updated": "2014-07-03T18:25:50.5785973+02:00",
  "UpdatedAssociateId": 194
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 846,
  "Domain": "Dashboards",
  "Name": "Glover-Conn",
  "Fullname": "rerum",
  "ParentId": 60,
  "Children": [
    {
      "HierarchyId": 356,
      "Domain": "Dashboards",
      "Name": "Rice, Heaney and King",
      "Fullname": "est",
      "ParentId": 216,
      "Children": [
        {},
        {}
      ],
      "Registered": "2020-02-28T18:25:50.5795975+01:00",
      "RegisteredAssociateId": 150,
      "Updated": "2010-04-08T18:25:50.5795975+02:00",
      "UpdatedAssociateId": 777,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 21
        }
      }
    }
  ],
  "Registered": "2002-10-16T18:25:50.5795975+02:00",
  "RegisteredAssociateId": 213,
  "Updated": "1999-04-27T18:25:50.5795975+02:00",
  "UpdatedAssociateId": 282,
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
      "FieldLength": 749
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```