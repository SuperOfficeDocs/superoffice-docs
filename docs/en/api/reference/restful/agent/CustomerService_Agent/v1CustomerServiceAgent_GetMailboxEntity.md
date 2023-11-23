---
title: POST Agents/CustomerService/GetMailboxEntity
uid: v1CustomerServiceAgent_GetMailboxEntity
generated: true
---

# POST Agents/CustomerService/GetMailboxEntity

```http
POST /api/v1/Agents/CustomerService/GetMailboxEntity
```

Gets a MailboxEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| mailboxEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetMailboxEntity?mailboxEntityId=95
POST /api/v1/Agents/CustomerService/GetMailboxEntity?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: MailboxEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| MailInFilterId | int32 | The primary key (auto-incremented) |
| ServerType | string | Enum indicating the protocol to use (POP/IMAP). |
| Address | string | The address associated with this mailbox (used as FROM: address when sending emails). |
| Username | string | The username used to log onto the mail account |
| Password | string | The password used to log into the mail account. This is hidden when reading |
| Server | string | The email server to connect to |
| Port | int32 | The port used to connect to the server |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/GetMailboxEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "MailInFilterId": 341,
  "ServerType": "Facebook",
  "Address": "sequi",
  "Username": "aspernatur",
  "Password": "tenetur",
  "Server": "nobis",
  "Port": 835,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 780
    }
  }
}
```