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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CommandName": "Wiza, Blanda and Brekke",
  "ActionResult": "Cancel",
  "User": {
    "AssociateId": 442,
    "Name": "Emard-Rohan",
    "Rank": 760,
    "Tooltip": "repellendus",
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
    "Lastlogin": "2005-04-22T16:48:30.9049408+02:00",
    "Lastlogout": "2000-07-31T16:48:30.9049408+02:00",
    "EjUserId": 411,
    "RequestSignature": "ipsam",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": false,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Stark-Wolf",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Heller, Powlowski and Jast",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "veniam",
      "ExtraFields2": "eos"
    },
    "CustomFields": {
      "CustomFields1": "quod",
      "CustomFields2": "harum"
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
  "Success": true,
  "Message": "laboriosam",
  "Result": "Cancel",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "monetize leading-edge partnerships"
      },
      "FieldType": "System.Int32",
      "FieldLength": 565
    }
  }
}
```