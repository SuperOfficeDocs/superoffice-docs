---
title: POST Agents/List/AddHierarchyToPath
uid: v1ListAgent_AddHierarchyToPath
---

# POST Agents/List/AddHierarchyToPath

```http
POST /api/v1/Agents/List/AddHierarchyToPath
```

Add a hierarchy item to a path







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/AddHierarchyToPath?$select=name,department,category/id
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

Domain, Path, Name 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Domain | String |  |
| Path | String |  |
| Name | String |  |

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
POST /api/v1/Agents/List/AddHierarchyToPath
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Domain": "Dashboards",
  "Path": "consequatur",
  "Name": "Predovic Group"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 893,
  "Domain": "Dashboards",
  "Name": "Hegmann LLC",
  "Fullname": "incidunt",
  "ParentId": 747,
  "Children": [
    {
      "HierarchyId": 648,
      "Domain": "Dashboards",
      "Name": "Cremin Group",
      "Fullname": "et",
      "ParentId": 735,
      "Children": [
        {},
        {}
      ],
      "Registered": "2022-05-02T03:51:27.4591714+02:00",
      "RegisteredAssociateId": 544,
      "Updated": "1999-09-10T03:51:27.4591714+02:00",
      "UpdatedAssociateId": 10,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    }
  ],
  "Registered": "2001-12-25T03:51:27.4591714+01:00",
  "RegisteredAssociateId": 372,
  "Updated": "2008-10-19T03:51:27.4591714+02:00",
  "UpdatedAssociateId": 474,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 838
    }
  }
}
```