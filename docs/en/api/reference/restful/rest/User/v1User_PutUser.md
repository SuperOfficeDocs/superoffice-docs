---
title: PUT User/{id}
uid: v1User_PutUser
generated: true
content_type: reference
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 225,
  "Name": "Runolfsdottir, Heidenreich and Okuneva",
  "Rank": 382,
  "Tooltip": "aliquid",
  "LicenseOwners": [
    {
      "Name": "Murazik LLC",
      "Description": "Fundamental coherent instruction set",
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
      "Name": "Murazik LLC",
      "Description": "Fundamental coherent instruction set",
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
      "Tooltip": "alias",
      "Id": 679,
      "Rank": 23,
      "Deleted": false
    },
    {
      "Value": "id",
      "Tooltip": "alias",
      "Id": 679,
      "Rank": 23,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2015-09-11T11:24:53.7967997+02:00",
  "Lastlogout": "2022-05-20T11:24:53.7967997+02:00",
  "EjUserId": 389,
  "RequestSignature": "et",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "consequuntur",
      "DisplayValue": "nam"
    },
    {
      "Type": null,
      "Value": "consequuntur",
      "DisplayValue": "nam"
    }
  ],
  "UserName": "Abshire LLC",
  "TicketCategories": [
    {
      "Id": 63,
      "Name": "Simonis, Brakus and Lowe",
      "ToolTip": "Occaecati sit nobis laudantium.",
      "Deleted": true,
      "Rank": 711,
      "Type": "quia",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "eos",
      "ColorBlock": 399,
      "ExtraInfo": "laboriosam",
      "StyleHint": "libero",
      "FullName": "Rowan Cleve Heidenreich DVM"
    }
  ],
  "NickName": "Spinka-Bashirian",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "aliquid"
  },
  "PostSaveCommands": [
    {
      "Name": "Shanahan-Streich",
      "DisplayName": "Considine Group",
      "Description": "Multi-tiered neutral system engine",
      "ToolTip": "Neque ipsa vitae ut et.",
      "Actions": "Implicit",
      "ActionData": "cumque"
    },
    {
      "Name": "Shanahan-Streich",
      "DisplayName": "Considine Group",
      "Description": "Multi-tiered neutral system engine",
      "ToolTip": "Neque ipsa vitae ut et.",
      "Actions": "Implicit",
      "ActionData": "cumque"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 580,
  "Name": "Kub, Wolff and Hane",
  "Rank": 991,
  "Tooltip": "molestiae",
  "LicenseOwners": [
    {
      "Name": "McClure-Lebsack",
      "Description": "Digitized static initiative",
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
          "FieldLength": 586
        }
      }
    },
    {
      "Name": "McClure-Lebsack",
      "Description": "Digitized static initiative",
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
          "FieldLength": 586
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "ducimus",
      "Tooltip": "qui",
      "Id": 698,
      "Rank": 634,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 700
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2018-02-26T11:24:53.7967997+01:00",
  "Lastlogout": "2010-03-20T11:24:53.7967997+01:00",
  "EjUserId": 589,
  "RequestSignature": "fugiat",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "corrupti",
      "DisplayValue": "repudiandae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 523
        }
      }
    },
    {
      "Type": null,
      "Value": "corrupti",
      "DisplayValue": "repudiandae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 523
        }
      }
    }
  ],
  "UserName": "Hintz, Bahringer and Kovacek",
  "TicketCategories": [
    {
      "Id": 884,
      "Name": "Stamm Group",
      "ToolTip": "Neque dolorum velit rerum accusantium sunt.",
      "Deleted": true,
      "Rank": 179,
      "Type": "similique",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "suscipit",
      "ColorBlock": 866,
      "ExtraInfo": "nostrum",
      "StyleHint": "amet",
      "FullName": "Prof. Tyrell Koch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 625
        }
      }
    }
  ],
  "NickName": "Flatley, Hahn and Reichel",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "ut"
  },
  "PostSaveCommands": [
    {
      "Name": "Keebler, Donnelly and Lesch",
      "DisplayName": "Kerluke, Stroman and Dach",
      "Description": "Extended bandwidth-monitored project",
      "ToolTip": "Velit ut in saepe.",
      "Actions": "Implicit",
      "ActionData": "dolores",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 681
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 446
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```