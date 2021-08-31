---
title: GET User/{userName}
id: v1User_GetUserFromName
---

# GET User/{userName}

```http
GET /api/v1/User/{userName}
```

Get a user, with lookup based on user name.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| userName | string | User name of the user to get. **Required** |



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
GET /api/v1/User/{userName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 138,
  "Name": "Wyman, Streich and Kassulke",
  "Rank": 755,
  "Tooltip": "fugiat",
  "LicenseOwners": [
    {
      "Name": "Herzog, Swaniawski and Streich",
      "Description": "Fully-configurable radical productivity",
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
          "FieldLength": 912
        }
      }
    },
    {
      "Name": "Herzog, Swaniawski and Streich",
      "Description": "Fully-configurable radical productivity",
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
          "FieldLength": 912
        }
      }
    }
  ],
  "Role": {
    "Id": 141,
    "Value": "at",
    "Tooltip": "hic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 101
      }
    }
  },
  "UserGroup": {
    "Value": "et",
    "Tooltip": "vitae",
    "Id": 189,
    "Rank": 119,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 474
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "exercitationem",
      "Tooltip": "voluptas",
      "Id": 678,
      "Rank": 214,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 519
        }
      }
    }
  ],
  "Person": {
    "Position": "odit",
    "PersonId": 68,
    "Mrmrs": "reiciendis",
    "Firstname": "Ed",
    "Lastname": "Pacocha",
    "MiddleName": "Dicki Inc and Sons",
    "Title": "ut",
    "Description": "Reactive modular help-desk",
    "Email": "marie.thompson@hane.ca",
    "FullName": "Colten Bogisich",
    "DirectPhone": "(686)605-0707 x152",
    "FormalName": "Connelly-Harris",
    "CountryId": 411,
    "ContactId": 61,
    "ContactName": "Conroy Inc and Sons",
    "Retired": 424,
    "Rank": 101,
    "ActiveInterests": 419,
    "ContactDepartment": "incentivize mission-critical experiences",
    "ContactCountryId": 882,
    "ContactOrgNr": "1092537",
    "FaxPhone": "112.242.1055 x6702",
    "MobilePhone": "(518)070-8127 x257",
    "ContactPhone": "084-233-0377 x170",
    "AssociateName": "Murphy-Oberbrunner",
    "AssociateId": 219,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "dolorem",
    "Kanalname": "odio",
    "Post1": "est",
    "Post2": "aut",
    "Post3": "dolores",
    "EmailName": "laurine@pfefferkunze.biz",
    "ContactFullName": "Lois Pouros",
    "ActiveErpLinks": 898,
    "TicketPriorityId": 347,
    "SupportLanguageId": 299,
    "SupportAssociateId": 277,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 76
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2005-09-23T15:05:43.1569037+02:00",
  "Lastlogout": "2003-04-14T15:05:43.1569037+02:00",
  "EjUserId": 582,
  "RequestSignature": "repellendus",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "accusantium",
      "DisplayValue": "tempore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "disintermediate virtual bandwidth"
          },
          "FieldType": "System.String",
          "FieldLength": 519
        }
      }
    },
    {
      "Type": {},
      "Value": "accusantium",
      "DisplayValue": "tempore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "disintermediate virtual bandwidth"
          },
          "FieldType": "System.String",
          "FieldLength": 519
        }
      }
    }
  ],
  "UserName": "Becker Group",
  "TicketCategories": [
    {
      "Id": 337,
      "Name": "Ortiz-West",
      "ToolTip": "Tempora unde ut sint.",
      "Deleted": false,
      "Rank": 616,
      "Type": "molestiae",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "repudiandae",
      "ColorBlock": 310,
      "ExtraInfo": "ea",
      "StyleHint": "ut",
      "FullName": "Earnest Collins",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    }
  ],
  "NickName": "Hermann, Harber and Homenick",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "fuga",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "distinctio"
  },
  "PostSaveCommands": [
    {
      "Name": "Wuckert, Lang and Nicolas",
      "DisplayName": "Goyette Group",
      "Description": "Cloned grid-enabled frame",
      "ToolTip": "Nesciunt cupiditate qui ut illo qui.",
      "Actions": "Implicit",
      "ActionData": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 188
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
      "FieldLength": 924
    }
  }
}
```