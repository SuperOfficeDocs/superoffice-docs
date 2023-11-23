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
  "HierarchyId": 118,
  "Domain": "Dashboards",
  "Name": "Miller LLC",
  "Fullname": "a",
  "ParentId": 935,
  "Children": [
    {
      "HierarchyId": 285,
      "Domain": "Dashboards",
      "Name": "Parisian-Murazik",
      "Fullname": "laborum",
      "ParentId": 580,
      "Children": [
        {},
        {}
      ],
      "Registered": "2013-08-01T13:38:13.7177215+02:00",
      "RegisteredAssociateId": 743,
      "Updated": "2005-01-26T13:38:13.7177215+01:00",
      "UpdatedAssociateId": 206
    }
  ],
  "Registered": "2010-08-29T13:38:13.7177215+02:00",
  "RegisteredAssociateId": 523,
  "Updated": "2001-08-20T13:38:13.7177215+02:00",
  "UpdatedAssociateId": 36
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 843,
  "Domain": "Dashboards",
  "Name": "Wisoky, McCullough and Stiedemann",
  "Fullname": "facere",
  "ParentId": 26,
  "Children": [
    {
      "HierarchyId": 480,
      "Domain": "Dashboards",
      "Name": "Morissette LLC",
      "Fullname": "vero",
      "ParentId": 233,
      "Children": [
        {},
        {}
      ],
      "Registered": "1997-04-28T13:38:13.7177215+02:00",
      "RegisteredAssociateId": 359,
      "Updated": "2020-06-06T13:38:13.7177215+02:00",
      "UpdatedAssociateId": 679,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 487
        }
      }
    }
  ],
  "Registered": "2015-10-27T13:38:13.7177215+01:00",
  "RegisteredAssociateId": 150,
  "Updated": "2006-10-03T13:38:13.7177215+02:00",
  "UpdatedAssociateId": 356,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 203
    }
  }
}
```