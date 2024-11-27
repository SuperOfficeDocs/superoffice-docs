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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 545,
  "Name": "Zemlak-Johns",
  "Rank": 802,
  "Tooltip": "quia",
  "LicenseOwners": [
    {
      "Name": "Wilderman, Roberts and Schinner",
      "Description": "Balanced system-worthy neural-net",
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
      "Name": "Wilderman, Roberts and Schinner",
      "Description": "Balanced system-worthy neural-net",
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
      "Value": "ad",
      "Tooltip": "cum",
      "Id": 891,
      "Rank": 884,
      "Deleted": false
    },
    {
      "Value": "ad",
      "Tooltip": "cum",
      "Id": 891,
      "Rank": 884,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2008-11-24T14:45:13.5055398+01:00",
  "Lastlogout": "2011-01-06T14:45:13.5055398+01:00",
  "EjUserId": 909,
  "RequestSignature": "et",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "adipisci",
      "DisplayValue": "aut"
    },
    {
      "Type": null,
      "Value": "adipisci",
      "DisplayValue": "aut"
    }
  ],
  "UserName": "McDermott-Harris",
  "TicketCategories": [
    {
      "Id": 116,
      "Name": "Zemlak, Mosciski and Grant",
      "ToolTip": "Id atque id odio exercitationem ea non incidunt.",
      "Deleted": false,
      "Rank": 699,
      "Type": "sunt",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "doloremque",
      "ColorBlock": 394,
      "ExtraInfo": "magni",
      "StyleHint": "consequuntur",
      "FullName": "Ms. Gerard Flavie Connelly"
    }
  ],
  "NickName": "Gaylord, Bins and Erdman",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "voluptatum",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "itaque",
    "CustomFields2": "perferendis"
  },
  "PostSaveCommands": [
    {
      "Name": "Feeney, Weimann and Haag",
      "DisplayName": "Hackett, Conroy and Stoltenberg",
      "Description": "Sharable 24/7 algorithm",
      "ToolTip": "Illo ducimus voluptatibus nisi.",
      "Actions": "Implicit",
      "ActionData": "praesentium"
    },
    {
      "Name": "Feeney, Weimann and Haag",
      "DisplayName": "Hackett, Conroy and Stoltenberg",
      "Description": "Sharable 24/7 algorithm",
      "ToolTip": "Illo ducimus voluptatibus nisi.",
      "Actions": "Implicit",
      "ActionData": "praesentium"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 524,
  "Name": "Powlowski, Senger and Rohan",
  "Rank": 349,
  "Tooltip": "omnis",
  "LicenseOwners": [
    {
      "Name": "Frami-Raynor",
      "Description": "Configurable composite customer loyalty",
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
          "FieldLength": 469
        }
      }
    },
    {
      "Name": "Frami-Raynor",
      "Description": "Configurable composite customer loyalty",
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
          "FieldLength": 469
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "ad",
      "Tooltip": "natus",
      "Id": 760,
      "Rank": 214,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 693
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "1998-11-03T14:45:13.5211613+01:00",
  "Lastlogout": "2014-12-02T14:45:13.5211613+01:00",
  "EjUserId": 644,
  "RequestSignature": "quis",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "quam",
      "DisplayValue": "soluta",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 803
        }
      }
    },
    {
      "Type": null,
      "Value": "quam",
      "DisplayValue": "soluta",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 803
        }
      }
    }
  ],
  "UserName": "Block, Hane and Marquardt",
  "TicketCategories": [
    {
      "Id": 896,
      "Name": "Murphy Inc and Sons",
      "ToolTip": "Minima tempora et animi a quibusdam nesciunt est.",
      "Deleted": false,
      "Rank": 202,
      "Type": "praesentium",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "fugiat",
      "ColorBlock": 510,
      "ExtraInfo": "asperiores",
      "StyleHint": "et",
      "FullName": "Tyler Keebler DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    }
  ],
  "NickName": "Hilpert LLC",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "libero"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "aspernatur"
  },
  "PostSaveCommands": [
    {
      "Name": "Shields Inc and Sons",
      "DisplayName": "Kuphal LLC",
      "Description": "Cloned real-time archive",
      "ToolTip": "Accusamus dolorem cupiditate odio ut perspiciatis vel officiis.",
      "Actions": "Implicit",
      "ActionData": "aut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 569
    }
  }
}
```