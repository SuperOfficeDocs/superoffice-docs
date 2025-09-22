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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 345,
  "Domain": "Dashboards",
  "Name": "Wisoky LLC",
  "Fullname": "dolorem",
  "ParentId": 571,
  "Children": [
    {
      "HierarchyId": 738,
      "Domain": "Dashboards",
      "Name": "Lynch Group",
      "Fullname": "aut",
      "ParentId": 612,
      "Children": [
        {},
        {}
      ],
      "Registered": "1999-11-23T11:24:53.2968202+01:00",
      "RegisteredAssociateId": 461,
      "Updated": "2024-12-29T11:24:53.2968202+01:00",
      "UpdatedAssociateId": 559
    }
  ],
  "Registered": "2023-12-12T11:24:53.2968202+01:00",
  "RegisteredAssociateId": 842,
  "Updated": "2014-06-27T11:24:53.2968202+02:00",
  "UpdatedAssociateId": 8
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 808,
  "Domain": "Dashboards",
  "Name": "Bergstrom-Mills",
  "Fullname": "ut",
  "ParentId": 119,
  "Children": [
    {
      "HierarchyId": 317,
      "Domain": "Dashboards",
      "Name": "Jones-Prosacco",
      "Fullname": "et",
      "ParentId": 466,
      "Children": [
        {},
        {}
      ],
      "Registered": "2017-01-05T11:24:53.2968202+01:00",
      "RegisteredAssociateId": 428,
      "Updated": "2005-11-09T11:24:53.2968202+01:00",
      "UpdatedAssociateId": 632,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    }
  ],
  "Registered": "2004-07-20T11:24:53.2968202+02:00",
  "RegisteredAssociateId": 680,
  "Updated": "1998-11-22T11:24:53.2968202+01:00",
  "UpdatedAssociateId": 350,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 85
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```