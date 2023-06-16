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
| UserGroup | UserGroup | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person | Person | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
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
  "AssociateId": 950,
  "Name": "Treutel-Ziemann",
  "Rank": 46,
  "Tooltip": "perspiciatis",
  "LicenseOwners": [
    {
      "Name": "Kovacek-O'Connell",
      "Description": "Face to face 24/7 function",
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
      "Name": "Kovacek-O'Connell",
      "Description": "Face to face 24/7 function",
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
      "Value": "pariatur",
      "Tooltip": "optio",
      "Id": 756,
      "Rank": 954,
      "Deleted": true
    },
    {
      "Value": "pariatur",
      "Tooltip": "optio",
      "Id": 756,
      "Rank": 954,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2008-10-29T16:00:48.7583614+01:00",
  "Lastlogout": "2003-08-09T16:00:48.7583614+02:00",
  "EjUserId": 690,
  "RequestSignature": "dolorum",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "doloribus",
      "DisplayValue": "accusamus"
    },
    {
      "Type": null,
      "Value": "doloribus",
      "DisplayValue": "accusamus"
    }
  ],
  "UserName": "Runte, Smith and Kunze",
  "TicketCategories": [
    {
      "Id": 885,
      "Name": "Champlin LLC",
      "ToolTip": "Sint distinctio.",
      "Deleted": false,
      "Rank": 553,
      "Type": "voluptatibus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "molestias",
      "ColorBlock": 416,
      "ExtraInfo": "voluptatem",
      "StyleHint": "nobis",
      "FullName": "Dr. Maria Rippin Jr."
    }
  ],
  "NickName": "Emmerich Group",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "ullam"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "incidunt"
  },
  "PostSaveCommands": [
    {
      "Name": "Marvin, Heller and Feil",
      "DisplayName": "Schumm, Heathcote and Boehm",
      "Description": "Realigned eco-centric analyzer",
      "ToolTip": "Beatae aperiam recusandae tempora molestiae.",
      "Actions": "Implicit",
      "ActionData": "quam"
    },
    {
      "Name": "Marvin, Heller and Feil",
      "DisplayName": "Schumm, Heathcote and Boehm",
      "Description": "Realigned eco-centric analyzer",
      "ToolTip": "Beatae aperiam recusandae tempora molestiae.",
      "Actions": "Implicit",
      "ActionData": "quam"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 985,
  "Name": "Kulas, Hoeger and Yost",
  "Rank": 494,
  "Tooltip": "cupiditate",
  "LicenseOwners": [
    {
      "Name": "Lang-Terry",
      "Description": "Horizontal tangible access",
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
          "FieldLength": 228
        }
      }
    },
    {
      "Name": "Lang-Terry",
      "Description": "Horizontal tangible access",
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
          "FieldLength": 228
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "rerum",
      "Tooltip": "aspernatur",
      "Id": 360,
      "Rank": 799,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2012-04-28T16:00:48.7583614+02:00",
  "Lastlogout": "2001-09-23T16:00:48.7583614+02:00",
  "EjUserId": 471,
  "RequestSignature": "illo",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "cum",
      "DisplayValue": "magnam",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    },
    {
      "Type": null,
      "Value": "cum",
      "DisplayValue": "magnam",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    }
  ],
  "UserName": "Parisian, Mante and Smitham",
  "TicketCategories": [
    {
      "Id": 795,
      "Name": "Collins Group",
      "ToolTip": "Distinctio non.",
      "Deleted": true,
      "Rank": 94,
      "Type": "aut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptatibus",
      "ColorBlock": 768,
      "ExtraInfo": "mollitia",
      "StyleHint": "vero",
      "FullName": "Shana Zion Block DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 80
        }
      }
    }
  ],
  "NickName": "O'Connell-King",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "voluptate"
  },
  "CustomFields": {
    "CustomFields1": "porro",
    "CustomFields2": "eius"
  },
  "PostSaveCommands": [
    {
      "Name": "Will-Halvorson",
      "DisplayName": "Eichmann LLC",
      "Description": "Re-engineered local system engine",
      "ToolTip": "Necessitatibus sapiente ipsum qui est est.",
      "Actions": "Implicit",
      "ActionData": "quia",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 485
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```