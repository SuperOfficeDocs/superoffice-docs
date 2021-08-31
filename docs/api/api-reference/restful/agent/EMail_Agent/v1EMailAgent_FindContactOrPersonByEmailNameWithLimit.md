---
title: FindContactOrPersonByEmailNameWithLimit
id: v1EMailAgent_FindContactOrPersonByEmailNameWithLimit
---

# FindContactOrPersonByEmailNameWithLimit

```http
POST /api/v1/Agents/EMail/FindContactOrPersonByEmailNameWithLimit
```

<para />

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/FindContactOrPersonByEmailNameWithLimit?$select=name,department,category/id
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

Name, EmailAddress, NumberOfContacts, NumberOfPersons 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| EmailAddress | string |  |
| NumberOfContacts | int32 |  |
| NumberOfPersons | int32 |  |


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
POST /api/v1/Agents/EMail/FindContactOrPersonByEmailNameWithLimit
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Name": "Mueller-Collins",
  "EmailAddress": "armani.doyle@reichertbotsford.us",
  "NumberOfContacts": 846,
  "NumberOfPersons": 689
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 604,
    "FullName": "Felix Kerluke DVM",
    "EmailAddress": "rosetta_towne@rennerstokes.uk",
    "ContactId": 729,
    "ContactName": "Mueller, Goyette and Wehner",
    "ContactDepartment": "",
    "ContactCategory": "VIP Customer",
    "SortName": "Abshire, Bechtelar and Wilderman",
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
        "FieldLength": 316
      }
    }
  }
]
```