---
title: POST Agents/CustomerService/SaveMailboxEntity
uid: v1CustomerServiceAgent_SaveMailboxEntity
generated: true
---

# POST Agents/CustomerService/SaveMailboxEntity

```http
POST /api/v1/Agents/CustomerService/SaveMailboxEntity
```

Updates the existing MailboxEntity or creates a new MailboxEntity if the id parameter is empty








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

The MailboxEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MailInFilterId | Integer | The primary key (auto-incremented) |
| ServerType | String | Enum indicating the protocol to use (POP/IMAP). |
| Address | String | The address associated with this mailbox (used as FROM: address when sending emails). |
| Username | String | The username used to log onto the mail account |
| Password | String | The password used to log into the mail account. This is hidden when reading |
| Server | String | The email server to connect to |
| Port | Integer | The port used to connect to the server |

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
POST /api/v1/Agents/CustomerService/SaveMailboxEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "MailInFilterId": 474,
  "ServerType": "Facebook",
  "Address": "laborum",
  "Username": "hic",
  "Password": "aut",
  "Server": "sint",
  "Port": 491
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "MailInFilterId": 717,
  "ServerType": "Facebook",
  "Address": "quasi",
  "Username": "velit",
  "Password": "nobis",
  "Server": "doloremque",
  "Port": 530,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 121
    }
  }
}
```