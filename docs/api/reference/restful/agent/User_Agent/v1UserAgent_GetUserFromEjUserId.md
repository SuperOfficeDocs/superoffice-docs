---
title: POST Agents/User/GetUserFromEjUserId
id: v1UserAgent_GetUserFromEjUserId
---

# POST Agents/User/GetUserFromEjUserId

```http
POST /api/v1/Agents/User/GetUserFromEjUserId
```

Get user from ejUserId - used for eJournal Legacy Support.

## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps

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
| UserGroup |  | The main user group that this user belongs to.  <br />Use MDO List name "usergroup" to get list items. |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  <br />Use MDO List name "usergroup" to get list items. |
| Person |  | The person associated with this user. Detailed information about the user  <br />Use MDO List name "person_new" to get list items. |
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
| TicketCategories | array | Request Ticket Categories assigned to the user.   <br />Use MDO List name "ejCategory" to get list items. |
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "EjUserId": 622
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AssociateId": 737,
    "Name": "Hamill, Little and Baumbach",
    "Rank": 476,
    "Tooltip": "laboriosam",
    "LicenseOwners": [
      {
        "Name": "Lesch-Aufderhar",
        "Description": "Distributed user-facing algorithm",
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
            "FieldLength": 207
          }
        }
      },
      {
        "Name": "Lesch-Aufderhar",
        "Description": "Distributed user-facing algorithm",
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
            "FieldLength": 207
          }
        }
      }
    ],
    "Role": {
      "Id": 36,
      "Value": "illo",
      "Tooltip": "est",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 732
        }
      }
    },
    "UserGroup": {
      "Value": "neque",
      "Tooltip": "iste",
      "Id": 494,
      "Rank": 939,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 929
        }
      }
    },
    "OtherGroups": [
      {
        "Value": "sed",
        "Tooltip": "molestiae",
        "Id": 131,
        "Rank": 280,
        "Deleted": true,
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
      }
    ],
    "Person": {
      "Position": "tenetur",
      "PersonId": 796,
      "Mrmrs": "explicabo",
      "Firstname": "Ward",
      "Lastname": "Abshire",
      "MiddleName": "Gleichner LLC",
      "Title": "maxime",
      "Description": "Mandatory client-driven encoding",
      "Email": "julianne.krajcik@ebert.co.uk",
      "FullName": "Jerrod Ferry",
      "DirectPhone": "1-536-341-0216",
      "FormalName": "Spinka-Kub",
      "CountryId": 974,
      "ContactId": 668,
      "ContactName": "Marvin, Renner and Schimmel",
      "Retired": 438,
      "Rank": 749,
      "ActiveInterests": 836,
      "ContactDepartment": "",
      "ContactCountryId": 808,
      "ContactOrgNr": "822713",
      "FaxPhone": "838-147-7364 x834",
      "MobilePhone": "711-038-0464 x867",
      "ContactPhone": "608.716.1725",
      "AssociateName": "Yost LLC",
      "AssociateId": 572,
      "UsePersonAddress": false,
      "ContactFax": "officia",
      "Kanafname": "enim",
      "Kanalname": "accusamus",
      "Post1": "vitae",
      "Post2": "nesciunt",
      "Post3": "commodi",
      "EmailName": "nelson@gorczanyrussel.co.uk",
      "ContactFullName": "Lorine Miller",
      "ActiveErpLinks": 646,
      "TicketPriorityId": 200,
      "SupportLanguageId": 171,
      "SupportAssociateId": 754,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 626
        }
      }
    },
    "Deleted": false,
    "Lastlogin": "2010-03-02T18:28:50.4824405+01:00",
    "Lastlogout": "2012-06-05T18:28:50.4824405+02:00",
    "EjUserId": 519,
    "RequestSignature": "blanditiis",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": false,
    "IsOnTravel": true,
    "Credentials": [
      {
        "Type": {},
        "Value": "sint",
        "DisplayValue": "maiores",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 410
          }
        }
      },
      {
        "Type": {},
        "Value": "sint",
        "DisplayValue": "maiores",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 410
          }
        }
      }
    ],
    "UserName": "Casper, Schaefer and Hahn",
    "TicketCategories": [
      {
        "Id": 281,
        "Name": "Denesik, Weber and Huels",
        "ToolTip": "Iure quia sint impedit eos.",
        "Deleted": false,
        "Rank": 460,
        "Type": "qui",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "nulla",
        "ColorBlock": 799,
        "ExtraInfo": "officia",
        "StyleHint": "suscipit",
        "FullName": "Tyshawn Mayer",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 213
          }
        }
      }
    ],
    "NickName": "Legros-Torp",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "tempore",
      "ExtraFields2": "neque"
    },
    "CustomFields": {
      "CustomFields1": "voluptatem",
      "CustomFields2": "deleniti"
    },
    "PostSaveCommands": [
      {
        "Name": "Von-Block",
        "DisplayName": "Farrell-Leffler",
        "Description": "Exclusive tertiary alliance",
        "ToolTip": "Aut dolorem velit qui earum.",
        "Actions": "Implicit",
        "ActionData": "ea",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 965
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
        "FieldLength": 177
      }
    }
  }
]
```
