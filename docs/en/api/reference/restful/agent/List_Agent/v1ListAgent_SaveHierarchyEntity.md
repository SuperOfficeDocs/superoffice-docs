---
title: POST Agents/List/SaveHierarchyEntity
uid: v1ListAgent_SaveHierarchyEntity
---

# POST Agents/List/SaveHierarchyEntity

```http
POST /api/v1/Agents/List/SaveHierarchyEntity
```

Updates the existing HierarchyEntity or creates a new HierarchyEntity if the id parameter is empty








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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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

## Sample request

```http!
POST /api/v1/Agents/List/SaveHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 489,
  "Domain": "Dashboards",
  "Name": "Kiehn, Friesen and Kirlin",
  "Fullname": "molestiae",
  "ParentId": 137,
  "Children": [
    {
      "HierarchyId": 902,
      "Domain": "Dashboards",
      "Name": "Zulauf, Friesen and Bauch",
      "Fullname": "blanditiis",
      "ParentId": 315,
      "Children": [
        {},
        {}
      ],
      "Registered": "2001-07-21T02:49:44.6860468+02:00",
      "RegisteredAssociateId": 619,
      "Updated": "1998-12-20T02:49:44.6860468+01:00",
      "UpdatedAssociateId": 561
    }
  ],
  "Registered": "2011-09-06T02:49:44.6860468+02:00",
  "RegisteredAssociateId": 542,
  "Updated": "2018-03-18T02:49:44.6860468+01:00",
  "UpdatedAssociateId": 281
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 536,
  "Domain": "Dashboards",
  "Name": "Bailey LLC",
  "Fullname": "quia",
  "ParentId": 24,
  "Children": [
    {
      "HierarchyId": 139,
      "Domain": "Dashboards",
      "Name": "Bartell Group",
      "Fullname": "nemo",
      "ParentId": 883,
      "Children": [
        {},
        {}
      ],
      "Registered": "2021-09-20T02:49:44.6860468+02:00",
      "RegisteredAssociateId": 293,
      "Updated": "1998-07-15T02:49:44.6860468+02:00",
      "UpdatedAssociateId": 469,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 807
        }
      }
    }
  ],
  "Registered": "1998-12-15T02:49:44.6860468+01:00",
  "RegisteredAssociateId": 475,
  "Updated": "2022-02-27T02:49:44.6860468+01:00",
  "UpdatedAssociateId": 603,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 624
    }
  }
}
```