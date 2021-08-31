---
title: SaveUser
id: v1UserAgent_SaveUser
---

# SaveUser

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
  "AssociateId": 359,
  "Name": "Keeling-Franecki",
  "Rank": 7,
  "Tooltip": "fuga",
  "LicenseOwners": [
    {
      "Name": "Purdy-Farrell",
      "Description": "Secured bandwidth-monitored synergy",
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
      "Name": "Purdy-Farrell",
      "Description": "Secured bandwidth-monitored synergy",
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
    "Id": 337,
    "Value": "quia",
    "Tooltip": "debitis"
  },
  "UserGroup": {
    "Value": "consectetur",
    "Tooltip": "est",
    "Id": 386,
    "Rank": 807,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "sed",
      "Tooltip": "quia",
      "Id": 876,
      "Rank": 689,
      "Deleted": false
    },
    {
      "Value": "sed",
      "Tooltip": "quia",
      "Id": 876,
      "Rank": 689,
      "Deleted": false
    }
  ],
  "Person": {
    "Position": "est",
    "PersonId": 582,
    "Mrmrs": "porro",
    "Firstname": "Cali",
    "Lastname": "Barton",
    "MiddleName": "Mante, Schaden and O'Hara",
    "Title": "quas",
    "Description": "Mandatory methodical methodology",
    "Email": "eileen@hilpert.com",
    "FullName": "Vaughn Murazik",
    "DirectPhone": "535.274.2316 x4427",
    "FormalName": "Mraz-Wilderman",
    "CountryId": 956,
    "ContactId": 372,
    "ContactName": "Bednar Group",
    "Retired": 506,
    "Rank": 687,
    "ActiveInterests": 831,
    "ContactDepartment": "",
    "ContactCountryId": 317,
    "ContactOrgNr": "1037186",
    "FaxPhone": "1-770-332-0474 x103",
    "MobilePhone": "(876)472-2752 x67874",
    "ContactPhone": "1-214-685-3831 x54180",
    "AssociateName": "Hilpert, Oberbrunner and Rutherford",
    "AssociateId": 31,
    "UsePersonAddress": true,
    "ContactFax": "ut",
    "Kanafname": "minima",
    "Kanalname": "enim",
    "Post1": "eligendi",
    "Post2": "quam",
    "Post3": "repellat",
    "EmailName": "delpha.metz@watsica.info",
    "ContactFullName": "Miss Lenna Rutherford",
    "ActiveErpLinks": 665,
    "TicketPriorityId": 688,
    "SupportLanguageId": 239,
    "SupportAssociateId": 709,
    "CategoryName": "VIP Customer"
  },
  "Deleted": true,
  "Lastlogin": "2014-08-29T14:58:05.5510547+02:00",
  "Lastlogout": "2018-10-13T14:58:05.5510547+02:00",
  "EjUserId": 451,
  "RequestSignature": "odio",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "laboriosam",
      "DisplayValue": "non"
    },
    {
      "Type": {},
      "Value": "laboriosam",
      "DisplayValue": "non"
    }
  ],
  "UserName": "Rowe, Kuhn and Kozey",
  "TicketCategories": [
    {
      "Id": 232,
      "Name": "Barton-Huel",
      "ToolTip": "Quo rem harum voluptatum optio.",
      "Deleted": false,
      "Rank": 75,
      "Type": "quis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "cupiditate",
      "ColorBlock": 987,
      "ExtraInfo": "neque",
      "StyleHint": "unde",
      "FullName": "Rahsaan Cummerata DDS"
    }
  ],
  "NickName": "Baumbach-Willms",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "fugit"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "sed"
  },
  "PostSaveCommands": [
    {
      "Name": "Steuber LLC",
      "DisplayName": "Schumm-Doyle",
      "Description": "Reduced disintermediate paradigm",
      "ToolTip": "Sint possimus fugit modi et mollitia rem.",
      "Actions": "Implicit",
      "ActionData": "quo"
    },
    {
      "Name": "Steuber LLC",
      "DisplayName": "Schumm-Doyle",
      "Description": "Reduced disintermediate paradigm",
      "ToolTip": "Sint possimus fugit modi et mollitia rem.",
      "Actions": "Implicit",
      "ActionData": "quo"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 563,
  "Name": "Schneider Inc and Sons",
  "Rank": 434,
  "Tooltip": "porro",
  "LicenseOwners": [
    {
      "Name": "Kemmer-Runte",
      "Description": "Upgradable content-based strategy",
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
          "FieldLength": 587
        }
      }
    },
    {
      "Name": "Kemmer-Runte",
      "Description": "Upgradable content-based strategy",
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
          "FieldLength": 587
        }
      }
    }
  ],
  "Role": {
    "Id": 322,
    "Value": "omnis",
    "Tooltip": "impedit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 498
      }
    }
  },
  "UserGroup": {
    "Value": "facere",
    "Tooltip": "rem",
    "Id": 318,
    "Rank": 99,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 698
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "et",
      "Tooltip": "eos",
      "Id": 840,
      "Rank": 780,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 69
        }
      }
    }
  ],
  "Person": {
    "Position": "perspiciatis",
    "PersonId": 219,
    "Mrmrs": "et",
    "Firstname": "Elmo",
    "Lastname": "Littel",
    "MiddleName": "Hegmann, Casper and Abshire",
    "Title": "nisi",
    "Description": "Versatile eco-centric toolset",
    "Email": "robert@schimmel.info",
    "FullName": "Dr. Arely Cummerata",
    "DirectPhone": "384-747-1252 x206",
    "FormalName": "Orn-Durgan",
    "CountryId": 576,
    "ContactId": 707,
    "ContactName": "Bailey Inc and Sons",
    "Retired": 515,
    "Rank": 818,
    "ActiveInterests": 751,
    "ContactDepartment": "",
    "ContactCountryId": 375,
    "ContactOrgNr": "1259761",
    "FaxPhone": "438-880-8724 x1266",
    "MobilePhone": "1-174-205-4161 x2816",
    "ContactPhone": "176.518.3173 x6221",
    "AssociateName": "Schinner LLC",
    "AssociateId": 828,
    "UsePersonAddress": true,
    "ContactFax": "modi",
    "Kanafname": "et",
    "Kanalname": "delectus",
    "Post1": "quia",
    "Post2": "possimus",
    "Post3": "quia",
    "EmailName": "carmel_hills@klocko.uk",
    "ContactFullName": "Nayeli Ortiz",
    "ActiveErpLinks": 731,
    "TicketPriorityId": 837,
    "SupportLanguageId": 314,
    "SupportAssociateId": 328,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 347
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2018-11-23T14:58:05.5570448+01:00",
  "Lastlogout": "2021-07-25T14:58:05.5570448+02:00",
  "EjUserId": 109,
  "RequestSignature": "nostrum",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "quod",
      "DisplayValue": "autem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 174
        }
      }
    },
    {
      "Type": {},
      "Value": "quod",
      "DisplayValue": "autem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 174
        }
      }
    }
  ],
  "UserName": "Skiles, Swift and Harvey",
  "TicketCategories": [
    {
      "Id": 414,
      "Name": "Halvorson Group",
      "ToolTip": "Odit illum aut rerum libero.",
      "Deleted": true,
      "Rank": 541,
      "Type": "debitis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "aut",
      "ColorBlock": 52,
      "ExtraInfo": "beatae",
      "StyleHint": "reiciendis",
      "FullName": "Danyka Bechtelar",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    }
  ],
  "NickName": "Crist-Kuhn",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "assumenda"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "amet"
  },
  "PostSaveCommands": [
    {
      "Name": "Lakin-Bartell",
      "DisplayName": "Lehner-Predovic",
      "Description": "Versatile directional circuit",
      "ToolTip": "Quia illum.",
      "Actions": "Implicit",
      "ActionData": "ea",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incentivize viral ROI"
          },
          "FieldType": "System.String",
          "FieldLength": 236
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
      "FieldLength": 406
    }
  }
}
```