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
PUT /api/v1/User/{userName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 425,
  "Name": "Hayes-Hermann",
  "Rank": 199,
  "Tooltip": "adipisci",
  "LicenseOwners": [
    {
      "Name": "Stark, Will and Braun",
      "Description": "Quality-focused cohesive strategy",
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
      "Name": "Stark, Will and Braun",
      "Description": "Quality-focused cohesive strategy",
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
      "Value": "consequatur",
      "Tooltip": "est",
      "Id": 522,
      "Rank": 354,
      "Deleted": false
    },
    {
      "Value": "consequatur",
      "Tooltip": "est",
      "Id": 522,
      "Rank": 354,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2006-03-02T11:16:14.4338903+01:00",
  "Lastlogout": "2011-04-05T11:16:14.4338903+02:00",
  "EjUserId": 17,
  "RequestSignature": "et",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "laboriosam",
      "DisplayValue": "beatae"
    },
    {
      "Type": null,
      "Value": "laboriosam",
      "DisplayValue": "beatae"
    }
  ],
  "UserName": "Walter, McKenzie and McCullough",
  "TicketCategories": [
    {
      "Id": 532,
      "Name": "Hodkiewicz-Dicki",
      "ToolTip": "Mollitia mollitia laborum et sunt minus.",
      "Deleted": true,
      "Rank": 657,
      "Type": "aut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "praesentium",
      "ColorBlock": 14,
      "ExtraInfo": "aperiam",
      "StyleHint": "accusamus",
      "FullName": "Kelsie Walker"
    }
  ],
  "NickName": "Jacobi LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "veritatis",
    "CustomFields2": "autem"
  },
  "PostSaveCommands": [
    {
      "Name": "Rippin, Walker and Cartwright",
      "DisplayName": "Schultz-Jewess",
      "Description": "Down-sized tertiary Graphical User Interface",
      "ToolTip": "Odio reprehenderit tempore aspernatur et veniam fuga.",
      "Actions": "Implicit",
      "ActionData": "laboriosam"
    },
    {
      "Name": "Rippin, Walker and Cartwright",
      "DisplayName": "Schultz-Jewess",
      "Description": "Down-sized tertiary Graphical User Interface",
      "ToolTip": "Odio reprehenderit tempore aspernatur et veniam fuga.",
      "Actions": "Implicit",
      "ActionData": "laboriosam"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 110,
  "Name": "Gleason LLC",
  "Rank": 668,
  "Tooltip": "nam",
  "LicenseOwners": [
    {
      "Name": "Pacocha-O'Keefe",
      "Description": "Compatible bifurcated synergy",
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
          "FieldLength": 682
        }
      }
    },
    {
      "Name": "Pacocha-O'Keefe",
      "Description": "Compatible bifurcated synergy",
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
          "FieldLength": 682
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "modi",
      "Tooltip": "est",
      "Id": 768,
      "Rank": 363,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 537
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2003-08-16T11:16:14.4338903+02:00",
  "Lastlogout": "1997-08-01T11:16:14.4338903+02:00",
  "EjUserId": 414,
  "RequestSignature": "deleniti",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "aut",
      "DisplayValue": "molestias",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 784
        }
      }
    },
    {
      "Type": null,
      "Value": "aut",
      "DisplayValue": "molestias",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 784
        }
      }
    }
  ],
  "UserName": "Blanda Inc and Sons",
  "TicketCategories": [
    {
      "Id": 341,
      "Name": "Spinka-Beahan",
      "ToolTip": "Qui amet autem sit praesentium.",
      "Deleted": false,
      "Rank": 749,
      "Type": "quis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "hic",
      "ColorBlock": 96,
      "ExtraInfo": "cupiditate",
      "StyleHint": "sequi",
      "FullName": "Miss Antonina Denis Padberg MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 595
        }
      }
    }
  ],
  "NickName": "Gottlieb-Gleason",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "error"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "molestiae"
  },
  "PostSaveCommands": [
    {
      "Name": "Legros, Klocko and Volkman",
      "DisplayName": "Zieme Group",
      "Description": "Persevering client-driven data-warehouse",
      "ToolTip": "Nihil sed ducimus fugiat ea quidem repellendus.",
      "Actions": "Implicit",
      "ActionData": "nesciunt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 509
    }
  }
}
```