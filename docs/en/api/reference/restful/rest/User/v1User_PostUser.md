---
title: POST User
uid: v1User_PostUser
generated: true
---

# POST User

```http
POST /api/v1/User
```

Creates a new User


Calls the User agent service SaveUser.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/User?$select=name,department,category/id
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

## Request Body: newEntity 

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

### Response body: UserWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/User
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 144,
  "Name": "Paucek Inc and Sons",
  "Rank": 797,
  "Tooltip": "excepturi",
  "LicenseOwners": [
    {
      "Name": "Wunsch Group",
      "Description": "User-centric secondary data-warehouse",
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
      "Name": "Wunsch Group",
      "Description": "User-centric secondary data-warehouse",
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
      "Value": "animi",
      "Tooltip": "molestiae",
      "Id": 351,
      "Rank": 265,
      "Deleted": false
    },
    {
      "Value": "animi",
      "Tooltip": "molestiae",
      "Id": 351,
      "Rank": 265,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2005-06-17T12:01:33.3707182+02:00",
  "Lastlogout": "2023-09-07T12:01:33.3707182+02:00",
  "EjUserId": 304,
  "RequestSignature": "ea",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "vero",
      "DisplayValue": "officia"
    },
    {
      "Type": null,
      "Value": "vero",
      "DisplayValue": "officia"
    }
  ],
  "UserName": "Bartoletti, Flatley and Kemmer",
  "TicketCategories": [
    {
      "Id": 885,
      "Name": "Veum LLC",
      "ToolTip": "Illum exercitationem quae qui.",
      "Deleted": true,
      "Rank": 155,
      "Type": "non",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "at",
      "ColorBlock": 770,
      "ExtraInfo": "nostrum",
      "StyleHint": "est",
      "FullName": "Reanna Parker Douglas Sr."
    }
  ],
  "NickName": "Spinka Inc and Sons",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "ab",
    "ExtraFields2": "laboriosam"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "nam"
  },
  "PostSaveCommands": [
    {
      "Name": "Wehner LLC",
      "DisplayName": "Franecki-Kohler",
      "Description": "Business-focused solution-oriented installation",
      "ToolTip": "Minima aut est et.",
      "Actions": "Implicit",
      "ActionData": "eum"
    },
    {
      "Name": "Wehner LLC",
      "DisplayName": "Franecki-Kohler",
      "Description": "Business-focused solution-oriented installation",
      "ToolTip": "Minima aut est et.",
      "Actions": "Implicit",
      "ActionData": "eum"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 213,
  "Name": "Spencer, Little and Funk",
  "Rank": 292,
  "Tooltip": "architecto",
  "LicenseOwners": [
    {
      "Name": "Spinka-Beatty",
      "Description": "Synchronised client-server data-warehouse",
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
          "FieldLength": 702
        }
      }
    },
    {
      "Name": "Spinka-Beatty",
      "Description": "Synchronised client-server data-warehouse",
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
          "FieldLength": 702
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "eum",
      "Tooltip": "ut",
      "Id": 254,
      "Rank": 245,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 310
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2015-10-09T12:01:33.3707182+02:00",
  "Lastlogout": "1998-03-19T12:01:33.3707182+01:00",
  "EjUserId": 424,
  "RequestSignature": "praesentium",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "architecto",
      "DisplayValue": "vitae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    },
    {
      "Type": null,
      "Value": "architecto",
      "DisplayValue": "vitae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    }
  ],
  "UserName": "Stark Group",
  "TicketCategories": [
    {
      "Id": 860,
      "Name": "Ullrich LLC",
      "ToolTip": "Maxime aut earum nulla molestiae.",
      "Deleted": true,
      "Rank": 636,
      "Type": "ipsum",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "in",
      "ColorBlock": 181,
      "ExtraInfo": "quisquam",
      "StyleHint": "qui",
      "FullName": "Orrin Purdy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    }
  ],
  "NickName": "Sipes LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "minus"
  },
  "PostSaveCommands": [
    {
      "Name": "Rosenbaum-Pacocha",
      "DisplayName": "Ebert LLC",
      "Description": "Grass-roots systematic ability",
      "ToolTip": "Saepe voluptas.",
      "Actions": "Implicit",
      "ActionData": "ipsum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1002
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 58
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```