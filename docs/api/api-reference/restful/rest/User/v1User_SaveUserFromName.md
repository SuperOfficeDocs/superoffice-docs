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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 541,
  "Name": "Eichmann-Keebler",
  "Rank": 197,
  "Tooltip": "sed",
  "LicenseOwners": [
    {
      "Name": "Anderson, Howell and Tromp",
      "Description": "Persevering impactful policy",
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
      "Name": "Anderson, Howell and Tromp",
      "Description": "Persevering impactful policy",
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
    "Id": 82,
    "Value": "magni",
    "Tooltip": "ducimus"
  },
  "UserGroup": {
    "Value": "odit",
    "Tooltip": "itaque",
    "Id": 544,
    "Rank": 715,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "officiis",
      "Tooltip": "id",
      "Id": 492,
      "Rank": 104,
      "Deleted": true
    },
    {
      "Value": "officiis",
      "Tooltip": "id",
      "Id": 492,
      "Rank": 104,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "delectus",
    "PersonId": 665,
    "Mrmrs": "quae",
    "Firstname": "Amanda",
    "Lastname": "Jewess",
    "MiddleName": "Kassulke LLC",
    "Title": "quia",
    "Description": "Total leading edge encoding",
    "Email": "casper@emmerichdurgan.name",
    "FullName": "Oral Murphy",
    "DirectPhone": "(684)572-8732 x6380",
    "FormalName": "Barrows Group",
    "CountryId": 680,
    "ContactId": 332,
    "ContactName": "Hartmann, Schumm and Paucek",
    "Retired": 531,
    "Rank": 737,
    "ActiveInterests": 977,
    "ContactDepartment": "",
    "ContactCountryId": 273,
    "ContactOrgNr": "1208902",
    "FaxPhone": "1-107-208-4513 x3424",
    "MobilePhone": "1-138-117-4838 x2887",
    "ContactPhone": "580-553-1611",
    "AssociateName": "Beatty Inc and Sons",
    "AssociateId": 331,
    "UsePersonAddress": false,
    "ContactFax": "dignissimos",
    "Kanafname": "perferendis",
    "Kanalname": "qui",
    "Post1": "porro",
    "Post2": "et",
    "Post3": "sunt",
    "EmailName": "hilario@vonrueden.co.uk",
    "ContactFullName": "Jocelyn Kemmer",
    "ActiveErpLinks": 645,
    "TicketPriorityId": 944,
    "SupportLanguageId": 339,
    "SupportAssociateId": 76,
    "CategoryName": "VIP Customer"
  },
  "Deleted": false,
  "Lastlogin": "1999-03-25T18:25:51.4871186+01:00",
  "Lastlogout": "2020-06-12T18:25:51.4871186+02:00",
  "EjUserId": 28,
  "RequestSignature": "enim",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "reiciendis",
      "DisplayValue": "illo"
    },
    {
      "Type": {},
      "Value": "reiciendis",
      "DisplayValue": "illo"
    }
  ],
  "UserName": "Harber Inc and Sons",
  "TicketCategories": [
    {
      "Id": 943,
      "Name": "Skiles, Greenfelder and Nolan",
      "ToolTip": "Quia quia sed.",
      "Deleted": true,
      "Rank": 58,
      "Type": "quam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "et",
      "ColorBlock": 65,
      "ExtraInfo": "eligendi",
      "StyleHint": "totam",
      "FullName": "Bella Daugherty"
    }
  ],
  "NickName": "Krajcik-Bins",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "earum",
    "ExtraFields2": "facere"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "dolores"
  },
  "PostSaveCommands": [
    {
      "Name": "Brekke, Bayer and Keebler",
      "DisplayName": "Kuvalis Group",
      "Description": "Multi-tiered hybrid conglomeration",
      "ToolTip": "Repellat quisquam.",
      "Actions": "Implicit",
      "ActionData": "ut"
    },
    {
      "Name": "Brekke, Bayer and Keebler",
      "DisplayName": "Kuvalis Group",
      "Description": "Multi-tiered hybrid conglomeration",
      "ToolTip": "Repellat quisquam.",
      "Actions": "Implicit",
      "ActionData": "ut"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 375,
  "Name": "Watsica-Abernathy",
  "Rank": 594,
  "Tooltip": "inventore",
  "LicenseOwners": [
    {
      "Name": "Walter Group",
      "Description": "Diverse 24 hour secured line",
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
          "FieldLength": 758
        }
      }
    },
    {
      "Name": "Walter Group",
      "Description": "Diverse 24 hour secured line",
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
          "FieldLength": 758
        }
      }
    }
  ],
  "Role": {
    "Id": 381,
    "Value": "quo",
    "Tooltip": "veniam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 220
      }
    }
  },
  "UserGroup": {
    "Value": "enim",
    "Tooltip": "beatae",
    "Id": 927,
    "Rank": 649,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 855
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "sunt",
      "Tooltip": "omnis",
      "Id": 707,
      "Rank": 874,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    }
  ],
  "Person": {
    "Position": "sint",
    "PersonId": 58,
    "Mrmrs": "possimus",
    "Firstname": "Cheyenne",
    "Lastname": "Goldner",
    "MiddleName": "Reinger Inc and Sons",
    "Title": "autem",
    "Description": "Team-oriented regional capacity",
    "Email": "althea_rosenbaum@prohaska.uk",
    "FullName": "Cory Blick",
    "DirectPhone": "316.468.4804 x8063",
    "FormalName": "Miller, Kirlin and Donnelly",
    "CountryId": 138,
    "ContactId": 974,
    "ContactName": "Bailey-Medhurst",
    "Retired": 402,
    "Rank": 879,
    "ActiveInterests": 596,
    "ContactDepartment": "",
    "ContactCountryId": 956,
    "ContactOrgNr": "653505",
    "FaxPhone": "404-654-3582 x1755",
    "MobilePhone": "(127)285-0023 x4251",
    "ContactPhone": "583-738-1620 x052",
    "AssociateName": "Hettinger, Donnelly and Bailey",
    "AssociateId": 735,
    "UsePersonAddress": true,
    "ContactFax": "corporis",
    "Kanafname": "optio",
    "Kanalname": "accusantium",
    "Post1": "repellat",
    "Post2": "nostrum",
    "Post3": "quia",
    "EmailName": "jazmyn_pouros@kirlin.us",
    "ContactFullName": "Alexis Kunde",
    "ActiveErpLinks": 541,
    "TicketPriorityId": 238,
    "SupportLanguageId": 926,
    "SupportAssociateId": 51,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 192
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2005-10-02T18:25:51.5031195+02:00",
  "Lastlogout": "2010-07-06T18:25:51.5031195+02:00",
  "EjUserId": 766,
  "RequestSignature": "atque",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "sapiente",
      "DisplayValue": "rem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    },
    {
      "Type": {},
      "Value": "sapiente",
      "DisplayValue": "rem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    }
  ],
  "UserName": "Armstrong, Cruickshank and Rodriguez",
  "TicketCategories": [
    {
      "Id": 295,
      "Name": "Kiehn-Heidenreich",
      "ToolTip": "Perspiciatis praesentium voluptas reiciendis dolorum animi.",
      "Deleted": true,
      "Rank": 102,
      "Type": "et",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quisquam",
      "ColorBlock": 410,
      "ExtraInfo": "et",
      "StyleHint": "et",
      "FullName": "Oren Breitenberg",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    }
  ],
  "NickName": "Collier, Homenick and Rath",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "esse"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "sint"
  },
  "PostSaveCommands": [
    {
      "Name": "Friesen, Herzog and Lowe",
      "DisplayName": "Roob-Fritsch",
      "Description": "Self-enabling executive encryption",
      "ToolTip": "Et reiciendis quis a libero et.",
      "Actions": "Implicit",
      "ActionData": "explicabo",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 220
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
      "FieldLength": 305
    }
  }
}
```