---
title: POST Agents/EMail/CreateDefaultEMailConnectionInfoExtended
uid: v1EMailAgent_CreateDefaultEMailConnectionInfoExtended
generated: true
---

# POST Agents/EMail/CreateDefaultEMailConnectionInfoExtended

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailConnectionInfoExtended
```

Set default values into a new EMailConnectionInfoExtended.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.







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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EMailConnectionInfoExtended

| Property Name | Type |  Description |
|----------------|------|--------------|
| Port | int32 |  |
| ServerName | string | Hostname or ip to server to connect to. Custom ports may be specified by adding ':' and the port number after the name/ip. Ex: '127.0.0.1:6543' |
| Protocol | string |  |
| UserName | string | Name of user to log in with |
| Password | string | Password for the username |
| UseSSL | bool | Use a secure connection with the server |
| Folder | string | Optional folder to set as current after logging in |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/CreateDefaultEMailConnectionInfoExtended
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Port": 88,
  "ServerName": "Mertz, Stamm and Crist",
  "Protocol": "ut",
  "UserName": "Marvin-Brown",
  "Password": "voluptatem",
  "UseSSL": true,
  "Folder": "dolor",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 953
    }
  }
}
```