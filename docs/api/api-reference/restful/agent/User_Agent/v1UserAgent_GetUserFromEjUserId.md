---
title: GetUserFromEjUserId
id: v1UserAgent_GetUserFromEjUserId
---

# GetUserFromEjUserId

```http
POST /api/v1/Agents/User/GetUserFromEjUserId
```

Get user from ejUserId - used for eJournal Legacy Support.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUserFromEjUserId?$select=name,department,category/id
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

## Request Body: request  

EjUserId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjUserId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/User/GetUserFromEjUserId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EjUserId": 572
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AssociateId": 705,
    "Name": "Nicolas-Stracke",
    "Rank": 801,
    "Tooltip": "rem",
    "LicenseOwners": [
      {
        "Name": "Lockman-Hayes",
        "Description": "Triple-buffered cohesive paradigm",
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
            "FieldLength": 636
          }
        }
      },
      {
        "Name": "Lockman-Hayes",
        "Description": "Triple-buffered cohesive paradigm",
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
            "FieldLength": 636
          }
        }
      }
    ],
    "Role": {
      "Id": 870,
      "Value": "iste",
      "Tooltip": "quod",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 580
        }
      }
    },
    "UserGroup": {
      "Value": "quia",
      "Tooltip": "dicta",
      "Id": 460,
      "Rank": 263,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    },
    "OtherGroups": [
      {
        "Value": "quis",
        "Tooltip": "aspernatur",
        "Id": 877,
        "Rank": 286,
        "Deleted": false,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 571
          }
        }
      }
    ],
    "Person": {
      "Position": "aliquam",
      "PersonId": 814,
      "Mrmrs": "illo",
      "Firstname": "Celestine",
      "Lastname": "Jacobs",
      "MiddleName": "Gerlach, Johnson and Ankunding",
      "Title": "occaecati",
      "Description": "Focused regional implementation",
      "Email": "lucile.ledner@smitham.ca",
      "FullName": "Jada Farrell",
      "DirectPhone": "(307)851-5241 x876",
      "FormalName": "Rutherford-Schumm",
      "CountryId": 68,
      "ContactId": 324,
      "ContactName": "Bogan, Schuster and Streich",
      "Retired": 512,
      "Rank": 995,
      "ActiveInterests": 122,
      "ContactDepartment": "",
      "ContactCountryId": 169,
      "ContactOrgNr": "731015",
      "FaxPhone": "1-161-473-2281",
      "MobilePhone": "133-062-2684",
      "ContactPhone": "1-515-447-7007 x210",
      "AssociateName": "Morissette Inc and Sons",
      "AssociateId": 648,
      "UsePersonAddress": true,
      "ContactFax": "omnis",
      "Kanafname": "libero",
      "Kanalname": "harum",
      "Post1": "beatae",
      "Post2": "eum",
      "Post3": "voluptas",
      "EmailName": "alejandrin_paucek@bartell.us",
      "ContactFullName": "Hunter Krajcik",
      "ActiveErpLinks": 917,
      "TicketPriorityId": 130,
      "SupportLanguageId": 359,
      "SupportAssociateId": 928,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 121
        }
      }
    },
    "Deleted": false,
    "Lastlogin": "2003-01-02T14:58:05.5330576+01:00",
    "Lastlogout": "2012-02-28T14:58:05.5330576+01:00",
    "EjUserId": 396,
    "RequestSignature": "magni",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": true,
    "Credentials": [
      {
        "Type": {},
        "Value": "voluptatum",
        "DisplayValue": "molestiae",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "e-enable 24/7 portals"
            },
            "FieldType": "System.Int32",
            "FieldLength": 196
          }
        }
      },
      {
        "Type": {},
        "Value": "voluptatum",
        "DisplayValue": "molestiae",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "e-enable 24/7 portals"
            },
            "FieldType": "System.Int32",
            "FieldLength": 196
          }
        }
      }
    ],
    "UserName": "Homenick-Hahn",
    "TicketCategories": [
      {
        "Id": 609,
        "Name": "Gulgowski LLC",
        "ToolTip": "Sint nihil commodi facilis voluptatem.",
        "Deleted": true,
        "Rank": 374,
        "Type": "laborum",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "sunt",
        "ColorBlock": 555,
        "ExtraInfo": "omnis",
        "StyleHint": "voluptatem",
        "FullName": "Junius Bechtelar",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 692
          }
        }
      }
    ],
    "NickName": "Buckridge, O'Reilly and Lemke",
    "WaitingForApproval": false,
    "ExtraFields": {
      "ExtraFields1": "quod",
      "ExtraFields2": "iusto"
    },
    "CustomFields": {
      "CustomFields1": "ducimus",
      "CustomFields2": "exercitationem"
    },
    "PostSaveCommands": [
      {
        "Name": "Simonis-Torp",
        "DisplayName": "Greenfelder Inc and Sons",
        "Description": "Face to face methodical definition",
        "ToolTip": "Magni qui excepturi asperiores ad dolorum.",
        "Actions": "Implicit",
        "ActionData": "sunt",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 532
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
        "FieldLength": 391
      }
    }
  }
]
```