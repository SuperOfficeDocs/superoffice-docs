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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 312,
  "Name": "Runolfsdottir LLC",
  "Rank": 413,
  "Tooltip": "non",
  "LicenseOwners": [
    {
      "Name": "O'Conner, Gulgowski and King",
      "Description": "Extended encompassing ability",
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
      "Name": "O'Conner, Gulgowski and King",
      "Description": "Extended encompassing ability",
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
    "Id": 207,
    "Value": "qui",
    "Tooltip": "omnis"
  },
  "UserGroup": {
    "Value": "sed",
    "Tooltip": "sit",
    "Id": 956,
    "Rank": 440,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "tempore",
      "Tooltip": "dolore",
      "Id": 856,
      "Rank": 104,
      "Deleted": true
    },
    {
      "Value": "tempore",
      "Tooltip": "dolore",
      "Id": 856,
      "Rank": 104,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "ea",
    "PersonId": 135,
    "Mrmrs": "ullam",
    "Firstname": "Brandon",
    "Lastname": "Krajcik",
    "MiddleName": "Gibson, Howe and Yundt",
    "Title": "est",
    "Description": "Proactive coherent matrix",
    "Email": "cordelia.schulist@hermann.name",
    "FullName": "Trent Homenick",
    "DirectPhone": "1-443-330-4504",
    "FormalName": "Zulauf Inc and Sons",
    "CountryId": 384,
    "ContactId": 857,
    "ContactName": "Dickinson Group",
    "Retired": 830,
    "Rank": 397,
    "ActiveInterests": 772,
    "ContactDepartment": "",
    "ContactCountryId": 491,
    "ContactOrgNr": "419555",
    "FaxPhone": "(144)273-6126",
    "MobilePhone": "484.144.3844 x54660",
    "ContactPhone": "1-854-030-0780",
    "AssociateName": "Osinski, Walter and Gaylord",
    "AssociateId": 136,
    "UsePersonAddress": true,
    "ContactFax": "fugit",
    "Kanafname": "et",
    "Kanalname": "magnam",
    "Post1": "omnis",
    "Post2": "sed",
    "Post3": "omnis",
    "EmailName": "zola_marks@fritsch.info",
    "ContactFullName": "Liliana Kris",
    "ActiveErpLinks": 845,
    "TicketPriorityId": 691,
    "SupportLanguageId": 157,
    "SupportAssociateId": 449,
    "CategoryName": "VIP Customer"
  },
  "Deleted": false,
  "Lastlogin": "2000-11-30T18:25:51.4491182+01:00",
  "Lastlogout": "1994-09-18T18:25:51.4491182+02:00",
  "EjUserId": 221,
  "RequestSignature": "perspiciatis",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "dolorem",
      "DisplayValue": "nisi"
    },
    {
      "Type": {},
      "Value": "dolorem",
      "DisplayValue": "nisi"
    }
  ],
  "UserName": "Zboncak, Flatley and Cronin",
  "TicketCategories": [
    {
      "Id": 301,
      "Name": "Zboncak Inc and Sons",
      "ToolTip": "Voluptates tempore et.",
      "Deleted": false,
      "Rank": 246,
      "Type": "dolores",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "a",
      "ColorBlock": 594,
      "ExtraInfo": "assumenda",
      "StyleHint": "veniam",
      "FullName": "Markus Hettinger Jr."
    }
  ],
  "NickName": "Dooley-Legros",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "perspiciatis"
  },
  "PostSaveCommands": [
    {
      "Name": "Cummerata-Cormier",
      "DisplayName": "Stiedemann-Hamill",
      "Description": "Realigned systematic encryption",
      "ToolTip": "Fugit officiis ut ut rerum sunt inventore.",
      "Actions": "Implicit",
      "ActionData": "voluptatum"
    },
    {
      "Name": "Cummerata-Cormier",
      "DisplayName": "Stiedemann-Hamill",
      "Description": "Realigned systematic encryption",
      "ToolTip": "Fugit officiis ut ut rerum sunt inventore.",
      "Actions": "Implicit",
      "ActionData": "voluptatum"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 957,
  "Name": "Stamm, Cruickshank and Barrows",
  "Rank": 10,
  "Tooltip": "quisquam",
  "LicenseOwners": [
    {
      "Name": "Cummings Inc and Sons",
      "Description": "Enterprise-wide non-volatile migration",
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
          "FieldLength": 167
        }
      }
    },
    {
      "Name": "Cummings Inc and Sons",
      "Description": "Enterprise-wide non-volatile migration",
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
          "FieldLength": 167
        }
      }
    }
  ],
  "Role": {
    "Id": 483,
    "Value": "et",
    "Tooltip": "quibusdam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 9
      }
    }
  },
  "UserGroup": {
    "Value": "accusantium",
    "Tooltip": "tempora",
    "Id": 71,
    "Rank": 319,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 870
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "eveniet",
      "Tooltip": "commodi",
      "Id": 711,
      "Rank": 342,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 290
        }
      }
    }
  ],
  "Person": {
    "Position": "sit",
    "PersonId": 184,
    "Mrmrs": "reiciendis",
    "Firstname": "Sheldon",
    "Lastname": "Beahan",
    "MiddleName": "Denesik, Satterfield and Koch",
    "Title": "possimus",
    "Description": "Quality-focused web-enabled throughput",
    "Email": "tatum@nolan.us",
    "FullName": "Hester McClure III",
    "DirectPhone": "(148)643-8160",
    "FormalName": "Hauck LLC",
    "CountryId": 935,
    "ContactId": 777,
    "ContactName": "Bogisich Inc and Sons",
    "Retired": 900,
    "Rank": 560,
    "ActiveInterests": 666,
    "ContactDepartment": "",
    "ContactCountryId": 398,
    "ContactOrgNr": "1411690",
    "FaxPhone": "1-824-164-5574 x2085",
    "MobilePhone": "518-057-6210 x16753",
    "ContactPhone": "(287)365-5256",
    "AssociateName": "Bogisich, Goyette and Streich",
    "AssociateId": 32,
    "UsePersonAddress": true,
    "ContactFax": "quisquam",
    "Kanafname": "iste",
    "Kanalname": "et",
    "Post1": "saepe",
    "Post2": "earum",
    "Post3": "eaque",
    "EmailName": "orville_wisozk@keelingabbott.co.uk",
    "ContactFullName": "Mr. Burley Wiza",
    "ActiveErpLinks": 593,
    "TicketPriorityId": 616,
    "SupportLanguageId": 490,
    "SupportAssociateId": 806,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 347
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "1999-12-25T18:25:51.4551179+01:00",
  "Lastlogout": "2011-03-24T18:25:51.4551179+01:00",
  "EjUserId": 129,
  "RequestSignature": "rerum",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "quia",
      "DisplayValue": "dolore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    },
    {
      "Type": {},
      "Value": "quia",
      "DisplayValue": "dolore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    }
  ],
  "UserName": "Parisian, Stanton and Streich",
  "TicketCategories": [
    {
      "Id": 950,
      "Name": "Carroll LLC",
      "ToolTip": "Delectus aut.",
      "Deleted": true,
      "Rank": 370,
      "Type": "harum",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "asperiores",
      "ColorBlock": 965,
      "ExtraInfo": "reprehenderit",
      "StyleHint": "ducimus",
      "FullName": "Santa Hermann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 397
        }
      }
    }
  ],
  "NickName": "Aufderhar, Watsica and Quigley",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "deleniti"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "omnis"
  },
  "PostSaveCommands": [
    {
      "Name": "VonRueden-Parker",
      "DisplayName": "Keeling-West",
      "Description": "Optimized scalable database",
      "ToolTip": "Debitis reprehenderit blanditiis dolores nesciunt.",
      "Actions": "Implicit",
      "ActionData": "libero",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "leverage best-of-breed experiences"
          },
          "FieldType": "System.String",
          "FieldLength": 420
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
      "FieldLength": 840
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```