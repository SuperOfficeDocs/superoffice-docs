---
title: PUT Hierarchy/{id}
id: v1HierarchyEntity_PutHierarchyEntity
---

# PUT Hierarchy/{id}

```http
PUT /api/v1/Hierarchy/{id}
```

Updates the existing HierarchyEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The HierarchyEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Hierarchy/{id}?$select=name,department,category/id
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

## Request Body: entity  

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
| 200 | HierarchyEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Hierarchy/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 652,
  "Domain": "Dashboards",
  "Name": "Heathcote Group",
  "Fullname": "tempore",
  "ParentId": 590,
  "Children": [
    {
      "HierarchyId": 634,
      "Domain": "Dashboards",
      "Name": "Blick-Kessler",
      "Fullname": "quas",
      "ParentId": 704,
      "Children": [
        {},
        {}
      ],
      "Registered": "2010-01-24T09:40:59.2356629+01:00",
      "RegisteredAssociateId": 358,
      "Updated": "2007-08-21T09:40:59.2356629+02:00",
      "UpdatedAssociateId": 670
    }
  ],
  "Registered": "2012-08-24T09:40:59.2356629+02:00",
  "RegisteredAssociateId": 323,
  "Updated": "2015-01-21T09:40:59.2356629+01:00",
  "UpdatedAssociateId": 597
}
```

```http_
HTTP/1.1 200 HierarchyEntity updated.
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 108,
  "Domain": "Dashboards",
  "Name": "Wunsch Group",
  "Fullname": "est",
  "ParentId": 629,
  "Children": [
    {
      "HierarchyId": 424,
      "Domain": "Dashboards",
      "Name": "Howell LLC",
      "Fullname": "ipsum",
      "ParentId": 360,
      "Children": [
        {},
        {}
      ],
      "Registered": "2020-09-09T09:40:59.2366629+02:00",
      "RegisteredAssociateId": 894,
      "Updated": "2005-04-14T09:40:59.2366629+02:00",
      "UpdatedAssociateId": 62,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    }
  ],
  "Registered": "2019-08-27T09:40:59.2366629+02:00",
  "RegisteredAssociateId": 83,
  "Updated": "2012-05-13T09:40:59.2366629+02:00",
  "UpdatedAssociateId": 436,
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
      "FieldLength": 541
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```