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
GET /api/v1/User/Default?personId=72
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
  "AssociateId": 211,
  "Name": "Keeling Inc and Sons",
  "Rank": 413,
  "Tooltip": "magnam",
  "LicenseOwners": [
    {
      "Name": "Murazik-Borer",
      "Description": "Ergonomic national capability",
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
          "FieldLength": 6
        }
      }
    },
    {
      "Name": "Murazik-Borer",
      "Description": "Ergonomic national capability",
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
          "FieldLength": 6
        }
      }
    }
  ],
  "Role": {
    "Id": 562,
    "Value": "minima",
    "Tooltip": "quidem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incentivize customized markets"
        },
        "FieldType": "System.Int32",
        "FieldLength": 910
      }
    }
  },
  "UserGroup": {
    "Value": "veniam",
    "Tooltip": "praesentium",
    "Id": 623,
    "Rank": 639,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 843
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "quaerat",
      "Tooltip": "qui",
      "Id": 485,
      "Rank": 136,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 725
        }
      }
    }
  ],
  "Person": {
    "Position": "quo",
    "PersonId": 407,
    "Mrmrs": "sunt",
    "Firstname": "Beverly",
    "Lastname": "Gleichner",
    "MiddleName": "Langworth, Mayer and Schowalter",
    "Title": "recusandae",
    "Description": "Self-enabling client-driven conglomeration",
    "Email": "kamren.hoppe@wunsch.co.uk",
    "FullName": "Juston Johnson MD",
    "DirectPhone": "1-646-880-3020",
    "FormalName": "Koelpin-Watsica",
    "CountryId": 64,
    "ContactId": 267,
    "ContactName": "Kuvalis-D'Amore",
    "Retired": 778,
    "Rank": 307,
    "ActiveInterests": 915,
    "ContactDepartment": "",
    "ContactCountryId": 42,
    "ContactOrgNr": "1185830",
    "FaxPhone": "252-106-5770 x1686",
    "MobilePhone": "124-481-8765 x35310",
    "ContactPhone": "(043)766-1077 x021",
    "AssociateName": "Rogahn Inc and Sons",
    "AssociateId": 31,
    "UsePersonAddress": true,
    "ContactFax": "qui",
    "Kanafname": "sed",
    "Kanalname": "molestiae",
    "Post1": "quod",
    "Post2": "sint",
    "Post3": "illo",
    "EmailName": "lenore@mraz.ca",
    "ContactFullName": "Antonetta Jones",
    "ActiveErpLinks": 99,
    "TicketPriorityId": 455,
    "SupportLanguageId": 690,
    "SupportAssociateId": 48,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 455
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2017-10-18T18:25:51.5401211+02:00",
  "Lastlogout": "2005-01-31T18:25:51.5401211+01:00",
  "EjUserId": 898,
  "RequestSignature": "iste",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "et",
      "DisplayValue": "ratione",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    },
    {
      "Type": {},
      "Value": "et",
      "DisplayValue": "ratione",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    }
  ],
  "UserName": "Johnson-Mann",
  "TicketCategories": [
    {
      "Id": 187,
      "Name": "Mohr-Brakus",
      "ToolTip": "Quia ex aut et.",
      "Deleted": false,
      "Rank": 355,
      "Type": "architecto",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "laborum",
      "ColorBlock": 534,
      "ExtraInfo": "ipsam",
      "StyleHint": "quaerat",
      "FullName": "Carolyn Johnston",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    }
  ],
  "NickName": "Bruen-Towne",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "corrupti"
  },
  "PostSaveCommands": [
    {
      "Name": "Doyle Group",
      "DisplayName": "Haag-Mayert",
      "Description": "Synchronised user-facing ability",
      "ToolTip": "Aut ea.",
      "Actions": "Implicit",
      "ActionData": "neque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 941
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
      "FieldLength": 542
    }
  }
}
```