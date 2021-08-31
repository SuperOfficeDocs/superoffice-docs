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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 82,
  "Name": "Schoen, Collins and Larkin",
  "Rank": 744,
  "Tooltip": "et",
  "LicenseOwners": [
    {
      "Name": "Koss, Marquardt and Schumm",
      "Description": "Multi-tiered 24 hour knowledge user",
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
      "Name": "Koss, Marquardt and Schumm",
      "Description": "Multi-tiered 24 hour knowledge user",
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
    "Id": 228,
    "Value": "occaecati",
    "Tooltip": "veniam"
  },
  "UserGroup": {
    "Value": "in",
    "Tooltip": "nisi",
    "Id": 341,
    "Rank": 93,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "neque",
      "Tooltip": "omnis",
      "Id": 872,
      "Rank": 122,
      "Deleted": false
    },
    {
      "Value": "neque",
      "Tooltip": "omnis",
      "Id": 872,
      "Rank": 122,
      "Deleted": false
    }
  ],
  "Person": {
    "Position": "et",
    "PersonId": 351,
    "Mrmrs": "corporis",
    "Firstname": "Jerald",
    "Lastname": "Grady",
    "MiddleName": "Powlowski, Raynor and Nader",
    "Title": "eos",
    "Description": "Polarised motivating customer loyalty",
    "Email": "abagail.pfannerstill@kuvalisharber.uk",
    "FullName": "Hershel Hirthe",
    "DirectPhone": "366-668-6677 x188",
    "FormalName": "Thompson-Walter",
    "CountryId": 713,
    "ContactId": 835,
    "ContactName": "Romaguera, Pollich and Veum",
    "Retired": 558,
    "Rank": 763,
    "ActiveInterests": 460,
    "ContactDepartment": "",
    "ContactCountryId": 135,
    "ContactOrgNr": "1242231",
    "FaxPhone": "(571)758-0871 x77377",
    "MobilePhone": "1-675-368-4563 x182",
    "ContactPhone": "(782)823-7188",
    "AssociateName": "Satterfield, Bailey and Sauer",
    "AssociateId": 867,
    "UsePersonAddress": false,
    "ContactFax": "facere",
    "Kanafname": "rerum",
    "Kanalname": "laboriosam",
    "Post1": "quasi",
    "Post2": "et",
    "Post3": "dolores",
    "EmailName": "christian@beier.us",
    "ContactFullName": "Leone Hoeger",
    "ActiveErpLinks": 561,
    "TicketPriorityId": 442,
    "SupportLanguageId": 735,
    "SupportAssociateId": 530,
    "CategoryName": "VIP Customer"
  },
  "Deleted": false,
  "Lastlogin": "2003-02-13T15:05:43.1599002+01:00",
  "Lastlogout": "2008-05-14T15:05:43.1599002+02:00",
  "EjUserId": 973,
  "RequestSignature": "eligendi",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "ut",
      "DisplayValue": "occaecati"
    },
    {
      "Type": {},
      "Value": "ut",
      "DisplayValue": "occaecati"
    }
  ],
  "UserName": "Schroeder-Durgan",
  "TicketCategories": [
    {
      "Id": 857,
      "Name": "Weissnat-Graham",
      "ToolTip": "Autem eius.",
      "Deleted": false,
      "Rank": 96,
      "Type": "ducimus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "adipisci",
      "ColorBlock": 162,
      "ExtraInfo": "sed",
      "StyleHint": "numquam",
      "FullName": "Jammie McCullough"
    }
  ],
  "NickName": "Pfeffer Group",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "accusantium",
    "CustomFields2": "quia"
  },
  "PostSaveCommands": [
    {
      "Name": "Lebsack-Weissnat",
      "DisplayName": "Kihn-King",
      "Description": "Ameliorated high-level migration",
      "ToolTip": "Praesentium dolore dolorem possimus est quaerat et.",
      "Actions": "Implicit",
      "ActionData": "aut"
    },
    {
      "Name": "Lebsack-Weissnat",
      "DisplayName": "Kihn-King",
      "Description": "Ameliorated high-level migration",
      "ToolTip": "Praesentium dolore dolorem possimus est quaerat et.",
      "Actions": "Implicit",
      "ActionData": "aut"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 571,
  "Name": "Jacobson Inc and Sons",
  "Rank": 857,
  "Tooltip": "deleniti",
  "LicenseOwners": [
    {
      "Name": "Schneider-Harris",
      "Description": "Versatile stable framework",
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
          "FieldLength": 635
        }
      }
    },
    {
      "Name": "Schneider-Harris",
      "Description": "Versatile stable framework",
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
          "FieldLength": 635
        }
      }
    }
  ],
  "Role": {
    "Id": 5,
    "Value": "illo",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 242
      }
    }
  },
  "UserGroup": {
    "Value": "qui",
    "Tooltip": "assumenda",
    "Id": 666,
    "Rank": 237,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 680
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "dolores",
      "Tooltip": "dolorem",
      "Id": 68,
      "Rank": 144,
      "Deleted": false,
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
  "Person": {
    "Position": "provident",
    "PersonId": 588,
    "Mrmrs": "odit",
    "Firstname": "Kim",
    "Lastname": "Kohler",
    "MiddleName": "Prohaska, Walker and Friesen",
    "Title": "ad",
    "Description": "Total fault-tolerant algorithm",
    "Email": "mollie_schowalter@hauck.com",
    "FullName": "Jude Torp",
    "DirectPhone": "540-788-5613 x14038",
    "FormalName": "Daugherty, Thompson and Glover",
    "CountryId": 275,
    "ContactId": 680,
    "ContactName": "Hamill Group",
    "Retired": 236,
    "Rank": 434,
    "ActiveInterests": 150,
    "ContactDepartment": "",
    "ContactCountryId": 597,
    "ContactOrgNr": "1119282",
    "FaxPhone": "652.274.5226 x725",
    "MobilePhone": "(663)105-2514",
    "ContactPhone": "1-255-780-7647",
    "AssociateName": "Casper-Predovic",
    "AssociateId": 879,
    "UsePersonAddress": false,
    "ContactFax": "hic",
    "Kanafname": "doloribus",
    "Kanalname": "quasi",
    "Post1": "voluptatibus",
    "Post2": "ea",
    "Post3": "esse",
    "EmailName": "berry@block.info",
    "ContactFullName": "Karlie Towne Jr.",
    "ActiveErpLinks": 521,
    "TicketPriorityId": 346,
    "SupportLanguageId": 591,
    "SupportAssociateId": 56,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 253
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2002-10-02T15:05:43.1668995+02:00",
  "Lastlogout": "2013-05-01T15:05:43.1668995+02:00",
  "EjUserId": 301,
  "RequestSignature": "corporis",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "eius",
      "DisplayValue": "at",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    },
    {
      "Type": {},
      "Value": "eius",
      "DisplayValue": "at",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    }
  ],
  "UserName": "Emard-Reynolds",
  "TicketCategories": [
    {
      "Id": 8,
      "Name": "Marks-Harris",
      "ToolTip": "Eius et harum in velit quas veritatis.",
      "Deleted": false,
      "Rank": 464,
      "Type": "similique",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "illo",
      "ColorBlock": 751,
      "ExtraInfo": "ducimus",
      "StyleHint": "iste",
      "FullName": "Mrs. Elroy Dietrich",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 611
        }
      }
    }
  ],
  "NickName": "Skiles, Quigley and Frami",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "doloremque"
  },
  "PostSaveCommands": [
    {
      "Name": "Crona-Batz",
      "DisplayName": "Morissette-Cartwright",
      "Description": "Organized fault-tolerant secured line",
      "ToolTip": "Quis quisquam temporibus.",
      "Actions": "Implicit",
      "ActionData": "non",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 500
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
      "FieldLength": 507
    }
  }
}
```