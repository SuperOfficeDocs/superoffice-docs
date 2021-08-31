---
title: PUT CRMScript/{id}
id: v1CRMScriptEntity_PutCRMScriptEntity
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


## Response: object

CRM Scripts - stored in the ejScript table, including source code.



CRMScriptEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | CRMScriptEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/CRMScript/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 23,
  "UniqueIdentifier": "numquam",
  "Name": "Morar, Jones and Doyle",
  "Description": "Seamless mobile approach",
  "IncludeId": "voluptas",
  "HierarchyId": 441,
  "Source": "suscipit",
  "Registered": "1996-07-20T15:05:42.0260026+02:00",
  "RegisteredAssociateId": 461,
  "Updated": "2001-02-05T15:05:42.0260026+01:00",
  "UpdatedAssociateId": 289
}
```

```http_
HTTP/1.1 200 CRMScriptEntity updated.
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 727,
  "UniqueIdentifier": "quo",
  "Name": "Kessler, Kuvalis and Miller",
  "Description": "Fully-configurable 5th generation paradigm",
  "IncludeId": "amet",
  "HierarchyId": 91,
  "Source": "voluptas",
  "Registered": "2017-12-06T15:05:42.0260026+01:00",
  "RegisteredAssociateId": 300,
  "Updated": "1994-11-29T15:05:42.0260026+01:00",
  "UpdatedAssociateId": 60,
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
      "FieldLength": 662
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```