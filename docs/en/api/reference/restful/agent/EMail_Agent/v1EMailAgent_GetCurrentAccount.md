---
title: POST Agents/EMail/GetCurrentAccount
uid: v1EMailAgent_GetCurrentAccount
generated: true
---

# POST Agents/EMail/GetCurrentAccount

```http
POST /api/v1/Agents/EMail/GetCurrentAccount
```

Get current account (last logged into should normally be current) for logged in associate


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetCurrentAccount?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetCurrentAccount
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EMailAccountId": 152,
  "EMailAddress": "nemo",
  "AssociateId": 727,
  "IncomingCredentials": null,
  "OutgoingCredentials": null,
  "AccountStatus": 637,
  "ErrorCount": 410,
  "ErrorReason": "",
  "InboxFolder": "possimus",
  "SentFolder": "illum",
  "SimpleMode": 912,
  "LastFetch": "2024-07-01T03:45:23.4048314+02:00",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 630
    }
  }
}
```