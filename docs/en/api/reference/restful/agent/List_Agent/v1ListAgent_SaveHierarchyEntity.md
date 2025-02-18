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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 495,
  "Domain": "Dashboards",
  "Name": "Yundt Group",
  "Fullname": "qui",
  "ParentId": 624,
  "Children": [
    {
      "HierarchyId": 433,
      "Domain": "Dashboards",
      "Name": "Kessler LLC",
      "Fullname": "possimus",
      "ParentId": 249,
      "Children": [
        {},
        {}
      ],
      "Registered": "2014-08-25T14:32:03.1722226+02:00",
      "RegisteredAssociateId": 732,
      "Updated": "2023-04-07T14:32:03.1722226+02:00",
      "UpdatedAssociateId": 287
    }
  ],
  "Registered": "2000-10-02T14:32:03.1722226+02:00",
  "RegisteredAssociateId": 657,
  "Updated": "1998-07-24T14:32:03.1722226+02:00",
  "UpdatedAssociateId": 871
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 384,
  "Domain": "Dashboards",
  "Name": "Hartmann Inc and Sons",
  "Fullname": "tempore",
  "ParentId": 423,
  "Children": [
    {
      "HierarchyId": 795,
      "Domain": "Dashboards",
      "Name": "Kub, Watsica and Bahringer",
      "Fullname": "a",
      "ParentId": 253,
      "Children": [
        {},
        {}
      ],
      "Registered": "2022-03-10T14:32:03.1722226+01:00",
      "RegisteredAssociateId": 222,
      "Updated": "2022-12-13T14:32:03.1722226+01:00",
      "UpdatedAssociateId": 301,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 198
        }
      }
    }
  ],
  "Registered": "2007-04-22T14:32:03.1722226+02:00",
  "RegisteredAssociateId": 114,
  "Updated": "2014-11-10T14:32:03.1722226+01:00",
  "UpdatedAssociateId": 232,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 436
    }
  }
}
```