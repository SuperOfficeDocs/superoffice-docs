---
title: POST Agents/User/GetUserFromEjUserId
id: v1UserAgent_GetUserFromEjUserId
---

# POST Agents/User/GetUserFromEjUserId

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "EjUserId": 461
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AssociateId": 881,
    "Name": "Herzog Group",
    "Rank": 611,
    "Tooltip": "accusantium",
    "LicenseOwners": [
      {
        "Name": "D'Amore LLC",
        "Description": "Total demand-driven archive",
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
            "FieldLength": 137
          }
        }
      },
      {
        "Name": "D'Amore LLC",
        "Description": "Total demand-driven archive",
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
            "FieldLength": 137
          }
        }
      }
    ],
    "Role": {
      "Id": 334,
      "Value": "repellat",
      "Tooltip": "blanditiis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    },
    "UserGroup": {
      "Value": "molestias",
      "Tooltip": "est",
      "Id": 667,
      "Rank": 111,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 773
        }
      }
    },
    "OtherGroups": [
      {
        "Value": "corporis",
        "Tooltip": "repudiandae",
        "Id": 714,
        "Rank": 763,
        "Deleted": true,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 887
          }
        }
      }
    ],
    "Person": {
      "Position": "rerum",
      "PersonId": 946,
      "Mrmrs": "autem",
      "Firstname": "Clint",
      "Lastname": "Cassin",
      "MiddleName": "Kuhn-Leannon",
      "Title": "praesentium",
      "Description": "Switchable incremental instruction set",
      "Email": "sydni_jacobs@lubowitz.info",
      "FullName": "Ms. Arvel Hayes",
      "DirectPhone": "(585)553-8602 x5113",
      "FormalName": "Swaniawski Group",
      "CountryId": 1001,
      "ContactId": 395,
      "ContactName": "Ferry Inc and Sons",
      "Retired": 142,
      "Rank": 495,
      "ActiveInterests": 795,
      "ContactDepartment": "",
      "ContactCountryId": 679,
      "ContactOrgNr": "563120",
      "FaxPhone": "217-685-7721 x5774",
      "MobilePhone": "1-530-181-4614 x3607",
      "ContactPhone": "635-304-3445",
      "AssociateName": "Witting Group",
      "AssociateId": 233,
      "UsePersonAddress": false,
      "ContactFax": "nostrum",
      "Kanafname": "possimus",
      "Kanalname": "repellat",
      "Post1": "voluptatem",
      "Post2": "molestiae",
      "Post3": "quam",
      "EmailName": "duane.smitham@bode.com",
      "ContactFullName": "Jasen Jacobs I",
      "ActiveErpLinks": 181,
      "TicketPriorityId": 850,
      "SupportLanguageId": 608,
      "SupportAssociateId": 519,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    },
    "Deleted": false,
    "Lastlogin": "2020-04-27T16:48:30.8529281+02:00",
    "Lastlogout": "2017-08-19T16:48:30.8529281+02:00",
    "EjUserId": 103,
    "RequestSignature": "culpa",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": true,
    "Credentials": [
      {
        "Type": {},
        "Value": "voluptatibus",
        "DisplayValue": "magni",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 803
          }
        }
      },
      {
        "Type": {},
        "Value": "voluptatibus",
        "DisplayValue": "magni",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 803
          }
        }
      }
    ],
    "UserName": "Towne Group",
    "TicketCategories": [
      {
        "Id": 750,
        "Name": "Ernser-Schulist",
        "ToolTip": "Sunt doloremque ratione.",
        "Deleted": false,
        "Rank": 803,
        "Type": "non",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "sapiente",
        "ColorBlock": 109,
        "ExtraInfo": "nisi",
        "StyleHint": "odio",
        "FullName": "Octavia Hudson",
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
      }
    ],
    "NickName": "Johnston LLC",
    "WaitingForApproval": false,
    "ExtraFields": {
      "ExtraFields1": "nam",
      "ExtraFields2": "sunt"
    },
    "CustomFields": {
      "CustomFields1": "aut",
      "CustomFields2": "voluptatem"
    },
    "PostSaveCommands": [
      {
        "Name": "Rogahn, Lockman and Bradtke",
        "DisplayName": "Haley LLC",
        "Description": "Robust homogeneous challenge",
        "ToolTip": "Delectus libero et voluptas reprehenderit.",
        "Actions": "Implicit",
        "ActionData": "reprehenderit",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 521
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
          "Reason": "target visionary schemas"
        },
        "FieldType": "System.Int32",
        "FieldLength": 8
      }
    }
  }
]
```