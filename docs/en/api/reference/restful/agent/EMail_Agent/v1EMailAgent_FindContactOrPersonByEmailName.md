---
title: POST Agents/EMail/FindContactOrPersonByEmailName
uid: v1EMailAgent_FindContactOrPersonByEmailName
generated: true
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
| Name | String |  |
| EmailAddress | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/FindContactOrPersonByEmailName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Name": "Wisoky-Mertz",
  "EmailAddress": "gillian.vandervort@hauckmuller.co.uk"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 673,
    "FullName": "Octavia Boyer",
    "EmailAddress": "casimer@stamm.co.uk",
    "ContactId": 74,
    "ContactName": "Farrell LLC",
    "ContactDepartment": "",
    "ContactCategory": "VIP Customer",
    "SortName": "Medhurst Group",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 395
      }
    }
  }
]
```