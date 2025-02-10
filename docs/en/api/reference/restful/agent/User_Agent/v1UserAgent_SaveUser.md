---
title: POST Agents/User/SaveUser
uid: v1UserAgent_SaveUser
generated: true
---

# POST Agents/User/SaveUser

```http
POST /api/v1/Agents/User/SaveUser
```

Updates the existing User or creates a new User if the id parameter is empty


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

## Request Body: entity 

The User to be saved. 

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

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: User

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 | Primary key |
| Name | string | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role | Role | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup | UserGroup | The main user group that this user belongs to.  Use MDO List name "usergroup" to get list items. |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  Use MDO List name "usergroup" to get list items. |
| Person | Person | The person associated with this user. Detailed information about the user  Use MDO List name "person_new" to get list items. |
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
| TicketCategories | array | Request Ticket Categories assigned to the user.   Use MDO List name "ejCategory" to get list items. |
| NickName | string | The unique nick name for this user. Used in Service as an alias, similar to Name/Initials. |
| WaitingForApproval | bool | The user is waiting for an administrator to approve/grant her/him access. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.User.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.User.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PostSaveCommands | array | Post custom commands the client should execute after save has completed. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/User/SaveUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 884,
  "Name": "Fahey, Mayert and Dickinson",
  "Rank": 529,
  "Tooltip": "tempora",
  "LicenseOwners": [
    {
      "Name": "Marquardt Group",
      "Description": "Right-sized user-facing knowledge user",
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
      "Name": "Marquardt Group",
      "Description": "Right-sized user-facing knowledge user",
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
      "Value": "rerum",
      "Tooltip": "voluptatibus",
      "Id": 195,
      "Rank": 928,
      "Deleted": false
    },
    {
      "Value": "rerum",
      "Tooltip": "voluptatibus",
      "Id": 195,
      "Rank": 928,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2005-11-12T12:01:28.5878372+01:00",
  "Lastlogout": "2001-01-16T12:01:28.5878372+01:00",
  "EjUserId": 398,
  "RequestSignature": "animi",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "id",
      "DisplayValue": "optio"
    },
    {
      "Type": null,
      "Value": "id",
      "DisplayValue": "optio"
    }
  ],
  "UserName": "Goldner-O'Conner",
  "TicketCategories": [
    {
      "Id": 28,
      "Name": "Morissette Inc and Sons",
      "ToolTip": "Sunt esse doloremque ratione.",
      "Deleted": true,
      "Rank": 803,
      "Type": "voluptatem",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "eveniet",
      "ColorBlock": 874,
      "ExtraInfo": "aut",
      "StyleHint": "facilis",
      "FullName": "Brown Stark"
    }
  ],
  "NickName": "Hagenes-Klocko",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "rem",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "explicabo"
  },
  "PostSaveCommands": [
    {
      "Name": "O'Keefe Inc and Sons",
      "DisplayName": "Smitham-Dooley",
      "Description": "Fully-configurable maximized matrices",
      "ToolTip": "Consequatur pariatur natus ipsa voluptatem.",
      "Actions": "Implicit",
      "ActionData": "molestias"
    },
    {
      "Name": "O'Keefe Inc and Sons",
      "DisplayName": "Smitham-Dooley",
      "Description": "Fully-configurable maximized matrices",
      "ToolTip": "Consequatur pariatur natus ipsa voluptatem.",
      "Actions": "Implicit",
      "ActionData": "molestias"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 743,
  "Name": "Crooks LLC",
  "Rank": 869,
  "Tooltip": "blanditiis",
  "LicenseOwners": [
    {
      "Name": "Fritsch-Kunde",
      "Description": "Triple-buffered discrete protocol",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 583
        }
      }
    },
    {
      "Name": "Fritsch-Kunde",
      "Description": "Triple-buffered discrete protocol",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 583
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "quasi",
      "Tooltip": "voluptas",
      "Id": 365,
      "Rank": 738,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 972
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2018-03-17T12:01:28.5878372+01:00",
  "Lastlogout": "2003-11-07T12:01:28.5878372+01:00",
  "EjUserId": 986,
  "RequestSignature": "inventore",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "quibusdam",
      "DisplayValue": "consequatur",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 997
        }
      }
    },
    {
      "Type": null,
      "Value": "quibusdam",
      "DisplayValue": "consequatur",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 997
        }
      }
    }
  ],
  "UserName": "Kovacek, Grimes and Ziemann",
  "TicketCategories": [
    {
      "Id": 628,
      "Name": "Ortiz, Russel and Hodkiewicz",
      "ToolTip": "Ducimus quia dolorem et.",
      "Deleted": false,
      "Rank": 567,
      "Type": "consequatur",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "eaque",
      "ColorBlock": 299,
      "ExtraInfo": "dicta",
      "StyleHint": "quasi",
      "FullName": "Maddison Hagenes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 83
        }
      }
    }
  ],
  "NickName": "Braun Group",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "ipsa",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "eos"
  },
  "PostSaveCommands": [
    {
      "Name": "Greenfelder, Lesch and Jast",
      "DisplayName": "Blanda Group",
      "Description": "Organic fault-tolerant artificial intelligence",
      "ToolTip": "Inventore cumque cupiditate quam dolorem ab.",
      "Actions": "Implicit",
      "ActionData": "possimus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 528
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 551
    }
  }
}
```