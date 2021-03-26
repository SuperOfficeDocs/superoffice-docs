---
title: POST Agents/Contact/GetNameDepartmentDuplicates
id: v1ContactAgent_GetNameDepartmentDuplicates
---

# POST Agents/Contact/GetNameDepartmentDuplicates

```http
POST /api/v1/Agents/Contact/GetNameDepartmentDuplicates
```

Get duplicates based on the contact name and department







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetNameDepartmentDuplicates?$select=name,department,category/id
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

Name, Department 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| Department | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| RuleName | string | Identifying name for rule |
| SoPrimaryKey | int32 | Identity of an entry in the SuperOffice database. Should be 0 for matches from external systems. |
| EntryName | string | Name of duplicate entry |
| EntryIdentifier | string | String identifier for entry. Typically used to identify an entry in an external system. |
| RuleDisplayName | string | Short name of rule to display to user |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Contact/GetNameDepartmentDuplicates
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Name": "Runolfsson-Hessel",
  "Department": "generate user-centric relationships"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "RuleName": "Hagenes Inc and Sons",
    "SoPrimaryKey": 2,
    "EntryName": "Hilll, Roberts and Koch",
    "EntryIdentifier": "ea",
    "RuleDisplayName": "Stehr-Kuvalis",
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
        "FieldType": "System.String",
        "FieldLength": 296
      }
    }
  }
]
```