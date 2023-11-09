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
POST /api/v1/User
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 275,
  "Name": "Vandervort-Langosh",
  "Rank": 21,
  "Tooltip": "ut",
  "LicenseOwners": [
    {
      "Name": "Rolfson LLC",
      "Description": "Organic multi-state process improvement",
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
      "Name": "Rolfson LLC",
      "Description": "Organic multi-state process improvement",
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
      "Value": "velit",
      "Tooltip": "rerum",
      "Id": 153,
      "Rank": 91,
      "Deleted": true
    },
    {
      "Value": "velit",
      "Tooltip": "rerum",
      "Id": 153,
      "Rank": 91,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2018-01-24T11:06:42.4741224+01:00",
  "Lastlogout": "2019-11-05T11:06:42.4741224+01:00",
  "EjUserId": 502,
  "RequestSignature": "quia",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "et",
      "DisplayValue": "et"
    },
    {
      "Type": null,
      "Value": "et",
      "DisplayValue": "et"
    }
  ],
  "UserName": "Bashirian-O'Connell",
  "TicketCategories": [
    {
      "Id": 157,
      "Name": "Kuhic LLC",
      "ToolTip": "Tempora ullam sed.",
      "Deleted": false,
      "Rank": 919,
      "Type": "nam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "assumenda",
      "ColorBlock": 402,
      "ExtraInfo": "nisi",
      "StyleHint": "neque",
      "FullName": "Prof. Jordi Guy Hoppe"
    }
  ],
  "NickName": "Wiza, Mayer and Shields",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "soluta"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "sapiente"
  },
  "PostSaveCommands": [
    {
      "Name": "McGlynn-Jakubowski",
      "DisplayName": "Vandervort LLC",
      "Description": "Fundamental human-resource open system",
      "ToolTip": "Molestias recusandae unde qui aut quo.",
      "Actions": "Implicit",
      "ActionData": "quasi"
    },
    {
      "Name": "McGlynn-Jakubowski",
      "DisplayName": "Vandervort LLC",
      "Description": "Fundamental human-resource open system",
      "ToolTip": "Molestias recusandae unde qui aut quo.",
      "Actions": "Implicit",
      "ActionData": "quasi"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 391,
  "Name": "Kerluke-Jewess",
  "Rank": 239,
  "Tooltip": "in",
  "LicenseOwners": [
    {
      "Name": "Osinski, Klein and Grimes",
      "Description": "Sharable regional project",
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
          "FieldLength": 674
        }
      }
    },
    {
      "Name": "Osinski, Klein and Grimes",
      "Description": "Sharable regional project",
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
          "FieldLength": 674
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "consequuntur",
      "Tooltip": "facere",
      "Id": 997,
      "Rank": 709,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 598
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2002-10-04T11:06:42.5690612+02:00",
  "Lastlogout": "2018-10-11T11:06:42.5690612+02:00",
  "EjUserId": 12,
  "RequestSignature": "tempora",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "rerum",
      "DisplayValue": "est",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    },
    {
      "Type": null,
      "Value": "rerum",
      "DisplayValue": "est",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    }
  ],
  "UserName": "Funk, Schinner and Thiel",
  "TicketCategories": [
    {
      "Id": 681,
      "Name": "Cronin, Douglas and Swaniawski",
      "ToolTip": "Repellat aut debitis error.",
      "Deleted": false,
      "Rank": 660,
      "Type": "ut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "praesentium",
      "ColorBlock": 645,
      "ExtraInfo": "quia",
      "StyleHint": "consequatur",
      "FullName": "Amely O'Connell III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 678
        }
      }
    }
  ],
  "NickName": "Bahringer, Cruickshank and Bahringer",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "tempora",
    "CustomFields2": "atque"
  },
  "PostSaveCommands": [
    {
      "Name": "Schmidt, Sipes and Bechtelar",
      "DisplayName": "Glover, Roberts and Labadie",
      "Description": "Focused cohesive help-desk",
      "ToolTip": "Distinctio optio esse aliquid dolorum hic illum.",
      "Actions": "Implicit",
      "ActionData": "porro",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 141
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 498
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```