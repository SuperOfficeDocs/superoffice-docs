---
title: POST Hierarchy
uid: v1HierarchyEntity_PostHierarchyEntity
generated: true
content_type: reference
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
POST /api/v1/Hierarchy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 957,
  "Domain": "Dashboards",
  "Name": "Brekke Inc and Sons",
  "Fullname": "ea",
  "ParentId": 560,
  "Children": [
    {
      "HierarchyId": 865,
      "Domain": "Dashboards",
      "Name": "Blanda Inc and Sons",
      "Fullname": "illo",
      "ParentId": 88,
      "Children": [
        {},
        {}
      ],
      "Registered": "2004-02-10T03:47:00.0349452+01:00",
      "RegisteredAssociateId": 295,
      "Updated": "1998-06-19T03:47:00.0349452+02:00",
      "UpdatedAssociateId": 933
    }
  ],
  "Registered": "2020-01-03T03:47:00.0349452+01:00",
  "RegisteredAssociateId": 950,
  "Updated": "2018-03-22T03:47:00.0349452+01:00",
  "UpdatedAssociateId": 428
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 233,
  "Domain": "Dashboards",
  "Name": "Hirthe, Bauch and Lowe",
  "Fullname": "cumque",
  "ParentId": 433,
  "Children": [
    {
      "HierarchyId": 14,
      "Domain": "Dashboards",
      "Name": "Collins-Ruecker",
      "Fullname": "eaque",
      "ParentId": 368,
      "Children": [
        {},
        {}
      ],
      "Registered": "2011-01-31T03:47:00.0349452+01:00",
      "RegisteredAssociateId": 225,
      "Updated": "2003-08-15T03:47:00.0349452+02:00",
      "UpdatedAssociateId": 34,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    }
  ],
  "Registered": "2024-08-26T03:47:00.0349452+02:00",
  "RegisteredAssociateId": 613,
  "Updated": "2006-04-29T03:47:00.0349452+02:00",
  "UpdatedAssociateId": 892,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 354
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```