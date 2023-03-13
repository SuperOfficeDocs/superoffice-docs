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
  "HierarchyId": 249,
  "Domain": "Dashboards",
  "Name": "Osinski-O'Reilly",
  "Fullname": "inventore",
  "ParentId": 974,
  "Children": [
    {
      "HierarchyId": 610,
      "Domain": "Dashboards",
      "Name": "Cassin-Doyle",
      "Fullname": "commodi",
      "ParentId": 502,
      "Children": [
        {},
        {}
      ],
      "Registered": "2016-04-01T14:19:03.6863742+02:00",
      "RegisteredAssociateId": 798,
      "Updated": "2008-12-07T14:19:03.6863742+01:00",
      "UpdatedAssociateId": 630
    }
  ],
  "Registered": "2019-08-31T14:19:03.6863742+02:00",
  "RegisteredAssociateId": 96,
  "Updated": "2005-03-05T14:19:03.6863742+01:00",
  "UpdatedAssociateId": 367
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 138,
  "Domain": "Dashboards",
  "Name": "Hagenes Group",
  "Fullname": "illum",
  "ParentId": 117,
  "Children": [
    {
      "HierarchyId": 619,
      "Domain": "Dashboards",
      "Name": "Hackett-Goyette",
      "Fullname": "veniam",
      "ParentId": 328,
      "Children": [
        {},
        {}
      ],
      "Registered": "2022-07-24T14:19:03.6863742+02:00",
      "RegisteredAssociateId": 110,
      "Updated": "2001-03-27T14:19:03.6863742+02:00",
      "UpdatedAssociateId": 103,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    }
  ],
  "Registered": "2011-01-19T14:19:03.6863742+01:00",
  "RegisteredAssociateId": 256,
  "Updated": "2007-09-25T14:19:03.6863742+02:00",
  "UpdatedAssociateId": 696,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 619
    }
  }
}
```