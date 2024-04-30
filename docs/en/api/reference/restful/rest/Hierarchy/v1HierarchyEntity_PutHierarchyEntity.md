---
title: PUT Hierarchy/{id}
uid: v1HierarchyEntity_PutHierarchyEntity
generated: true
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

HierarchyEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | HierarchyEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: HierarchyEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Hierarchy/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 329,
  "Domain": "Dashboards",
  "Name": "Stokes, Mayert and Green",
  "Fullname": "consectetur",
  "ParentId": 586,
  "Children": [
    {
      "HierarchyId": 931,
      "Domain": "Dashboards",
      "Name": "Dicki LLC",
      "Fullname": "autem",
      "ParentId": 927,
      "Children": [
        {},
        {}
      ],
      "Registered": "2016-06-12T11:44:42.0077636+02:00",
      "RegisteredAssociateId": 8,
      "Updated": "2002-10-26T11:44:42.0077636+02:00",
      "UpdatedAssociateId": 827
    }
  ],
  "Registered": "2002-08-25T11:44:42.0077636+02:00",
  "RegisteredAssociateId": 491,
  "Updated": "2004-12-11T11:44:42.0077636+01:00",
  "UpdatedAssociateId": 604
}
```

## Sample response

```http_
HTTP/1.1 200 HierarchyEntity updated.
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 781,
  "Domain": "Dashboards",
  "Name": "Hane LLC",
  "Fullname": "expedita",
  "ParentId": 117,
  "Children": [
    {
      "HierarchyId": 131,
      "Domain": "Dashboards",
      "Name": "Sanford-Yundt",
      "Fullname": "excepturi",
      "ParentId": 405,
      "Children": [
        {},
        {}
      ],
      "Registered": "1997-12-07T11:44:42.0077636+01:00",
      "RegisteredAssociateId": 582,
      "Updated": "2011-03-25T11:44:42.0077636+01:00",
      "UpdatedAssociateId": 879,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    }
  ],
  "Registered": "2004-06-24T11:44:42.0077636+02:00",
  "RegisteredAssociateId": 19,
  "Updated": "2019-11-15T11:44:42.0077636+01:00",
  "UpdatedAssociateId": 159,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 985
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```