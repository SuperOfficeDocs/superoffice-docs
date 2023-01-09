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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/SaveHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 138,
  "Domain": "Dashboards",
  "Name": "Nicolas LLC",
  "Fullname": "veritatis",
  "ParentId": 944,
  "Children": [
    {
      "HierarchyId": 363,
      "Domain": "Dashboards",
      "Name": "Schaefer-Hartmann",
      "Fullname": "fuga",
      "ParentId": 854,
      "Children": [
        {},
        {}
      ],
      "Registered": "2004-08-24T17:37:18.276242+02:00",
      "RegisteredAssociateId": 965,
      "Updated": "2009-08-17T17:37:18.276242+02:00",
      "UpdatedAssociateId": 716
    }
  ],
  "Registered": "2014-03-17T17:37:18.276242+01:00",
  "RegisteredAssociateId": 402,
  "Updated": "2019-04-13T17:37:18.276242+02:00",
  "UpdatedAssociateId": 625
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 467,
  "Domain": "Dashboards",
  "Name": "Friesen, Keeling and Collins",
  "Fullname": "expedita",
  "ParentId": 415,
  "Children": [
    {
      "HierarchyId": 788,
      "Domain": "Dashboards",
      "Name": "Pouros LLC",
      "Fullname": "corrupti",
      "ParentId": 644,
      "Children": [
        {},
        {}
      ],
      "Registered": "2012-02-12T17:37:18.2772429+01:00",
      "RegisteredAssociateId": 447,
      "Updated": "2007-06-08T17:37:18.2772429+02:00",
      "UpdatedAssociateId": 574,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    }
  ],
  "Registered": "2013-12-07T17:37:18.2772429+01:00",
  "RegisteredAssociateId": 337,
  "Updated": "2000-09-15T17:37:18.2772429+02:00",
  "UpdatedAssociateId": 197,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 72
    }
  }
}
```