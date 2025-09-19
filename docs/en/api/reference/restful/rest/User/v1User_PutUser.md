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
  "AssociateId": 283,
  "Name": "Abshire-Frami",
  "Rank": 278,
  "Tooltip": "architecto",
  "LicenseOwners": [
    {
      "Name": "Runte-Veum",
      "Description": "Persevering homogeneous matrices",
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
      "Name": "Runte-Veum",
      "Description": "Persevering homogeneous matrices",
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
      "Value": "delectus",
      "Tooltip": "soluta",
      "Id": 883,
      "Rank": 682,
      "Deleted": false
    },
    {
      "Value": "delectus",
      "Tooltip": "soluta",
      "Id": 883,
      "Rank": 682,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2015-04-15T03:41:59.2304945+02:00",
  "Lastlogout": "2008-08-20T03:41:59.2304945+02:00",
  "EjUserId": 112,
  "RequestSignature": "et",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "quod",
      "DisplayValue": "quaerat"
    },
    {
      "Type": null,
      "Value": "quod",
      "DisplayValue": "quaerat"
    }
  ],
  "UserName": "Greenholt, Hartmann and Weimann",
  "TicketCategories": [
    {
      "Id": 54,
      "Name": "Yundt-Pfannerstill",
      "ToolTip": "Harum blanditiis.",
      "Deleted": false,
      "Rank": 851,
      "Type": "id",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "deleniti",
      "ColorBlock": 162,
      "ExtraInfo": "eaque",
      "StyleHint": "quaerat",
      "FullName": "Jessie Johnston"
    }
  ],
  "NickName": "Langosh-Toy",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "ipsum"
  },
  "PostSaveCommands": [
    {
      "Name": "Collins Group",
      "DisplayName": "Schuster, Hermiston and Lueilwitz",
      "Description": "Implemented even-keeled hardware",
      "ToolTip": "Praesentium non vel quis ut.",
      "Actions": "Implicit",
      "ActionData": "non"
    },
    {
      "Name": "Collins Group",
      "DisplayName": "Schuster, Hermiston and Lueilwitz",
      "Description": "Implemented even-keeled hardware",
      "ToolTip": "Praesentium non vel quis ut.",
      "Actions": "Implicit",
      "ActionData": "non"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 328,
  "Name": "Conroy, Spencer and Rice",
  "Rank": 97,
  "Tooltip": "vero",
  "LicenseOwners": [
    {
      "Name": "Kuhic-Donnelly",
      "Description": "Switchable cohesive encryption",
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
          "FieldLength": 881
        }
      }
    },
    {
      "Name": "Kuhic-Donnelly",
      "Description": "Switchable cohesive encryption",
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
          "FieldLength": 881
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "vitae",
      "Tooltip": "iure",
      "Id": 732,
      "Rank": 101,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 634
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2006-10-24T03:41:59.2304945+02:00",
  "Lastlogout": "2015-02-23T03:41:59.2304945+01:00",
  "EjUserId": 16,
  "RequestSignature": "eveniet",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "odit",
      "DisplayValue": "provident",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 374
        }
      }
    },
    {
      "Type": null,
      "Value": "odit",
      "DisplayValue": "provident",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 374
        }
      }
    }
  ],
  "UserName": "D'Amore-Nitzsche",
  "TicketCategories": [
    {
      "Id": 462,
      "Name": "Hamill-Kertzmann",
      "ToolTip": "Rerum et voluptate repudiandae aperiam et.",
      "Deleted": false,
      "Rank": 978,
      "Type": "excepturi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "iste",
      "ColorBlock": 174,
      "ExtraInfo": "suscipit",
      "StyleHint": "laborum",
      "FullName": "Prof. Wanda Alba Cole DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 66
        }
      }
    }
  ],
  "NickName": "Runolfsson-Runolfsdottir",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "alias"
  },
  "PostSaveCommands": [
    {
      "Name": "Beier, Krajcik and Bins",
      "DisplayName": "Beahan LLC",
      "Description": "Upgradable empowering concept",
      "ToolTip": "Aliquam et quod officia id repudiandae cum cum.",
      "Actions": "Implicit",
      "ActionData": "officiis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 820
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```