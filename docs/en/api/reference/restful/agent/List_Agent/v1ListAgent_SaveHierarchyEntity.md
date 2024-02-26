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
  "HierarchyId": 843,
  "Domain": "Dashboards",
  "Name": "Douglas-Streich",
  "Fullname": "voluptas",
  "ParentId": 956,
  "Children": [
    {
      "HierarchyId": 769,
      "Domain": "Dashboards",
      "Name": "Kuhn, Bahringer and Mueller",
      "Fullname": "sint",
      "ParentId": 410,
      "Children": [
        {},
        {}
      ],
      "Registered": "2004-11-01T10:30:24.0725232+01:00",
      "RegisteredAssociateId": 860,
      "Updated": "1999-12-23T10:30:24.0725232+01:00",
      "UpdatedAssociateId": 674
    }
  ],
  "Registered": "2018-08-16T10:30:24.0725232+02:00",
  "RegisteredAssociateId": 394,
  "Updated": "2002-12-17T10:30:24.0725232+01:00",
  "UpdatedAssociateId": 410
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 191,
  "Domain": "Dashboards",
  "Name": "Schneider, DuBuque and Nienow",
  "Fullname": "fuga",
  "ParentId": 383,
  "Children": [
    {
      "HierarchyId": 462,
      "Domain": "Dashboards",
      "Name": "Rice-Osinski",
      "Fullname": "repudiandae",
      "ParentId": 845,
      "Children": [
        {},
        {}
      ],
      "Registered": "2008-10-25T10:30:24.0725232+02:00",
      "RegisteredAssociateId": 411,
      "Updated": "2012-10-15T10:30:24.0725232+02:00",
      "UpdatedAssociateId": 403,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    }
  ],
  "Registered": "2000-04-05T10:30:24.0725232+02:00",
  "RegisteredAssociateId": 146,
  "Updated": "2013-09-27T10:30:24.0725232+02:00",
  "UpdatedAssociateId": 837,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 940
    }
  }
}
```