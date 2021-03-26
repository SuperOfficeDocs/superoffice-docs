---
title: GET Hierarchy/{domain}
id: v1HierarchyEntity_GetAllInDomain
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
GET /api/v1/Hierarchy/{domain}?children=True
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

## Sample Request

```http!
GET /api/v1/Hierarchy/{domain}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "HierarchyId": 820,
    "Domain": "Dashboards",
    "Name": "Sauer Group",
    "Fullname": "ut",
    "ParentId": 1000,
    "Children": [
      {
        "HierarchyId": 274,
        "Domain": "Dashboards",
        "Name": "Emard-Lind",
        "Fullname": "rerum",
        "ParentId": 664,
        "Children": [
          {},
          {}
        ],
        "Registered": "2007-04-09T09:40:59.238663+02:00",
        "RegisteredAssociateId": 606,
        "Updated": "1996-04-03T09:40:59.238663+02:00",
        "UpdatedAssociateId": 925,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 816
          }
        }
      }
    ],
    "Registered": "2001-03-08T09:40:59.238663+01:00",
    "RegisteredAssociateId": 566,
    "Updated": "2003-01-21T09:40:59.238663+01:00",
    "UpdatedAssociateId": 790,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 104
      }
    }
  }
]
```