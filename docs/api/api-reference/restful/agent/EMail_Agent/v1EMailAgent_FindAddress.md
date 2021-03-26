---
title: POST Agents/EMail/FindAddress
id: v1EMailAgent_FindAddress
---

# POST Agents/EMail/FindAddress

```http
POST /api/v1/Agents/EMail/FindAddress
```

Search for contacts and persons with the specified e-mail address (exact match on the email address string required)



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/FindAddress?$select=name,department,category/id
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

Address 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Address | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| ContactName | string |  |
| PersonId | int32 | Primary key |
| PersonName | string |  |
| AssociateId | int32 | Primary key |
| Address | string |  |
| EmailId | int32 | Primary key |
| DuplicatePersonIds | array | All persons with this EmailAddress stored in db is listed here |
| Name | string | The name on the email address |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/FindAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Address": "voluptatum"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ContactId": 754,
    "ContactName": "O'Hara Inc and Sons",
    "PersonId": 911,
    "PersonName": "Fadel, Aufderhar and Welch",
    "AssociateId": 17,
    "Address": "neque",
    "EmailId": 778,
    "DuplicatePersonIds": [
      638,
      791
    ],
    "Name": "Frami LLC",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate one-to-one content"
        },
        "FieldType": "System.Int32",
        "FieldLength": 208
      }
    }
  }
]
```