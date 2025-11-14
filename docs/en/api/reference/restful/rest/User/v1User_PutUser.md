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


NsApiSlow threshold: 2000 ms.


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
  "AssociateId": 981,
  "Name": "Auer, Cassin and Torphy",
  "Rank": 967,
  "Tooltip": "maxime",
  "LicenseOwners": [
    {
      "Name": "Dach Group",
      "Description": "Future-proofed well-modulated system engine",
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
      "Name": "Dach Group",
      "Description": "Future-proofed well-modulated system engine",
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
      "Value": "ipsum",
      "Tooltip": "dolor",
      "Id": 208,
      "Rank": 294,
      "Deleted": false
    },
    {
      "Value": "ipsum",
      "Tooltip": "dolor",
      "Id": 208,
      "Rank": 294,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2001-07-02T02:30:53.147395+02:00",
  "Lastlogout": "2024-03-02T02:30:53.147395+01:00",
  "EjUserId": 115,
  "RequestSignature": "dolorem",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "eum",
      "DisplayValue": "harum"
    },
    {
      "Type": null,
      "Value": "eum",
      "DisplayValue": "harum"
    }
  ],
  "UserName": "Lehner-Larson",
  "TicketCategories": [
    {
      "Id": 250,
      "Name": "Feeney-Klein",
      "ToolTip": "Ipsa aliquid facere rerum aut dolorum est.",
      "Deleted": true,
      "Rank": 740,
      "Type": "ipsam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "nemo",
      "ColorBlock": 765,
      "ExtraInfo": "odit",
      "StyleHint": "quis",
      "FullName": "Ms. Ludwig Makenna Harvey"
    }
  ],
  "NickName": "Schiller-McGlynn",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "hic",
    "CustomFields2": "aut"
  },
  "PostSaveCommands": [
    {
      "Name": "Dickens Group",
      "DisplayName": "Mraz, Strosin and Schinner",
      "Description": "Public-key exuding toolset",
      "ToolTip": "Qui cupiditate placeat illum suscipit.",
      "Actions": "Implicit",
      "ActionData": "animi"
    },
    {
      "Name": "Dickens Group",
      "DisplayName": "Mraz, Strosin and Schinner",
      "Description": "Public-key exuding toolset",
      "ToolTip": "Qui cupiditate placeat illum suscipit.",
      "Actions": "Implicit",
      "ActionData": "animi"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 113,
  "Name": "Heathcote Group",
  "Rank": 813,
  "Tooltip": "cum",
  "LicenseOwners": [
    {
      "Name": "Boehm, Rippin and Schaefer",
      "Description": "Switchable grid-enabled functionalities",
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
          "FieldLength": 446
        }
      }
    },
    {
      "Name": "Boehm, Rippin and Schaefer",
      "Description": "Switchable grid-enabled functionalities",
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
          "FieldLength": 446
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "quidem",
      "Tooltip": "possimus",
      "Id": 78,
      "Rank": 308,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 716
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2024-11-21T02:30:53.147395+01:00",
  "Lastlogout": "2025-07-15T02:30:53.147395+02:00",
  "EjUserId": 526,
  "RequestSignature": "cum",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "temporibus",
      "DisplayValue": "recusandae",
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
      "Value": "temporibus",
      "DisplayValue": "recusandae",
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
  "UserName": "Leannon Inc and Sons",
  "TicketCategories": [
    {
      "Id": 369,
      "Name": "Turner, Bradtke and Jakubowski",
      "ToolTip": "Est autem earum rem est tempore voluptatem.",
      "Deleted": true,
      "Rank": 196,
      "Type": "debitis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "reiciendis",
      "ColorBlock": 680,
      "ExtraInfo": "voluptatem",
      "StyleHint": "repellendus",
      "FullName": "Adrien Dorothy Brekke DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "NickName": "Gaylord, Kessler and Bechtelar",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "quos"
  },
  "PostSaveCommands": [
    {
      "Name": "McCullough-Wehner",
      "DisplayName": "Romaguera-Mraz",
      "Description": "Sharable human-resource functionalities",
      "ToolTip": "Eos exercitationem.",
      "Actions": "Implicit",
      "ActionData": "quae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 777
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 677
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```