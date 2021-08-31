---
title: GetUserFromPersonId
id: v1UserAgent_GetUserFromPersonId
---

# GetUserFromPersonId

```http
POST /api/v1/Agents/User/GetUserFromPersonId
```

Returns the user associated with the supplied person id



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUserFromPersonId?$select=name,department,category/id
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

PersonId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |


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
POST /api/v1/Agents/User/GetUserFromPersonId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 987
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AssociateId": 907,
    "Name": "Schroeder, Daugherty and Lebsack",
    "Rank": 869,
    "Tooltip": "saepe",
    "LicenseOwners": [
      {
        "Name": "Wehner, Rau and Krajcik",
        "Description": "Monitored object-oriented ability",
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
            "FieldLength": 655
          }
        }
      },
      {
        "Name": "Wehner, Rau and Krajcik",
        "Description": "Monitored object-oriented ability",
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
            "FieldLength": 655
          }
        }
      }
    ],
    "Role": {
      "Id": 950,
      "Value": "fugiat",
      "Tooltip": "cum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    },
    "UserGroup": {
      "Value": "dicta",
      "Tooltip": "ab",
      "Id": 25,
      "Rank": 621,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 819
        }
      }
    },
    "OtherGroups": [
      {
        "Value": "qui",
        "Tooltip": "voluptas",
        "Id": 322,
        "Rank": 318,
        "Deleted": true,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 904
          }
        }
      }
    ],
    "Person": {
      "Position": "laudantium",
      "PersonId": 172,
      "Mrmrs": "enim",
      "Firstname": "Antone",
      "Lastname": "Bergnaum",
      "MiddleName": "Bergstrom Group",
      "Title": "assumenda",
      "Description": "Intuitive radical open architecture",
      "Email": "jackeline_grant@wisoky.name",
      "FullName": "Orville Ziemann",
      "DirectPhone": "308.505.3775 x332",
      "FormalName": "Baumbach Group",
      "CountryId": 888,
      "ContactId": 630,
      "ContactName": "Bode, Nader and O'Conner",
      "Retired": 590,
      "Rank": 797,
      "ActiveInterests": 97,
      "ContactDepartment": "",
      "ContactCountryId": 937,
      "ContactOrgNr": "999259",
      "FaxPhone": "740-460-8167",
      "MobilePhone": "877.483.5550",
      "ContactPhone": "1-088-641-4252 x75672",
      "AssociateName": "Ledner, Baumbach and Wisozk",
      "AssociateId": 694,
      "UsePersonAddress": false,
      "ContactFax": "optio",
      "Kanafname": "et",
      "Kanalname": "voluptatem",
      "Post1": "ex",
      "Post2": "ducimus",
      "Post3": "sed",
      "EmailName": "geoffrey.labadie@leannon.biz",
      "ContactFullName": "Caroline Bins",
      "ActiveErpLinks": 53,
      "TicketPriorityId": 150,
      "SupportLanguageId": 106,
      "SupportAssociateId": 619,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    },
    "Deleted": false,
    "Lastlogin": "2012-02-07T14:58:05.4602934+01:00",
    "Lastlogout": "1995-02-07T14:58:05.4602934+01:00",
    "EjUserId": 257,
    "RequestSignature": "tempora",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": false,
    "IsOnTravel": false,
    "Credentials": [
      {
        "Type": {},
        "Value": "earum",
        "DisplayValue": "et",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 477
          }
        }
      },
      {
        "Type": {},
        "Value": "earum",
        "DisplayValue": "et",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 477
          }
        }
      }
    ],
    "UserName": "Goodwin LLC",
    "TicketCategories": [
      {
        "Id": 524,
        "Name": "Beahan LLC",
        "ToolTip": "Fuga nobis porro quidem nihil similique.",
        "Deleted": false,
        "Rank": 135,
        "Type": "distinctio",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "ut",
        "ColorBlock": 127,
        "ExtraInfo": "veniam",
        "StyleHint": "repellendus",
        "FullName": "Duncan Keeling",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 714
          }
        }
      }
    ],
    "NickName": "Conroy LLC",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "quae",
      "ExtraFields2": "corporis"
    },
    "CustomFields": {
      "CustomFields1": "natus",
      "CustomFields2": "ut"
    },
    "PostSaveCommands": [
      {
        "Name": "Bradtke Inc and Sons",
        "DisplayName": "Ferry, Friesen and Wyman",
        "Description": "Synergized maximized service-desk",
        "ToolTip": "Amet asperiores labore id.",
        "Actions": "Implicit",
        "ActionData": "qui",
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
        "FieldLength": 839
      }
    }
  }
]
```