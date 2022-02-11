---
title: POST Agents/User/GetCredentialTypes
id: v1UserAgent_GetCredentialTypes
---

# POST Agents/User/GetCredentialTypes

```http
POST /api/v1/Agents/User/GetCredentialTypes
```

Get available credential types that can be used for authentication



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetCredentialTypes?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DisplayType | string | The name of the credentials to be displayed in the user interface.  This will typically be Password for user-name/password scenarios and Active Directoru User for AD integration. |
| Type | string | Type of credentials, corresponding to name of plugin and type in the credentials table |
| Description | string | Description of the authentication type.  This value is used in a list of authentication providers that can be choosen by an end user and should be a fairly describtive text.  This will typically be SuperOffice is responsible for username and password for a password scenario. |
| ValueControl | string | Type of control used to display the value. |
| CanCreatePerson | bool |  |
| IsUserNameSupported | bool |  |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/User/GetCredentialTypes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DisplayType": "qui",
    "Type": "voluptatem",
    "Description": "Persistent disintermediate internet solution",
    "ValueControl": "Edit",
    "CanCreatePerson": true,
    "IsUserNameSupported": true,
    "TableRight": {
      "Mask": "Delete",
      "Reason": "reinvent integrated vortals"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 959
      }
    }
  }
]
```