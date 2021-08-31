---
title: GET User/CredentialTypes
id: v1User_GetCredentialTypes
---

# GET User/CredentialTypes

```http
GET /api/v1/User/CredentialTypes
```

Get available credential types that can be used for authentication



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






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
GET /api/v1/User/CredentialTypes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DisplayType": "corrupti",
    "Type": "delectus",
    "Description": "Upgradable bandwidth-monitored knowledge base",
    "ValueControl": "Edit",
    "CanCreatePerson": true,
    "IsUserNameSupported": true,
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
        "FieldLength": 673
      }
    }
  }
]
```