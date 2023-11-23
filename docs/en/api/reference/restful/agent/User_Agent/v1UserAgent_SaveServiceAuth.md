---
title: POST Agents/User/SaveServiceAuth
uid: v1UserAgent_SaveServiceAuth
generated: true
---

# POST Agents/User/SaveServiceAuth

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
| ServiceAuthId | Integer | The primary key |
| Server | String | The mail server |
| Port | Integer | The server port |
| AuthType | String | The type of authentication, plain-text, OAuth... |
| Username | String | The username |
| Password | String | The (decrypted) password or token |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ServiceAuth

| Property Name | Type |  Description |
|----------------|------|--------------|
| ServiceAuthId | int32 | The primary key |
| Server | string | The mail server |
| Port | int32 | The server port |
| AuthType | string | The type of authentication, plain-text, OAuth... |
| Username | string | The username |
| Password | string | The (decrypted) password or token |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/User/SaveServiceAuth
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ServiceAuthId": 436,
  "Server": "qui",
  "Port": 678,
  "AuthType": "necessitatibus",
  "Username": "dolorem",
  "Password": "harum"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ServiceAuthId": 711,
  "Server": "voluptas",
  "Port": 439,
  "AuthType": "sint",
  "Username": "nihil",
  "Password": "officiis",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 200
    }
  }
}
```