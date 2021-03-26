---
title: PUT User/{userName}
id: v1User_SaveUserFromName
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



Carrier object for User.
Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>.

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

## Sample Request

```http!
PUT /api/v1/User/{userName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 118,
  "Name": "Bartell, Schuster and Lang",
  "Rank": 539,
  "Tooltip": "quo",
  "LicenseOwners": [
    {
      "Name": "Miller Group",
      "Description": "Stand-alone assymetric knowledge base",
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
      "Name": "Miller Group",
      "Description": "Stand-alone assymetric knowledge base",
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
    "Id": 381,
    "Value": "dolor",
    "Tooltip": "incidunt"
  },
  "UserGroup": {
    "Value": "suscipit",
    "Tooltip": "eos",
    "Id": 350,
    "Rank": 61,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "quaerat",
      "Tooltip": "quidem",
      "Id": 634,
      "Rank": 885,
      "Deleted": true
    },
    {
      "Value": "quaerat",
      "Tooltip": "quidem",
      "Id": 634,
      "Rank": 885,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "impedit",
    "PersonId": 1001,
    "Mrmrs": "ad",
    "Firstname": "Dianna",
    "Lastname": "McDermott",
    "MiddleName": "Lowe-Morissette",
    "Title": "nisi",
    "Description": "Grass-roots zero administration alliance",
    "Email": "mozell_kessler@kris.ca",
    "FullName": "Nona Emmerich",
    "DirectPhone": "(883)885-7738",
    "FormalName": "Pagac-Nolan",
    "CountryId": 509,
    "ContactId": 784,
    "ContactName": "Kertzmann, Abshire and Purdy",
    "Retired": 320,
    "Rank": 411,
    "ActiveInterests": 732,
    "ContactDepartment": "",
    "ContactCountryId": 863,
    "ContactOrgNr": "252002",
    "FaxPhone": "1-583-340-4351 x6361",
    "MobilePhone": "172.618.8816",
    "ContactPhone": "(861)656-7717",
    "AssociateName": "Mann, Ziemann and Murray",
    "AssociateId": 141,
    "UsePersonAddress": true,
    "ContactFax": "officia",
    "Kanafname": "in",
    "Kanalname": "consequuntur",
    "Post1": "qui",
    "Post2": "deserunt",
    "Post3": "aut",
    "EmailName": "laverna.dubuque@klein.us",
    "ContactFullName": "Louisa Will",
    "ActiveErpLinks": 578,
    "TicketPriorityId": 898,
    "SupportLanguageId": 973,
    "SupportAssociateId": 325,
    "CategoryName": "VIP Customer"
  },
  "Deleted": true,
  "Lastlogin": "2014-12-21T09:41:00.08006+01:00",
  "Lastlogout": "2013-09-28T09:41:00.08006+02:00",
  "EjUserId": 135,
  "RequestSignature": "saepe",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "odit",
      "DisplayValue": "ducimus"
    },
    {
      "Type": {},
      "Value": "odit",
      "DisplayValue": "ducimus"
    }
  ],
  "UserName": "Hamill-Wintheiser",
  "TicketCategories": [
    {
      "Id": 353,
      "Name": "Bogisich, Mueller and Schmeler",
      "ToolTip": "Officiis ut atque nemo eum numquam.",
      "Deleted": false,
      "Rank": 750,
      "Type": "illo",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "eveniet",
      "ColorBlock": 433,
      "ExtraInfo": "voluptatem",
      "StyleHint": "nulla",
      "FullName": "Orie Reinger"
    }
  ],
  "NickName": "Mertz, Heidenreich and Hills",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "cupiditate"
  },
  "PostSaveCommands": [
    {
      "Name": "Hermann-Rice",
      "DisplayName": "Renner-Bergstrom",
      "Description": "Phased fault-tolerant parallelism",
      "ToolTip": "Ab dolorum.",
      "Actions": "Implicit",
      "ActionData": "voluptatem"
    },
    {
      "Name": "Hermann-Rice",
      "DisplayName": "Renner-Bergstrom",
      "Description": "Phased fault-tolerant parallelism",
      "ToolTip": "Ab dolorum.",
      "Actions": "Implicit",
      "ActionData": "voluptatem"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 823,
  "Name": "Leffler Group",
  "Rank": 47,
  "Tooltip": "impedit",
  "LicenseOwners": [
    {
      "Name": "Bashirian, Ullrich and Ernser",
      "Description": "Multi-channelled cohesive matrices",
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
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    },
    {
      "Name": "Bashirian, Ullrich and Ernser",
      "Description": "Multi-channelled cohesive matrices",
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
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    }
  ],
  "Role": {
    "Id": 688,
    "Value": "et",
    "Tooltip": "vitae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 228
      }
    }
  },
  "UserGroup": {
    "Value": "dicta",
    "Tooltip": "autem",
    "Id": 45,
    "Rank": 221,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 95
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "esse",
      "Tooltip": "ut",
      "Id": 710,
      "Rank": 618,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "aggregate open-source communities"
          },
          "FieldType": "System.String",
          "FieldLength": 319
        }
      }
    }
  ],
  "Person": {
    "Position": "eaque",
    "PersonId": 504,
    "Mrmrs": "eaque",
    "Firstname": "Arnulfo",
    "Lastname": "Jakubowski",
    "MiddleName": "Willms Group",
    "Title": "repellat",
    "Description": "Operative client-server core",
    "Email": "joana@bogan.co.uk",
    "FullName": "Rhett Dooley",
    "DirectPhone": "1-434-701-7208 x13824",
    "FormalName": "Cartwright, Kling and Kreiger",
    "CountryId": 618,
    "ContactId": 711,
    "ContactName": "Stark Group",
    "Retired": 783,
    "Rank": 706,
    "ActiveInterests": 364,
    "ContactDepartment": "extend granular applications",
    "ContactCountryId": 214,
    "ContactOrgNr": "539463",
    "FaxPhone": "673.866.6420 x858",
    "MobilePhone": "277.352.3570 x276",
    "ContactPhone": "(608)066-7764 x778",
    "AssociateName": "McClure-O'Connell",
    "AssociateId": 858,
    "UsePersonAddress": true,
    "ContactFax": "similique",
    "Kanafname": "nihil",
    "Kanalname": "et",
    "Post1": "consequatur",
    "Post2": "aut",
    "Post3": "quia",
    "EmailName": "sheldon.fisher@erdman.name",
    "ContactFullName": "Odessa Kozey Sr.",
    "ActiveErpLinks": 302,
    "TicketPriorityId": 566,
    "SupportLanguageId": 743,
    "SupportAssociateId": 248,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 165
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2009-06-04T09:41:00.0860594+02:00",
  "Lastlogout": "2018-02-28T09:41:00.0860594+01:00",
  "EjUserId": 994,
  "RequestSignature": "alias",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "quo",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 743
        }
      }
    },
    {
      "Type": {},
      "Value": "quo",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 743
        }
      }
    }
  ],
  "UserName": "Hessel, Luettgen and Aufderhar",
  "TicketCategories": [
    {
      "Id": 215,
      "Name": "Schmeler Inc and Sons",
      "ToolTip": "Placeat ullam reiciendis.",
      "Deleted": false,
      "Rank": 421,
      "Type": "eos",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "iusto",
      "ColorBlock": 456,
      "ExtraInfo": "dolore",
      "StyleHint": "eius",
      "FullName": "Janet Feeney",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    }
  ],
  "NickName": "Orn-Ziemann",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "veniam",
    "CustomFields2": "reiciendis"
  },
  "PostSaveCommands": [
    {
      "Name": "Fritsch Group",
      "DisplayName": "Vandervort-Conn",
      "Description": "Persevering uniform encoding",
      "ToolTip": "Dignissimos omnis quos atque.",
      "Actions": "Implicit",
      "ActionData": "unde",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 315
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
      "FieldType": "System.Int32",
      "FieldLength": 535
    }
  }
}
```