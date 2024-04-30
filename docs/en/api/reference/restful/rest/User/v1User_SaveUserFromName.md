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
  "AssociateId": 422,
  "Name": "Windler-Bartell",
  "Rank": 739,
  "Tooltip": "ut",
  "LicenseOwners": [
    {
      "Name": "Keeling, Murphy and Howell",
      "Description": "Devolved directional orchestration",
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
      "Name": "Keeling, Murphy and Howell",
      "Description": "Devolved directional orchestration",
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
      "Value": "ea",
      "Tooltip": "voluptatem",
      "Id": 162,
      "Rank": 226,
      "Deleted": false
    },
    {
      "Value": "ea",
      "Tooltip": "voluptatem",
      "Id": 162,
      "Rank": 226,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2019-06-08T11:44:42.8357055+02:00",
  "Lastlogout": "2016-06-24T11:44:42.8357055+02:00",
  "EjUserId": 474,
  "RequestSignature": "id",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "ut",
      "DisplayValue": "recusandae"
    },
    {
      "Type": null,
      "Value": "ut",
      "DisplayValue": "recusandae"
    }
  ],
  "UserName": "Daniel-Champlin",
  "TicketCategories": [
    {
      "Id": 178,
      "Name": "Klocko Group",
      "ToolTip": "Enim aliquam dolorum ut omnis sed pariatur quod.",
      "Deleted": false,
      "Rank": 678,
      "Type": "molestias",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "optio",
      "ColorBlock": 517,
      "ExtraInfo": "eligendi",
      "StyleHint": "natus",
      "FullName": "Coralie Dietrich"
    }
  ],
  "NickName": "Ortiz-Blick",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "esse"
  },
  "CustomFields": {
    "CustomFields1": "ipsa",
    "CustomFields2": "sint"
  },
  "PostSaveCommands": [
    {
      "Name": "Konopelski LLC",
      "DisplayName": "Kihn-Dickinson",
      "Description": "Realigned tertiary moratorium",
      "ToolTip": "Sapiente mollitia repudiandae voluptas blanditiis quia.",
      "Actions": "Implicit",
      "ActionData": "placeat"
    },
    {
      "Name": "Konopelski LLC",
      "DisplayName": "Kihn-Dickinson",
      "Description": "Realigned tertiary moratorium",
      "ToolTip": "Sapiente mollitia repudiandae voluptas blanditiis quia.",
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
  "AssociateId": 547,
  "Name": "Graham-Mertz",
  "Rank": 159,
  "Tooltip": "asperiores",
  "LicenseOwners": [
    {
      "Name": "Ratke LLC",
      "Description": "Multi-lateral grid-enabled emulation",
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
          "FieldLength": 361
        }
      }
    },
    {
      "Name": "Ratke LLC",
      "Description": "Multi-lateral grid-enabled emulation",
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
          "FieldLength": 361
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "ut",
      "Tooltip": "dolorem",
      "Id": 887,
      "Rank": 34,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 43
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2002-03-11T11:44:42.8513292+01:00",
  "Lastlogout": "2003-03-09T11:44:42.8513292+01:00",
  "EjUserId": 7,
  "RequestSignature": "velit",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "quia",
      "DisplayValue": "velit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    },
    {
      "Type": null,
      "Value": "quia",
      "DisplayValue": "velit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    }
  ],
  "UserName": "Romaguera-McKenzie",
  "TicketCategories": [
    {
      "Id": 327,
      "Name": "Kemmer, Herzog and Gleason",
      "ToolTip": "Aut est sunt sequi.",
      "Deleted": true,
      "Rank": 806,
      "Type": "hic",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "consequatur",
      "ColorBlock": 975,
      "ExtraInfo": "consectetur",
      "StyleHint": "autem",
      "FullName": "Brown Cecile Bruen IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 207
        }
      }
    }
  ],
  "NickName": "Emmerich-Welch",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "laudantium",
    "CustomFields2": "provident"
  },
  "PostSaveCommands": [
    {
      "Name": "Shanahan Group",
      "DisplayName": "Hayes Inc and Sons",
      "Description": "Customer-focused interactive process improvement",
      "ToolTip": "Voluptatem esse.",
      "Actions": "Implicit",
      "ActionData": "ut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 889
    }
  }
}
```