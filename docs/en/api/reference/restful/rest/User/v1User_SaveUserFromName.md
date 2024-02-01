---
title: PUT User/{userName}
uid: v1User_SaveUserFromName
generated: true
---

# PUT User/{userName}

```http
PUT /api/v1/User/{userName}
```

Save a user, with lookup based on the user name.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





| Path Part | Type | Description |
|-----------|------|-------------|
| userName | string | User name of the user to get. **Required** |



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

## Request Body: user 

User object to save. 

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

### Response body: User

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

## Sample request

```http!
PUT /api/v1/User/{userName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 930,
  "Name": "Little, Konopelski and Tillman",
  "Rank": 389,
  "Tooltip": "soluta",
  "LicenseOwners": [
    {
      "Name": "Borer LLC",
      "Description": "Operative secondary groupware",
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
      "Name": "Borer LLC",
      "Description": "Operative secondary groupware",
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
      "Value": "molestiae",
      "Tooltip": "saepe",
      "Id": 810,
      "Rank": 275,
      "Deleted": false
    },
    {
      "Value": "molestiae",
      "Tooltip": "saepe",
      "Id": 810,
      "Rank": 275,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2019-03-13T23:04:05.1935051+01:00",
  "Lastlogout": "2018-01-25T23:04:05.1935051+01:00",
  "EjUserId": 10,
  "RequestSignature": "voluptatem",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "enim",
      "DisplayValue": "molestiae"
    },
    {
      "Type": null,
      "Value": "enim",
      "DisplayValue": "molestiae"
    }
  ],
  "UserName": "Bode Group",
  "TicketCategories": [
    {
      "Id": 313,
      "Name": "Nienow, Bergstrom and Blick",
      "ToolTip": "Voluptates dolorem.",
      "Deleted": false,
      "Rank": 965,
      "Type": "nulla",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "recusandae",
      "ColorBlock": 475,
      "ExtraInfo": "sunt",
      "StyleHint": "expedita",
      "FullName": "Emely Trantow"
    }
  ],
  "NickName": "Wuckert, Rath and Hagenes",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "vitae",
    "ExtraFields2": "blanditiis"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "voluptates"
  },
  "PostSaveCommands": [
    {
      "Name": "Reinger LLC",
      "DisplayName": "Schumm, Mertz and Schmitt",
      "Description": "Persistent composite algorithm",
      "ToolTip": "Nobis dolor voluptatem maxime.",
      "Actions": "Implicit",
      "ActionData": "recusandae"
    },
    {
      "Name": "Reinger LLC",
      "DisplayName": "Schumm, Mertz and Schmitt",
      "Description": "Persistent composite algorithm",
      "ToolTip": "Nobis dolor voluptatem maxime.",
      "Actions": "Implicit",
      "ActionData": "recusandae"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 239,
  "Name": "Heathcote-Batz",
  "Rank": 604,
  "Tooltip": "quam",
  "LicenseOwners": [
    {
      "Name": "Keeling-Parisian",
      "Description": "Advanced systemic hub",
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
          "FieldLength": 824
        }
      }
    },
    {
      "Name": "Keeling-Parisian",
      "Description": "Advanced systemic hub",
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
          "FieldLength": 824
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "et",
      "Tooltip": "est",
      "Id": 748,
      "Rank": 965,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 52
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2003-04-05T23:04:05.1995033+02:00",
  "Lastlogout": "2017-01-17T23:04:05.1995033+01:00",
  "EjUserId": 1000,
  "RequestSignature": "voluptatem",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "quisquam",
      "DisplayValue": "ipsum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    },
    {
      "Type": null,
      "Value": "quisquam",
      "DisplayValue": "ipsum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "UserName": "Hagenes, Klein and Beahan",
  "TicketCategories": [
    {
      "Id": 15,
      "Name": "McKenzie, Denesik and Gerlach",
      "ToolTip": "Autem aperiam laborum non dolores atque quia voluptas.",
      "Deleted": true,
      "Rank": 389,
      "Type": "delectus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "corporis",
      "ColorBlock": 458,
      "ExtraInfo": "est",
      "StyleHint": "consequatur",
      "FullName": "Rodrick White",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    }
  ],
  "NickName": "Maggio-Parisian",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "asperiores"
  },
  "PostSaveCommands": [
    {
      "Name": "Friesen LLC",
      "DisplayName": "Kozey, Kuhic and Turcotte",
      "Description": "Front-line executive matrix",
      "ToolTip": "Aliquam earum ex.",
      "Actions": "Implicit",
      "ActionData": "dolores",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 444
        }
      }
    }
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
```