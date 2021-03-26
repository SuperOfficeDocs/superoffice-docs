---
title: POST Agents/User/GetUser
id: v1UserAgent_GetUser
---

# POST Agents/User/GetUser

```http
POST /api/v1/Agents/User/GetUser
```

Gets a User object.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| userId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUser?userId=344
POST /api/v1/Agents/User/GetUser?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/User/GetUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 135,
  "Name": "Stamm, Mills and Haag",
  "Rank": 649,
  "Tooltip": "a",
  "LicenseOwners": [
    {
      "Name": "Morar Group",
      "Description": "Decentralized bi-directional benchmark",
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
          "FieldLength": 99
        }
      }
    },
    {
      "Name": "Morar Group",
      "Description": "Decentralized bi-directional benchmark",
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
          "FieldLength": 99
        }
      }
    }
  ],
  "Role": {
    "Id": 328,
    "Value": "dignissimos",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 688
      }
    }
  },
  "UserGroup": {
    "Value": "ullam",
    "Tooltip": "reprehenderit",
    "Id": 505,
    "Rank": 623,
    "Deleted": false,
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
      "Value": "perspiciatis",
      "Tooltip": "aspernatur",
      "Id": 870,
      "Rank": 547,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 530
        }
      }
    }
  ],
  "Person": {
    "Position": "atque",
    "PersonId": 474,
    "Mrmrs": "cumque",
    "Firstname": "Rico",
    "Lastname": "Stiedemann",
    "MiddleName": "Haley Inc and Sons",
    "Title": "sapiente",
    "Description": "Integrated multi-state capacity",
    "Email": "damien@mantekozey.com",
    "FullName": "Thelma Hilpert DDS",
    "DirectPhone": "337.240.8564 x87867",
    "FormalName": "Brown Group",
    "CountryId": 5,
    "ContactId": 585,
    "ContactName": "Kertzmann, Quitzon and Hamill",
    "Retired": 27,
    "Rank": 346,
    "ActiveInterests": 919,
    "ContactDepartment": "",
    "ContactCountryId": 400,
    "ContactOrgNr": "961045",
    "FaxPhone": "1-764-440-5506",
    "MobilePhone": "523.576.7023 x11864",
    "ContactPhone": "(116)228-7012",
    "AssociateName": "Schuppe-Block",
    "AssociateId": 8,
    "UsePersonAddress": true,
    "ContactFax": "architecto",
    "Kanafname": "inventore",
    "Kanalname": "libero",
    "Post1": "vitae",
    "Post2": "iste",
    "Post3": "enim",
    "EmailName": "maeve_mccullough@weissnat.uk",
    "ContactFullName": "Josianne Padberg",
    "ActiveErpLinks": 702,
    "TicketPriorityId": 492,
    "SupportLanguageId": 351,
    "SupportAssociateId": 431,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 19
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "1994-03-10T16:48:30.9789341+01:00",
  "Lastlogout": "2004-02-06T16:48:30.9789341+01:00",
  "EjUserId": 59,
  "RequestSignature": "quidem",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "aut",
      "DisplayValue": "doloribus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "facilitate front-end bandwidth"
          },
          "FieldType": "System.String",
          "FieldLength": 880
        }
      }
    },
    {
      "Type": {},
      "Value": "aut",
      "DisplayValue": "doloribus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "facilitate front-end bandwidth"
          },
          "FieldType": "System.String",
          "FieldLength": 880
        }
      }
    }
  ],
  "UserName": "Ledner Group",
  "TicketCategories": [
    {
      "Id": 250,
      "Name": "Schinner-Herzog",
      "ToolTip": "Voluptatem ullam dolores incidunt sed.",
      "Deleted": true,
      "Rank": 72,
      "Type": "aperiam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptatem",
      "ColorBlock": 118,
      "ExtraInfo": "sit",
      "StyleHint": "laboriosam",
      "FullName": "Rollin Paucek Jr.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 923
        }
      }
    }
  ],
  "NickName": "Conroy, Quitzon and Rau",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "animi"
  },
  "PostSaveCommands": [
    {
      "Name": "Conroy, Quigley and Maggio",
      "DisplayName": "Halvorson-Barton",
      "Description": "Open-architected holistic hub",
      "ToolTip": "Et animi.",
      "Actions": "Implicit",
      "ActionData": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "monetize bleeding-edge interfaces"
          },
          "FieldType": "System.Int32",
          "FieldLength": 396
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
      "FieldLength": 518
    }
  }
}
```