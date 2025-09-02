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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 268,
  "Domain": "Dashboards",
  "Name": "Moore Inc and Sons",
  "Fullname": "et",
  "ParentId": 4,
  "Children": [
    {
      "HierarchyId": 486,
      "Domain": "Dashboards",
      "Name": "Lubowitz-Jast",
      "Fullname": "vel",
      "ParentId": 378,
      "Children": [
        {},
        {}
      ],
      "Registered": "2008-02-04T03:46:54.9726245+01:00",
      "RegisteredAssociateId": 237,
      "Updated": "2020-01-16T03:46:54.9726245+01:00",
      "UpdatedAssociateId": 361
    }
  ],
  "Registered": "2001-01-17T03:46:54.9726245+01:00",
  "RegisteredAssociateId": 847,
  "Updated": "2011-09-06T03:46:54.9726245+02:00",
  "UpdatedAssociateId": 894
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 162,
  "Domain": "Dashboards",
  "Name": "Hodkiewicz, Johnson and Kerluke",
  "Fullname": "ducimus",
  "ParentId": 713,
  "Children": [
    {
      "HierarchyId": 311,
      "Domain": "Dashboards",
      "Name": "Collins, Mayer and Feeney",
      "Fullname": "necessitatibus",
      "ParentId": 386,
      "Children": [
        {},
        {}
      ],
      "Registered": "2003-02-06T03:46:54.9726245+01:00",
      "RegisteredAssociateId": 357,
      "Updated": "2024-07-30T03:46:54.9726245+02:00",
      "UpdatedAssociateId": 734,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 100
        }
      }
    }
  ],
  "Registered": "2008-11-23T03:46:54.9726245+01:00",
  "RegisteredAssociateId": 480,
  "Updated": "2007-04-12T03:46:54.9726245+02:00",
  "UpdatedAssociateId": 439,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 292
    }
  }
}
```