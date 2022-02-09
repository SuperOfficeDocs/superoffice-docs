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
  "AssociateId": 914,
  "Name": "Ritchie-Runolfsdottir",
  "Rank": 963,
  "Tooltip": "ipsam",
  "LicenseOwners": [
    {
      "Name": "Predovic, Fahey and Emmerich",
      "Description": "Mandatory tertiary challenge",
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
      "Name": "Predovic, Fahey and Emmerich",
      "Description": "Mandatory tertiary challenge",
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
    "Id": 882,
    "Value": "sint",
    "Tooltip": "recusandae"
  },
  "UserGroup": {
    "Value": "quia",
    "Tooltip": "delectus",
    "Id": 144,
    "Rank": 975,
    "Deleted": false
  },
  "OtherGroups": [
    {
      "Value": "velit",
      "Tooltip": "et",
      "Id": 806,
      "Rank": 304,
      "Deleted": true
    },
    {
      "Value": "velit",
      "Tooltip": "et",
      "Id": 806,
      "Rank": 304,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "officiis",
    "PersonId": 688,
    "Mrmrs": "qui",
    "Firstname": "Damion",
    "Lastname": "Mante",
    "MiddleName": "Hoeger-Spencer",
    "Title": "enim",
    "Description": "Sharable upward-trending hierarchy",
    "Email": "merl@kuhntremblay.name",
    "FullName": "Cleora Lowe",
    "DirectPhone": "714.160.3827 x213",
    "FormalName": "Schneider LLC",
    "CountryId": 481,
    "ContactId": 793,
    "ContactName": "Wilkinson, Swaniawski and Cronin",
    "Retired": 843,
    "Rank": 393,
    "ActiveInterests": 807,
    "ContactDepartment": "",
    "ContactCountryId": 960,
    "ContactOrgNr": "718373",
    "FaxPhone": "561-800-0366",
    "MobilePhone": "340.112.5643 x525",
    "ContactPhone": "1-531-221-1401 x5040",
    "AssociateName": "Herman, Beahan and Bogan",
    "AssociateId": 119,
    "UsePersonAddress": true,
    "ContactFax": "nam",
    "Kanafname": "ut",
    "Kanalname": "odit",
    "Post1": "dolorum",
    "Post2": "voluptas",
    "Post3": "commodi",
    "EmailName": "chadrick.paucek@casper.uk",
    "ContactFullName": "Hazle Stroman",
    "ActiveErpLinks": 543,
    "TicketPriorityId": 142,
    "SupportLanguageId": 845,
    "SupportAssociateId": 499,
    "CategoryName": "VIP Customer"
  },
  "Deleted": false,
  "Lastlogin": "2017-01-24T18:28:50.4994428+01:00",
  "Lastlogout": "2012-05-04T18:28:50.4994428+02:00",
  "EjUserId": 528,
  "RequestSignature": "tempora",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "nihil",
      "DisplayValue": "est"
    },
    {
      "Type": {},
      "Value": "nihil",
      "DisplayValue": "est"
    }
  ],
  "UserName": "Murphy-Feest",
  "TicketCategories": [
    {
      "Id": 179,
      "Name": "Larkin Inc and Sons",
      "ToolTip": "Dicta quas molestiae dolorum voluptatum.",
      "Deleted": false,
      "Rank": 675,
      "Type": "eveniet",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "laudantium",
      "ColorBlock": 265,
      "ExtraInfo": "nihil",
      "StyleHint": "quos",
      "FullName": "Carrie Hagenes"
    }
  ],
  "NickName": "Keebler, Bradtke and VonRueden",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "dolorum"
  },
  "PostSaveCommands": [
    {
      "Name": "Sipes-Simonis",
      "DisplayName": "Jones, Ullrich and Reichert",
      "Description": "Fundamental intangible parallelism",
      "ToolTip": "Labore labore accusamus eum repellendus non.",
      "Actions": "Implicit",
      "ActionData": "sunt"
    },
    {
      "Name": "Sipes-Simonis",
      "DisplayName": "Jones, Ullrich and Reichert",
      "Description": "Fundamental intangible parallelism",
      "ToolTip": "Labore labore accusamus eum repellendus non.",
      "Actions": "Implicit",
      "ActionData": "sunt"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 272,
  "Name": "Muller-Adams",
  "Rank": 165,
  "Tooltip": "ducimus",
  "LicenseOwners": [
    {
      "Name": "Schumm-Kohler",
      "Description": "Stand-alone zero administration hardware",
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
          "FieldLength": 360
        }
      }
    },
    {
      "Name": "Schumm-Kohler",
      "Description": "Stand-alone zero administration hardware",
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
          "FieldLength": 360
        }
      }
    }
  ],
  "Role": {
    "Id": 911,
    "Value": "non",
    "Tooltip": "deserunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 667
      }
    }
  },
  "UserGroup": {
    "Value": "recusandae",
    "Tooltip": "ut",
    "Id": 315,
    "Rank": 566,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 307
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "quasi",
      "Tooltip": "perferendis",
      "Id": 663,
      "Rank": 907,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "Person": {
    "Position": "et",
    "PersonId": 58,
    "Mrmrs": "dolores",
    "Firstname": "Cory",
    "Lastname": "Aufderhar",
    "MiddleName": "Wisoky, Hodkiewicz and Rau",
    "Title": "quasi",
    "Description": "Open-architected optimizing implementation",
    "Email": "derrick@lemkecronin.co.uk",
    "FullName": "Mabel Smitham DVM",
    "DirectPhone": "660.874.8102",
    "FormalName": "Kautzer-Huels",
    "CountryId": 876,
    "ContactId": 683,
    "ContactName": "Walter-Zemlak",
    "Retired": 574,
    "Rank": 809,
    "ActiveInterests": 500,
    "ContactDepartment": "",
    "ContactCountryId": 438,
    "ContactOrgNr": "188090",
    "FaxPhone": "(586)330-1028",
    "MobilePhone": "(478)135-1678 x54525",
    "ContactPhone": "(167)287-7804",
    "AssociateName": "Torphy, Hand and Gorczany",
    "AssociateId": 384,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "ratione",
    "Kanalname": "nobis",
    "Post1": "ut",
    "Post2": "quis",
    "Post3": "dicta",
    "EmailName": "icie.christiansen@schowalter.uk",
    "ContactFullName": "Stella Marvin",
    "ActiveErpLinks": 34,
    "TicketPriorityId": 993,
    "SupportLanguageId": 97,
    "SupportAssociateId": 868,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 552
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2019-12-02T18:28:50.5574414+01:00",
  "Lastlogout": "2000-06-09T18:28:50.5574414+02:00",
  "EjUserId": 966,
  "RequestSignature": "excepturi",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "asperiores",
      "DisplayValue": "rerum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    },
    {
      "Type": {},
      "Value": "asperiores",
      "DisplayValue": "rerum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    }
  ],
  "UserName": "Conn-Langworth",
  "TicketCategories": [
    {
      "Id": 304,
      "Name": "Carroll Group",
      "ToolTip": "Et fugit et officia nostrum exercitationem.",
      "Deleted": false,
      "Rank": 942,
      "Type": "et",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "expedita",
      "ColorBlock": 152,
      "ExtraInfo": "ut",
      "StyleHint": "deleniti",
      "FullName": "Theodora Robel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    }
  ],
  "NickName": "Kuvalis-Kautzer",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "dolore",
    "ExtraFields2": "a"
  },
  "CustomFields": {
    "CustomFields1": "dolore",
    "CustomFields2": "in"
  },
  "PostSaveCommands": [
    {
      "Name": "Turner Inc and Sons",
      "DisplayName": "Bailey LLC",
      "Description": "User-friendly contextually-based circuit",
      "ToolTip": "Non incidunt ut ex qui ullam adipisci.",
      "Actions": "Implicit",
      "ActionData": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 787
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
      "FieldLength": 900
    }
  }
}
```