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
GET /api/v1/User/Default?personId=89
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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 544,
  "Name": "Dickinson, Skiles and Raynor",
  "Rank": 496,
  "Tooltip": "aut",
  "LicenseOwners": [
    {
      "Name": "Wehner-Morissette",
      "Description": "Synergistic composite portal",
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
          "FieldLength": 425
        }
      }
    },
    {
      "Name": "Wehner-Morissette",
      "Description": "Synergistic composite portal",
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
          "FieldLength": 425
        }
      }
    }
  ],
  "Role": {
    "Id": 896,
    "Value": "veniam",
    "Tooltip": "odit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "repurpose proactive methodologies"
        },
        "FieldType": "System.String",
        "FieldLength": 423
      }
    }
  },
  "UserGroup": {
    "Value": "nam",
    "Tooltip": "commodi",
    "Id": 296,
    "Rank": 262,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 758
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "voluptas",
      "Tooltip": "laborum",
      "Id": 894,
      "Rank": 399,
      "Deleted": false,
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
  "Person": {
    "Position": "voluptatum",
    "PersonId": 268,
    "Mrmrs": "aut",
    "Firstname": "Erik",
    "Lastname": "Rohan",
    "MiddleName": "Kihn Inc and Sons",
    "Title": "amet",
    "Description": "Business-focused web-enabled core",
    "Email": "israel_ritchie@conroykling.uk",
    "FullName": "Dr. Jasper Funk",
    "DirectPhone": "208.130.5103",
    "FormalName": "Hilll-Harvey",
    "CountryId": 266,
    "ContactId": 994,
    "ContactName": "Predovic-Marvin",
    "Retired": 569,
    "Rank": 661,
    "ActiveInterests": 655,
    "ContactDepartment": "",
    "ContactCountryId": 526,
    "ContactOrgNr": "1042650",
    "FaxPhone": "540-212-0563 x237",
    "MobilePhone": "206.013.2747 x32854",
    "ContactPhone": "435.840.0721 x2745",
    "AssociateName": "Herzog-Rosenbaum",
    "AssociateId": 602,
    "UsePersonAddress": true,
    "ContactFax": "repellendus",
    "Kanafname": "ad",
    "Kanalname": "aut",
    "Post1": "vitae",
    "Post2": "ut",
    "Post3": "esse",
    "EmailName": "afton@schuppe.info",
    "ContactFullName": "Christian Abshire",
    "ActiveErpLinks": 900,
    "TicketPriorityId": 865,
    "SupportLanguageId": 55,
    "SupportAssociateId": 77,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 416
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2007-07-12T09:41:00.0930589+02:00",
  "Lastlogout": "2012-09-24T09:41:00.0930589+02:00",
  "EjUserId": 229,
  "RequestSignature": "aut",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "soluta",
      "DisplayValue": "autem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 819
        }
      }
    },
    {
      "Type": {},
      "Value": "soluta",
      "DisplayValue": "autem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 819
        }
      }
    }
  ],
  "UserName": "Metz, Schmidt and Macejkovic",
  "TicketCategories": [
    {
      "Id": 658,
      "Name": "Bode, Deckow and Macejkovic",
      "ToolTip": "Natus modi eos culpa odio labore officiis.",
      "Deleted": false,
      "Rank": 354,
      "Type": "magnam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "reiciendis",
      "ColorBlock": 695,
      "ExtraInfo": "veniam",
      "StyleHint": "quo",
      "FullName": "Coy Weimann IV",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 728
        }
      }
    }
  ],
  "NickName": "Stehr Inc and Sons",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "ipsa",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "veniam"
  },
  "PostSaveCommands": [
    {
      "Name": "Sawayn Group",
      "DisplayName": "Bartoletti LLC",
      "Description": "Organic non-volatile middleware",
      "ToolTip": "Repudiandae autem.",
      "Actions": "Implicit",
      "ActionData": "accusantium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 883
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
      "FieldLength": 611
    }
  }
}
```