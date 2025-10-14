---
title: POST Agents/User/SaveUser
uid: v1UserAgent_SaveUser
generated: true
content_type: reference
---

# POST Agents/User/SaveUser

```http
POST /api/v1/Agents/User/SaveUser
```

Updates the existing User or creates a new User if the id parameter is 0.


NsApiSlow threshold: 2000 ms.


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

## Request Body: user 

The User that is saved 

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 837,
  "Name": "Kub, Bernier and Cartwright",
  "Rank": 631,
  "Tooltip": "minus",
  "LicenseOwners": [
    {
      "Name": "Lueilwitz Group",
      "Description": "Polarised context-sensitive encryption",
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
      "Name": "Lueilwitz Group",
      "Description": "Polarised context-sensitive encryption",
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
      "Value": "provident",
      "Tooltip": "facilis",
      "Id": 428,
      "Rank": 630,
      "Deleted": false
    },
    {
      "Value": "provident",
      "Tooltip": "facilis",
      "Id": 428,
      "Rank": 630,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2019-11-18T03:40:48.1879959+01:00",
  "Lastlogout": "2005-04-01T03:40:48.1879959+02:00",
  "EjUserId": 179,
  "RequestSignature": "veniam",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "qui",
      "DisplayValue": "repudiandae"
    },
    {
      "Type": null,
      "Value": "qui",
      "DisplayValue": "repudiandae"
    }
  ],
  "UserName": "Bradtke, Champlin and Waters",
  "TicketCategories": [
    {
      "Id": 844,
      "Name": "Johnston LLC",
      "ToolTip": "Ullam voluptatem quo eos libero nostrum.",
      "Deleted": true,
      "Rank": 787,
      "Type": "fugit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "distinctio",
      "ColorBlock": 921,
      "ExtraInfo": "maxime",
      "StyleHint": "impedit",
      "FullName": "Mrs. Spencer Darrion Barton"
    }
  ],
  "NickName": "Gerlach Group",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "nulla"
  },
  "PostSaveCommands": [
    {
      "Name": "Ryan, Miller and Torp",
      "DisplayName": "Lueilwitz, Maggio and Turcotte",
      "Description": "Multi-lateral multi-state system engine",
      "ToolTip": "Doloremque et fugit eos.",
      "Actions": "Implicit",
      "ActionData": "numquam"
    },
    {
      "Name": "Ryan, Miller and Torp",
      "DisplayName": "Lueilwitz, Maggio and Turcotte",
      "Description": "Multi-lateral multi-state system engine",
      "ToolTip": "Doloremque et fugit eos.",
      "Actions": "Implicit",
      "ActionData": "numquam"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 386,
  "Name": "O'Reilly, Quigley and Wisoky",
  "Rank": 601,
  "Tooltip": "quidem",
  "LicenseOwners": [
    {
      "Name": "Doyle, Gulgowski and Hartmann",
      "Description": "Phased content-based contingency",
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
          "FieldLength": 515
        }
      }
    },
    {
      "Name": "Doyle, Gulgowski and Hartmann",
      "Description": "Phased content-based contingency",
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
          "FieldLength": 515
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "reiciendis",
      "Tooltip": "laboriosam",
      "Id": 797,
      "Rank": 894,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 540
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2025-05-30T03:40:48.2036224+02:00",
  "Lastlogout": "1998-07-16T03:40:48.2036224+02:00",
  "EjUserId": 828,
  "RequestSignature": "sapiente",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "ipsum",
      "DisplayValue": "ipsam",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    },
    {
      "Type": null,
      "Value": "ipsum",
      "DisplayValue": "ipsam",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "UserName": "Hermiston-Goyette",
  "TicketCategories": [
    {
      "Id": 79,
      "Name": "Rodriguez-Lynch",
      "ToolTip": "Iusto est consequatur suscipit vitae sed necessitatibus architecto.",
      "Deleted": true,
      "Rank": 400,
      "Type": "explicabo",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sed",
      "ColorBlock": 612,
      "ExtraInfo": "dolorem",
      "StyleHint": "quo",
      "FullName": "Carlo Wunsch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 947
        }
      }
    }
  ],
  "NickName": "Gerlach, Rosenbaum and Gusikowski",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "accusamus",
    "CustomFields2": "a"
  },
  "PostSaveCommands": [
    {
      "Name": "Kovacek Inc and Sons",
      "DisplayName": "Schulist Inc and Sons",
      "Description": "Decentralized impactful concept",
      "ToolTip": "Et sunt similique eligendi natus consequatur aut.",
      "Actions": "Implicit",
      "ActionData": "natus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 486
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 713
    }
  }
}
```