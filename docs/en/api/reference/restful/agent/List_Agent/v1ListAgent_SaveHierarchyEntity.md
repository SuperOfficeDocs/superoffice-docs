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
  "HierarchyId": 590,
  "Domain": "Dashboards",
  "Name": "Koelpin LLC",
  "Fullname": "minus",
  "ParentId": 544,
  "Children": [
    {
      "HierarchyId": 803,
      "Domain": "Dashboards",
      "Name": "Leuschke-Kutch",
      "Fullname": "nulla",
      "ParentId": 131,
      "Children": [
        {},
        {}
      ],
      "Registered": "2020-04-06T10:17:55.7384214+02:00",
      "RegisteredAssociateId": 278,
      "Updated": "2007-10-26T10:17:55.7384214+02:00",
      "UpdatedAssociateId": 60
    }
  ],
  "Registered": "2018-08-29T10:17:55.7384214+02:00",
  "RegisteredAssociateId": 861,
  "Updated": "2014-07-31T10:17:55.7384214+02:00",
  "UpdatedAssociateId": 202
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 995,
  "Domain": "Dashboards",
  "Name": "Bode Inc and Sons",
  "Fullname": "sed",
  "ParentId": 954,
  "Children": [
    {
      "HierarchyId": 77,
      "Domain": "Dashboards",
      "Name": "Robel, Feest and Purdy",
      "Fullname": "id",
      "ParentId": 319,
      "Children": [
        {},
        {}
      ],
      "Registered": "2003-04-07T10:17:55.7384214+02:00",
      "RegisteredAssociateId": 91,
      "Updated": "2002-03-30T10:17:55.7384214+01:00",
      "UpdatedAssociateId": 376,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    }
  ],
  "Registered": "2007-06-11T10:17:55.7384214+02:00",
  "RegisteredAssociateId": 156,
  "Updated": "2009-06-03T10:17:55.7384214+02:00",
  "UpdatedAssociateId": 151,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 681
    }
  }
}
```