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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 890,
  "Name": "Braun, Larkin and Hansen",
  "Rank": 999,
  "Tooltip": "minima",
  "LicenseOwners": [
    {
      "Name": "Schuster Group",
      "Description": "Secured static migration",
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
      "Name": "Schuster Group",
      "Description": "Secured static migration",
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
      "Value": "repellendus",
      "Tooltip": "consectetur",
      "Id": 620,
      "Rank": 752,
      "Deleted": false
    },
    {
      "Value": "repellendus",
      "Tooltip": "consectetur",
      "Id": 620,
      "Rank": 752,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2001-07-20T12:01:33.3863444+02:00",
  "Lastlogout": "2006-06-10T12:01:33.3863444+02:00",
  "EjUserId": 334,
  "RequestSignature": "qui",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "quam",
      "DisplayValue": "doloremque"
    },
    {
      "Type": null,
      "Value": "quam",
      "DisplayValue": "doloremque"
    }
  ],
  "UserName": "Adams, Ratke and Ward",
  "TicketCategories": [
    {
      "Id": 6,
      "Name": "Gusikowski Group",
      "ToolTip": "Est ut id quae quae repellendus beatae sed.",
      "Deleted": false,
      "Rank": 865,
      "Type": "eos",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sed",
      "ColorBlock": 424,
      "ExtraInfo": "earum",
      "StyleHint": "et",
      "FullName": "Pinkie Hauck"
    }
  ],
  "NickName": "Bernier LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "facere"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "incidunt"
  },
  "PostSaveCommands": [
    {
      "Name": "Kirlin Inc and Sons",
      "DisplayName": "Johnson Inc and Sons",
      "Description": "Triple-buffered asynchronous application",
      "ToolTip": "Voluptas pariatur quisquam.",
      "Actions": "Implicit",
      "ActionData": "fuga"
    },
    {
      "Name": "Kirlin Inc and Sons",
      "DisplayName": "Johnson Inc and Sons",
      "Description": "Triple-buffered asynchronous application",
      "ToolTip": "Voluptas pariatur quisquam.",
      "Actions": "Implicit",
      "ActionData": "fuga"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 921,
  "Name": "Balistreri Inc and Sons",
  "Rank": 306,
  "Tooltip": "sed",
  "LicenseOwners": [
    {
      "Name": "Daniel, Bosco and Bogan",
      "Description": "Upgradable local portal",
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
          "FieldLength": 529
        }
      }
    },
    {
      "Name": "Daniel, Bosco and Bogan",
      "Description": "Upgradable local portal",
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
          "FieldLength": 529
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "non",
      "Tooltip": "dolorum",
      "Id": 988,
      "Rank": 399,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 579
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2003-11-27T12:01:33.3863444+01:00",
  "Lastlogout": "2005-06-06T12:01:33.3863444+02:00",
  "EjUserId": 389,
  "RequestSignature": "magnam",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "est",
      "DisplayValue": "eaque",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    },
    {
      "Type": null,
      "Value": "est",
      "DisplayValue": "eaque",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    }
  ],
  "UserName": "Murphy LLC",
  "TicketCategories": [
    {
      "Id": 192,
      "Name": "Jones, Hayes and Kassulke",
      "ToolTip": "Ut voluptas sit itaque.",
      "Deleted": false,
      "Rank": 83,
      "Type": "veritatis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "facere",
      "ColorBlock": 766,
      "ExtraInfo": "eos",
      "StyleHint": "mollitia",
      "FullName": "Rylan Ruecker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    }
  ],
  "NickName": "Kautzer, Zemlak and Cartwright",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "animi",
    "CustomFields2": "qui"
  },
  "PostSaveCommands": [
    {
      "Name": "Wilkinson-Sporer",
      "DisplayName": "Kulas Inc and Sons",
      "Description": "Self-enabling human-resource alliance",
      "ToolTip": "Dolor ullam illo et illum qui nemo.",
      "Actions": "Implicit",
      "ActionData": "cupiditate",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 382
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 788
    }
  }
}
```