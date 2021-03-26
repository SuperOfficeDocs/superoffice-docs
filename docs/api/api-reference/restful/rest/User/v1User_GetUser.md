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
  "AssociateId": 754,
  "Name": "Paucek Group",
  "Rank": 484,
  "Tooltip": "odit",
  "LicenseOwners": [
    {
      "Name": "McKenzie, Gulgowski and Hahn",
      "Description": "User-centric mobile process improvement",
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
            "Reason": "synergize cross-media systems"
          },
          "FieldType": "System.String",
          "FieldLength": 574
        }
      }
    },
    {
      "Name": "McKenzie, Gulgowski and Hahn",
      "Description": "User-centric mobile process improvement",
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
            "Reason": "synergize cross-media systems"
          },
          "FieldType": "System.String",
          "FieldLength": 574
        }
      }
    }
  ],
  "Role": {
    "Id": 131,
    "Value": "omnis",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate intuitive users"
        },
        "FieldType": "System.Int32",
        "FieldLength": 428
      }
    }
  },
  "UserGroup": {
    "Value": "incidunt",
    "Tooltip": "cupiditate",
    "Id": 422,
    "Rank": 974,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 354
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "aliquid",
      "Tooltip": "qui",
      "Id": 460,
      "Rank": 850,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "empower enterprise e-commerce"
          },
          "FieldType": "System.String",
          "FieldLength": 909
        }
      }
    }
  ],
  "Person": {
    "Position": "inventore",
    "PersonId": 990,
    "Mrmrs": "dolores",
    "Firstname": "Isaac",
    "Lastname": "Kutch",
    "MiddleName": "Leannon Group",
    "Title": "magnam",
    "Description": "Proactive zero tolerance parallelism",
    "Email": "arjun.bergstrom@pollich.uk",
    "FullName": "Shanon Boyle",
    "DirectPhone": "1-018-555-8875 x157",
    "FormalName": "Simonis, Goyette and Stracke",
    "CountryId": 208,
    "ContactId": 215,
    "ContactName": "Larson LLC",
    "Retired": 221,
    "Rank": 496,
    "ActiveInterests": 558,
    "ContactDepartment": "",
    "ContactCountryId": 217,
    "ContactOrgNr": "1494511",
    "FaxPhone": "(223)803-8860 x077",
    "MobilePhone": "040-608-5460 x068",
    "ContactPhone": "(063)103-3828 x833",
    "AssociateName": "Lebsack, Donnelly and Wisoky",
    "AssociateId": 714,
    "UsePersonAddress": true,
    "ContactFax": "voluptate",
    "Kanafname": "dolorem",
    "Kanalname": "cum",
    "Post1": "vero",
    "Post2": "culpa",
    "Post3": "molestiae",
    "EmailName": "jayme@stromanzieme.ca",
    "ContactFullName": "Meaghan Kuhn",
    "ActiveErpLinks": 62,
    "TicketPriorityId": 162,
    "SupportLanguageId": 182,
    "SupportAssociateId": 166,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 692
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2008-04-22T09:41:00.0540596+02:00",
  "Lastlogout": "2019-02-26T09:41:00.0540596+01:00",
  "EjUserId": 318,
  "RequestSignature": "eos",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "perspiciatis",
      "DisplayValue": "sed",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    },
    {
      "Type": {},
      "Value": "perspiciatis",
      "DisplayValue": "sed",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    }
  ],
  "UserName": "Wilderman, Swift and Blanda",
  "TicketCategories": [
    {
      "Id": 528,
      "Name": "Boyer-Adams",
      "ToolTip": "Impedit dolore molestiae distinctio omnis odit incidunt.",
      "Deleted": true,
      "Rank": 771,
      "Type": "incidunt",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "itaque",
      "ColorBlock": 345,
      "ExtraInfo": "et",
      "StyleHint": "quo",
      "FullName": "Ivory Will",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    }
  ],
  "NickName": "Morissette Group",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "sit"
  },
  "PostSaveCommands": [
    {
      "Name": "Connelly LLC",
      "DisplayName": "Hills Group",
      "Description": "Enterprise-wide optimal frame",
      "ToolTip": "Est laudantium sequi iure officiis est.",
      "Actions": "Implicit",
      "ActionData": "exercitationem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 742
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
      "FieldLength": 252
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```