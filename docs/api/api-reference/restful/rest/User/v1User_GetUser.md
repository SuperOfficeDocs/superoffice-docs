---
title: GET User/{id}
id: v1User_GetUser
---

# GET User/{id}

```http
GET /api/v1/User/{id}
```

Gets a User object.

Calls the User agent service GetUser.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the User to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/User/{id}?$select=name,department,category/id
GET /api/v1/User/{id}?fk=False
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



User entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | User found. |
| 404 | Not Found. |

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
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/User/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 User found.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 919,
  "Name": "Kihn Inc and Sons",
  "Rank": 91,
  "Tooltip": "et",
  "LicenseOwners": [
    {
      "Name": "Bednar LLC",
      "Description": "Open-architected bottom-line initiative",
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
          "FieldLength": 749
        }
      }
    },
    {
      "Name": "Bednar LLC",
      "Description": "Open-architected bottom-line initiative",
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
          "FieldLength": 749
        }
      }
    }
  ],
  "Role": {
    "Id": 735,
    "Value": "aut",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 23
      }
    }
  },
  "UserGroup": {
    "Value": "ex",
    "Tooltip": "sequi",
    "Id": 228,
    "Rank": 460,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 730
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "ut",
      "Tooltip": "cumque",
      "Id": 175,
      "Rank": 69,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 406
        }
      }
    }
  ],
  "Person": {
    "Position": "numquam",
    "PersonId": 825,
    "Mrmrs": "eius",
    "Firstname": "Glennie",
    "Lastname": "Nienow",
    "MiddleName": "Ratke, Morissette and Champlin",
    "Title": "enim",
    "Description": "Monitored optimal superstructure",
    "Email": "angel@harvey.name",
    "FullName": "Gerry Kutch",
    "DirectPhone": "1-578-665-5812",
    "FormalName": "Ferry, Ward and Langworth",
    "CountryId": 48,
    "ContactId": 780,
    "ContactName": "Collier Inc and Sons",
    "Retired": 729,
    "Rank": 257,
    "ActiveInterests": 439,
    "ContactDepartment": "transform clicks-and-mortar convergence",
    "ContactCountryId": 74,
    "ContactOrgNr": "920256",
    "FaxPhone": "(376)000-6734",
    "MobilePhone": "1-445-378-7817 x3060",
    "ContactPhone": "1-676-241-3880",
    "AssociateName": "Sporer-Kling",
    "AssociateId": 956,
    "UsePersonAddress": true,
    "ContactFax": "facere",
    "Kanafname": "reiciendis",
    "Kanalname": "voluptates",
    "Post1": "possimus",
    "Post2": "animi",
    "Post3": "excepturi",
    "EmailName": "haven@ryan.name",
    "ContactFullName": "Rhoda Bruen",
    "ActiveErpLinks": 139,
    "TicketPriorityId": 917,
    "SupportLanguageId": 622,
    "SupportAssociateId": 115,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 296
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2011-12-14T18:25:51.4611177+01:00",
  "Lastlogout": "1995-05-07T18:25:51.4611177+02:00",
  "EjUserId": 123,
  "RequestSignature": "animi",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "fugit",
      "DisplayValue": "iste",
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
    {
      "Type": {},
      "Value": "fugit",
      "DisplayValue": "iste",
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
    }
  ],
  "UserName": "Adams-Gusikowski",
  "TicketCategories": [
    {
      "Id": 588,
      "Name": "Lind, Marvin and Feeney",
      "ToolTip": "Laborum voluptates.",
      "Deleted": true,
      "Rank": 607,
      "Type": "accusantium",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "eveniet",
      "ColorBlock": 545,
      "ExtraInfo": "ut",
      "StyleHint": "dolorem",
      "FullName": "Jerad Connelly",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 702
        }
      }
    }
  ],
  "NickName": "Kuhn-Murazik",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "ab",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "labore",
    "CustomFields2": "qui"
  },
  "PostSaveCommands": [
    {
      "Name": "King, Wyman and Hintz",
      "DisplayName": "Rempel-Ullrich",
      "Description": "Cloned motivating monitoring",
      "ToolTip": "In beatae.",
      "Actions": "Implicit",
      "ActionData": "dolorum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 858
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
        "Reason": "morph viral e-markets"
      },
      "FieldType": "System.Int32",
      "FieldLength": 461
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```