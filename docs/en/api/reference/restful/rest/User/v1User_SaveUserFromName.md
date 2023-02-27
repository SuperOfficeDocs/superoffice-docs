---
title: PUT User/{userName}
uid: v1User_SaveUserFromName
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/User/{userName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 993,
  "Name": "Prosacco LLC",
  "Rank": 716,
  "Tooltip": "id",
  "LicenseOwners": [
    {
      "Name": "Gleason, Von and Gibson",
      "Description": "Intuitive context-sensitive success",
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
      "Name": "Gleason, Von and Gibson",
      "Description": "Intuitive context-sensitive success",
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
      "Value": "doloremque",
      "Tooltip": "consequatur",
      "Id": 794,
      "Rank": 60,
      "Deleted": false
    },
    {
      "Value": "doloremque",
      "Tooltip": "consequatur",
      "Id": 794,
      "Rank": 60,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2017-04-09T14:19:11.0529787+02:00",
  "Lastlogout": "2012-02-17T14:19:11.0529787+01:00",
  "EjUserId": 507,
  "RequestSignature": "ducimus",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "ea",
      "DisplayValue": "id"
    },
    {
      "Type": null,
      "Value": "ea",
      "DisplayValue": "id"
    }
  ],
  "UserName": "Schultz LLC",
  "TicketCategories": [
    {
      "Id": 138,
      "Name": "Kshlerin Inc and Sons",
      "ToolTip": "Tenetur nobis aperiam fugit ipsa ab.",
      "Deleted": false,
      "Rank": 698,
      "Type": "saepe",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sunt",
      "ColorBlock": 540,
      "ExtraInfo": "repellat",
      "StyleHint": "ex",
      "FullName": "Josefina Green I"
    }
  ],
  "NickName": "Wunsch, Turner and Zemlak",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "ipsum",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "minus",
    "CustomFields2": "ex"
  },
  "PostSaveCommands": [
    {
      "Name": "Legros, Ritchie and Pacocha",
      "DisplayName": "Treutel Inc and Sons",
      "Description": "Cross-platform non-volatile installation",
      "ToolTip": "Similique voluptatem asperiores laborum.",
      "Actions": "Implicit",
      "ActionData": "deserunt"
    },
    {
      "Name": "Legros, Ritchie and Pacocha",
      "DisplayName": "Treutel Inc and Sons",
      "Description": "Cross-platform non-volatile installation",
      "ToolTip": "Similique voluptatem asperiores laborum.",
      "Actions": "Implicit",
      "ActionData": "deserunt"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 209,
  "Name": "Torp, Hamill and Greenholt",
  "Rank": 772,
  "Tooltip": "distinctio",
  "LicenseOwners": [
    {
      "Name": "Carter LLC",
      "Description": "Synergistic intermediate portal",
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
          "FieldLength": 182
        }
      }
    },
    {
      "Name": "Carter LLC",
      "Description": "Synergistic intermediate portal",
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
          "FieldLength": 182
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "omnis",
      "Tooltip": "corrupti",
      "Id": 96,
      "Rank": 514,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2020-10-28T14:19:11.0529787+01:00",
  "Lastlogout": "2006-05-30T14:19:11.0529787+02:00",
  "EjUserId": 684,
  "RequestSignature": "harum",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "officiis",
      "DisplayValue": "nulla",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    },
    {
      "Type": null,
      "Value": "officiis",
      "DisplayValue": "nulla",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    }
  ],
  "UserName": "Durgan, Grimes and Murphy",
  "TicketCategories": [
    {
      "Id": 278,
      "Name": "Simonis-Rath",
      "ToolTip": "Officia consequuntur non veniam sit dolorum et saepe.",
      "Deleted": false,
      "Rank": 964,
      "Type": "error",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quam",
      "ColorBlock": 488,
      "ExtraInfo": "similique",
      "StyleHint": "ratione",
      "FullName": "Miss Kattie Ibrahim Collins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 569
        }
      }
    }
  ],
  "NickName": "Pouros LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "delectus"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "odio"
  },
  "PostSaveCommands": [
    {
      "Name": "Zboncak, Hackett and Konopelski",
      "DisplayName": "Leffler-Ritchie",
      "Description": "Self-enabling zero administration local area network",
      "ToolTip": "Alias eum.",
      "Actions": "Implicit",
      "ActionData": "et",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 995
    }
  }
}
```