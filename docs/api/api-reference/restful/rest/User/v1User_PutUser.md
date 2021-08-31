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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 398,
  "Name": "Champlin, Wolf and Carter",
  "Rank": 841,
  "Tooltip": "natus",
  "LicenseOwners": [
    {
      "Name": "Gibson-Lemke",
      "Description": "Self-enabling intermediate workforce",
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
      "Name": "Gibson-Lemke",
      "Description": "Self-enabling intermediate workforce",
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
    "Id": 910,
    "Value": "iusto",
    "Tooltip": "amet"
  },
  "UserGroup": {
    "Value": "ratione",
    "Tooltip": "id",
    "Id": 741,
    "Rank": 878,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "officiis",
      "Tooltip": "debitis",
      "Id": 821,
      "Rank": 203,
      "Deleted": true
    },
    {
      "Value": "officiis",
      "Tooltip": "debitis",
      "Id": 821,
      "Rank": 203,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "ipsum",
    "PersonId": 729,
    "Mrmrs": "beatae",
    "Firstname": "Ashley",
    "Lastname": "Rice",
    "MiddleName": "Balistreri, Murphy and Lueilwitz",
    "Title": "quo",
    "Description": "Exclusive intangible installation",
    "Email": "omer@jewess.ca",
    "FullName": "Christina Howe",
    "DirectPhone": "(068)743-3237",
    "FormalName": "Reichert LLC",
    "CountryId": 313,
    "ContactId": 453,
    "ContactName": "Cartwright Inc and Sons",
    "Retired": 183,
    "Rank": 526,
    "ActiveInterests": 40,
    "ContactDepartment": "",
    "ContactCountryId": 560,
    "ContactOrgNr": "772734",
    "FaxPhone": "1-670-554-3808",
    "MobilePhone": "1-211-748-6253 x68243",
    "ContactPhone": "701-143-3642",
    "AssociateName": "Fisher, Nienow and Gutkowski",
    "AssociateId": 375,
    "UsePersonAddress": true,
    "ContactFax": "ut",
    "Kanafname": "quae",
    "Kanalname": "facilis",
    "Post1": "recusandae",
    "Post2": "eaque",
    "Post3": "nobis",
    "EmailName": "reece@dach.ca",
    "ContactFullName": "Selmer Schmeler",
    "ActiveErpLinks": 375,
    "TicketPriorityId": 843,
    "SupportLanguageId": 746,
    "SupportAssociateId": 431,
    "CategoryName": "VIP Customer"
  },
  "Deleted": true,
  "Lastlogin": "2014-10-23T15:05:43.1368999+02:00",
  "Lastlogout": "2016-08-22T15:05:43.1368999+02:00",
  "EjUserId": 465,
  "RequestSignature": "sit",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "error",
      "DisplayValue": "recusandae"
    },
    {
      "Type": {},
      "Value": "error",
      "DisplayValue": "recusandae"
    }
  ],
  "UserName": "Lemke Inc and Sons",
  "TicketCategories": [
    {
      "Id": 338,
      "Name": "Morar-Quigley",
      "ToolTip": "Qui odio omnis inventore aspernatur placeat.",
      "Deleted": true,
      "Rank": 374,
      "Type": "eveniet",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "corporis",
      "ColorBlock": 639,
      "ExtraInfo": "ad",
      "StyleHint": "reprehenderit",
      "FullName": "Imani Nicolas"
    }
  ],
  "NickName": "Halvorson-Stark",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "praesentium",
    "CustomFields2": "tempora"
  },
  "PostSaveCommands": [
    {
      "Name": "Rogahn LLC",
      "DisplayName": "Murray, Jakubowski and Medhurst",
      "Description": "Persevering maximized benchmark",
      "ToolTip": "Architecto sint ab ullam et quaerat dolores.",
      "Actions": "Implicit",
      "ActionData": "ipsum"
    },
    {
      "Name": "Rogahn LLC",
      "DisplayName": "Murray, Jakubowski and Medhurst",
      "Description": "Persevering maximized benchmark",
      "ToolTip": "Architecto sint ab ullam et quaerat dolores.",
      "Actions": "Implicit",
      "ActionData": "ipsum"
    }
  ]
}
```

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 863,
  "Name": "Sanford Inc and Sons",
  "Rank": 912,
  "Tooltip": "sint",
  "LicenseOwners": [
    {
      "Name": "Wiza Group",
      "Description": "Focused clear-thinking contingency",
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
          "FieldLength": 520
        }
      }
    },
    {
      "Name": "Wiza Group",
      "Description": "Focused clear-thinking contingency",
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
          "FieldLength": 520
        }
      }
    }
  ],
  "Role": {
    "Id": 519,
    "Value": "rem",
    "Tooltip": "rem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 35
      }
    }
  },
  "UserGroup": {
    "Value": "consequatur",
    "Tooltip": "est",
    "Id": 597,
    "Rank": 169,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "syndicate sticky infrastructures"
        },
        "FieldType": "System.Int32",
        "FieldLength": 64
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "harum",
      "Tooltip": "esse",
      "Id": 279,
      "Rank": 56,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 766
        }
      }
    }
  ],
  "Person": {
    "Position": "distinctio",
    "PersonId": 542,
    "Mrmrs": "reprehenderit",
    "Firstname": "Edmond",
    "Lastname": "White",
    "MiddleName": "Terry-Bednar",
    "Title": "ea",
    "Description": "Function-based bifurcated benchmark",
    "Email": "jarrett@batz.co.uk",
    "FullName": "Ms. Elsie Heidenreich",
    "DirectPhone": "453-756-7343 x2622",
    "FormalName": "Lueilwitz-Abshire",
    "CountryId": 557,
    "ContactId": 275,
    "ContactName": "Glover, Corkery and Schultz",
    "Retired": 130,
    "Rank": 471,
    "ActiveInterests": 356,
    "ContactDepartment": "",
    "ContactCountryId": 373,
    "ContactOrgNr": "646013",
    "FaxPhone": "1-105-384-1853",
    "MobilePhone": "1-571-174-6417 x0433",
    "ContactPhone": "232.442.8215 x5760",
    "AssociateName": "O'Kon, Nienow and Herman",
    "AssociateId": 532,
    "UsePersonAddress": false,
    "ContactFax": "delectus",
    "Kanafname": "ut",
    "Kanalname": "laborum",
    "Post1": "quam",
    "Post2": "explicabo",
    "Post3": "ullam",
    "EmailName": "beth.smitham@corwinwaters.uk",
    "ContactFullName": "Lessie Wolff",
    "ActiveErpLinks": 491,
    "TicketPriorityId": 246,
    "SupportLanguageId": 660,
    "SupportAssociateId": 18,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 401
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "1998-12-30T15:05:43.1428991+01:00",
  "Lastlogout": "1997-07-06T15:05:43.1428991+02:00",
  "EjUserId": 825,
  "RequestSignature": "quae",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "omnis",
      "DisplayValue": "sunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 629
        }
      }
    },
    {
      "Type": {},
      "Value": "omnis",
      "DisplayValue": "sunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 629
        }
      }
    }
  ],
  "UserName": "Wilkinson, Auer and Kub",
  "TicketCategories": [
    {
      "Id": 424,
      "Name": "Stroman LLC",
      "ToolTip": "Quo exercitationem et mollitia neque explicabo sunt.",
      "Deleted": false,
      "Rank": 289,
      "Type": "aut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "vel",
      "ColorBlock": 794,
      "ExtraInfo": "reprehenderit",
      "StyleHint": "id",
      "FullName": "Miss Sherwood Hane",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    }
  ],
  "NickName": "Dare-Veum",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "perferendis",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "quam",
    "CustomFields2": "corporis"
  },
  "PostSaveCommands": [
    {
      "Name": "Kling-Swaniawski",
      "DisplayName": "Terry-Schmidt",
      "Description": "Reduced encompassing capability",
      "ToolTip": "Explicabo aspernatur.",
      "Actions": "Implicit",
      "ActionData": "voluptas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "syndicate granular ROI"
          },
          "FieldType": "System.Int32",
          "FieldLength": 710
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
      "FieldLength": 98
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```