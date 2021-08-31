---
title: SaveServiceAuth
id: v1UserAgent_SaveServiceAuth
---

# SaveServiceAuth

```http
POST /api/v1/Agents/User/SaveServiceAuth
```

Updates the existing ServiceAuth or creates a new ServiceAuth if the id parameter is empty



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






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

The ServiceAuth to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ServiceAuthId | int32 | The primary key |
| Server | string | The mail server |
| Port | int32 | The server port |
| AuthType | string | The type of authentication, plain-text, OAuth... |
| Username | string | The username |
| Password | string | The (decrypted) password or token |


## Response: object

Properties for service authentication



Carrier object for ServiceAuth.
Services for the ServiceAuth Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ServiceAuthId | int32 | The primary key |
| Server | string | The mail server |
| Port | int32 | The server port |
| AuthType | string | The type of authentication, plain-text, OAuth... |
| Username | string | The username |
| Password | string | The (decrypted) password or token |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/User/SaveServiceAuth
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ServiceAuthId": 913,
  "Server": "enim",
  "Port": 434,
  "AuthType": "quia",
  "Username": "veritatis",
  "Password": "aperiam"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ServiceAuthId": 346,
  "Server": "doloribus",
  "Port": 62,
  "AuthType": "et",
  "Username": "est",
  "Password": "possimus",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "architect vertical experiences"
      },
      "FieldType": "System.Int32",
      "FieldLength": 811
    }
  }
}
```