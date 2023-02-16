---
title: PUT User/{id}
uid: v1User_PutUser
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/User/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 202,
  "Name": "Gerlach, Legros and Bogisich",
  "Rank": 594,
  "Tooltip": "reiciendis",
  "LicenseOwners": [
    {
      "Name": "Kling, Halvorson and Thiel",
      "Description": "Synchronised motivating moratorium",
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
      "Name": "Kling, Halvorson and Thiel",
      "Description": "Synchronised motivating moratorium",
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
      "Value": "cumque",
      "Tooltip": "modi",
      "Id": 500,
      "Rank": 804,
      "Deleted": false
    },
    {
      "Value": "cumque",
      "Tooltip": "modi",
      "Id": 500,
      "Rank": 804,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "1999-07-12T14:19:11.0373578+02:00",
  "Lastlogout": "2014-07-15T14:19:11.0373578+02:00",
  "EjUserId": 83,
  "RequestSignature": "accusamus",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "sint",
      "DisplayValue": "commodi"
    },
    {
      "Type": null,
      "Value": "sint",
      "DisplayValue": "commodi"
    }
  ],
  "UserName": "Bergnaum-Ebert",
  "TicketCategories": [
    {
      "Id": 728,
      "Name": "Ullrich, McClure and Gislason",
      "ToolTip": "Modi quia adipisci et quo vitae doloribus.",
      "Deleted": false,
      "Rank": 667,
      "Type": "non",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "distinctio",
      "ColorBlock": 704,
      "ExtraInfo": "laborum",
      "StyleHint": "atque",
      "FullName": "Vincenzo Waters"
    }
  ],
  "NickName": "Huels LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "maiores",
    "CustomFields2": "praesentium"
  },
  "PostSaveCommands": [
    {
      "Name": "Mraz, Koch and Windler",
      "DisplayName": "Kling LLC",
      "Description": "Multi-layered impactful pricing structure",
      "ToolTip": "Aliquid occaecati officiis.",
      "Actions": "Implicit",
      "ActionData": "cupiditate"
    },
    {
      "Name": "Mraz, Koch and Windler",
      "DisplayName": "Kling LLC",
      "Description": "Multi-layered impactful pricing structure",
      "ToolTip": "Aliquid occaecati officiis.",
      "Actions": "Implicit",
      "ActionData": "cupiditate"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 586,
  "Name": "Leuschke-Dietrich",
  "Rank": 332,
  "Tooltip": "aperiam",
  "LicenseOwners": [
    {
      "Name": "Jacobs Inc and Sons",
      "Description": "Cloned 24/7 structure",
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
          "FieldLength": 224
        }
      }
    },
    {
      "Name": "Jacobs Inc and Sons",
      "Description": "Cloned 24/7 structure",
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
          "FieldLength": 224
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "corrupti",
      "Tooltip": "dolor",
      "Id": 678,
      "Rank": 512,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 568
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2010-08-27T14:19:11.0373578+02:00",
  "Lastlogout": "2003-07-03T14:19:11.0373578+02:00",
  "EjUserId": 637,
  "RequestSignature": "officiis",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "fuga",
      "DisplayValue": "omnis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 575
        }
      }
    },
    {
      "Type": null,
      "Value": "fuga",
      "DisplayValue": "omnis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 575
        }
      }
    }
  ],
  "UserName": "Kuhic, Dare and Kunde",
  "TicketCategories": [
    {
      "Id": 462,
      "Name": "Jacobs-Upton",
      "ToolTip": "Magnam at.",
      "Deleted": true,
      "Rank": 912,
      "Type": "dolore",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "in",
      "ColorBlock": 130,
      "ExtraInfo": "est",
      "StyleHint": "quae",
      "FullName": "Ms. Nicklaus Victor Ratke Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 718
        }
      }
    }
  ],
  "NickName": "Denesik, Schumm and Grimes",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "corrupti"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "et"
  },
  "PostSaveCommands": [
    {
      "Name": "Carter Group",
      "DisplayName": "Boehm, Veum and Halvorson",
      "Description": "Multi-channelled regional middleware",
      "ToolTip": "Quae animi sit qui sit ullam magnam.",
      "Actions": "Implicit",
      "ActionData": "qui",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 799
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 738
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```