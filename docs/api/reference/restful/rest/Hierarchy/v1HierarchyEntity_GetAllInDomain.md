---
title: GET Hierarchy/{domain}
uid: v1HierarchyEntity_GetAllInDomain
---

# GET Hierarchy/{domain}

```http
GET /api/v1/Hierarchy/{domain}
```

Get all items in a domain

| Path Part | Type | Description |
|-----------|------|-------------|
| domain | Enum: Unknown, ExtraTables, ScreenDefinitions, Scripts, Selections, ExternalDocuments, UserGroups, ExternalDocumentRelatedToSpmMessage, Dashboards | Type of items to get (scripts, extra tables, etc) **Required** |

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| children | bool |  Include sub-items? |

```http
GET /api/v1/Hierarchy/{domain}?children=False
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Hierarchy/{domain}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "HierarchyId": 722,
    "Domain": "Dashboards",
    "Name": "Funk Inc and Sons",
    "Fullname": "et",
    "ParentId": 182,
    "Children": [
      {
        "HierarchyId": 720,
        "Domain": "Dashboards",
        "Name": "Langworth, Beatty and Rau",
        "Fullname": "nihil",
        "ParentId": 493,
        "Children": [
          {},
          {}
        ],
        "Registered": "2003-05-31T11:10:52.9171798+02:00",
        "RegisteredAssociateId": 378,
        "Updated": "2017-05-25T11:10:52.9171798+02:00",
        "UpdatedAssociateId": 583,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 531
          }
        }
      }
    ],
    "Registered": "2013-09-24T11:10:52.9171798+02:00",
    "RegisteredAssociateId": 398,
    "Updated": "2019-03-31T11:10:52.9171798+02:00",
    "UpdatedAssociateId": 642,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 261
      }
    }
  }
]
```
