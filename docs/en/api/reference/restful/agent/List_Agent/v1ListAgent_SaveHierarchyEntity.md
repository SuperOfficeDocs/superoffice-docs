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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 749,
  "Domain": "Dashboards",
  "Name": "Gottlieb-Morar",
  "Fullname": "atque",
  "ParentId": 205,
  "Children": [
    {
      "HierarchyId": 763,
      "Domain": "Dashboards",
      "Name": "Haley-Reilly",
      "Fullname": "quia",
      "ParentId": 588,
      "Children": [
        {},
        {}
      ],
      "Registered": "1998-06-28T13:28:23.007483+02:00",
      "RegisteredAssociateId": 143,
      "Updated": "2015-12-24T13:28:23.007483+01:00",
      "UpdatedAssociateId": 161
    }
  ],
  "Registered": "2019-04-13T13:28:23.007483+02:00",
  "RegisteredAssociateId": 744,
  "Updated": "2004-05-23T13:28:23.007483+02:00",
  "UpdatedAssociateId": 146
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 854,
  "Domain": "Dashboards",
  "Name": "Dare Inc and Sons",
  "Fullname": "ut",
  "ParentId": 424,
  "Children": [
    {
      "HierarchyId": 6,
      "Domain": "Dashboards",
      "Name": "Predovic Group",
      "Fullname": "non",
      "ParentId": 249,
      "Children": [
        {},
        {}
      ],
      "Registered": "1998-11-01T13:28:23.007483+01:00",
      "RegisteredAssociateId": 477,
      "Updated": "2005-09-19T13:28:23.007483+02:00",
      "UpdatedAssociateId": 541,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 569
        }
      }
    }
  ],
  "Registered": "1999-03-12T13:28:23.007483+01:00",
  "RegisteredAssociateId": 855,
  "Updated": "2011-07-14T13:28:23.007483+02:00",
  "UpdatedAssociateId": 110,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 18
    }
  }
}
```