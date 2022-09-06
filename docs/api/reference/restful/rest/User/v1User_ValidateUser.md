---
title: POST User/Validate
uid: v1User_ValidateUser
---

# POST User/Validate

```http
POST /api/v1/User/Validate
```

Check that entity is ready for saving, return error messages by field.

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

## Request Body: user

Entity to be checked for errors.

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 | Primary key |
| Name | string | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role |  | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup |  | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person |  | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
| Deleted | bool | If true, the user is retired and should have no rights, not appear in lists, etc. |
| Lastlogin | date-time | Last login date |
| Lastlogout | date-time | Last logout date |
| EjUserId | int32 | ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| RequestSignature | string | ej users request signature |
| Type | string | User type: 1=InternalAssociate, 2=ResourceAssociate, 3=ExternalAssociate, 4=AnonymousAssociate, 5=SystemAssociate |
| IsPersonRetired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| IsOnTravel | bool | True if the user is on travel. |
| Credentials | array | List of credentials registered for this user. i.e. valid authentication methods. |
| UserName | string | User name, a.k.a. Login name. This might be an e-mail address. |
| TicketCategories | array | Request Ticket Categories assigned to the user.   <para>Use MDO List name "ejCategory" to get list items.</para> |
| NickName | string | The unique nick name for this user. Used in Service as an alias, similar to Name/Initials. |
| WaitingForApproval | bool | The user is waiting for an administrator to approve/grant her/him access. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.User.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.User.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PostSaveCommands | array | Post custom commands the client should execute after save has completed. |

## Response: object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

## Sample request

```http!
POST /api/v1/User/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 128,
  "Name": "Bahringer, Hessel and Friesen",
  "Rank": 235,
  "Tooltip": "quo",
  "LicenseOwners": [
    {
      "Name": "Glover Inc and Sons",
      "Description": "Enhanced dynamic frame",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ]
    },
    {
      "Name": "Glover Inc and Sons",
      "Description": "Enhanced dynamic frame",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ]
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "vitae",
      "Tooltip": "nam",
      "Id": 339,
      "Rank": 154,
      "Deleted": true
    },
    {
      "Value": "vitae",
      "Tooltip": "nam",
      "Id": 339,
      "Rank": 154,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "1998-11-19T11:10:53.8541856+01:00",
  "Lastlogout": "2018-04-08T11:10:53.8541856+02:00",
  "EjUserId": 137,
  "RequestSignature": "aut",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "aperiam",
      "DisplayValue": "ipsam"
    },
    {
      "Type": null,
      "Value": "aperiam",
      "DisplayValue": "ipsam"
    }
  ],
  "UserName": "Russel, Abernathy and Leannon",
  "TicketCategories": [
    {
      "Id": 443,
      "Name": "Senger, Shanahan and Parker",
      "ToolTip": "Magni omnis dignissimos.",
      "Deleted": false,
      "Rank": 638,
      "Type": "excepturi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "est",
      "ColorBlock": 654,
      "ExtraInfo": "omnis",
      "StyleHint": "consequuntur",
      "FullName": "Prof. Lucio Smith"
    }
  ],
  "NickName": "Bailey, Schinner and Veum",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "excepturi"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "omnis"
  },
  "PostSaveCommands": [
    {
      "Name": "VonRueden-Ernser",
      "DisplayName": "Wunsch-Sauer",
      "Description": "Proactive full-range groupware",
      "ToolTip": "Assumenda dolores repellendus impedit autem ad autem maxime.",
      "Actions": "Implicit",
      "ActionData": "ipsam"
    },
    {
      "Name": "VonRueden-Ernser",
      "DisplayName": "Wunsch-Sauer",
      "Description": "Proactive full-range groupware",
      "ToolTip": "Assumenda dolores repellendus impedit autem ad autem maxime.",
      "Actions": "Implicit",
      "ActionData": "ipsam"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "architecto",
  "2": "totam"
}
```
