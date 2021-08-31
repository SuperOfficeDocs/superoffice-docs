---
title: POST User
id: v1User_PostUser
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
| AssociateId | int32 | Primary key |
| Name | string | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role |  | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup |  | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person |  | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
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


## Response: object

SuperOffice User, with login credentials and an associated person.



User entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 | Primary key |
| Name | string | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role |  | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup |  | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person |  | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/User
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 275,
  "Name": "Yost, McClure and Harvey",
  "Rank": 97,
  "Tooltip": "rem",
  "LicenseOwners": [
    {
      "Name": "Legros LLC",
      "Description": "Profit-focused neutral local area network",
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
      "Name": "Legros LLC",
      "Description": "Profit-focused neutral local area network",
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
  "Role": {
    "Id": 679,
    "Value": "cum",
    "Tooltip": "voluptatem"
  },
  "UserGroup": {
    "Value": "et",
    "Tooltip": "corporis",
    "Id": 461,
    "Rank": 536,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "voluptatem",
      "Tooltip": "dolores",
      "Id": 453,
      "Rank": 186,
      "Deleted": false
    },
    {
      "Value": "voluptatem",
      "Tooltip": "dolores",
      "Id": 453,
      "Rank": 186,
      "Deleted": false
    }
  ],
  "Person": {
    "Position": "qui",
    "PersonId": 217,
    "Mrmrs": "ab",
    "Firstname": "Alessandra",
    "Lastname": "Stark",
    "MiddleName": "Kunze-Corwin",
    "Title": "ut",
    "Description": "Team-oriented context-sensitive strategy",
    "Email": "imani@langoshrippin.co.uk",
    "FullName": "Vern Paucek",
    "DirectPhone": "1-070-235-0312 x846",
    "FormalName": "Predovic-Konopelski",
    "CountryId": 898,
    "ContactId": 368,
    "ContactName": "Ziemann Inc and Sons",
    "Retired": 646,
    "Rank": 231,
    "ActiveInterests": 130,
    "ContactDepartment": "",
    "ContactCountryId": 600,
    "ContactOrgNr": "1880076",
    "FaxPhone": "445-470-1620 x427",
    "MobilePhone": "870.687.2157 x6335",
    "ContactPhone": "576.185.6388 x54652",
    "AssociateName": "Runolfsdottir, Hermiston and Strosin",
    "AssociateId": 232,
    "UsePersonAddress": true,
    "ContactFax": "repudiandae",
    "Kanafname": "sed",
    "Kanalname": "vel",
    "Post1": "voluptas",
    "Post2": "deleniti",
    "Post3": "dolores",
    "EmailName": "leatha.schimmel@stark.us",
    "ContactFullName": "Ayana Ritchie",
    "ActiveErpLinks": 303,
    "TicketPriorityId": 270,
    "SupportLanguageId": 560,
    "SupportAssociateId": 500,
    "CategoryName": "VIP Customer"
  },
  "Deleted": true,
  "Lastlogin": "2018-04-25T15:05:43.0908671+02:00",
  "Lastlogout": "1996-05-02T15:05:43.0908671+02:00",
  "EjUserId": 979,
  "RequestSignature": "quam",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "voluptatem",
      "DisplayValue": "ut"
    },
    {
      "Type": {},
      "Value": "voluptatem",
      "DisplayValue": "ut"
    }
  ],
  "UserName": "Larson, Bosco and Koelpin",
  "TicketCategories": [
    {
      "Id": 26,
      "Name": "Von Inc and Sons",
      "ToolTip": "Officiis cum.",
      "Deleted": false,
      "Rank": 709,
      "Type": "quisquam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quia",
      "ColorBlock": 717,
      "ExtraInfo": "dolorum",
      "StyleHint": "rerum",
      "FullName": "Tavares Kutch"
    }
  ],
  "NickName": "Blanda Inc and Sons",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "consequatur"
  },
  "PostSaveCommands": [
    {
      "Name": "Gorczany Inc and Sons",
      "DisplayName": "Kovacek-Fay",
      "Description": "Ergonomic dedicated info-mediaries",
      "ToolTip": "Voluptatum alias quas id aut ipsum.",
      "Actions": "Implicit",
      "ActionData": "ratione"
    },
    {
      "Name": "Gorczany Inc and Sons",
      "DisplayName": "Kovacek-Fay",
      "Description": "Ergonomic dedicated info-mediaries",
      "ToolTip": "Voluptatum alias quas id aut ipsum.",
      "Actions": "Implicit",
      "ActionData": "ratione"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 859,
  "Name": "Konopelski, Roberts and Mosciski",
  "Rank": 123,
  "Tooltip": "optio",
  "LicenseOwners": [
    {
      "Name": "Rolfson LLC",
      "Description": "Distributed background hierarchy",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 283
        }
      }
    },
    {
      "Name": "Rolfson LLC",
      "Description": "Distributed background hierarchy",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 283
        }
      }
    }
  ],
  "Role": {
    "Id": 359,
    "Value": "ea",
    "Tooltip": "maxime",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 5
      }
    }
  },
  "UserGroup": {
    "Value": "sit",
    "Tooltip": "eum",
    "Id": 890,
    "Rank": 677,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 207
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "quo",
      "Tooltip": "sapiente",
      "Id": 18,
      "Rank": 57,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    }
  ],
  "Person": {
    "Position": "et",
    "PersonId": 229,
    "Mrmrs": "recusandae",
    "Firstname": "Stephanie",
    "Lastname": "Jewess",
    "MiddleName": "Roberts Group",
    "Title": "sed",
    "Description": "Enterprise-wide incremental hub",
    "Email": "luna_turcotte@schulist.uk",
    "FullName": "Lula Conn",
    "DirectPhone": "363-248-5175 x662",
    "FormalName": "Schimmel, Harber and Kuvalis",
    "CountryId": 281,
    "ContactId": 596,
    "ContactName": "Kiehn, Lynch and Cole",
    "Retired": 718,
    "Rank": 286,
    "ActiveInterests": 123,
    "ContactDepartment": "",
    "ContactCountryId": 753,
    "ContactOrgNr": "440248",
    "FaxPhone": "(474)843-4416",
    "MobilePhone": "1-528-654-0485",
    "ContactPhone": "(287)558-3070",
    "AssociateName": "Haley-Conn",
    "AssociateId": 946,
    "UsePersonAddress": false,
    "ContactFax": "suscipit",
    "Kanafname": "quae",
    "Kanalname": "autem",
    "Post1": "quia",
    "Post2": "consequatur",
    "Post3": "molestias",
    "EmailName": "freddy_mann@mrazkuphal.ca",
    "ContactFullName": "Brenda Tromp",
    "ActiveErpLinks": 736,
    "TicketPriorityId": 502,
    "SupportLanguageId": 112,
    "SupportAssociateId": 171,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 9
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "1998-11-25T15:05:43.1148658+01:00",
  "Lastlogout": "2001-07-18T15:05:43.1148658+02:00",
  "EjUserId": 705,
  "RequestSignature": "mollitia",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "officiis",
      "DisplayValue": "placeat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    },
    {
      "Type": {},
      "Value": "officiis",
      "DisplayValue": "placeat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    }
  ],
  "UserName": "Larson Inc and Sons",
  "TicketCategories": [
    {
      "Id": 696,
      "Name": "Hoppe-Huels",
      "ToolTip": "Iusto numquam unde facilis quia.",
      "Deleted": true,
      "Rank": 889,
      "Type": "et",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "cum",
      "ColorBlock": 798,
      "ExtraInfo": "illo",
      "StyleHint": "ducimus",
      "FullName": "Reuben Lueilwitz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    }
  ],
  "NickName": "Fahey LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "et"
  },
  "PostSaveCommands": [
    {
      "Name": "Hills-Gislason",
      "DisplayName": "Mosciski-Yundt",
      "Description": "Exclusive value-added task-force",
      "ToolTip": "Dicta voluptatem doloremque unde et voluptatibus.",
      "Actions": "Implicit",
      "ActionData": "vel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 490
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```