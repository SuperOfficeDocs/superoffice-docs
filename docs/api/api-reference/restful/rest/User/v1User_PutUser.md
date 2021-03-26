---
title: PUT User/{id}
id: v1User_PutUser
---

# PUT User/{id}

```http
PUT /api/v1/User/{id}
```

Updates the existing User



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The User id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/User/{id}?$select=name,department,category/id
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

## Request Body: entity  

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
| 200 | User updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/User/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 914,
  "Name": "Turcotte-Weber",
  "Rank": 573,
  "Tooltip": "et",
  "LicenseOwners": [
    {
      "Name": "Leuschke-Mayert",
      "Description": "Multi-tiered stable core",
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
      "Name": "Leuschke-Mayert",
      "Description": "Multi-tiered stable core",
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
    "Id": 10,
    "Value": "praesentium",
    "Tooltip": "perferendis"
  },
  "UserGroup": {
    "Value": "facere",
    "Tooltip": "eos",
    "Id": 382,
    "Rank": 310,
    "Deleted": false
  },
  "OtherGroups": [
    {
      "Value": "hic",
      "Tooltip": "qui",
      "Id": 556,
      "Rank": 17,
      "Deleted": true
    },
    {
      "Value": "hic",
      "Tooltip": "qui",
      "Id": 556,
      "Rank": 17,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "velit",
    "PersonId": 699,
    "Mrmrs": "magnam",
    "Firstname": "Jabari",
    "Lastname": "Gusikowski",
    "MiddleName": "Cassin, Jerde and Roob",
    "Title": "incidunt",
    "Description": "Pre-emptive impactful info-mediaries",
    "Email": "astrid@durgan.ca",
    "FullName": "Ora Emmerich V",
    "DirectPhone": "188.685.8702",
    "FormalName": "Ebert-Mitchell",
    "CountryId": 715,
    "ContactId": 325,
    "ContactName": "Weber-Hoeger",
    "Retired": 528,
    "Rank": 79,
    "ActiveInterests": 115,
    "ContactDepartment": "",
    "ContactCountryId": 474,
    "ContactOrgNr": "1050230",
    "FaxPhone": "(734)885-5218",
    "MobilePhone": "562-274-1775",
    "ContactPhone": "(682)364-0245 x066",
    "AssociateName": "Gleason-Bernhard",
    "AssociateId": 392,
    "UsePersonAddress": false,
    "ContactFax": "aliquid",
    "Kanafname": "autem",
    "Kanalname": "quis",
    "Post1": "labore",
    "Post2": "enim",
    "Post3": "nemo",
    "EmailName": "rosina_haley@metz.name",
    "ContactFullName": "Cathryn Stehr IV",
    "ActiveErpLinks": 649,
    "TicketPriorityId": 611,
    "SupportLanguageId": 82,
    "SupportAssociateId": 536,
    "CategoryName": "VIP Customer"
  },
  "Deleted": false,
  "Lastlogin": "2005-07-02T09:41:00.0590595+02:00",
  "Lastlogout": "2010-01-31T09:41:00.0590595+01:00",
  "EjUserId": 779,
  "RequestSignature": "voluptas",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "perferendis",
      "DisplayValue": "blanditiis"
    },
    {
      "Type": {},
      "Value": "perferendis",
      "DisplayValue": "blanditiis"
    }
  ],
  "UserName": "Schulist, Stokes and Crona",
  "TicketCategories": [
    {
      "Id": 58,
      "Name": "Beer LLC",
      "ToolTip": "Libero voluptate et consequatur velit sit.",
      "Deleted": false,
      "Rank": 887,
      "Type": "soluta",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "cumque",
      "ColorBlock": 163,
      "ExtraInfo": "aut",
      "StyleHint": "corrupti",
      "FullName": "Erik Jacobson"
    }
  ],
  "NickName": "Bogisich-Oberbrunner",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "laudantium",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "deserunt",
    "CustomFields2": "voluptatem"
  },
  "PostSaveCommands": [
    {
      "Name": "Stark Group",
      "DisplayName": "Volkman, Ernser and Volkman",
      "Description": "Cross-platform client-server hub",
      "ToolTip": "Suscipit quaerat facere excepturi sed pariatur.",
      "Actions": "Implicit",
      "ActionData": "libero"
    },
    {
      "Name": "Stark Group",
      "DisplayName": "Volkman, Ernser and Volkman",
      "Description": "Cross-platform client-server hub",
      "ToolTip": "Suscipit quaerat facere excepturi sed pariatur.",
      "Actions": "Implicit",
      "ActionData": "libero"
    }
  ]
}
```

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 85,
  "Name": "Hackett, Ondricka and Shanahan",
  "Rank": 114,
  "Tooltip": "quod",
  "LicenseOwners": [
    {
      "Name": "Hayes Inc and Sons",
      "Description": "Secured neutral adapter",
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
          "FieldLength": 614
        }
      }
    },
    {
      "Name": "Hayes Inc and Sons",
      "Description": "Secured neutral adapter",
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
          "FieldLength": 614
        }
      }
    }
  ],
  "Role": {
    "Id": 431,
    "Value": "nemo",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 724
      }
    }
  },
  "UserGroup": {
    "Value": "eum",
    "Tooltip": "officiis",
    "Id": 47,
    "Rank": 235,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 571
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "labore",
      "Tooltip": "et",
      "Id": 309,
      "Rank": 843,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 223
        }
      }
    }
  ],
  "Person": {
    "Position": "enim",
    "PersonId": 209,
    "Mrmrs": "et",
    "Firstname": "Ethel",
    "Lastname": "Shields",
    "MiddleName": "Dooley-Fahey",
    "Title": "reprehenderit",
    "Description": "Customer-focused transitional website",
    "Email": "alexie@blockpagac.biz",
    "FullName": "Fatima Bechtelar",
    "DirectPhone": "748.581.3407",
    "FormalName": "Ondricka Inc and Sons",
    "CountryId": 328,
    "ContactId": 287,
    "ContactName": "Von-Hettinger",
    "Retired": 344,
    "Rank": 928,
    "ActiveInterests": 852,
    "ContactDepartment": "e-enable granular portals",
    "ContactCountryId": 97,
    "ContactOrgNr": "1514149",
    "FaxPhone": "1-548-170-7771 x127",
    "MobilePhone": "1-087-027-1610",
    "ContactPhone": "1-355-527-3504",
    "AssociateName": "Carroll LLC",
    "AssociateId": 192,
    "UsePersonAddress": true,
    "ContactFax": "harum",
    "Kanafname": "ratione",
    "Kanalname": "facilis",
    "Post1": "aperiam",
    "Post2": "quis",
    "Post3": "dicta",
    "EmailName": "virginia.shields@vonbartoletti.uk",
    "ContactFullName": "Crawford Fritsch",
    "ActiveErpLinks": 525,
    "TicketPriorityId": 335,
    "SupportLanguageId": 753,
    "SupportAssociateId": 687,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 834
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "1998-10-13T09:41:00.0640593+02:00",
  "Lastlogout": "2021-03-17T09:41:00.0640593+01:00",
  "EjUserId": 338,
  "RequestSignature": "harum",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "fuga",
      "DisplayValue": "quaerat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 631
        }
      }
    },
    {
      "Type": {},
      "Value": "fuga",
      "DisplayValue": "quaerat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 631
        }
      }
    }
  ],
  "UserName": "Mraz, Wehner and Dooley",
  "TicketCategories": [
    {
      "Id": 477,
      "Name": "Schowalter, Flatley and Hoeger",
      "ToolTip": "Vel deleniti sapiente neque ea.",
      "Deleted": false,
      "Rank": 539,
      "Type": "ut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "et",
      "ColorBlock": 816,
      "ExtraInfo": "ex",
      "StyleHint": "omnis",
      "FullName": "Priscilla Homenick DVM",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 58
        }
      }
    }
  ],
  "NickName": "Becker Group",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "consequuntur",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "quae",
    "CustomFields2": "exercitationem"
  },
  "PostSaveCommands": [
    {
      "Name": "Denesik-Gislason",
      "DisplayName": "Reichert, King and Lehner",
      "Description": "Function-based zero tolerance standardization",
      "ToolTip": "Qui inventore et perspiciatis.",
      "Actions": "Implicit",
      "ActionData": "iure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 906
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
      "FieldLength": 142
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```