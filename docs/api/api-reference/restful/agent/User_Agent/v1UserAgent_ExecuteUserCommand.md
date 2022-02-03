---
title: POST Agents/User/ExecuteUserCommand
id: v1UserAgent_ExecuteUserCommand
---

# POST Agents/User/ExecuteUserCommand

```http
POST /api/v1/Agents/User/ExecuteUserCommand
```

Executes the custom command for User



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

## Request Body: request  

The name of the command to execute. Result of an UI operation. The User to execute commands on. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CommandName | string |  |
| ActionResult | string |  |
| User |  | SuperOffice User, with login credentials and an associated person. <para /> Carrier object for User. Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |


## Response: object

Generic carrier object for entity commands.



Carrier object for CommandResult.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Success | bool | The command was successfully executed. |
| Message | string | Message which should be displayed in GUI. |
| Result | string | The result used in this action. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/User/ExecuteUserCommand
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "CommandName": "D'Amore-Langosh",
  "ActionResult": "Cancel",
  "User": {
    "AssociateId": 147,
    "Name": "Frami, Hilpert and Schumm",
    "Rank": 411,
    "Tooltip": "quod",
    "LicenseOwners": [
      {},
      {}
    ],
    "Role": {},
    "UserGroup": {},
    "OtherGroups": [
      {},
      {}
    ],
    "Person": {},
    "Deleted": true,
    "Lastlogin": "1994-12-01T18:28:50.5604425+01:00",
    "Lastlogout": "2001-05-24T18:28:50.5604425+02:00",
    "EjUserId": 543,
    "RequestSignature": "qui",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": false,
    "IsOnTravel": true,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Breitenberg-Shields",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Tromp Inc and Sons",
    "WaitingForApproval": false,
    "ExtraFields": {
      "ExtraFields1": "reprehenderit",
      "ExtraFields2": "odio"
    },
    "CustomFields": {
      "CustomFields1": "error",
      "CustomFields2": "nulla"
    },
    "PostSaveCommands": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": false,
  "Message": "quia",
  "Result": "Cancel",
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
      "FieldLength": 256
    }
  }
}
```