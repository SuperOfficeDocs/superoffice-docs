---
title: POST Agents/EMail/SaveEMailAccount
uid: v1EMailAgent_SaveEMailAccount
generated: true
---

# POST Agents/EMail/SaveEMailAccount

```http
POST /api/v1/Agents/EMail/SaveEMailAccount
```

Updates the existing EMailAccount or creates a new EMailAccount if the id parameter is empty


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.







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

The EMailAccount to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EMailAccountId | Integer | The account primary key |
| EMailAddress | String | The account (from) address |
| AssociateId | Integer | Id of the associate who owns this account |
| IncomingCredentials | ServiceAuth | Account credentials for imap |
| OutgoingCredentials | ServiceAuth | Account credentials for smtp |
| AccountStatus | Integer | The account status (Disabled or...) Readonly field |
| ErrorCount | Integer | Count of concurring errors of fetching email. Readonly field |
| ErrorReason | String | Reason/Error message. Readonly field |
| InboxFolder | String | Inbox folder name if available in the db |
| SentFolder | String | Sent email folder name if available in the db |
| SimpleMode | Integer | Simple mode used for sending and retrieving invitations, accept/decline etc. without the full Inbox GUI experience |
| LastFetch | String | When we last fetched email  in UTC. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EMailAccount

| Property Name | Type |  Description |
|----------------|------|--------------|
| EMailAccountId | int32 | The account primary key |
| EMailAddress | string | The account (from) address |
| AssociateId | int32 | Id of the associate who owns this account |
| IncomingCredentials | ServiceAuth | Account credentials for imap |
| OutgoingCredentials | ServiceAuth | Account credentials for smtp |
| AccountStatus | int32 | The account status (Disabled or...) Readonly field |
| ErrorCount | int32 | Count of concurring errors of fetching email. Readonly field |
| ErrorReason | string | Reason/Error message. Readonly field |
| InboxFolder | string | Inbox folder name if available in the db |
| SentFolder | string | Sent email folder name if available in the db |
| SimpleMode | int32 | Simple mode used for sending and retrieving invitations, accept/decline etc. without the full Inbox GUI experience |
| LastFetch | date-time | When we last fetched email  in UTC. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/SaveEMailAccount
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "EMailAccountId": 818,
  "EMailAddress": "beatae",
  "AssociateId": 195,
  "IncomingCredentials": null,
  "OutgoingCredentials": null,
  "AccountStatus": 379,
  "ErrorCount": 390,
  "ErrorReason": "",
  "InboxFolder": "sed",
  "SentFolder": "voluptatem",
  "SimpleMode": 188,
  "LastFetch": "2002-05-10T12:01:27.8065326+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EMailAccountId": 963,
  "EMailAddress": "ullam",
  "AssociateId": 308,
  "IncomingCredentials": null,
  "OutgoingCredentials": null,
  "AccountStatus": 375,
  "ErrorCount": 905,
  "ErrorReason": "",
  "InboxFolder": "non",
  "SentFolder": "ut",
  "SimpleMode": 584,
  "LastFetch": "2000-03-19T12:01:27.8065326+01:00",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 660
    }
  }
}
```