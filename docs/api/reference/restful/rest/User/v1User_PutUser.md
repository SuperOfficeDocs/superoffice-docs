---
title: PUT User/{id}
uid: v1User_PutUser
---

# PUT User/{id}

```http
PUT /api/v1/User/{id}
```

Updates the existing User

## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps

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
| AssociateId | int32 | Primary key |
| Name | string | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role |  | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup |  | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person |  | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
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

## Response

User updated.

| Response | Description |
|----------------|-------------|
| 200 | User updated. |
| 400 | Bad request. Entity to save is not in request body. |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 | Primary key |
| Name | string | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role |  | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup |  | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person |  | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/User/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 265,
  "Name": "Cassin-Hettinger",
  "Rank": 729,
  "Tooltip": "quo",
  "LicenseOwners": [
    {
      "Name": "Sporer, Corkery and Hammes",
      "Description": "Realigned system-worthy matrices",
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
      "Name": "Sporer, Corkery and Hammes",
      "Description": "Realigned system-worthy matrices",
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
      "Value": "enim",
      "Tooltip": "totam",
      "Id": 770,
      "Rank": 931,
      "Deleted": true
    },
    {
      "Value": "enim",
      "Tooltip": "totam",
      "Id": 770,
      "Rank": 931,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2018-04-19T11:10:53.8131839+02:00",
  "Lastlogout": "1996-01-23T11:10:53.8131839+01:00",
  "EjUserId": 193,
  "RequestSignature": "dolorum",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "aut",
      "DisplayValue": "qui"
    },
    {
      "Type": null,
      "Value": "aut",
      "DisplayValue": "qui"
    }
  ],
  "UserName": "Cartwright, Beatty and White",
  "TicketCategories": [
    {
      "Id": 860,
      "Name": "Greenholt, Kris and Koelpin",
      "ToolTip": "Ut fugiat similique.",
      "Deleted": false,
      "Rank": 924,
      "Type": "quis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quia",
      "ColorBlock": 883,
      "ExtraInfo": "beatae",
      "StyleHint": "sunt",
      "FullName": "Ursula Robel I"
    }
  ],
  "NickName": "Hagenes-Zboncak",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "ratione",
    "ExtraFields2": "aperiam"
  },
  "CustomFields": {
    "CustomFields1": "odit",
    "CustomFields2": "incidunt"
  },
  "PostSaveCommands": [
    {
      "Name": "Blanda, McGlynn and Gorczany",
      "DisplayName": "Rau Group",
      "Description": "Progressive asynchronous groupware",
      "ToolTip": "Voluptas provident.",
      "Actions": "Implicit",
      "ActionData": "neque"
    },
    {
      "Name": "Blanda, McGlynn and Gorczany",
      "DisplayName": "Rau Group",
      "Description": "Progressive asynchronous groupware",
      "ToolTip": "Voluptas provident.",
      "Actions": "Implicit",
      "ActionData": "neque"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 152,
  "Name": "Hettinger, Pollich and Moen",
  "Rank": 483,
  "Tooltip": "est",
  "LicenseOwners": [
    {
      "Name": "Walter-Walter",
      "Description": "Secured disintermediate methodology",
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
          "FieldLength": 233
        }
      }
    },
    {
      "Name": "Walter-Walter",
      "Description": "Secured disintermediate methodology",
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
          "FieldLength": 233
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "rerum",
      "Tooltip": "commodi",
      "Id": 898,
      "Rank": 538,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 22
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "1995-06-18T11:10:53.8182132+02:00",
  "Lastlogout": "2020-06-02T11:10:53.8182132+02:00",
  "EjUserId": 347,
  "RequestSignature": "cumque",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "veritatis",
      "DisplayValue": "labore",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 886
        }
      }
    },
    {
      "Type": null,
      "Value": "veritatis",
      "DisplayValue": "labore",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 886
        }
      }
    }
  ],
  "UserName": "Lakin, Kub and Rau",
  "TicketCategories": [
    {
      "Id": 75,
      "Name": "Ernser Group",
      "ToolTip": "Libero aut a.",
      "Deleted": false,
      "Rank": 470,
      "Type": "alias",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quisquam",
      "ColorBlock": 560,
      "ExtraInfo": "quis",
      "StyleHint": "eaque",
      "FullName": "Mrs. Ashly Bell Pfeffer Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    }
  ],
  "NickName": "Durgan Inc and Sons",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "neque"
  },
  "PostSaveCommands": [
    {
      "Name": "Johns LLC",
      "DisplayName": "Herman Group",
      "Description": "Cloned neutral protocol",
      "ToolTip": "Et iste aperiam labore corrupti.",
      "Actions": "Implicit",
      "ActionData": "natus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 236
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 603
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
