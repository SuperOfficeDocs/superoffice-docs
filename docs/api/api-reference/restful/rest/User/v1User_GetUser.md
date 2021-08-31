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
Accept-Language: *
```

```http_
HTTP/1.1 200 User found.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 723,
  "Name": "King-Emmerich",
  "Rank": 284,
  "Tooltip": "illo",
  "LicenseOwners": [
    {
      "Name": "Johnson-Collier",
      "Description": "Seamless even-keeled intranet",
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
          "FieldLength": 164
        }
      }
    },
    {
      "Name": "Johnson-Collier",
      "Description": "Seamless even-keeled intranet",
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
          "FieldLength": 164
        }
      }
    }
  ],
  "Role": {
    "Id": 197,
    "Value": "laborum",
    "Tooltip": "eum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 124
      }
    }
  },
  "UserGroup": {
    "Value": "repellat",
    "Tooltip": "quos",
    "Id": 630,
    "Rank": 391,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 110
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "veritatis",
      "Tooltip": "ut",
      "Id": 559,
      "Rank": 393,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 369
        }
      }
    }
  ],
  "Person": {
    "Position": "voluptatibus",
    "PersonId": 330,
    "Mrmrs": "nulla",
    "Firstname": "Lazaro",
    "Lastname": "Marquardt",
    "MiddleName": "Conn, Zemlak and Pouros",
    "Title": "qui",
    "Description": "Balanced 24/7 system engine",
    "Email": "giovanna_boyer@hahn.biz",
    "FullName": "Loyce Heathcote Jr.",
    "DirectPhone": "556-517-4134 x176",
    "FormalName": "Buckridge Group",
    "CountryId": 903,
    "ContactId": 602,
    "ContactName": "Littel LLC",
    "Retired": 393,
    "Rank": 447,
    "ActiveInterests": 176,
    "ContactDepartment": "",
    "ContactCountryId": 50,
    "ContactOrgNr": "990437",
    "FaxPhone": "112-445-3843 x2461",
    "MobilePhone": "325-168-2014 x81152",
    "ContactPhone": "834.238.3246",
    "AssociateName": "Jaskolski, Feest and Will",
    "AssociateId": 996,
    "UsePersonAddress": false,
    "ContactFax": "mollitia",
    "Kanafname": "dolores",
    "Kanalname": "nam",
    "Post1": "id",
    "Post2": "dolorem",
    "Post3": "maiores",
    "EmailName": "grady@haley.com",
    "ContactFullName": "Coleman Fisher",
    "ActiveErpLinks": 895,
    "TicketPriorityId": 511,
    "SupportLanguageId": 474,
    "SupportAssociateId": 859,
    "CategoryName": "VIP Customer",
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
  "Deleted": false,
  "Lastlogin": "1999-09-05T15:05:43.1348994+02:00",
  "Lastlogout": "2016-09-22T15:05:43.1348994+02:00",
  "EjUserId": 529,
  "RequestSignature": "sint",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "voluptatem",
      "DisplayValue": "repellendus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 384
        }
      }
    },
    {
      "Type": {},
      "Value": "voluptatem",
      "DisplayValue": "repellendus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 384
        }
      }
    }
  ],
  "UserName": "Christiansen, Lockman and Lockman",
  "TicketCategories": [
    {
      "Id": 222,
      "Name": "Murray Group",
      "ToolTip": "Commodi sunt nemo minima.",
      "Deleted": true,
      "Rank": 977,
      "Type": "optio",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "commodi",
      "ColorBlock": 940,
      "ExtraInfo": "non",
      "StyleHint": "et",
      "FullName": "Adriana Kohler",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    }
  ],
  "NickName": "Orn-Kozey",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "praesentium",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "vel"
  },
  "PostSaveCommands": [
    {
      "Name": "Kuhic-Langworth",
      "DisplayName": "Muller, Green and Oberbrunner",
      "Description": "Cloned directional projection",
      "ToolTip": "Molestiae similique est recusandae inventore quia in.",
      "Actions": "Implicit",
      "ActionData": "alias",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 804
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
      "FieldLength": 605
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```