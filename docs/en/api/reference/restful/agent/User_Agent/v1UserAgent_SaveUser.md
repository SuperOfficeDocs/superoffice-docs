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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 658,
  "Name": "Becker, Parker and Herzog",
  "Rank": 9,
  "Tooltip": "nostrum",
  "LicenseOwners": [
    {
      "Name": "Zemlak-Gutkowski",
      "Description": "Enhanced bifurcated customer loyalty",
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
      "Name": "Zemlak-Gutkowski",
      "Description": "Enhanced bifurcated customer loyalty",
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
      "Value": "accusamus",
      "Tooltip": "voluptas",
      "Id": 285,
      "Rank": 499,
      "Deleted": true
    },
    {
      "Value": "accusamus",
      "Tooltip": "voluptas",
      "Id": 285,
      "Rank": 499,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2005-05-19T11:24:48.9063744+02:00",
  "Lastlogout": "2024-04-04T11:24:48.9063744+02:00",
  "EjUserId": 972,
  "RequestSignature": "corrupti",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "atque",
      "DisplayValue": "et"
    },
    {
      "Type": null,
      "Value": "atque",
      "DisplayValue": "et"
    }
  ],
  "UserName": "Moen LLC",
  "TicketCategories": [
    {
      "Id": 970,
      "Name": "Koch-Bernier",
      "ToolTip": "Doloremque nihil possimus.",
      "Deleted": false,
      "Rank": 901,
      "Type": "aut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "fugiat",
      "ColorBlock": 876,
      "ExtraInfo": "voluptas",
      "StyleHint": "qui",
      "FullName": "Nicklaus Sporer"
    }
  ],
  "NickName": "Robel-O'Reilly",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "doloribus"
  },
  "PostSaveCommands": [
    {
      "Name": "Weimann Inc and Sons",
      "DisplayName": "Langworth, Kozey and Kihn",
      "Description": "Versatile eco-centric support",
      "ToolTip": "Dolor consequatur qui aut dolor sit.",
      "Actions": "Implicit",
      "ActionData": "sequi"
    },
    {
      "Name": "Weimann Inc and Sons",
      "DisplayName": "Langworth, Kozey and Kihn",
      "Description": "Versatile eco-centric support",
      "ToolTip": "Dolor consequatur qui aut dolor sit.",
      "Actions": "Implicit",
      "ActionData": "sequi"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 862,
  "Name": "Morissette-Cormier",
  "Rank": 565,
  "Tooltip": "aut",
  "LicenseOwners": [
    {
      "Name": "Smith-Schinner",
      "Description": "Self-enabling incremental website",
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
          "FieldLength": 8
        }
      }
    },
    {
      "Name": "Smith-Schinner",
      "Description": "Self-enabling incremental website",
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
          "FieldLength": 8
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "sint",
      "Tooltip": "accusamus",
      "Id": 174,
      "Rank": 253,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 518
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2020-09-04T11:24:48.9063744+02:00",
  "Lastlogout": "2014-04-04T11:24:48.9063744+02:00",
  "EjUserId": 10,
  "RequestSignature": "fuga",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "aut",
      "DisplayValue": "repellendus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    },
    {
      "Type": null,
      "Value": "aut",
      "DisplayValue": "repellendus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    }
  ],
  "UserName": "Becker Inc and Sons",
  "TicketCategories": [
    {
      "Id": 299,
      "Name": "Deckow, Kovacek and Bednar",
      "ToolTip": "Vitae incidunt magni ut debitis delectus repudiandae.",
      "Deleted": false,
      "Rank": 933,
      "Type": "praesentium",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "aut",
      "ColorBlock": 310,
      "ExtraInfo": "quia",
      "StyleHint": "perspiciatis",
      "FullName": "Mckayla Jacobs",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 272
        }
      }
    }
  ],
  "NickName": "Rohan-Christiansen",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "voluptate"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "sunt"
  },
  "PostSaveCommands": [
    {
      "Name": "Halvorson, Funk and Gibson",
      "DisplayName": "Cummings Group",
      "Description": "Proactive leading edge synergy",
      "ToolTip": "Similique voluptatibus omnis voluptas voluptatem.",
      "Actions": "Implicit",
      "ActionData": "aut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 208
    }
  }
}
```