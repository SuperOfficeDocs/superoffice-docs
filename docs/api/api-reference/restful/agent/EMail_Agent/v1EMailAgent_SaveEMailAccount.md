---
title: POST Agents/EMail/SaveEMailAccount
id: v1EMailAgent_SaveEMailAccount
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
| EMailAccountId | int32 | The account primary key |
| EMailAddress | string | The account (from) address |
| AssociateId | int32 | Id of the associate who owns this account |
| IncomingCredentials |  | Account credentials for imap |
| OutgoingCredentials |  | Account credentials for smtp |
| AccountStatus | int32 | The account status (Disabled or...) Readonly field |
| ErrorCount | int32 | Count of concurring errors of fetching email. Readonly field |
| ErrorReason | string | Reason/Error message. Readonly field |


## Response: object

Properties for an email account



Carrier object for EMailAccount.
Services for the EMailAccount Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| EMailAccountId | int32 | The account primary key |
| EMailAddress | string | The account (from) address |
| AssociateId | int32 | Id of the associate who owns this account |
| IncomingCredentials |  | Account credentials for imap |
| OutgoingCredentials |  | Account credentials for smtp |
| AccountStatus | int32 | The account status (Disabled or...) Readonly field |
| ErrorCount | int32 | Count of concurring errors of fetching email. Readonly field |
| ErrorReason | string | Reason/Error message. Readonly field |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/SaveEMailAccount
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EMailAccountId": 742,
  "EMailAddress": "repellat",
  "AssociateId": 475,
  "IncomingCredentials": {
    "ServiceAuthId": 622,
    "Server": "corrupti",
    "Port": 455,
    "AuthType": "eligendi",
    "Username": "et",
    "Password": "sequi"
  },
  "OutgoingCredentials": {
    "ServiceAuthId": 699,
    "Server": "vitae",
    "Port": 177,
    "AuthType": "quaerat",
    "Username": "ratione",
    "Password": "rem"
  },
  "AccountStatus": 376,
  "ErrorCount": 336,
  "ErrorReason": ""
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EMailAccountId": 264,
  "EMailAddress": "optio",
  "AssociateId": 616,
  "IncomingCredentials": {
    "ServiceAuthId": 164,
    "Server": "dignissimos",
    "Port": 953,
    "AuthType": "molestiae",
    "Username": "harum",
    "Password": "magnam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 124
      }
    }
  },
  "OutgoingCredentials": {
    "ServiceAuthId": 559,
    "Server": "asperiores",
    "Port": 723,
    "AuthType": "rerum",
    "Username": "minus",
    "Password": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 409
      }
    }
  },
  "AccountStatus": 880,
  "ErrorCount": 915,
  "ErrorReason": "",
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
      "FieldType": "System.String",
      "FieldLength": 592
    }
  }
}
```