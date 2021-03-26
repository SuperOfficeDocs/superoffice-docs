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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 492
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AssociateId": 693,
    "Name": "Hills-Smitham",
    "Rank": 926,
    "Tooltip": "sint",
    "LicenseOwners": [
      {
        "Name": "Gleason LLC",
        "Description": "Future-proofed radical capacity",
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
            "FieldLength": 242
          }
        }
      },
      {
        "Name": "Gleason LLC",
        "Description": "Future-proofed radical capacity",
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
            "FieldLength": 242
          }
        }
      }
    ],
    "Role": {
      "Id": 393,
      "Value": "quia",
      "Tooltip": "impedit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 394
        }
      }
    },
    "UserGroup": {
      "Value": "soluta",
      "Tooltip": "et",
      "Id": 658,
      "Rank": 192,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 817
        }
      }
    },
    "OtherGroups": [
      {
        "Value": "veniam",
        "Tooltip": "qui",
        "Id": 512,
        "Rank": 582,
        "Deleted": false,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 416
          }
        }
      }
    ],
    "Person": {
      "Position": "odio",
      "PersonId": 955,
      "Mrmrs": "voluptatem",
      "Firstname": "Maud",
      "Lastname": "Sporer",
      "MiddleName": "Lind, Hermiston and Harvey",
      "Title": "aut",
      "Description": "Enterprise-wide eco-centric service-desk",
      "Email": "carissa.smitham@kub.co.uk",
      "FullName": "Germaine Hermann",
      "DirectPhone": "1-178-386-3441",
      "FormalName": "Kozey Inc and Sons",
      "CountryId": 658,
      "ContactId": 460,
      "ContactName": "Rohan Group",
      "Retired": 585,
      "Rank": 195,
      "ActiveInterests": 746,
      "ContactDepartment": "",
      "ContactCountryId": 975,
      "ContactOrgNr": "763185",
      "FaxPhone": "1-311-012-4734 x310",
      "MobilePhone": "(831)803-5776 x307",
      "ContactPhone": "328.313.2134",
      "AssociateName": "Reichel, Wyman and Jakubowski",
      "AssociateId": 319,
      "UsePersonAddress": false,
      "ContactFax": "sunt",
      "Kanafname": "odit",
      "Kanalname": "eum",
      "Post1": "doloribus",
      "Post2": "quo",
      "Post3": "est",
      "EmailName": "foster@denesik.uk",
      "ContactFullName": "Ms. Aubree Balistreri",
      "ActiveErpLinks": 571,
      "TicketPriorityId": 156,
      "SupportLanguageId": 742,
      "SupportAssociateId": 7,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 380
        }
      }
    },
    "Deleted": true,
    "Lastlogin": "2007-03-22T16:48:30.8339381+01:00",
    "Lastlogout": "1998-07-17T16:48:30.8339381+02:00",
    "EjUserId": 124,
    "RequestSignature": "et",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": false,
    "IsOnTravel": false,
    "Credentials": [
      {
        "Type": {},
        "Value": "et",
        "DisplayValue": "ipsam",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 995
          }
        }
      },
      {
        "Type": {},
        "Value": "et",
        "DisplayValue": "ipsam",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 995
          }
        }
      }
    ],
    "UserName": "Sanford, Eichmann and O'Keefe",
    "TicketCategories": [
      {
        "Id": 936,
        "Name": "Johnston LLC",
        "ToolTip": "Non tenetur molestias vel veritatis.",
        "Deleted": false,
        "Rank": 273,
        "Type": "optio",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "cupiditate",
        "ColorBlock": 239,
        "ExtraInfo": "earum",
        "StyleHint": "esse",
        "FullName": "Joel Nikolaus",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 439
          }
        }
      }
    ],
    "NickName": "Anderson, Thiel and Frami",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "minima",
      "ExtraFields2": "voluptate"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "maxime"
    },
    "PostSaveCommands": [
      {
        "Name": "Mraz-Kreiger",
        "DisplayName": "Langosh, Stiedemann and Simonis",
        "Description": "Pre-emptive empowering pricing structure",
        "ToolTip": "Fugiat ea labore laudantium omnis dolor et.",
        "Actions": "Implicit",
        "ActionData": "excepturi",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 721
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
        "FieldLength": 664
      }
    }
  }
]
```