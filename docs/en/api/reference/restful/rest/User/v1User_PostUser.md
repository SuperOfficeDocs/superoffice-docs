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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 785,
  "Name": "Kshlerin-Powlowski",
  "Rank": 82,
  "Tooltip": "doloremque",
  "LicenseOwners": [
    {
      "Name": "Grimes, Streich and Bernier",
      "Description": "Realigned full-range groupware",
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
      "Name": "Grimes, Streich and Bernier",
      "Description": "Realigned full-range groupware",
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
      "Value": "repudiandae",
      "Tooltip": "corporis",
      "Id": 136,
      "Rank": 415,
      "Deleted": false
    },
    {
      "Value": "repudiandae",
      "Tooltip": "corporis",
      "Id": 136,
      "Rank": 415,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2021-12-13T11:44:42.8044603+01:00",
  "Lastlogout": "1996-12-11T11:44:42.8044603+01:00",
  "EjUserId": 972,
  "RequestSignature": "similique",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "laborum",
      "DisplayValue": "accusamus"
    },
    {
      "Type": null,
      "Value": "laborum",
      "DisplayValue": "accusamus"
    }
  ],
  "UserName": "Krajcik-Frami",
  "TicketCategories": [
    {
      "Id": 703,
      "Name": "Bechtelar LLC",
      "ToolTip": "Vel enim esse corrupti.",
      "Deleted": true,
      "Rank": 995,
      "Type": "reprehenderit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sed",
      "ColorBlock": 755,
      "ExtraInfo": "dolores",
      "StyleHint": "ipsa",
      "FullName": "Cleta Bruen"
    }
  ],
  "NickName": "Streich, Steuber and Kerluke",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "deserunt",
    "CustomFields2": "impedit"
  },
  "PostSaveCommands": [
    {
      "Name": "Price Inc and Sons",
      "DisplayName": "D'Amore-Romaguera",
      "Description": "Compatible methodical Graphical User Interface",
      "ToolTip": "In velit veniam totam omnis illo.",
      "Actions": "Implicit",
      "ActionData": "id"
    },
    {
      "Name": "Price Inc and Sons",
      "DisplayName": "D'Amore-Romaguera",
      "Description": "Compatible methodical Graphical User Interface",
      "ToolTip": "In velit veniam totam omnis illo.",
      "Actions": "Implicit",
      "ActionData": "id"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 564,
  "Name": "Rice-Green",
  "Rank": 257,
  "Tooltip": "tempore",
  "LicenseOwners": [
    {
      "Name": "Koss, Stoltenberg and Anderson",
      "Description": "Multi-layered leading edge conglomeration",
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
          "FieldLength": 965
        }
      }
    },
    {
      "Name": "Koss, Stoltenberg and Anderson",
      "Description": "Multi-layered leading edge conglomeration",
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
          "FieldLength": 965
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "quia",
      "Tooltip": "atque",
      "Id": 161,
      "Rank": 758,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2005-08-24T11:44:42.8201108+02:00",
  "Lastlogout": "2008-02-07T11:44:42.8201108+01:00",
  "EjUserId": 747,
  "RequestSignature": "hic",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "ex",
      "DisplayValue": "dolore",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 493
        }
      }
    },
    {
      "Type": null,
      "Value": "ex",
      "DisplayValue": "dolore",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 493
        }
      }
    }
  ],
  "UserName": "Murphy-Heaney",
  "TicketCategories": [
    {
      "Id": 250,
      "Name": "Crist LLC",
      "ToolTip": "Vel quia.",
      "Deleted": true,
      "Rank": 392,
      "Type": "ab",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "aut",
      "ColorBlock": 588,
      "ExtraInfo": "et",
      "StyleHint": "aspernatur",
      "FullName": "Darrel Zieme MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    }
  ],
  "NickName": "Goodwin Inc and Sons",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "magni",
    "ExtraFields2": "minus"
  },
  "CustomFields": {
    "CustomFields1": "minus",
    "CustomFields2": "omnis"
  },
  "PostSaveCommands": [
    {
      "Name": "Haley-Boyer",
      "DisplayName": "Labadie, Hoeger and Donnelly",
      "Description": "Automated national frame",
      "ToolTip": "Hic et et hic reiciendis quasi vel.",
      "Actions": "Implicit",
      "ActionData": "fugiat",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 719
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```