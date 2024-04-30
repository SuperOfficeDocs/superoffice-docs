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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 800,
  "Name": "Morar-Abernathy",
  "Rank": 285,
  "Tooltip": "earum",
  "LicenseOwners": [
    {
      "Name": "Pouros-Leannon",
      "Description": "Proactive 6th generation secured line",
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
      "Name": "Pouros-Leannon",
      "Description": "Proactive 6th generation secured line",
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
      "Value": "voluptatum",
      "Tooltip": "ad",
      "Id": 218,
      "Rank": 73,
      "Deleted": false
    },
    {
      "Value": "voluptatum",
      "Tooltip": "ad",
      "Id": 218,
      "Rank": 73,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2021-05-11T11:16:14.4188485+02:00",
  "Lastlogout": "2018-07-29T11:16:14.4188485+02:00",
  "EjUserId": 376,
  "RequestSignature": "natus",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "enim",
      "DisplayValue": "voluptatibus"
    },
    {
      "Type": null,
      "Value": "enim",
      "DisplayValue": "voluptatibus"
    }
  ],
  "UserName": "Sanford, Herzog and Mohr",
  "TicketCategories": [
    {
      "Id": 930,
      "Name": "Fadel, Ebert and Glover",
      "ToolTip": "Provident consequatur alias nam ipsum non.",
      "Deleted": false,
      "Rank": 332,
      "Type": "consequatur",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sed",
      "ColorBlock": 595,
      "ExtraInfo": "nesciunt",
      "StyleHint": "facere",
      "FullName": "Mertie Rice"
    }
  ],
  "NickName": "Grant-Langworth",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "sapiente"
  },
  "PostSaveCommands": [
    {
      "Name": "Keeling, Koch and Gorczany",
      "DisplayName": "Blick-Zieme",
      "Description": "Balanced tertiary installation",
      "ToolTip": "Error omnis ea sint.",
      "Actions": "Implicit",
      "ActionData": "facere"
    },
    {
      "Name": "Keeling, Koch and Gorczany",
      "DisplayName": "Blick-Zieme",
      "Description": "Balanced tertiary installation",
      "ToolTip": "Error omnis ea sint.",
      "Actions": "Implicit",
      "ActionData": "facere"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 840,
  "Name": "Balistreri, Wuckert and Kertzmann",
  "Rank": 540,
  "Tooltip": "omnis",
  "LicenseOwners": [
    {
      "Name": "Bradtke, Greenfelder and Runte",
      "Description": "Grass-roots heuristic middleware",
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
          "FieldLength": 801
        }
      }
    },
    {
      "Name": "Bradtke, Greenfelder and Runte",
      "Description": "Grass-roots heuristic middleware",
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
          "FieldLength": 801
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "voluptas",
      "Tooltip": "tenetur",
      "Id": 314,
      "Rank": 693,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 203
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2023-01-01T11:16:14.4188485+01:00",
  "Lastlogout": "2010-09-09T11:16:14.4188485+02:00",
  "EjUserId": 839,
  "RequestSignature": "maiores",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "cum",
      "DisplayValue": "necessitatibus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 608
        }
      }
    },
    {
      "Type": null,
      "Value": "cum",
      "DisplayValue": "necessitatibus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 608
        }
      }
    }
  ],
  "UserName": "Casper-Sanford",
  "TicketCategories": [
    {
      "Id": 577,
      "Name": "Effertz-Gislason",
      "ToolTip": "Blanditiis minima illo neque sunt.",
      "Deleted": false,
      "Rank": 696,
      "Type": "incidunt",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "fugit",
      "ColorBlock": 28,
      "ExtraInfo": "animi",
      "StyleHint": "omnis",
      "FullName": "Mr. Schuyler Rashawn Zulauf",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    }
  ],
  "NickName": "Dickinson, Monahan and Cummerata",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "iusto"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "illo"
  },
  "PostSaveCommands": [
    {
      "Name": "Fritsch Inc and Sons",
      "DisplayName": "Schaefer Group",
      "Description": "Extended multimedia benchmark",
      "ToolTip": "Sint fugiat quis accusantium et porro.",
      "Actions": "Implicit",
      "ActionData": "quisquam",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 28
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 280
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```