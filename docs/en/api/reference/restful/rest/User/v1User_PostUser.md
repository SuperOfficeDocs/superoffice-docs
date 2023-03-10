---
title: POST User
uid: v1User_PostUser
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/User
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 467,
  "Name": "Zemlak, Roberts and Feil",
  "Rank": 992,
  "Tooltip": "laboriosam",
  "LicenseOwners": [
    {
      "Name": "Lakin-Spencer",
      "Description": "Proactive methodical groupware",
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
      "Name": "Lakin-Spencer",
      "Description": "Proactive methodical groupware",
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
      "Value": "amet",
      "Tooltip": "qui",
      "Id": 378,
      "Rank": 664,
      "Deleted": false
    },
    {
      "Value": "amet",
      "Tooltip": "qui",
      "Id": 378,
      "Rank": 664,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2018-10-11T12:15:27.7285891+02:00",
  "Lastlogout": "2004-10-12T12:15:27.7285891+02:00",
  "EjUserId": 402,
  "RequestSignature": "at",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "possimus",
      "DisplayValue": "quam"
    },
    {
      "Type": null,
      "Value": "possimus",
      "DisplayValue": "quam"
    }
  ],
  "UserName": "Baumbach-Bailey",
  "TicketCategories": [
    {
      "Id": 707,
      "Name": "Koepp LLC",
      "ToolTip": "Voluptatum repellat.",
      "Deleted": false,
      "Rank": 363,
      "Type": "nemo",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "perspiciatis",
      "ColorBlock": 762,
      "ExtraInfo": "corporis",
      "StyleHint": "consequatur",
      "FullName": "Brandi Pfeffer"
    }
  ],
  "NickName": "Robel Group",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "libero"
  },
  "PostSaveCommands": [
    {
      "Name": "Pouros LLC",
      "DisplayName": "Waters, Gulgowski and Muller",
      "Description": "Realigned hybrid circuit",
      "ToolTip": "Sunt fugiat ipsa perspiciatis est commodi fuga.",
      "Actions": "Implicit",
      "ActionData": "dicta"
    },
    {
      "Name": "Pouros LLC",
      "DisplayName": "Waters, Gulgowski and Muller",
      "Description": "Realigned hybrid circuit",
      "ToolTip": "Sunt fugiat ipsa perspiciatis est commodi fuga.",
      "Actions": "Implicit",
      "ActionData": "dicta"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 90,
  "Name": "Ferry-Gerlach",
  "Rank": 579,
  "Tooltip": "est",
  "LicenseOwners": [
    {
      "Name": "Hodkiewicz Group",
      "Description": "Ameliorated user-facing secured line",
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
          "FieldLength": 609
        }
      }
    },
    {
      "Name": "Hodkiewicz Group",
      "Description": "Ameliorated user-facing secured line",
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
          "FieldLength": 609
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "molestias",
      "Tooltip": "voluptatibus",
      "Id": 142,
      "Rank": 395,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 377
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2004-05-03T12:15:27.7356249+02:00",
  "Lastlogout": "2006-06-01T12:15:27.7356249+02:00",
  "EjUserId": 675,
  "RequestSignature": "consequuntur",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "nemo",
      "DisplayValue": "facilis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    },
    {
      "Type": null,
      "Value": "nemo",
      "DisplayValue": "facilis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    }
  ],
  "UserName": "Corkery LLC",
  "TicketCategories": [
    {
      "Id": 228,
      "Name": "Hamill Group",
      "ToolTip": "Suscipit rem est vitae aut.",
      "Deleted": true,
      "Rank": 879,
      "Type": "ut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ullam",
      "ColorBlock": 253,
      "ExtraInfo": "amet",
      "StyleHint": "error",
      "FullName": "Beryl Weissnat",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    }
  ],
  "NickName": "Rice-Emmerich",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "dolorem"
  },
  "PostSaveCommands": [
    {
      "Name": "Hilll-Fritsch",
      "DisplayName": "Koch-Johnson",
      "Description": "Synergized value-added hierarchy",
      "ToolTip": "Quia iste.",
      "Actions": "Implicit",
      "ActionData": "nemo",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 743
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 980
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```