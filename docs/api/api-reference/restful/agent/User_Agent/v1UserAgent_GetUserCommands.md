---
title: POST Agents/User/GetUserCommands
id: v1UserAgent_GetUserCommands
---

# POST Agents/User/GetUserCommands

```http
POST /api/v1/Agents/User/GetUserCommands
```

Get registered custom commands for User



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

The User entity. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| User |  | SuperOffice User, with login credentials and an associated person. <para /> Carrier object for User. Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Unique name of the command |
| DisplayName | string | The name to show in GUI |
| Description | string | Description of the command. |
| ToolTip | string | Tooltip to be used in the GUI |
| Actions | string | The actions to call when invoked |
| ActionData | string | The data to be used when the command is invoked |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/User/GetUserCommands
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "User": {
    "AssociateId": 421,
    "Name": "Howe Inc and Sons",
    "Rank": 111,
    "Tooltip": "saepe",
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
    "Lastlogin": "2006-06-28T16:48:30.9039401+02:00",
    "Lastlogout": "2000-05-24T16:48:30.9039401+02:00",
    "EjUserId": 134,
    "RequestSignature": "pariatur",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": false,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Brekke-Rau",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Osinski, Eichmann and Nicolas",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "sint",
      "ExtraFields2": "amet"
    },
    "CustomFields": {
      "CustomFields1": "natus",
      "CustomFields2": "dolores"
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

[
  {
    "Name": "Doyle, Lemke and Dickens",
    "DisplayName": "Mertz, Hayes and Quigley",
    "Description": "Vision-oriented zero administration open system",
    "ToolTip": "Voluptatem consequuntur omnis dolores id.",
    "Actions": "Implicit",
    "ActionData": "dolorum",
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
        "FieldLength": 60
      }
    }
  }
]
```