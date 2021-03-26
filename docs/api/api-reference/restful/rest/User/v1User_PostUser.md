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
  "AssociateId": 628,
  "Name": "Hoeger LLC",
  "Rank": 373,
  "Tooltip": "molestiae",
  "LicenseOwners": [
    {
      "Name": "Wehner-Funk",
      "Description": "Enhanced neutral forecast",
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
      "Name": "Wehner-Funk",
      "Description": "Enhanced neutral forecast",
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
    "Id": 724,
    "Value": "quaerat",
    "Tooltip": "perspiciatis"
  },
  "UserGroup": {
    "Value": "ut",
    "Tooltip": "esse",
    "Id": 727,
    "Rank": 238,
    "Deleted": false
  },
  "OtherGroups": [
    {
      "Value": "maiores",
      "Tooltip": "qui",
      "Id": 282,
      "Rank": 784,
      "Deleted": true
    },
    {
      "Value": "maiores",
      "Tooltip": "qui",
      "Id": 282,
      "Rank": 784,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "qui",
    "PersonId": 610,
    "Mrmrs": "nihil",
    "Firstname": "Eddie",
    "Lastname": "Lind",
    "MiddleName": "Bernhard Inc and Sons",
    "Title": "iste",
    "Description": "Front-line value-added matrices",
    "Email": "charlene_sauer@kozey.info",
    "FullName": "Eleanora Conroy DDS",
    "DirectPhone": "(444)541-3417 x74057",
    "FormalName": "Johns Inc and Sons",
    "CountryId": 938,
    "ContactId": 774,
    "ContactName": "Jacobs, Roberts and Considine",
    "Retired": 500,
    "Rank": 699,
    "ActiveInterests": 634,
    "ContactDepartment": "",
    "ContactCountryId": 55,
    "ContactOrgNr": "1050917",
    "FaxPhone": "(454)563-0140",
    "MobilePhone": "(272)086-3711 x000",
    "ContactPhone": "316.454.6148 x3025",
    "AssociateName": "Boehm Group",
    "AssociateId": 257,
    "UsePersonAddress": false,
    "ContactFax": "iusto",
    "Kanafname": "velit",
    "Kanalname": "est",
    "Post1": "et",
    "Post2": "non",
    "Post3": "molestias",
    "EmailName": "jane_gottlieb@hagenes.info",
    "ContactFullName": "Nicolette Botsford",
    "ActiveErpLinks": 295,
    "TicketPriorityId": 328,
    "SupportLanguageId": 722,
    "SupportAssociateId": 883,
    "CategoryName": "VIP Customer"
  },
  "Deleted": true,
  "Lastlogin": "1999-12-16T09:41:00.0090591+01:00",
  "Lastlogout": "2001-08-24T09:41:00.0090591+02:00",
  "EjUserId": 44,
  "RequestSignature": "placeat",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "a",
      "DisplayValue": "facere"
    },
    {
      "Type": {},
      "Value": "a",
      "DisplayValue": "facere"
    }
  ],
  "UserName": "Stokes-Brekke",
  "TicketCategories": [
    {
      "Id": 690,
      "Name": "Kohler-Reichert",
      "ToolTip": "Deleniti vel saepe est eaque.",
      "Deleted": true,
      "Rank": 248,
      "Type": "nisi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "officiis",
      "ColorBlock": 899,
      "ExtraInfo": "cum",
      "StyleHint": "necessitatibus",
      "FullName": "Letitia Rosenbaum"
    }
  ],
  "NickName": "Hane-Konopelski",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "sequi",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "facilis",
    "CustomFields2": "illum"
  },
  "PostSaveCommands": [
    {
      "Name": "Zulauf, Hane and Walsh",
      "DisplayName": "Schuster-Glover",
      "Description": "Inverse encompassing system engine",
      "ToolTip": "Maiores sunt dicta quaerat voluptates et sit.",
      "Actions": "Implicit",
      "ActionData": "eos"
    },
    {
      "Name": "Zulauf, Hane and Walsh",
      "DisplayName": "Schuster-Glover",
      "Description": "Inverse encompassing system engine",
      "ToolTip": "Maiores sunt dicta quaerat voluptates et sit.",
      "Actions": "Implicit",
      "ActionData": "eos"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 240,
  "Name": "Hagenes LLC",
  "Rank": 656,
  "Tooltip": "non",
  "LicenseOwners": [
    {
      "Name": "Prohaska LLC",
      "Description": "User-friendly multi-state knowledge user",
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
          "FieldLength": 696
        }
      }
    },
    {
      "Name": "Prohaska LLC",
      "Description": "User-friendly multi-state knowledge user",
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
          "FieldLength": 696
        }
      }
    }
  ],
  "Role": {
    "Id": 19,
    "Value": "earum",
    "Tooltip": "sed",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 396
      }
    }
  },
  "UserGroup": {
    "Value": "corporis",
    "Tooltip": "velit",
    "Id": 553,
    "Rank": 996,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 237
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "dolor",
      "Tooltip": "voluptas",
      "Id": 761,
      "Rank": 534,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "leverage ubiquitous partnerships"
          },
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "Person": {
    "Position": "rerum",
    "PersonId": 878,
    "Mrmrs": "quia",
    "Firstname": "Julian",
    "Lastname": "Romaguera",
    "MiddleName": "Gerlach Group",
    "Title": "nesciunt",
    "Description": "Object-based zero defect time-frame",
    "Email": "anais_sauer@stroman.com",
    "FullName": "Krystina Altenwerth",
    "DirectPhone": "123.100.4016",
    "FormalName": "Oberbrunner-Kreiger",
    "CountryId": 629,
    "ContactId": 522,
    "ContactName": "Conroy LLC",
    "Retired": 33,
    "Rank": 511,
    "ActiveInterests": 204,
    "ContactDepartment": "",
    "ContactCountryId": 112,
    "ContactOrgNr": "736883",
    "FaxPhone": "(271)634-4380",
    "MobilePhone": "304.474.3013 x264",
    "ContactPhone": "744-161-0776",
    "AssociateName": "Wunsch-Kerluke",
    "AssociateId": 348,
    "UsePersonAddress": false,
    "ContactFax": "sed",
    "Kanafname": "corrupti",
    "Kanalname": "quo",
    "Post1": "perspiciatis",
    "Post2": "aliquid",
    "Post3": "maxime",
    "EmailName": "claude@blick.biz",
    "ContactFullName": "Wilson Armstrong",
    "ActiveErpLinks": 173,
    "TicketPriorityId": 241,
    "SupportLanguageId": 920,
    "SupportAssociateId": 535,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 963
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2019-05-14T09:41:00.0180596+02:00",
  "Lastlogout": "2020-09-10T09:41:00.0180596+02:00",
  "EjUserId": 233,
  "RequestSignature": "ut",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "nisi",
      "DisplayValue": "provident",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    },
    {
      "Type": {},
      "Value": "nisi",
      "DisplayValue": "provident",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "UserName": "VonRueden, Mosciski and Kautzer",
  "TicketCategories": [
    {
      "Id": 369,
      "Name": "Stoltenberg, Tillman and Buckridge",
      "ToolTip": "Qui similique sequi sequi aliquam possimus consequatur.",
      "Deleted": true,
      "Rank": 878,
      "Type": "beatae",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "nam",
      "ColorBlock": 473,
      "ExtraInfo": "autem",
      "StyleHint": "eos",
      "FullName": "Jaylen Harber",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    }
  ],
  "NickName": "D'Amore-Legros",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "nam"
  },
  "PostSaveCommands": [
    {
      "Name": "Bogisich Inc and Sons",
      "DisplayName": "Hessel-Watsica",
      "Description": "Profit-focused motivating initiative",
      "ToolTip": "Ratione excepturi sunt.",
      "Actions": "Implicit",
      "ActionData": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 22
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
      "FieldLength": 976
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```