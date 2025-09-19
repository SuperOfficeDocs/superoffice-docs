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
  "HierarchyId": 35,
  "Domain": "Dashboards",
  "Name": "Murazik Inc and Sons",
  "Fullname": "magnam",
  "ParentId": 859,
  "Children": [
    {
      "HierarchyId": 701,
      "Domain": "Dashboards",
      "Name": "Kessler Inc and Sons",
      "Fullname": "quas",
      "ParentId": 128,
      "Children": [
        {},
        {}
      ],
      "Registered": "2024-12-12T03:41:58.7617712+01:00",
      "RegisteredAssociateId": 20,
      "Updated": "2002-05-25T03:41:58.7617712+02:00",
      "UpdatedAssociateId": 490
    }
  ],
  "Registered": "2023-12-24T03:41:58.7617712+01:00",
  "RegisteredAssociateId": 178,
  "Updated": "2024-08-03T03:41:58.7617712+02:00",
  "UpdatedAssociateId": 982
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 845,
  "Domain": "Dashboards",
  "Name": "Langosh, Morar and Ankunding",
  "Fullname": "incidunt",
  "ParentId": 863,
  "Children": [
    {
      "HierarchyId": 601,
      "Domain": "Dashboards",
      "Name": "Dietrich-Treutel",
      "Fullname": "optio",
      "ParentId": 675,
      "Children": [
        {},
        {}
      ],
      "Registered": "2025-03-27T03:41:58.7617712+01:00",
      "RegisteredAssociateId": 617,
      "Updated": "2002-10-07T03:41:58.7617712+02:00",
      "UpdatedAssociateId": 708,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 2
        }
      }
    }
  ],
  "Registered": "2011-07-13T03:41:58.7617712+02:00",
  "RegisteredAssociateId": 334,
  "Updated": "2020-08-13T03:41:58.7617712+02:00",
  "UpdatedAssociateId": 589,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 521
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```