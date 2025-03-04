---
title: PUT User/{id}
uid: v1User_PutUser
generated: true
---

# PUT User/{id}

```http
PUT /api/v1/User/{id}
```

Updates the existing User


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The User id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/User/{id}?$select=name,department,category/id
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

User updated.

| Response | Description |
|----------------|-------------|
| 200 | User updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/User/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 622,
  "Name": "Reilly-Will",
  "Rank": 880,
  "Tooltip": "rerum",
  "LicenseOwners": [
    {
      "Name": "Ratke-Bauch",
      "Description": "Phased tertiary framework",
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
      "Name": "Ratke-Bauch",
      "Description": "Phased tertiary framework",
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
      "Value": "velit",
      "Tooltip": "et",
      "Id": 204,
      "Rank": 925,
      "Deleted": true
    },
    {
      "Value": "velit",
      "Tooltip": "et",
      "Id": 204,
      "Rank": 925,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2013-12-18T14:13:49.5555275+01:00",
  "Lastlogout": "2006-08-20T14:13:49.5555275+02:00",
  "EjUserId": 660,
  "RequestSignature": "eligendi",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "distinctio",
      "DisplayValue": "nulla"
    },
    {
      "Type": null,
      "Value": "distinctio",
      "DisplayValue": "nulla"
    }
  ],
  "UserName": "Mann, Gulgowski and Ryan",
  "TicketCategories": [
    {
      "Id": 141,
      "Name": "Blanda Inc and Sons",
      "ToolTip": "Libero laborum tenetur aperiam ut provident.",
      "Deleted": false,
      "Rank": 646,
      "Type": "reprehenderit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "natus",
      "ColorBlock": 29,
      "ExtraInfo": "quibusdam",
      "StyleHint": "voluptate",
      "FullName": "Ryley Julian Gleason DDS"
    }
  ],
  "NickName": "Nicolas, Ward and Carroll",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "reprehenderit"
  },
  "PostSaveCommands": [
    {
      "Name": "Kemmer-Smith",
      "DisplayName": "Armstrong Group",
      "Description": "Integrated attitude-oriented capability",
      "ToolTip": "Nesciunt quis omnis qui facere omnis sit aut.",
      "Actions": "Implicit",
      "ActionData": "facilis"
    },
    {
      "Name": "Kemmer-Smith",
      "DisplayName": "Armstrong Group",
      "Description": "Integrated attitude-oriented capability",
      "ToolTip": "Nesciunt quis omnis qui facere omnis sit aut.",
      "Actions": "Implicit",
      "ActionData": "facilis"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 290,
  "Name": "Gaylord, Robel and Wiegand",
  "Rank": 979,
  "Tooltip": "dicta",
  "LicenseOwners": [
    {
      "Name": "Mayer Inc and Sons",
      "Description": "Customizable directional pricing structure",
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
          "FieldLength": 770
        }
      }
    },
    {
      "Name": "Mayer Inc and Sons",
      "Description": "Customizable directional pricing structure",
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
          "FieldLength": 770
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "dolore",
      "Tooltip": "quasi",
      "Id": 434,
      "Rank": 413,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2014-02-17T14:13:49.5555275+01:00",
  "Lastlogout": "2012-06-28T14:13:49.5555275+02:00",
  "EjUserId": 971,
  "RequestSignature": "voluptatem",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "eveniet",
      "DisplayValue": "dolorem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 116
        }
      }
    },
    {
      "Type": null,
      "Value": "eveniet",
      "DisplayValue": "dolorem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 116
        }
      }
    }
  ],
  "UserName": "Medhurst, Purdy and Schmeler",
  "TicketCategories": [
    {
      "Id": 958,
      "Name": "Runolfsdottir, Ankunding and Dooley",
      "ToolTip": "Voluptatum ab provident occaecati culpa.",
      "Deleted": true,
      "Rank": 717,
      "Type": "dolor",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "deleniti",
      "ColorBlock": 662,
      "ExtraInfo": "voluptas",
      "StyleHint": "corrupti",
      "FullName": "Ms. Johnny Angie Gerlach PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 99
        }
      }
    }
  ],
  "NickName": "Padberg-McGlynn",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "labore"
  },
  "CustomFields": {
    "CustomFields1": "excepturi",
    "CustomFields2": "excepturi"
  },
  "PostSaveCommands": [
    {
      "Name": "Brakus-O'Connell",
      "DisplayName": "Hoeger-Pfannerstill",
      "Description": "Monitored value-added algorithm",
      "ToolTip": "Nam ipsum quos.",
      "Actions": "Implicit",
      "ActionData": "a",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 109
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```