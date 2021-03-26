---
title: POST Agents/EMail/FindContactOrPersonByEmailName
id: v1EMailAgent_FindContactOrPersonByEmailName
---

# POST Agents/EMail/FindContactOrPersonByEmailName

```http
POST /api/v1/Agents/EMail/FindContactOrPersonByEmailName
```

<para />

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/FindContactOrPersonByEmailName?$select=name,department,category/id
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

Name, EmailAddress 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| EmailAddress | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | The id of the person |
| FullName | string | The person fullname |
| EmailAddress | string | The emailAddress |
| ContactId | int32 | The id of the contact |
| ContactName | string | The contact name |
| ContactDepartment | string | Department |
| ContactCategory | string | Contact category |
| SortName | string | If person ? The person name, else contact name |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/FindContactOrPersonByEmailName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Name": "Ullrich, Koch and Russel",
  "EmailAddress": "tate@keeling.us"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 178,
    "FullName": "Leanne Torp DVM",
    "EmailAddress": "hardy_kirlin@nicolas.info",
    "ContactId": 415,
    "ContactName": "Ortiz-Leannon",
    "ContactDepartment": "",
    "ContactCategory": "VIP Customer",
    "SortName": "Hessel, Hilpert and Swift",
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
        "FieldLength": 240
      }
    }
  }
]
```