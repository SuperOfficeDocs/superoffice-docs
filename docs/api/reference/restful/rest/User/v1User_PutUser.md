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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 305,
  "Name": "Corkery Inc and Sons",
  "Rank": 376,
  "Tooltip": "sed",
  "LicenseOwners": [
    {
      "Name": "Wintheiser, Sanford and Dare",
      "Description": "Balanced tertiary functionalities",
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
      "Name": "Wintheiser, Sanford and Dare",
      "Description": "Balanced tertiary functionalities",
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
    "Id": 229,
    "Value": "illo",
    "Tooltip": "rerum"
  },
  "UserGroup": {
    "Value": "quaerat",
    "Tooltip": "delectus",
    "Id": 84,
    "Rank": 358,
    "Deleted": false
  },
  "OtherGroups": [
    {
      "Value": "explicabo",
      "Tooltip": "sed",
      "Id": 632,
      "Rank": 630,
      "Deleted": true
    },
    {
      "Value": "explicabo",
      "Tooltip": "sed",
      "Id": 632,
      "Rank": 630,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "et",
    "PersonId": 336,
    "Mrmrs": "facilis",
    "Firstname": "Eryn",
    "Lastname": "Emard",
    "MiddleName": "Rodriguez, Crist and Block",
    "Title": "voluptatum",
    "Description": "Public-key optimal analyzer",
    "Email": "kaylah@lang.com",
    "FullName": "Mr. Tremayne Kuvalis",
    "DirectPhone": "1-057-148-3588 x306",
    "FormalName": "Langosh-Wintheiser",
    "CountryId": 890,
    "ContactId": 948,
    "ContactName": "Denesik, Christiansen and Batz",
    "Retired": 659,
    "Rank": 565,
    "ActiveInterests": 703,
    "ContactDepartment": "drive real-time e-commerce",
    "ContactCountryId": 237,
    "ContactOrgNr": "1576175",
    "FaxPhone": "661-285-4211 x31877",
    "MobilePhone": "111-023-8824 x318",
    "ContactPhone": "516.107.3583 x28872",
    "AssociateName": "Schaefer-Hartmann",
    "AssociateId": 908,
    "UsePersonAddress": true,
    "ContactFax": "accusantium",
    "Kanafname": "et",
    "Kanalname": "voluptatem",
    "Post1": "dolor",
    "Post2": "corrupti",
    "Post3": "voluptate",
    "EmailName": "celestine@hackettkessler.biz",
    "ContactFullName": "Antonio Bartoletti",
    "ActiveErpLinks": 564,
    "TicketPriorityId": 255,
    "SupportLanguageId": 761,
    "SupportAssociateId": 727,
    "CategoryName": "VIP Customer"
  },
  "Deleted": true,
  "Lastlogin": "2010-03-19T18:25:51.4651177+01:00",
  "Lastlogout": "2019-01-16T18:25:51.4651177+01:00",
  "EjUserId": 734,
  "RequestSignature": "expedita",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "harum",
      "DisplayValue": "ab"
    },
    {
      "Type": {},
      "Value": "harum",
      "DisplayValue": "ab"
    }
  ],
  "UserName": "Schiller, Carter and Douglas",
  "TicketCategories": [
    {
      "Id": 632,
      "Name": "Dooley-Walker",
      "ToolTip": "Vel autem repudiandae reiciendis et.",
      "Deleted": false,
      "Rank": 835,
      "Type": "quo",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "doloribus",
      "ColorBlock": 929,
      "ExtraInfo": "quo",
      "StyleHint": "dignissimos",
      "FullName": "Rhianna Berge Sr."
    }
  ],
  "NickName": "Mertz-Swaniawski",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "tenetur"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "natus"
  },
  "PostSaveCommands": [
    {
      "Name": "Simonis, Moore and Rempel",
      "DisplayName": "Torphy, Medhurst and Kub",
      "Description": "Intuitive multi-tasking policy",
      "ToolTip": "Eum quia culpa tenetur sed possimus totam.",
      "Actions": "Implicit",
      "ActionData": "facere"
    },
    {
      "Name": "Simonis, Moore and Rempel",
      "DisplayName": "Torphy, Medhurst and Kub",
      "Description": "Intuitive multi-tasking policy",
      "ToolTip": "Eum quia culpa tenetur sed possimus totam.",
      "Actions": "Implicit",
      "ActionData": "facere"
    }
  ]
}
```

```http_
HTTP/1.1 200 User updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 723,
  "Name": "Grimes-Roberts",
  "Rank": 121,
  "Tooltip": "non",
  "LicenseOwners": [
    {
      "Name": "Gibson-Witting",
      "Description": "Face to face neutral project",
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
          "FieldLength": 367
        }
      }
    },
    {
      "Name": "Gibson-Witting",
      "Description": "Face to face neutral project",
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
          "FieldLength": 367
        }
      }
    }
  ],
  "Role": {
    "Id": 925,
    "Value": "suscipit",
    "Tooltip": "quam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 917
      }
    }
  },
  "UserGroup": {
    "Value": "et",
    "Tooltip": "quos",
    "Id": 18,
    "Rank": 15,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 675
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "repudiandae",
      "Tooltip": "et",
      "Id": 691,
      "Rank": 753,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 778
        }
      }
    }
  ],
  "Person": {
    "Position": "ea",
    "PersonId": 240,
    "Mrmrs": "sint",
    "Firstname": "Lourdes",
    "Lastname": "Hammes",
    "MiddleName": "Rowe Group",
    "Title": "sed",
    "Description": "Extended dynamic model",
    "Email": "vergie.kuhlman@schambergerparisian.ca",
    "FullName": "Adele Reichel",
    "DirectPhone": "1-365-460-7542 x605",
    "FormalName": "Kirlin LLC",
    "CountryId": 795,
    "ContactId": 15,
    "ContactName": "Wolff, Kshlerin and Beahan",
    "Retired": 982,
    "Rank": 117,
    "ActiveInterests": 702,
    "ContactDepartment": "",
    "ContactCountryId": 476,
    "ContactOrgNr": "1258863",
    "FaxPhone": "821-085-1321 x35142",
    "MobilePhone": "833.362.2603",
    "ContactPhone": "(462)583-6338 x4171",
    "AssociateName": "Rodriguez-Leuschke",
    "AssociateId": 587,
    "UsePersonAddress": false,
    "ContactFax": "laudantium",
    "Kanafname": "provident",
    "Kanalname": "consequuntur",
    "Post1": "non",
    "Post2": "sunt",
    "Post3": "qui",
    "EmailName": "kris@metz.ca",
    "ContactFullName": "Dianna Jenkins",
    "ActiveErpLinks": 165,
    "TicketPriorityId": 866,
    "SupportLanguageId": 269,
    "SupportAssociateId": 453,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 393
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2001-01-24T18:25:51.4721496+01:00",
  "Lastlogout": "2017-08-05T18:25:51.4721496+02:00",
  "EjUserId": 219,
  "RequestSignature": "tempora",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "dolore",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    },
    {
      "Type": {},
      "Value": "dolore",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    }
  ],
  "UserName": "Tillman-Morissette",
  "TicketCategories": [
    {
      "Id": 682,
      "Name": "Walker, Bogan and Mann",
      "ToolTip": "Ullam asperiores voluptatem quia sint.",
      "Deleted": true,
      "Rank": 803,
      "Type": "asperiores",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "exercitationem",
      "ColorBlock": 838,
      "ExtraInfo": "quo",
      "StyleHint": "laudantium",
      "FullName": "Cicero Funk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 482
        }
      }
    }
  ],
  "NickName": "Bashirian, O'Keefe and Murray",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "quasi"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "libero"
  },
  "PostSaveCommands": [
    {
      "Name": "Lowe, Lang and Brown",
      "DisplayName": "Yost-Schamberger",
      "Description": "Customer-focused bottom-line leverage",
      "ToolTip": "Ipsum nobis eius iure.",
      "Actions": "Implicit",
      "ActionData": "voluptas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 445
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
      "FieldLength": 144
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```