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
  "AssociateId": 976,
  "Name": "Kiehn Group",
  "Rank": 584,
  "Tooltip": "et",
  "LicenseOwners": [
    {
      "Name": "Christiansen, Smitham and Mayer",
      "Description": "Enterprise-wide cohesive support",
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
      "Name": "Christiansen, Smitham and Mayer",
      "Description": "Enterprise-wide cohesive support",
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
      "Value": "quia",
      "Tooltip": "qui",
      "Id": 218,
      "Rank": 246,
      "Deleted": false
    },
    {
      "Value": "quia",
      "Tooltip": "qui",
      "Id": 218,
      "Rank": 246,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2017-09-10T12:57:35.2743471+02:00",
  "Lastlogout": "2011-04-18T12:57:35.2743471+02:00",
  "EjUserId": 196,
  "RequestSignature": "cumque",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "distinctio",
      "DisplayValue": "voluptas"
    },
    {
      "Type": null,
      "Value": "distinctio",
      "DisplayValue": "voluptas"
    }
  ],
  "UserName": "Rolfson Group",
  "TicketCategories": [
    {
      "Id": 542,
      "Name": "Wintheiser Group",
      "ToolTip": "Ea error necessitatibus iusto reprehenderit sunt provident.",
      "Deleted": false,
      "Rank": 722,
      "Type": "magni",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "totam",
      "ColorBlock": 335,
      "ExtraInfo": "ex",
      "StyleHint": "quos",
      "FullName": "Serenity Renner IV"
    }
  ],
  "NickName": "Bernier Group",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "et"
  },
  "PostSaveCommands": [
    {
      "Name": "O'Kon-Walter",
      "DisplayName": "Metz-Nienow",
      "Description": "Enhanced maximized superstructure",
      "ToolTip": "Libero placeat.",
      "Actions": "Implicit",
      "ActionData": "sint"
    },
    {
      "Name": "O'Kon-Walter",
      "DisplayName": "Metz-Nienow",
      "Description": "Enhanced maximized superstructure",
      "ToolTip": "Libero placeat.",
      "Actions": "Implicit",
      "ActionData": "sint"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 765,
  "Name": "Beier-Brekke",
  "Rank": 331,
  "Tooltip": "ad",
  "LicenseOwners": [
    {
      "Name": "Monahan LLC",
      "Description": "Focused eco-centric interface",
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
          "FieldType": "System.Int32",
          "FieldLength": 665
        }
      }
    },
    {
      "Name": "Monahan LLC",
      "Description": "Focused eco-centric interface",
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
          "FieldType": "System.Int32",
          "FieldLength": 665
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "in",
      "Tooltip": "soluta",
      "Id": 794,
      "Rank": 60,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 2
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2005-01-04T12:57:35.2899717+01:00",
  "Lastlogout": "2023-12-30T12:57:35.2899717+01:00",
  "EjUserId": 465,
  "RequestSignature": "dolor",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "temporibus",
      "DisplayValue": "excepturi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 397
        }
      }
    },
    {
      "Type": null,
      "Value": "temporibus",
      "DisplayValue": "excepturi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 397
        }
      }
    }
  ],
  "UserName": "Schimmel Inc and Sons",
  "TicketCategories": [
    {
      "Id": 638,
      "Name": "Collier-Cremin",
      "ToolTip": "Vel esse nisi aut dolores reiciendis.",
      "Deleted": false,
      "Rank": 150,
      "Type": "et",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "blanditiis",
      "ColorBlock": 219,
      "ExtraInfo": "consequatur",
      "StyleHint": "et",
      "FullName": "Dr. Dina Colby Harris",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 942
        }
      }
    }
  ],
  "NickName": "Kunde-Stamm",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "cupiditate"
  },
  "PostSaveCommands": [
    {
      "Name": "Murray-Connelly",
      "DisplayName": "Towne, Kuphal and Runte",
      "Description": "Profound homogeneous data-warehouse",
      "ToolTip": "Accusamus quos aperiam expedita sit consequuntur illum.",
      "Actions": "Implicit",
      "ActionData": "et",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 853
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 309
    }
  }
}
```