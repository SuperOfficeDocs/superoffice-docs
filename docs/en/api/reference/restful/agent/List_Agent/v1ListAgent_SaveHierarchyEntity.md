---
title: POST Agents/List/SaveHierarchyEntity
uid: v1ListAgent_SaveHierarchyEntity
generated: true
content_type: reference
---

# POST Agents/List/SaveHierarchyEntity

```http
POST /api/v1/Agents/List/SaveHierarchyEntity
```

Updates the existing HierarchyEntity or creates a new HierarchyEntity if the id parameter is 0.


NsApiSlow threshold: 5000 ms.







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

## Request Body: hierarchyEntity 

The HierarchyEntity that is saved 

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

### Response body: HierarchyEntity

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

## Sample request

```http!
POST /api/v1/Agents/List/SaveHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 728,
  "Domain": "Dashboards",
  "Name": "Schultz Group",
  "Fullname": "et",
  "ParentId": 264,
  "Children": [
    {
      "HierarchyId": 183,
      "Domain": "Dashboards",
      "Name": "Blick-Heller",
      "Fullname": "beatae",
      "ParentId": 988,
      "Children": [
        {},
        {}
      ],
      "Registered": "2001-07-28T02:30:47.4288293+02:00",
      "RegisteredAssociateId": 178,
      "Updated": "2021-10-22T02:30:47.4288293+02:00",
      "UpdatedAssociateId": 84
    }
  ],
  "Registered": "2013-05-14T02:30:47.4288293+02:00",
  "RegisteredAssociateId": 408,
  "Updated": "1998-11-05T02:30:47.4288293+01:00",
  "UpdatedAssociateId": 483
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 159,
  "Domain": "Dashboards",
  "Name": "Ortiz-Leuschke",
  "Fullname": "sed",
  "ParentId": 199,
  "Children": [
    {
      "HierarchyId": 964,
      "Domain": "Dashboards",
      "Name": "Runolfsdottir-Denesik",
      "Fullname": "voluptatum",
      "ParentId": 167,
      "Children": [
        {},
        {}
      ],
      "Registered": "2013-10-09T02:30:47.4288293+02:00",
      "RegisteredAssociateId": 943,
      "Updated": "1999-03-31T02:30:47.4288293+02:00",
      "UpdatedAssociateId": 862,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 397
        }
      }
    }
  ],
  "Registered": "2023-11-19T02:30:47.4288293+01:00",
  "RegisteredAssociateId": 165,
  "Updated": "2014-01-05T02:30:47.4288293+01:00",
  "UpdatedAssociateId": 171,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 947
    }
  }
}
```