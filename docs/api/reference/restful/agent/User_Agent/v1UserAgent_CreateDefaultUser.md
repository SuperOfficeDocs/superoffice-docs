---
title: POST Agents/User/CreateDefaultUser
id: v1UserAgent_CreateDefaultUser
---

# POST Agents/User/CreateDefaultUser

```http
POST /api/v1/Agents/User/CreateDefaultUser
```

Set default values into a new User.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






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
POST /api/v1/Agents/User/CreateDefaultUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 16,
  "Name": "Wilderman-McDermott",
  "Rank": 135,
  "Tooltip": "consectetur",
  "LicenseOwners": [
    {
      "Name": "Casper Group",
      "Description": "Automated encompassing focus group",
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
          "FieldLength": 289
        }
      }
    },
    {
      "Name": "Casper Group",
      "Description": "Automated encompassing focus group",
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
          "FieldLength": 289
        }
      }
    }
  ],
  "Role": {
    "Id": 550,
    "Value": "et",
    "Tooltip": "voluptatibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 501
      }
    }
  },
  "UserGroup": {
    "Value": "et",
    "Tooltip": "est",
    "Id": 293,
    "Rank": 156,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 41
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "eum",
      "Tooltip": "molestias",
      "Id": 515,
      "Rank": 315,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 309
        }
      }
    }
  ],
  "Person": {
    "Position": "illo",
    "PersonId": 547,
    "Mrmrs": "et",
    "Firstname": "Demetrius",
    "Lastname": "Quitzon",
    "MiddleName": "Romaguera Group",
    "Title": "harum",
    "Description": "Monitored value-added protocol",
    "Email": "leif@kulas.co.uk",
    "FullName": "Lizeth Raynor",
    "DirectPhone": "316-225-8772",
    "FormalName": "Corwin Inc and Sons",
    "CountryId": 598,
    "ContactId": 182,
    "ContactName": "Mayert, Hills and Fadel",
    "Retired": 197,
    "Rank": 40,
    "ActiveInterests": 565,
    "ContactDepartment": "",
    "ContactCountryId": 916,
    "ContactOrgNr": "1037294",
    "FaxPhone": "113.783.7753 x43665",
    "MobilePhone": "414.782.3483",
    "ContactPhone": "1-173-621-6753 x426",
    "AssociateName": "Roob LLC",
    "AssociateId": 408,
    "UsePersonAddress": true,
    "ContactFax": "qui",
    "Kanafname": "quis",
    "Kanalname": "voluptatem",
    "Post1": "blanditiis",
    "Post2": "explicabo",
    "Post3": "est",
    "EmailName": "susie_tromp@zemlakcummerata.ca",
    "ContactFullName": "Dina Bradtke PhD",
    "ActiveErpLinks": 15,
    "TicketPriorityId": 715,
    "SupportLanguageId": 73,
    "SupportAssociateId": 961,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 683
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2009-02-01T18:28:50.4964407+01:00",
  "Lastlogout": "1996-08-28T18:28:50.4964407+02:00",
  "EjUserId": 953,
  "RequestSignature": "fugiat",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "vel",
      "DisplayValue": "tenetur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 748
        }
      }
    },
    {
      "Type": {},
      "Value": "vel",
      "DisplayValue": "tenetur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 748
        }
      }
    }
  ],
  "UserName": "O'Connell, Ruecker and Kassulke",
  "TicketCategories": [
    {
      "Id": 794,
      "Name": "Prohaska, Heller and Marvin",
      "ToolTip": "Cumque beatae minus qui.",
      "Deleted": false,
      "Rank": 955,
      "Type": "est",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "maiores",
      "ColorBlock": 563,
      "ExtraInfo": "repellendus",
      "StyleHint": "necessitatibus",
      "FullName": "Felicita Klein",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    }
  ],
  "NickName": "Effertz-Tromp",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "animi",
    "CustomFields2": "rem"
  },
  "PostSaveCommands": [
    {
      "Name": "Dietrich, Hane and Cole",
      "DisplayName": "Mueller Group",
      "Description": "Diverse contextually-based leverage",
      "ToolTip": "Delectus eos sed.",
      "Actions": "Implicit",
      "ActionData": "corrupti",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 275
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
      "FieldLength": 578
    }
  }
}
```