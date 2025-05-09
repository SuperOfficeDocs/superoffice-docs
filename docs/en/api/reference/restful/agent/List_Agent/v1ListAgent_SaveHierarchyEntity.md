---
title: POST Agents/List/SaveHierarchyEntity
uid: v1ListAgent_SaveHierarchyEntity
generated: true
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
  "HierarchyId": 606,
  "Domain": "Dashboards",
  "Name": "Wiza-Miller",
  "Fullname": "dolor",
  "ParentId": 693,
  "Children": [
    {
      "HierarchyId": 640,
      "Domain": "Dashboards",
      "Name": "Littel-Bins",
      "Fullname": "ipsum",
      "ParentId": 183,
      "Children": [
        {},
        {}
      ],
      "Registered": "2021-01-27T16:32:39.3051024+01:00",
      "RegisteredAssociateId": 311,
      "Updated": "2010-11-01T16:32:39.3051024+01:00",
      "UpdatedAssociateId": 565
    }
  ],
  "Registered": "2006-07-11T16:32:39.3051024+02:00",
  "RegisteredAssociateId": 174,
  "Updated": "2024-04-10T16:32:39.3051024+02:00",
  "UpdatedAssociateId": 693
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 166,
  "Domain": "Dashboards",
  "Name": "Lang-Orn",
  "Fullname": "quia",
  "ParentId": 854,
  "Children": [
    {
      "HierarchyId": 83,
      "Domain": "Dashboards",
      "Name": "Pollich Inc and Sons",
      "Fullname": "quo",
      "ParentId": 159,
      "Children": [
        {},
        {}
      ],
      "Registered": "2003-10-15T16:32:39.3051024+02:00",
      "RegisteredAssociateId": 702,
      "Updated": "2022-04-15T16:32:39.3051024+02:00",
      "UpdatedAssociateId": 649,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    }
  ],
  "Registered": "2016-08-12T16:32:39.3051024+02:00",
  "RegisteredAssociateId": 701,
  "Updated": "2006-12-16T16:32:39.3051024+01:00",
  "UpdatedAssociateId": 366,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 835
    }
  }
}
```