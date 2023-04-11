---
title: POST Agents/User/SaveUser
uid: v1UserAgent_SaveUser
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
| UserGroup | UserGroup | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person | Person | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
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
  "AssociateId": 252,
  "Name": "Welch, Marvin and Franecki",
  "Rank": 454,
  "Tooltip": "eveniet",
  "LicenseOwners": [
    {
      "Name": "Frami-Feeney",
      "Description": "Object-based high-level database",
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
      "Name": "Frami-Feeney",
      "Description": "Object-based high-level database",
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
      "Value": "voluptas",
      "Tooltip": "qui",
      "Id": 747,
      "Rank": 997,
      "Deleted": true
    },
    {
      "Value": "voluptas",
      "Tooltip": "qui",
      "Id": 747,
      "Rank": 997,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2015-10-06T15:29:23.3187535+02:00",
  "Lastlogout": "2005-07-17T15:29:23.3187535+02:00",
  "EjUserId": 749,
  "RequestSignature": "est",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "est",
      "DisplayValue": "perspiciatis"
    },
    {
      "Type": null,
      "Value": "est",
      "DisplayValue": "perspiciatis"
    }
  ],
  "UserName": "Adams, Lynch and Wisoky",
  "TicketCategories": [
    {
      "Id": 639,
      "Name": "Hilll, Roberts and Gerhold",
      "ToolTip": "Perspiciatis deserunt assumenda fugit.",
      "Deleted": false,
      "Rank": 106,
      "Type": "labore",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "asperiores",
      "ColorBlock": 456,
      "ExtraInfo": "voluptas",
      "StyleHint": "ut",
      "FullName": "Dawson Dooley"
    }
  ],
  "NickName": "Bayer, Glover and Corwin",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "porro"
  },
  "PostSaveCommands": [
    {
      "Name": "D'Amore-Lynch",
      "DisplayName": "Emard-Lehner",
      "Description": "Persevering context-sensitive attitude",
      "ToolTip": "Dolor omnis.",
      "Actions": "Implicit",
      "ActionData": "consequatur"
    },
    {
      "Name": "D'Amore-Lynch",
      "DisplayName": "Emard-Lehner",
      "Description": "Persevering context-sensitive attitude",
      "ToolTip": "Dolor omnis.",
      "Actions": "Implicit",
      "ActionData": "consequatur"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 290,
  "Name": "Crona LLC",
  "Rank": 959,
  "Tooltip": "soluta",
  "LicenseOwners": [
    {
      "Name": "Torp, Kutch and Weimann",
      "Description": "Inverse composite adapter",
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
          "FieldLength": 297
        }
      }
    },
    {
      "Name": "Torp, Kutch and Weimann",
      "Description": "Inverse composite adapter",
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
          "FieldLength": 297
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "rem",
      "Tooltip": "ex",
      "Id": 4,
      "Rank": 762,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 349
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2016-04-20T15:29:23.3247546+02:00",
  "Lastlogout": "2002-04-14T15:29:23.3247546+02:00",
  "EjUserId": 55,
  "RequestSignature": "explicabo",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "maiores",
      "DisplayValue": "ut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    },
    {
      "Type": null,
      "Value": "maiores",
      "DisplayValue": "ut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    }
  ],
  "UserName": "Breitenberg LLC",
  "TicketCategories": [
    {
      "Id": 838,
      "Name": "Bednar Inc and Sons",
      "ToolTip": "Rerum eos quis.",
      "Deleted": false,
      "Rank": 700,
      "Type": "eos",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "magni",
      "ColorBlock": 649,
      "ExtraInfo": "quidem",
      "StyleHint": "sunt",
      "FullName": "Mrs. Billy Abigail Olson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    }
  ],
  "NickName": "Zieme, Wolf and Renner",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "quibusdam"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "est"
  },
  "PostSaveCommands": [
    {
      "Name": "Ortiz, Dicki and Ernser",
      "DisplayName": "Ortiz Inc and Sons",
      "Description": "Public-key value-added challenge",
      "ToolTip": "Maxime est sint aspernatur facere provident.",
      "Actions": "Implicit",
      "ActionData": "quod",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 393
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 457
    }
  }
}
```