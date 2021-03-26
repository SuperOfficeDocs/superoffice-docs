---
title: POST Agents/User/SaveUser
id: v1UserAgent_SaveUser
---

# POST Agents/User/SaveUser

```http
POST /api/v1/Agents/User/SaveUser
```

Updates the existing User or creates a new User if the id parameter is empty



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






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
POST /api/v1/Agents/User/SaveUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 314,
  "Name": "Gutmann, Schmitt and Langworth",
  "Rank": 257,
  "Tooltip": "non",
  "LicenseOwners": [
    {
      "Name": "Anderson Group",
      "Description": "Intuitive leading edge task-force",
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
      "Name": "Anderson Group",
      "Description": "Intuitive leading edge task-force",
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
    "Id": 308,
    "Value": "occaecati",
    "Tooltip": "porro"
  },
  "UserGroup": {
    "Value": "non",
    "Tooltip": "aut",
    "Id": 209,
    "Rank": 837,
    "Deleted": false
  },
  "OtherGroups": [
    {
      "Value": "ipsa",
      "Tooltip": "ad",
      "Id": 292,
      "Rank": 647,
      "Deleted": true
    },
    {
      "Value": "ipsa",
      "Tooltip": "ad",
      "Id": 292,
      "Rank": 647,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "laborum",
    "PersonId": 497,
    "Mrmrs": "magni",
    "Firstname": "Reyna",
    "Lastname": "Emmerich",
    "MiddleName": "Lubowitz Inc and Sons",
    "Title": "repellendus",
    "Description": "Customer-focused fault-tolerant hub",
    "Email": "mariela_bednar@kemmer.biz",
    "FullName": "Ayana Wisoky DVM",
    "DirectPhone": "126.601.6277 x35408",
    "FormalName": "Simonis-Johnson",
    "CountryId": 707,
    "ContactId": 177,
    "ContactName": "Kozey, Mills and Koepp",
    "Retired": 237,
    "Rank": 418,
    "ActiveInterests": 819,
    "ContactDepartment": "",
    "ContactCountryId": 943,
    "ContactOrgNr": "840295",
    "FaxPhone": "728.242.6851",
    "MobilePhone": "733.632.2362 x6065",
    "ContactPhone": "(452)134-3262",
    "AssociateName": "Ortiz Group",
    "AssociateId": 574,
    "UsePersonAddress": false,
    "ContactFax": "ut",
    "Kanafname": "quisquam",
    "Kanalname": "quae",
    "Post1": "nobis",
    "Post2": "quia",
    "Post3": "maiores",
    "EmailName": "stewart.cronin@olson.info",
    "ContactFullName": "Miss Iva Robel",
    "ActiveErpLinks": 272,
    "TicketPriorityId": 461,
    "SupportLanguageId": 197,
    "SupportAssociateId": 650,
    "CategoryName": "VIP Customer"
  },
  "Deleted": false,
  "Lastlogin": "2014-04-24T16:48:30.8989403+02:00",
  "Lastlogout": "2005-04-27T16:48:30.8989403+02:00",
  "EjUserId": 517,
  "RequestSignature": "asperiores",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "at",
      "DisplayValue": "nam"
    },
    {
      "Type": {},
      "Value": "at",
      "DisplayValue": "nam"
    }
  ],
  "UserName": "Torp, Stokes and Runolfsdottir",
  "TicketCategories": [
    {
      "Id": 500,
      "Name": "Hammes-Ondricka",
      "ToolTip": "Saepe aut.",
      "Deleted": false,
      "Rank": 801,
      "Type": "quasi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "aut",
      "ColorBlock": 451,
      "ExtraInfo": "pariatur",
      "StyleHint": "dolor",
      "FullName": "Name Breitenberg I"
    }
  ],
  "NickName": "Hettinger, Stroman and Runolfsson",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "illo",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "deserunt",
    "CustomFields2": "est"
  },
  "PostSaveCommands": [
    {
      "Name": "Swift, Wyman and Keeling",
      "DisplayName": "Marquardt-Zemlak",
      "Description": "Versatile fresh-thinking implementation",
      "ToolTip": "Quam omnis.",
      "Actions": "Implicit",
      "ActionData": "corrupti"
    },
    {
      "Name": "Swift, Wyman and Keeling",
      "DisplayName": "Marquardt-Zemlak",
      "Description": "Versatile fresh-thinking implementation",
      "ToolTip": "Quam omnis.",
      "Actions": "Implicit",
      "ActionData": "corrupti"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 440,
  "Name": "Schimmel-Konopelski",
  "Rank": 719,
  "Tooltip": "rerum",
  "LicenseOwners": [
    {
      "Name": "Jenkins-Sawayn",
      "Description": "Exclusive radical adapter",
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
          "FieldLength": 116
        }
      }
    },
    {
      "Name": "Jenkins-Sawayn",
      "Description": "Exclusive radical adapter",
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
          "FieldLength": 116
        }
      }
    }
  ],
  "Role": {
    "Id": 632,
    "Value": "aliquam",
    "Tooltip": "architecto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 236
      }
    }
  },
  "UserGroup": {
    "Value": "aut",
    "Tooltip": "recusandae",
    "Id": 503,
    "Rank": 168,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 519
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "sint",
      "Tooltip": "impedit",
      "Id": 864,
      "Rank": 719,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    }
  ],
  "Person": {
    "Position": "ut",
    "PersonId": 524,
    "Mrmrs": "dolorem",
    "Firstname": "Bailee",
    "Lastname": "Kihn",
    "MiddleName": "Willms-Keebler",
    "Title": "atque",
    "Description": "Devolved radical database",
    "Email": "earnestine@quitzon.uk",
    "FullName": "Vivienne Metz",
    "DirectPhone": "1-441-382-0445",
    "FormalName": "Jast, Morissette and Abbott",
    "CountryId": 951,
    "ContactId": 604,
    "ContactName": "Quigley, Bogan and Sanford",
    "Retired": 33,
    "Rank": 418,
    "ActiveInterests": 950,
    "ContactDepartment": "",
    "ContactCountryId": 240,
    "ContactOrgNr": "1194998",
    "FaxPhone": "635.386.6420 x01686",
    "MobilePhone": "305.063.6877",
    "ContactPhone": "(055)162-0608",
    "AssociateName": "Kub-Stanton",
    "AssociateId": 329,
    "UsePersonAddress": true,
    "ContactFax": "nobis",
    "Kanafname": "hic",
    "Kanalname": "ab",
    "Post1": "placeat",
    "Post2": "ipsum",
    "Post3": "saepe",
    "EmailName": "gillian@pagac.biz",
    "ContactFullName": "Velva Reichert",
    "ActiveErpLinks": 888,
    "TicketPriorityId": 286,
    "SupportLanguageId": 820,
    "SupportAssociateId": 608,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 981
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "1998-11-18T16:48:30.9029403+01:00",
  "Lastlogout": "2000-06-26T16:48:30.9029403+02:00",
  "EjUserId": 365,
  "RequestSignature": "illo",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "autem",
      "DisplayValue": "eum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    },
    {
      "Type": {},
      "Value": "autem",
      "DisplayValue": "eum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    }
  ],
  "UserName": "Harber-Feil",
  "TicketCategories": [
    {
      "Id": 955,
      "Name": "Cummerata-Renner",
      "ToolTip": "Animi et voluptate magni.",
      "Deleted": true,
      "Rank": 818,
      "Type": "totam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "officia",
      "ColorBlock": 736,
      "ExtraInfo": "pariatur",
      "StyleHint": "rerum",
      "FullName": "Kelsie Hirthe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 339
        }
      }
    }
  ],
  "NickName": "Braun, Huels and Rippin",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "accusantium",
    "CustomFields2": "ducimus"
  },
  "PostSaveCommands": [
    {
      "Name": "Streich Group",
      "DisplayName": "Emard LLC",
      "Description": "Innovative client-server frame",
      "ToolTip": "Quis voluptatem perferendis eligendi.",
      "Actions": "Implicit",
      "ActionData": "alias",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 264
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
      "FieldLength": 646
    }
  }
}
```