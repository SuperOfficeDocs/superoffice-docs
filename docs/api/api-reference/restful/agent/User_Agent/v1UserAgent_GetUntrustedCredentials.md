---
title: GetUntrustedCredentials
id: v1UserAgent_GetUntrustedCredentials
---

# GetUntrustedCredentials

```http
POST /api/v1/Agents/User/GetUntrustedCredentials
```

Get a set of credentials of a specified type for authenticated user.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUntrustedCredentials?$select=name,department,category/id
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

Type 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ValidFrom | date-time | Credentials are valid from this date. |
| ValidTo | date-time | Credentials are valid to this date. |
| Comment | string | Description of credentials. Max 255 characters. |
| SecretValue | string | Data stored encrypted in the db. Typically a password. Max 70 characters. |
| PublicValue | string | Data stored unencrypted in the db.  Typically server and or username. Max 238 characters. |
| IsActive | bool | Is this credentials currently active. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/User/GetUntrustedCredentials
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Type": "nulla"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ValidFrom": "2007-02-04T14:58:05.4522936+01:00",
    "ValidTo": "2012-11-19T14:58:05.4522936+01:00",
    "Comment": "aut",
    "SecretValue": "mollitia",
    "PublicValue": "delectus",
    "IsActive": true,
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
        "FieldLength": 271
      }
    }
  }
]
```