---
title: POST Agents/User/SaveUser
uid: v1UserAgent_SaveUser
generated: true
content_type: reference
---

# POST Agents/User/SaveUser

```http
POST /api/v1/Agents/User/SaveUser
```

Updates the existing User or creates a new User if the id parameter is 0.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.







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

The User that is saved 

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

## Sample request

```http!
POST /api/v1/Agents/User/SaveUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 406,
  "Name": "Hyatt, Price and McClure",
  "Rank": 750,
  "Tooltip": "rerum",
  "LicenseOwners": [
    {
      "Name": "Zboncak, Kshlerin and Pfannerstill",
      "Description": "Secured mobile productivity",
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
      "Name": "Zboncak, Kshlerin and Pfannerstill",
      "Description": "Secured mobile productivity",
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
      "Value": "eum",
      "Tooltip": "veritatis",
      "Id": 758,
      "Rank": 518,
      "Deleted": false
    },
    {
      "Value": "eum",
      "Tooltip": "veritatis",
      "Id": 758,
      "Rank": 518,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2011-05-10T03:41:54.3400739+02:00",
  "Lastlogout": "2017-11-07T03:41:54.3400739+01:00",
  "EjUserId": 134,
  "RequestSignature": "non",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "beatae",
      "DisplayValue": "nesciunt"
    },
    {
      "Type": null,
      "Value": "beatae",
      "DisplayValue": "nesciunt"
    }
  ],
  "UserName": "Harber, Yost and Monahan",
  "TicketCategories": [
    {
      "Id": 908,
      "Name": "Kuhlman, Kuphal and Berge",
      "ToolTip": "Ut accusamus recusandae dolor in incidunt ducimus.",
      "Deleted": false,
      "Rank": 742,
      "Type": "deserunt",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "harum",
      "ColorBlock": 428,
      "ExtraInfo": "soluta",
      "StyleHint": "veritatis",
      "FullName": "Garnet Friesen"
    }
  ],
  "NickName": "Kuphal Inc and Sons",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "quidem",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "dolores"
  },
  "PostSaveCommands": [
    {
      "Name": "Grimes, Hegmann and Mills",
      "DisplayName": "Oberbrunner, Connelly and Spencer",
      "Description": "Cloned executive function",
      "ToolTip": "Non quia id totam beatae ut iste recusandae.",
      "Actions": "Implicit",
      "ActionData": "ipsum"
    },
    {
      "Name": "Grimes, Hegmann and Mills",
      "DisplayName": "Oberbrunner, Connelly and Spencer",
      "Description": "Cloned executive function",
      "ToolTip": "Non quia id totam beatae ut iste recusandae.",
      "Actions": "Implicit",
      "ActionData": "ipsum"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 760,
  "Name": "Koelpin-Schulist",
  "Rank": 252,
  "Tooltip": "tempora",
  "LicenseOwners": [
    {
      "Name": "Labadie Inc and Sons",
      "Description": "Versatile fresh-thinking matrix",
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
          "FieldLength": 943
        }
      }
    },
    {
      "Name": "Labadie Inc and Sons",
      "Description": "Versatile fresh-thinking matrix",
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
          "FieldLength": 943
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "deleniti",
      "Tooltip": "quis",
      "Id": 297,
      "Rank": 560,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "1998-11-21T03:41:54.3400739+01:00",
  "Lastlogout": "2017-07-08T03:41:54.3400739+02:00",
  "EjUserId": 394,
  "RequestSignature": "velit",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "in",
      "DisplayValue": "et",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    },
    {
      "Type": null,
      "Value": "in",
      "DisplayValue": "et",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "UserName": "Brakus Group",
  "TicketCategories": [
    {
      "Id": 368,
      "Name": "Funk-Doyle",
      "ToolTip": "Labore inventore expedita nostrum qui qui.",
      "Deleted": false,
      "Rank": 129,
      "Type": "maiores",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptatibus",
      "ColorBlock": 803,
      "ExtraInfo": "ex",
      "StyleHint": "rerum",
      "FullName": "Lela Bradley Gerlach DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    }
  ],
  "NickName": "Koelpin, Boehm and Buckridge",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "cum"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "libero"
  },
  "PostSaveCommands": [
    {
      "Name": "Skiles, Dibbert and Kertzmann",
      "DisplayName": "Hills-Cartwright",
      "Description": "Phased optimizing firmware",
      "ToolTip": "Dolore tenetur nemo molestiae autem.",
      "Actions": "Implicit",
      "ActionData": "nobis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 721
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 500
    }
  }
}
```