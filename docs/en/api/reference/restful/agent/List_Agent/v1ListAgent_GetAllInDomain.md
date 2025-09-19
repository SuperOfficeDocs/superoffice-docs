---
title: POST Agents/List/GetAllInDomain
uid: v1ListAgent_GetAllInDomain
generated: true
content_type: reference
---

# POST Agents/List/GetAllInDomain

```http
POST /api/v1/Agents/List/GetAllInDomain
```

Get all items in a domain







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetAllInDomain?$select=name,department,category/id
```


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

## Request Body: request 

Domain, Children 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Domain | String |  |
| Children | Boolean |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/List/GetAllInDomain
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Domain": "Dashboards",
  "Children": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "HierarchyId": 832,
    "Domain": "Dashboards",
    "Name": "Stehr Group",
    "Fullname": "doloremque",
    "ParentId": 262,
    "Children": [
      {
        "HierarchyId": 455,
        "Domain": "Dashboards",
        "Name": "Gutkowski, Gulgowski and Schmeler",
        "Fullname": "hic",
        "ParentId": 281,
        "Children": [
          {},
          {}
        ],
        "Registered": "1998-09-05T03:41:53.7307246+02:00",
        "RegisteredAssociateId": 456,
        "Updated": "2016-03-30T03:41:53.7307246+02:00",
        "UpdatedAssociateId": 421,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 476
          }
        }
      }
    ],
    "Registered": "2021-05-03T03:41:53.7307246+02:00",
    "RegisteredAssociateId": 896,
    "Updated": "2022-09-29T03:41:53.7307246+02:00",
    "UpdatedAssociateId": 695,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 445
      }
    }
  }
]
```