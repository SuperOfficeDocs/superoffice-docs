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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
POST /api/v1/Agents/List/SaveHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 731,
  "Domain": "Dashboards",
  "Name": "Satterfield-Nader",
  "Fullname": "natus",
  "ParentId": 935,
  "Children": [
    {
      "HierarchyId": 497,
      "Domain": "Dashboards",
      "Name": "Kuvalis, Cassin and Satterfield",
      "Fullname": "sit",
      "ParentId": 517,
      "Children": [
        {},
        {}
      ],
      "Registered": "2019-06-26T11:10:27.247453+02:00",
      "RegisteredAssociateId": 10,
      "Updated": "2004-05-06T11:10:27.247453+02:00",
      "UpdatedAssociateId": 669
    }
  ],
  "Registered": "2000-09-19T11:10:27.247453+02:00",
  "RegisteredAssociateId": 176,
  "Updated": "2013-06-19T11:10:27.247453+02:00",
  "UpdatedAssociateId": 370
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 123,
  "Domain": "Dashboards",
  "Name": "Von, Grant and Jaskolski",
  "Fullname": "non",
  "ParentId": 638,
  "Children": [
    {
      "HierarchyId": 472,
      "Domain": "Dashboards",
      "Name": "Dickinson LLC",
      "Fullname": "possimus",
      "ParentId": 82,
      "Children": [
        {},
        {}
      ],
      "Registered": "2017-09-05T11:10:27.248455+02:00",
      "RegisteredAssociateId": 482,
      "Updated": "2006-09-26T11:10:27.248455+02:00",
      "UpdatedAssociateId": 388,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "Registered": "2012-05-06T11:10:27.248455+02:00",
  "RegisteredAssociateId": 56,
  "Updated": "2008-02-19T11:10:27.248455+01:00",
  "UpdatedAssociateId": 830,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 918
    }
  }
}
```