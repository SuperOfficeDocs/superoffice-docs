---
title: POST Hierarchy
uid: v1HierarchyEntity_PostHierarchyEntity
generated: true
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
  "HierarchyId": 990,
  "Domain": "Dashboards",
  "Name": "Ortiz, Hackett and Hamill",
  "Fullname": "cum",
  "ParentId": 647,
  "Children": [
    {
      "HierarchyId": 147,
      "Domain": "Dashboards",
      "Name": "Prohaska-Shanahan",
      "Fullname": "consequuntur",
      "ParentId": 191,
      "Children": [
        {},
        {}
      ],
      "Registered": "2011-03-26T12:57:42.4638774+01:00",
      "RegisteredAssociateId": 494,
      "Updated": "2011-04-04T12:57:42.4638774+02:00",
      "UpdatedAssociateId": 754
    }
  ],
  "Registered": "2014-11-05T12:57:42.4638774+01:00",
  "RegisteredAssociateId": 534,
  "Updated": "2016-10-21T12:57:42.4638774+02:00",
  "UpdatedAssociateId": 49
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 60,
  "Domain": "Dashboards",
  "Name": "Runolfsdottir, Wisoky and O'Conner",
  "Fullname": "repellendus",
  "ParentId": 919,
  "Children": [
    {
      "HierarchyId": 925,
      "Domain": "Dashboards",
      "Name": "Collins Inc and Sons",
      "Fullname": "ut",
      "ParentId": 338,
      "Children": [
        {},
        {}
      ],
      "Registered": "2007-02-18T12:57:42.4638774+01:00",
      "RegisteredAssociateId": 39,
      "Updated": "2021-01-17T12:57:42.4638774+01:00",
      "UpdatedAssociateId": 811,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    }
  ],
  "Registered": "2002-07-21T12:57:42.4638774+02:00",
  "RegisteredAssociateId": 558,
  "Updated": "2009-02-12T12:57:42.4638774+01:00",
  "UpdatedAssociateId": 297,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 866
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```