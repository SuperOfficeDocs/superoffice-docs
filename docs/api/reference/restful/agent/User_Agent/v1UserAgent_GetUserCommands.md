---
title: POST Agents/User/GetUserCommands
id: v1UserAgent_GetUserCommands
---

# POST Agents/User/GetUserCommands

```http
POST /api/v1/Agents/User/GetUserCommands
```

Get registered custom commands for User

## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps

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
| User |  | SuperOffice User, with login credentials and an associated person. <br /> Carrier object for User. Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "User": {
    "AssociateId": 832,
    "Name": "Jacobi, Smith and Considine",
    "Rank": 578,
    "Tooltip": "libero",
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
    "Deleted": false,
    "Lastlogin": "2004-03-02T18:28:50.5594416+01:00",
    "Lastlogout": "1995-03-01T18:28:50.5594416+01:00",
    "EjUserId": 77,
    "RequestSignature": "sunt",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": true,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Jones-Emmerich",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Mohr, Smith and Weimann",
    "WaitingForApproval": false,
    "ExtraFields": {
      "ExtraFields1": "qui",
      "ExtraFields2": "iure"
    },
    "CustomFields": {
      "CustomFields1": "harum",
      "CustomFields2": "magnam"
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
    "Name": "Lang Inc and Sons",
    "DisplayName": "Shanahan-Kunde",
    "Description": "Multi-lateral zero defect frame",
    "ToolTip": "Ex dolor et.",
    "Actions": "Implicit",
    "ActionData": "quasi",
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
        "FieldLength": 720
      }
    }
  }
]
```
