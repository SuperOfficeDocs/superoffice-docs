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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 889,
  "Domain": "Dashboards",
  "Name": "Abshire-Gibson",
  "Fullname": "pariatur",
  "ParentId": 78,
  "Children": [
    {
      "HierarchyId": 445,
      "Domain": "Dashboards",
      "Name": "Kreiger-Kuhn",
      "Fullname": "esse",
      "ParentId": 732,
      "Children": [
        {},
        {}
      ],
      "Registered": "2005-05-04T11:24:48.234527+02:00",
      "RegisteredAssociateId": 96,
      "Updated": "2025-06-07T11:24:48.234527+02:00",
      "UpdatedAssociateId": 971
    }
  ],
  "Registered": "2003-09-27T11:24:48.234527+02:00",
  "RegisteredAssociateId": 742,
  "Updated": "2001-07-28T11:24:48.234527+02:00",
  "UpdatedAssociateId": 473
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 411,
  "Domain": "Dashboards",
  "Name": "Harris-Goodwin",
  "Fullname": "quos",
  "ParentId": 52,
  "Children": [
    {
      "HierarchyId": 228,
      "Domain": "Dashboards",
      "Name": "Reichert Inc and Sons",
      "Fullname": "non",
      "ParentId": 385,
      "Children": [
        {},
        {}
      ],
      "Registered": "2001-01-26T11:24:48.234527+01:00",
      "RegisteredAssociateId": 11,
      "Updated": "2002-11-28T11:24:48.234527+01:00",
      "UpdatedAssociateId": 408,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 577
        }
      }
    }
  ],
  "Registered": "2017-08-11T11:24:48.234527+02:00",
  "RegisteredAssociateId": 866,
  "Updated": "2006-10-18T11:24:48.234527+02:00",
  "UpdatedAssociateId": 801,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 65
    }
  }
}
```