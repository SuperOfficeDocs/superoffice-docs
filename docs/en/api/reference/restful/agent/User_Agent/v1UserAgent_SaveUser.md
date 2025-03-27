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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 296,
  "Name": "Crooks, Barrows and Pfeffer",
  "Rank": 716,
  "Tooltip": "quia",
  "LicenseOwners": [
    {
      "Name": "Aufderhar Inc and Sons",
      "Description": "Universal static middleware",
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
      "Name": "Aufderhar Inc and Sons",
      "Description": "Universal static middleware",
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
      "Value": "aut",
      "Tooltip": "tenetur",
      "Id": 653,
      "Rank": 951,
      "Deleted": false
    },
    {
      "Value": "aut",
      "Tooltip": "tenetur",
      "Id": 653,
      "Rank": 951,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2011-11-02T02:38:22.1825743+01:00",
  "Lastlogout": "2003-06-19T02:38:22.1825743+02:00",
  "EjUserId": 610,
  "RequestSignature": "porro",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "quaerat",
      "DisplayValue": "error"
    },
    {
      "Type": null,
      "Value": "quaerat",
      "DisplayValue": "error"
    }
  ],
  "UserName": "Mayer-Huel",
  "TicketCategories": [
    {
      "Id": 902,
      "Name": "Boehm, McGlynn and Ondricka",
      "ToolTip": "Dolor et a aliquid.",
      "Deleted": true,
      "Rank": 292,
      "Type": "voluptatem",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "excepturi",
      "ColorBlock": 569,
      "ExtraInfo": "voluptas",
      "StyleHint": "quia",
      "FullName": "Reyes Dooley"
    }
  ],
  "NickName": "Wilkinson-Pouros",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "eveniet"
  },
  "PostSaveCommands": [
    {
      "Name": "Cormier, Gutkowski and Koelpin",
      "DisplayName": "Gusikowski Group",
      "Description": "Organized user-facing architecture",
      "ToolTip": "Nihil dolorem ipsa optio eaque quis labore.",
      "Actions": "Implicit",
      "ActionData": "eos"
    },
    {
      "Name": "Cormier, Gutkowski and Koelpin",
      "DisplayName": "Gusikowski Group",
      "Description": "Organized user-facing architecture",
      "ToolTip": "Nihil dolorem ipsa optio eaque quis labore.",
      "Actions": "Implicit",
      "ActionData": "eos"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 53,
  "Name": "Boehm, Langosh and Hills",
  "Rank": 209,
  "Tooltip": "quia",
  "LicenseOwners": [
    {
      "Name": "Bernhard LLC",
      "Description": "Triple-buffered explicit extranet",
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
          "FieldLength": 214
        }
      }
    },
    {
      "Name": "Bernhard LLC",
      "Description": "Triple-buffered explicit extranet",
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
          "FieldLength": 214
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "omnis",
      "Tooltip": "nisi",
      "Id": 848,
      "Rank": 280,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 255
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2013-09-29T02:38:22.1825743+02:00",
  "Lastlogout": "2011-06-24T02:38:22.1825743+02:00",
  "EjUserId": 373,
  "RequestSignature": "similique",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "molestiae",
      "DisplayValue": "nemo",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 197
        }
      }
    },
    {
      "Type": null,
      "Value": "molestiae",
      "DisplayValue": "nemo",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 197
        }
      }
    }
  ],
  "UserName": "Hoppe-Dooley",
  "TicketCategories": [
    {
      "Id": 809,
      "Name": "Marvin LLC",
      "ToolTip": "Eveniet qui nostrum quo cupiditate.",
      "Deleted": true,
      "Rank": 866,
      "Type": "optio",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "et",
      "ColorBlock": 796,
      "ExtraInfo": "et",
      "StyleHint": "atque",
      "FullName": "Michale Arthur Hand II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 462
        }
      }
    }
  ],
  "NickName": "Nicolas LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "vero",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "eius"
  },
  "PostSaveCommands": [
    {
      "Name": "Bartell Inc and Sons",
      "DisplayName": "Kohler-Graham",
      "Description": "Integrated dedicated forecast",
      "ToolTip": "Culpa alias quia autem dignissimos.",
      "Actions": "Implicit",
      "ActionData": "dignissimos",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 476
    }
  }
}
```