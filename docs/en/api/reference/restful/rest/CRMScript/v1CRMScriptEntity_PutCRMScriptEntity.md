---
title: PUT CRMScript/{id}
uid: v1CRMScriptEntity_PutCRMScriptEntity
generated: true
---

# PUT CRMScript/{id}

```http
PUT /api/v1/CRMScript/{id}
```

Updates the existing CRMScriptEntity


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The CRMScriptEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/CRMScript/{id}?$select=name,department,category/id
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

## Request Body: entity 

The CRMScriptEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjscriptId | Integer | Primary key |
| UniqueIdentifier | String | Global unique identifier, accross customers/tenants |
| Name | String | A description of this script |
| Description | String | Optional description of what this script is used for. |
| IncludeId | String | A unique name used for including this script in another |
| HierarchyId | Integer | The script is inside this hierarchy folder |
| Source | String | The script |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |

## Response:

CRMScriptEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | CRMScriptEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: CRMScriptEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjscriptId | int32 | Primary key |
| UniqueIdentifier | string | Global unique identifier, accross customers/tenants |
| Name | string | A description of this script |
| Description | string | Optional description of what this script is used for. |
| IncludeId | string | A unique name used for including this script in another |
| HierarchyId | int32 | The script is inside this hierarchy folder |
| Source | string | The script |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/CRMScript/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 452,
  "UniqueIdentifier": "aut",
  "Name": "Macejkovic Inc and Sons",
  "Description": "Reverse-engineered attitude-oriented analyzer",
  "IncludeId": "enim",
  "HierarchyId": 714,
  "Source": "consequatur",
  "Registered": "2012-10-24T11:16:13.8550957+02:00",
  "RegisteredAssociateId": 837,
  "Updated": "2016-04-11T11:16:13.8550957+02:00",
  "UpdatedAssociateId": 469
}
```

## Sample response

```http_
HTTP/1.1 200 CRMScriptEntity updated.
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 128,
  "UniqueIdentifier": "eius",
  "Name": "Harris, Lemke and Rolfson",
  "Description": "Assimilated eco-centric project",
  "IncludeId": "sed",
  "HierarchyId": 383,
  "Source": "placeat",
  "Registered": "2012-11-27T11:16:13.8550957+01:00",
  "RegisteredAssociateId": 218,
  "Updated": "1999-01-24T11:16:13.8550957+01:00",
  "UpdatedAssociateId": 136,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 167
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```