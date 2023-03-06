---
title: PUT Hierarchy/{domain}/{path}
uid: v1HierarchyEntity_UpdateHierarchyFromPath
---

# PUT Hierarchy/{domain}/{path}

```http
PUT /api/v1/Hierarchy/{domain}/{path}
```

Update a hierarchy item from a path






| Path Part | Type | Description |
|-----------|------|-------------|
| domain | Enum: Unknown, ExtraTables, ScreenDefinitions, Scripts, Selections, ExternalDocuments, UserGroups, ExternalDocumentRelatedToSpmMessage, Dashboards | Type of items to get **Required** |
| path | string | Hierarchy path to item **Required** |



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

The hierarchy node to update. 

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/Hierarchy/{domain}/{path}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 152,
  "Domain": "Dashboards",
  "Name": "Jones, Hettinger and Langosh",
  "Fullname": "sunt",
  "ParentId": 453,
  "Children": [
    {
      "HierarchyId": 365,
      "Domain": "Dashboards",
      "Name": "Bruen-Morissette",
      "Fullname": "autem",
      "ParentId": 748,
      "Children": [
        {},
        {}
      ],
      "Registered": "2010-05-30T14:19:10.3654771+02:00",
      "RegisteredAssociateId": 802,
      "Updated": "1998-04-01T14:19:10.3654771+02:00",
      "UpdatedAssociateId": 645
    }
  ],
  "Registered": "2001-12-01T14:19:10.3654771+01:00",
  "RegisteredAssociateId": 81,
  "Updated": "2001-07-12T14:19:10.3654771+02:00",
  "UpdatedAssociateId": 592
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 677,
  "Domain": "Dashboards",
  "Name": "Feeney LLC",
  "Fullname": "ut",
  "ParentId": 747,
  "Children": [
    {
      "HierarchyId": 244,
      "Domain": "Dashboards",
      "Name": "Smitham-Schultz",
      "Fullname": "sit",
      "ParentId": 406,
      "Children": [
        {},
        {}
      ],
      "Registered": "2020-05-04T14:19:10.3654771+02:00",
      "RegisteredAssociateId": 643,
      "Updated": "1997-08-26T14:19:10.3654771+02:00",
      "UpdatedAssociateId": 885,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 572
        }
      }
    }
  ],
  "Registered": "1997-01-24T14:19:10.3654771+01:00",
  "RegisteredAssociateId": 631,
  "Updated": "1997-04-29T14:19:10.3654771+02:00",
  "UpdatedAssociateId": 254,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 600
    }
  }
}
```