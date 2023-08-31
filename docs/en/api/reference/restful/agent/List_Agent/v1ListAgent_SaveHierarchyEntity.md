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
  "HierarchyId": 549,
  "Domain": "Dashboards",
  "Name": "Romaguera-Kerluke",
  "Fullname": "iste",
  "ParentId": 981,
  "Children": [
    {
      "HierarchyId": 495,
      "Domain": "Dashboards",
      "Name": "Schiller LLC",
      "Fullname": "incidunt",
      "ParentId": 22,
      "Children": [
        {},
        {}
      ],
      "Registered": "1998-04-16T03:31:26.7300385+02:00",
      "RegisteredAssociateId": 953,
      "Updated": "2016-08-13T03:31:26.7300385+02:00",
      "UpdatedAssociateId": 850
    }
  ],
  "Registered": "2007-01-17T03:31:26.7300385+01:00",
  "RegisteredAssociateId": 618,
  "Updated": "2001-11-20T03:31:26.7300385+01:00",
  "UpdatedAssociateId": 162
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 911,
  "Domain": "Dashboards",
  "Name": "Terry, Feil and Adams",
  "Fullname": "alias",
  "ParentId": 516,
  "Children": [
    {
      "HierarchyId": 705,
      "Domain": "Dashboards",
      "Name": "Hammes-Braun",
      "Fullname": "omnis",
      "ParentId": 437,
      "Children": [
        {},
        {}
      ],
      "Registered": "2011-09-12T03:31:26.7300385+02:00",
      "RegisteredAssociateId": 860,
      "Updated": "2002-06-28T03:31:26.7300385+02:00",
      "UpdatedAssociateId": 414,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "Registered": "2005-08-18T03:31:26.7300385+02:00",
  "RegisteredAssociateId": 840,
  "Updated": "2002-09-30T03:31:26.7300385+02:00",
  "UpdatedAssociateId": 946,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 768
    }
  }
}
```