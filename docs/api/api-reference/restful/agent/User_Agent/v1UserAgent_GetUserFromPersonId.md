---
title: POST Agents/User/GetUserFromPersonId
id: v1UserAgent_GetUserFromPersonId
---

# POST Agents/User/GetUserFromPersonId

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 958
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AssociateId": 414,
    "Name": "Feeney, Paucek and Dietrich",
    "Rank": 150,
    "Tooltip": "veritatis",
    "LicenseOwners": [
      {
        "Name": "Predovic Inc and Sons",
        "Description": "Programmable maximized encryption",
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
            "FieldLength": 875
          }
        }
      },
      {
        "Name": "Predovic Inc and Sons",
        "Description": "Programmable maximized encryption",
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
            "FieldLength": 875
          }
        }
      }
    ],
    "Role": {
      "Id": 361,
      "Value": "omnis",
      "Tooltip": "illum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 581
        }
      }
    },
    "UserGroup": {
      "Value": "qui",
      "Tooltip": "rerum",
      "Id": 767,
      "Rank": 792,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "scale granular synergies"
          },
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    },
    "OtherGroups": [
      {
        "Value": "autem",
        "Tooltip": "dolor",
        "Id": 826,
        "Rank": 115,
        "Deleted": false,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 226
          }
        }
      }
    ],
    "Person": {
      "Position": "voluptas",
      "PersonId": 357,
      "Mrmrs": "ut",
      "Firstname": "Mckayla",
      "Lastname": "Dickens",
      "MiddleName": "Marks Group",
      "Title": "corporis",
      "Description": "Sharable foreground structure",
      "Email": "lucius_gleason@swaniawski.ca",
      "FullName": "Kirsten Heller",
      "DirectPhone": "(758)825-3438 x1016",
      "FormalName": "Tromp-Lockman",
      "CountryId": 489,
      "ContactId": 430,
      "ContactName": "Wiegand, Hagenes and Harber",
      "Retired": 282,
      "Rank": 190,
      "ActiveInterests": 761,
      "ContactDepartment": "",
      "ContactCountryId": 115,
      "ContactOrgNr": "1507399",
      "FaxPhone": "(334)487-5018 x33662",
      "MobilePhone": "155.031.5642 x574",
      "ContactPhone": "1-266-866-5250",
      "AssociateName": "Koelpin, Gorczany and Schulist",
      "AssociateId": 540,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "sit",
      "Kanalname": "praesentium",
      "Post1": "cum",
      "Post2": "et",
      "Post3": "quibusdam",
      "EmailName": "martin.schoen@spinkaoconner.biz",
      "ContactFullName": "Neil Wiza",
      "ActiveErpLinks": 560,
      "TicketPriorityId": 979,
      "SupportLanguageId": 903,
      "SupportAssociateId": 52,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "iterate user-centric deliverables"
          },
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    },
    "Deleted": false,
    "Lastlogin": "2019-05-25T18:28:50.4614118+02:00",
    "Lastlogout": "1998-06-18T18:28:50.4614118+02:00",
    "EjUserId": 337,
    "RequestSignature": "vero",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": true,
    "Credentials": [
      {
        "Type": {},
        "Value": "eveniet",
        "DisplayValue": "ut",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 957
          }
        }
      },
      {
        "Type": {},
        "Value": "eveniet",
        "DisplayValue": "ut",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 957
          }
        }
      }
    ],
    "UserName": "Cruickshank-Senger",
    "TicketCategories": [
      {
        "Id": 254,
        "Name": "Mann, Huel and DuBuque",
        "ToolTip": "Voluptate omnis unde.",
        "Deleted": false,
        "Rank": 373,
        "Type": "et",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "repellat",
        "ColorBlock": 67,
        "ExtraInfo": "ipsum",
        "StyleHint": "autem",
        "FullName": "Miss Douglas King",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 136
          }
        }
      }
    ],
    "NickName": "Abbott-Wilkinson",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "ea",
      "ExtraFields2": "at"
    },
    "CustomFields": {
      "CustomFields1": "laudantium",
      "CustomFields2": "et"
    },
    "PostSaveCommands": [
      {
        "Name": "Bauch-Klocko",
        "DisplayName": "Cremin, Terry and Denesik",
        "Description": "Streamlined uniform success",
        "ToolTip": "Repellendus optio quis.",
        "Actions": "Implicit",
        "ActionData": "natus",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 669
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
        "FieldLength": 427
      }
    }
  }
]
```