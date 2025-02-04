---
title: PUT User/{userName}
uid: v1User_SaveUserFromName
generated: true
---

# PUT User/{userName}

```http
PUT /api/v1/User/{userName}
```

Save a user, with lookup based on the user name.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





| Path Part | Type | Description |
|-----------|------|-------------|
| userName | string | User name of the user to get. **Required** |



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

User object to save. 

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
PUT /api/v1/User/{userName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 629,
  "Name": "Hauck, Bernier and O'Hara",
  "Rank": 457,
  "Tooltip": "maiores",
  "LicenseOwners": [
    {
      "Name": "Carter, Mills and Gerhold",
      "Description": "Up-sized systemic interface",
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
      "Name": "Carter, Mills and Gerhold",
      "Description": "Up-sized systemic interface",
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
      "Value": "tempora",
      "Tooltip": "pariatur",
      "Id": 627,
      "Rank": 362,
      "Deleted": true
    },
    {
      "Value": "tempora",
      "Tooltip": "pariatur",
      "Id": 627,
      "Rank": 362,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "1999-12-06T13:13:32.6986606+01:00",
  "Lastlogout": "2017-12-11T13:13:32.6986606+01:00",
  "EjUserId": 961,
  "RequestSignature": "molestiae",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "molestiae",
      "DisplayValue": "cumque"
    },
    {
      "Type": null,
      "Value": "molestiae",
      "DisplayValue": "cumque"
    }
  ],
  "UserName": "Mann, Goodwin and Beatty",
  "TicketCategories": [
    {
      "Id": 615,
      "Name": "Waters-Jerde",
      "ToolTip": "Culpa molestiae voluptas.",
      "Deleted": false,
      "Rank": 261,
      "Type": "fugiat",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "tempore",
      "ColorBlock": 375,
      "ExtraInfo": "modi",
      "StyleHint": "labore",
      "FullName": "Cullen Kirlin"
    }
  ],
  "NickName": "Considine, Schroeder and Ebert",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "est"
  },
  "PostSaveCommands": [
    {
      "Name": "Runolfsdottir Inc and Sons",
      "DisplayName": "Kautzer-Pacocha",
      "Description": "Compatible fresh-thinking implementation",
      "ToolTip": "Asperiores dolorum et in placeat.",
      "Actions": "Implicit",
      "ActionData": "placeat"
    },
    {
      "Name": "Runolfsdottir Inc and Sons",
      "DisplayName": "Kautzer-Pacocha",
      "Description": "Compatible fresh-thinking implementation",
      "ToolTip": "Asperiores dolorum et in placeat.",
      "Actions": "Implicit",
      "ActionData": "placeat"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 462,
  "Name": "Doyle Inc and Sons",
  "Rank": 87,
  "Tooltip": "rerum",
  "LicenseOwners": [
    {
      "Name": "Dickinson, Marvin and Waters",
      "Description": "Customer-focused foreground pricing structure",
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
          "FieldLength": 450
        }
      }
    },
    {
      "Name": "Dickinson, Marvin and Waters",
      "Description": "Customer-focused foreground pricing structure",
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
          "FieldLength": 450
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "et",
      "Tooltip": "qui",
      "Id": 713,
      "Rank": 849,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2015-07-08T13:13:32.6986606+02:00",
  "Lastlogout": "2024-04-06T13:13:32.6986606+02:00",
  "EjUserId": 165,
  "RequestSignature": "sunt",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "impedit",
      "DisplayValue": "fugit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 691
        }
      }
    },
    {
      "Type": null,
      "Value": "impedit",
      "DisplayValue": "fugit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 691
        }
      }
    }
  ],
  "UserName": "Miller, Hayes and Tromp",
  "TicketCategories": [
    {
      "Id": 190,
      "Name": "Wyman Inc and Sons",
      "ToolTip": "Quas fugit.",
      "Deleted": false,
      "Rank": 763,
      "Type": "asperiores",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "harum",
      "ColorBlock": 246,
      "ExtraInfo": "neque",
      "StyleHint": "dolor",
      "FullName": "Mr. Sister Schinner MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "NickName": "Schamberger LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "sequi",
    "ExtraFields2": "quibusdam"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "nulla"
  },
  "PostSaveCommands": [
    {
      "Name": "Cruickshank-Ondricka",
      "DisplayName": "Jast, Stoltenberg and Windler",
      "Description": "Fundamental value-added complexity",
      "ToolTip": "Est quaerat minima quaerat totam.",
      "Actions": "Implicit",
      "ActionData": "alias",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 140
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 716
    }
  }
}
```