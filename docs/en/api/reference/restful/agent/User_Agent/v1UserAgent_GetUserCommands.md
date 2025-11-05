---
title: POST Agents/User/GetUserCommands
uid: v1UserAgent_GetUserCommands
generated: true
content_type: reference
---

# POST Agents/User/GetUserCommands

```http
POST /api/v1/Agents/User/GetUserCommands
```

Get registered custom commands for User


NsApiSlow threshold: 2000 ms.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUserCommands?$select=name,department,category/id
```


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

SuperOffice User, with login credentials and an associated person.
<para />
Carrier object for User.
Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer | Primary key |
| Name | String | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | Integer | Rank order |
| Tooltip | String | Tooltip or other description |
| LicenseOwners | Array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role | Role | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup | UserGroup | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | Array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person | Person | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
| Deleted | Boolean | If true, the user is retired and should have no rights, not appear in lists, etc. |
| Lastlogin | String | Last login date |
| Lastlogout | String | Last logout date |
| EjUserId | Integer | ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| RequestSignature | String | ej users request signature |
| Type | String | User type: 1=InternalAssociate, 2=ResourceAssociate, 3=ExternalAssociate, 4=AnonymousAssociate, 5=SystemAssociate |
| IsPersonRetired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| IsOnTravel | Boolean | True if the user is on travel. |
| Credentials | Array | List of credentials registered for this user. i.e. valid authentication methods. |
| UserName | String | User name, a.k.a. Login name. This might be an e-mail address. |
| TicketCategories | Array | Request Ticket Categories assigned to the user.   <para>Use MDO List name "ejCategory" to get list items.</para> |
| NickName | String | The unique nick name for this user. Used in Service as an alias, similar to Name/Initials. |
| WaitingForApproval | Boolean | The user is waiting for an administrator to approve/grant her/him access. |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.User.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.User.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PostSaveCommands | Array | Post custom commands the client should execute after save has completed. |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Unique name of the command |
| DisplayName | string | The name to show in GUI |
| Description | string | Description of the command. |
| ToolTip | string | Tooltip to be used in the GUI |
| Actions | string | The actions to call when invoked |
| ActionData | string | The data to be used when the command is invoked |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/User/GetUserCommands
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 27,
  "Name": "Metz-Schiller",
  "Rank": 1002,
  "Tooltip": "eos",
  "LicenseOwners": [
    {
      "Name": "Weimann, Konopelski and Jacobi",
      "Description": "Stand-alone scalable website",
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
      "Name": "Weimann, Konopelski and Jacobi",
      "Description": "Stand-alone scalable website",
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
      "Value": "omnis",
      "Tooltip": "quia",
      "Id": 941,
      "Rank": 812,
      "Deleted": true
    },
    {
      "Value": "omnis",
      "Tooltip": "quia",
      "Id": 941,
      "Rank": 812,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2008-11-04T02:30:48.1006818+01:00",
  "Lastlogout": "2001-08-11T02:30:48.1006818+02:00",
  "EjUserId": 623,
  "RequestSignature": "esse",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "qui",
      "DisplayValue": "explicabo"
    },
    {
      "Type": null,
      "Value": "qui",
      "DisplayValue": "explicabo"
    }
  ],
  "UserName": "Moore Inc and Sons",
  "TicketCategories": [
    {
      "Id": 890,
      "Name": "Koepp LLC",
      "ToolTip": "Similique possimus veritatis eum est fugiat ut consectetur.",
      "Deleted": false,
      "Rank": 743,
      "Type": "accusantium",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "nisi",
      "ColorBlock": 259,
      "ExtraInfo": "placeat",
      "StyleHint": "ipsum",
      "FullName": "Prof. Antone Hattie Murazik DVM"
    }
  ],
  "NickName": "Zboncak Group",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "est"
  },
  "PostSaveCommands": [
    {
      "Name": "Feil LLC",
      "DisplayName": "Powlowski, Schneider and Huels",
      "Description": "Upgradable attitude-oriented service-desk",
      "ToolTip": "Atque et porro aut consequatur eaque.",
      "Actions": "Implicit",
      "ActionData": "rem"
    },
    {
      "Name": "Feil LLC",
      "DisplayName": "Powlowski, Schneider and Huels",
      "Description": "Upgradable attitude-oriented service-desk",
      "ToolTip": "Atque et porro aut consequatur eaque.",
      "Actions": "Implicit",
      "ActionData": "rem"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Jacobson, Bode and Sanford",
    "DisplayName": "Schneider-Schneider",
    "Description": "Re-contextualized homogeneous website",
    "ToolTip": "Placeat fugiat.",
    "Actions": "Implicit",
    "ActionData": "quaerat",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 423
      }
    }
  }
]
```