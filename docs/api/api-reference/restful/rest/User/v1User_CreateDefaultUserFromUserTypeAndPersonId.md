---
title: GET User/Default
id: v1User_CreateDefaultUserFromUserTypeAndPersonId
---

# GET User/Default

```http
GET /api/v1/User/Default
```

Create default User providing the associate type and person id.

System and Anonymous users can be created without an exsisting person and permits person id to be 0.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| userType | Enum: Unknown, InternalAssociate, ResourceAssociate, ExternalAssociate, AnonymousAssociate, SystemAssociate |  Type of associate for the user |
| personId | int32 |  Primary key of the person to become a user. |

```http
GET /api/v1/User/Default?userType=AnonymousAssociate
GET /api/v1/User/Default?personId=799
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
GET /api/v1/User/Default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 67,
  "Name": "Hartmann, Crona and Koelpin",
  "Rank": 855,
  "Tooltip": "delectus",
  "LicenseOwners": [
    {
      "Name": "Collins LLC",
      "Description": "Down-sized clear-thinking hardware",
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
          "FieldLength": 424
        }
      }
    },
    {
      "Name": "Collins LLC",
      "Description": "Down-sized clear-thinking hardware",
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
          "FieldLength": 424
        }
      }
    }
  ],
  "Role": {
    "Id": 620,
    "Value": "autem",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 590
      }
    }
  },
  "UserGroup": {
    "Value": "exercitationem",
    "Tooltip": "voluptate",
    "Id": 972,
    "Rank": 57,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 652
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "quas",
      "Tooltip": "molestiae",
      "Id": 618,
      "Rank": 1001,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 740
        }
      }
    }
  ],
  "Person": {
    "Position": "dolores",
    "PersonId": 713,
    "Mrmrs": "eum",
    "Firstname": "Rodrigo",
    "Lastname": "Schmitt",
    "MiddleName": "Nicolas, Jacobson and Gaylord",
    "Title": "sunt",
    "Description": "Progressive even-keeled parallelism",
    "Email": "carmel@schumm.co.uk",
    "FullName": "Ferne Bruen",
    "DirectPhone": "1-352-267-7037 x672",
    "FormalName": "Schroeder Group",
    "CountryId": 777,
    "ContactId": 249,
    "ContactName": "Ferry, Dickens and Romaguera",
    "Retired": 268,
    "Rank": 275,
    "ActiveInterests": 57,
    "ContactDepartment": "",
    "ContactCountryId": 163,
    "ContactOrgNr": "1187107",
    "FaxPhone": "730-241-4363 x30240",
    "MobilePhone": "800.520.4725 x381",
    "ContactPhone": "686.583.7865 x3343",
    "AssociateName": "Boyle, Klein and Robel",
    "AssociateId": 248,
    "UsePersonAddress": true,
    "ContactFax": "nesciunt",
    "Kanafname": "impedit",
    "Kanalname": "consequatur",
    "Post1": "voluptatem",
    "Post2": "eos",
    "Post3": "excepturi",
    "EmailName": "tatyana@kertzmannhills.biz",
    "ContactFullName": "Marquise Rolfson",
    "ActiveErpLinks": 30,
    "TicketPriorityId": 313,
    "SupportLanguageId": 354,
    "SupportAssociateId": 172,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 35
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2017-05-20T15:05:43.1748996+02:00",
  "Lastlogout": "2004-03-08T15:05:43.1748996+01:00",
  "EjUserId": 725,
  "RequestSignature": "dolorem",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "ipsum",
      "DisplayValue": "distinctio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 890
        }
      }
    },
    {
      "Type": {},
      "Value": "ipsum",
      "DisplayValue": "distinctio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 890
        }
      }
    }
  ],
  "UserName": "Muller Group",
  "TicketCategories": [
    {
      "Id": 402,
      "Name": "Quitzon, Dickinson and Luettgen",
      "ToolTip": "Earum pariatur perspiciatis ut perspiciatis nemo.",
      "Deleted": false,
      "Rank": 117,
      "Type": "nihil",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "temporibus",
      "ColorBlock": 504,
      "ExtraInfo": "aspernatur",
      "StyleHint": "commodi",
      "FullName": "Gay Cruickshank",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "grow web-enabled solutions"
          },
          "FieldType": "System.String",
          "FieldLength": 876
        }
      }
    }
  ],
  "NickName": "Murray LLC",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "non"
  },
  "PostSaveCommands": [
    {
      "Name": "Schulist, Littel and Brekke",
      "DisplayName": "Robel Inc and Sons",
      "Description": "Public-key interactive neural-net",
      "ToolTip": "Consequatur aperiam.",
      "Actions": "Implicit",
      "ActionData": "est",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 258
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
      "FieldLength": 260
    }
  }
}
```