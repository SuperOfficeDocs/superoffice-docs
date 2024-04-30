---
title: POST Agents/User/SaveUser
uid: v1UserAgent_SaveUser
generated: true
---

# POST Agents/User/SaveUser

```http
POST /api/v1/Agents/User/SaveUser
```

Updates the existing User or creates a new User if the id parameter is empty


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
  "AssociateId": 521,
  "Name": "Wehner-Lindgren",
  "Rank": 443,
  "Tooltip": "reprehenderit",
  "LicenseOwners": [
    {
      "Name": "Rogahn, Tromp and Mitchell",
      "Description": "Stand-alone contextually-based artificial intelligence",
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
      "Name": "Rogahn, Tromp and Mitchell",
      "Description": "Stand-alone contextually-based artificial intelligence",
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
      "Value": "voluptatem",
      "Tooltip": "consequatur",
      "Id": 180,
      "Rank": 124,
      "Deleted": false
    },
    {
      "Value": "voluptatem",
      "Tooltip": "consequatur",
      "Id": 180,
      "Rank": 124,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2023-08-08T11:44:34.9625302+02:00",
  "Lastlogout": "2006-06-04T11:44:34.9625302+02:00",
  "EjUserId": 180,
  "RequestSignature": "accusamus",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "fugit",
      "DisplayValue": "repudiandae"
    },
    {
      "Type": null,
      "Value": "fugit",
      "DisplayValue": "repudiandae"
    }
  ],
  "UserName": "Hand, Rowe and Armstrong",
  "TicketCategories": [
    {
      "Id": 145,
      "Name": "Sauer, Yundt and Wilkinson",
      "ToolTip": "Deserunt officia sit temporibus sed neque consequatur eos.",
      "Deleted": false,
      "Rank": 183,
      "Type": "fugit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "praesentium",
      "ColorBlock": 861,
      "ExtraInfo": "omnis",
      "StyleHint": "nihil",
      "FullName": "Lucie Name Morissette IV"
    }
  ],
  "NickName": "Wisoky-Feest",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "mollitia"
  },
  "CustomFields": {
    "CustomFields1": "commodi",
    "CustomFields2": "et"
  },
  "PostSaveCommands": [
    {
      "Name": "Greenfelder LLC",
      "DisplayName": "Emmerich, Williamson and Morissette",
      "Description": "Multi-layered asynchronous standardization",
      "ToolTip": "Eligendi culpa temporibus ullam.",
      "Actions": "Implicit",
      "ActionData": "laudantium"
    },
    {
      "Name": "Greenfelder LLC",
      "DisplayName": "Emmerich, Williamson and Morissette",
      "Description": "Multi-layered asynchronous standardization",
      "ToolTip": "Eligendi culpa temporibus ullam.",
      "Actions": "Implicit",
      "ActionData": "laudantium"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 272,
  "Name": "Trantow, Keebler and Bins",
  "Rank": 18,
  "Tooltip": "consequatur",
  "LicenseOwners": [
    {
      "Name": "Macejkovic, Zieme and Goodwin",
      "Description": "Persistent intangible application",
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
          "FieldLength": 306
        }
      }
    },
    {
      "Name": "Macejkovic, Zieme and Goodwin",
      "Description": "Persistent intangible application",
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
          "FieldLength": 306
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "qui",
      "Tooltip": "non",
      "Id": 950,
      "Rank": 829,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 991
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2023-11-14T11:44:34.9625302+01:00",
  "Lastlogout": "2020-07-14T11:44:34.9625302+02:00",
  "EjUserId": 150,
  "RequestSignature": "qui",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "quam",
      "DisplayValue": "et",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 283
        }
      }
    },
    {
      "Type": null,
      "Value": "quam",
      "DisplayValue": "et",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 283
        }
      }
    }
  ],
  "UserName": "Labadie-Pagac",
  "TicketCategories": [
    {
      "Id": 361,
      "Name": "Terry, Hyatt and Huel",
      "ToolTip": "Nulla architecto rerum veniam.",
      "Deleted": false,
      "Rank": 697,
      "Type": "eaque",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "placeat",
      "ColorBlock": 793,
      "ExtraInfo": "excepturi",
      "StyleHint": "vero",
      "FullName": "Erich Breitenberg",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    }
  ],
  "NickName": "Block LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "maiores",
    "CustomFields2": "qui"
  },
  "PostSaveCommands": [
    {
      "Name": "Hagenes, Denesik and Block",
      "DisplayName": "Heaney Inc and Sons",
      "Description": "Business-focused methodical definition",
      "ToolTip": "Ut libero rerum dolore nihil.",
      "Actions": "Implicit",
      "ActionData": "ipsum",
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
      "FieldType": "System.String",
      "FieldLength": 627
    }
  }
}
```