---
title: POST User
uid: v1User_PostUser
generated: true
content_type: reference
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 230,
  "Name": "Hegmann-Schulist",
  "Rank": 865,
  "Tooltip": "voluptatum",
  "LicenseOwners": [
    {
      "Name": "Jast-Stiedemann",
      "Description": "User-friendly foreground info-mediaries",
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
      "Name": "Jast-Stiedemann",
      "Description": "User-friendly foreground info-mediaries",
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
      "Value": "id",
      "Tooltip": "odit",
      "Id": 962,
      "Rank": 175,
      "Deleted": true
    },
    {
      "Value": "id",
      "Tooltip": "odit",
      "Id": 962,
      "Rank": 175,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2015-03-13T11:24:53.7811756+01:00",
  "Lastlogout": "2004-12-07T11:24:53.7811756+01:00",
  "EjUserId": 979,
  "RequestSignature": "iste",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "assumenda",
      "DisplayValue": "aut"
    },
    {
      "Type": null,
      "Value": "assumenda",
      "DisplayValue": "aut"
    }
  ],
  "UserName": "Shields-Hyatt",
  "TicketCategories": [
    {
      "Id": 636,
      "Name": "Vandervort Inc and Sons",
      "ToolTip": "Expedita ipsam.",
      "Deleted": false,
      "Rank": 348,
      "Type": "placeat",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "deleniti",
      "ColorBlock": 458,
      "ExtraInfo": "quia",
      "StyleHint": "sit",
      "FullName": "Madelynn Konopelski"
    }
  ],
  "NickName": "Metz LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "quaerat",
    "CustomFields2": "dignissimos"
  },
  "PostSaveCommands": [
    {
      "Name": "Hudson, Lindgren and Mraz",
      "DisplayName": "Wiegand, Jacobi and Friesen",
      "Description": "Ameliorated full-range time-frame",
      "ToolTip": "Dolore quibusdam consequuntur minima qui harum.",
      "Actions": "Implicit",
      "ActionData": "recusandae"
    },
    {
      "Name": "Hudson, Lindgren and Mraz",
      "DisplayName": "Wiegand, Jacobi and Friesen",
      "Description": "Ameliorated full-range time-frame",
      "ToolTip": "Dolore quibusdam consequuntur minima qui harum.",
      "Actions": "Implicit",
      "ActionData": "recusandae"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 241,
  "Name": "Maggio-Pagac",
  "Rank": 165,
  "Tooltip": "molestiae",
  "LicenseOwners": [
    {
      "Name": "Greenholt, Kunze and Fritsch",
      "Description": "Team-oriented responsive array",
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
          "FieldLength": 155
        }
      }
    },
    {
      "Name": "Greenholt, Kunze and Fritsch",
      "Description": "Team-oriented responsive array",
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
          "FieldLength": 155
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "molestias",
      "Tooltip": "dolor",
      "Id": 70,
      "Rank": 644,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2021-05-09T11:24:53.7967997+02:00",
  "Lastlogout": "2015-07-08T11:24:53.7967997+02:00",
  "EjUserId": 288,
  "RequestSignature": "quia",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "dignissimos",
      "DisplayValue": "accusamus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    },
    {
      "Type": null,
      "Value": "dignissimos",
      "DisplayValue": "accusamus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    }
  ],
  "UserName": "Collier Inc and Sons",
  "TicketCategories": [
    {
      "Id": 579,
      "Name": "Bednar, Mohr and Keeling",
      "ToolTip": "Repudiandae quisquam quam et sit et.",
      "Deleted": false,
      "Rank": 195,
      "Type": "aut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "repudiandae",
      "ColorBlock": 381,
      "ExtraInfo": "iure",
      "StyleHint": "dolor",
      "FullName": "Ms. Roberto Corkery",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    }
  ],
  "NickName": "Ernser, Satterfield and Bosco",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "quaerat"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "pariatur"
  },
  "PostSaveCommands": [
    {
      "Name": "Kuphal-Boehm",
      "DisplayName": "Wintheiser Inc and Sons",
      "Description": "Decentralized systematic intranet",
      "ToolTip": "Sed sint nemo.",
      "Actions": "Implicit",
      "ActionData": "voluptatem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 516
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 939
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```