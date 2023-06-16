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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 522,
  "Name": "Kreiger-Gleichner",
  "Rank": 86,
  "Tooltip": "occaecati",
  "LicenseOwners": [
    {
      "Name": "Yundt, Sauer and Wisozk",
      "Description": "Cloned executive encoding",
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
      "Name": "Yundt, Sauer and Wisozk",
      "Description": "Cloned executive encoding",
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
      "Tooltip": "laboriosam",
      "Id": 220,
      "Rank": 455,
      "Deleted": true
    },
    {
      "Value": "molestiae",
      "Tooltip": "laboriosam",
      "Id": 220,
      "Rank": 455,
      "Deleted": true
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2017-03-20T16:00:48.7896079+01:00",
  "Lastlogout": "2001-08-18T16:00:48.7896079+02:00",
  "EjUserId": 546,
  "RequestSignature": "dolores",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "quis",
      "DisplayValue": "rem"
    },
    {
      "Type": null,
      "Value": "quis",
      "DisplayValue": "rem"
    }
  ],
  "UserName": "Kessler, Little and Medhurst",
  "TicketCategories": [
    {
      "Id": 158,
      "Name": "West Inc and Sons",
      "ToolTip": "Rerum excepturi.",
      "Deleted": false,
      "Rank": 18,
      "Type": "ut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptatibus",
      "ColorBlock": 189,
      "ExtraInfo": "aut",
      "StyleHint": "enim",
      "FullName": "Dr. Madonna Buford Morar"
    }
  ],
  "NickName": "Hammes, Morar and Jacobson",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "corrupti"
  },
  "PostSaveCommands": [
    {
      "Name": "Padberg, Ruecker and Renner",
      "DisplayName": "Rogahn, Hahn and Watsica",
      "Description": "Universal high-level software",
      "ToolTip": "Sint neque aperiam laboriosam temporibus.",
      "Actions": "Implicit",
      "ActionData": "consectetur"
    },
    {
      "Name": "Padberg, Ruecker and Renner",
      "DisplayName": "Rogahn, Hahn and Watsica",
      "Description": "Universal high-level software",
      "ToolTip": "Sint neque aperiam laboriosam temporibus.",
      "Actions": "Implicit",
      "ActionData": "consectetur"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 140,
  "Name": "Zieme, Schowalter and Larkin",
  "Rank": 272,
  "Tooltip": "eos",
  "LicenseOwners": [
    {
      "Name": "Kuhlman-Smith",
      "Description": "Seamless actuating orchestration",
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
          "FieldLength": 311
        }
      }
    },
    {
      "Name": "Kuhlman-Smith",
      "Description": "Seamless actuating orchestration",
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
          "FieldLength": 311
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "cumque",
      "Tooltip": "reprehenderit",
      "Id": 275,
      "Rank": 216,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 42
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2013-07-14T16:00:48.7896079+02:00",
  "Lastlogout": "2000-06-11T16:00:48.7896079+02:00",
  "EjUserId": 300,
  "RequestSignature": "dignissimos",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "in",
      "DisplayValue": "quo",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 204
        }
      }
    },
    {
      "Type": null,
      "Value": "in",
      "DisplayValue": "quo",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 204
        }
      }
    }
  ],
  "UserName": "Hamill, Wyman and Fahey",
  "TicketCategories": [
    {
      "Id": 8,
      "Name": "Champlin, Ward and Roberts",
      "ToolTip": "Et et.",
      "Deleted": true,
      "Rank": 859,
      "Type": "blanditiis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dolor",
      "ColorBlock": 42,
      "ExtraInfo": "a",
      "StyleHint": "delectus",
      "FullName": "Trenton Schroeder",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 494
        }
      }
    }
  ],
  "NickName": "Koelpin-Trantow",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "consequatur"
  },
  "PostSaveCommands": [
    {
      "Name": "Strosin, Hahn and Stoltenberg",
      "DisplayName": "Buckridge-Hodkiewicz",
      "Description": "De-engineered bifurcated artificial intelligence",
      "ToolTip": "Laudantium nemo et aut.",
      "Actions": "Implicit",
      "ActionData": "porro",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 501
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 822
    }
  }
}
```