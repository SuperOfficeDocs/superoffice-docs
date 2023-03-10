---
title: POST Agents/List/SaveHierarchyEntity
uid: v1ListAgent_SaveHierarchyEntity
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/SaveHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 759,
  "Domain": "Dashboards",
  "Name": "Hegmann, Goyette and Mohr",
  "Fullname": "consequuntur",
  "ParentId": 349,
  "Children": [
    {
      "HierarchyId": 750,
      "Domain": "Dashboards",
      "Name": "Boyer-Bauch",
      "Fullname": "labore",
      "ParentId": 488,
      "Children": [
        {},
        {}
      ],
      "Registered": "2013-04-26T12:15:19.3267465+02:00",
      "RegisteredAssociateId": 76,
      "Updated": "2015-03-23T12:15:19.3267465+01:00",
      "UpdatedAssociateId": 102
    }
  ],
  "Registered": "2010-12-17T12:15:19.3267465+01:00",
  "RegisteredAssociateId": 880,
  "Updated": "2000-06-14T12:15:19.3267465+02:00",
  "UpdatedAssociateId": 814
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 693,
  "Domain": "Dashboards",
  "Name": "Langosh LLC",
  "Fullname": "ab",
  "ParentId": 109,
  "Children": [
    {
      "HierarchyId": 964,
      "Domain": "Dashboards",
      "Name": "Lemke, Mueller and Wilkinson",
      "Fullname": "dolore",
      "ParentId": 859,
      "Children": [
        {},
        {}
      ],
      "Registered": "1999-12-10T12:15:19.3277474+01:00",
      "RegisteredAssociateId": 281,
      "Updated": "2010-11-13T12:15:19.3277474+01:00",
      "UpdatedAssociateId": 295,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    }
  ],
  "Registered": "2009-02-26T12:15:19.3277474+01:00",
  "RegisteredAssociateId": 529,
  "Updated": "2002-10-27T12:15:19.3277474+01:00",
  "UpdatedAssociateId": 305,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 382
    }
  }
}
```