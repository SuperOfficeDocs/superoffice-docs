---
title: POST Agents/User/CreateDefaultUser
id: v1UserAgent_CreateDefaultUser
---

# POST Agents/User/CreateDefaultUser

```http
POST /api/v1/Agents/User/CreateDefaultUser
```

Set default values into a new User.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






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
POST /api/v1/Agents/User/CreateDefaultUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 14,
  "Name": "Heaney, Spinka and Schroeder",
  "Rank": 889,
  "Tooltip": "ut",
  "LicenseOwners": [
    {
      "Name": "Watsica-Olson",
      "Description": "Monitored discrete customer loyalty",
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
          "FieldLength": 109
        }
      }
    },
    {
      "Name": "Watsica-Olson",
      "Description": "Monitored discrete customer loyalty",
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
          "FieldLength": 109
        }
      }
    }
  ],
  "Role": {
    "Id": 192,
    "Value": "corporis",
    "Tooltip": "natus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 332
      }
    }
  },
  "UserGroup": {
    "Value": "dicta",
    "Tooltip": "porro",
    "Id": 810,
    "Rank": 461,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 3
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "eos",
      "Tooltip": "qui",
      "Id": 801,
      "Rank": 50,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    }
  ],
  "Person": {
    "Position": "commodi",
    "PersonId": 317,
    "Mrmrs": "fugit",
    "Firstname": "Enola",
    "Lastname": "Leannon",
    "MiddleName": "Herman LLC",
    "Title": "iste",
    "Description": "Configurable bifurcated intranet",
    "Email": "rubie@rice.ca",
    "FullName": "Miss Ervin Keeling",
    "DirectPhone": "644.746.7853 x032",
    "FormalName": "Pagac-Davis",
    "CountryId": 402,
    "ContactId": 88,
    "ContactName": "Goldner LLC",
    "Retired": 260,
    "Rank": 833,
    "ActiveInterests": 676,
    "ContactDepartment": "",
    "ContactCountryId": 289,
    "ContactOrgNr": "377143",
    "FaxPhone": "243-667-6866 x7218",
    "MobilePhone": "654-802-5601 x83673",
    "ContactPhone": "(462)276-6448",
    "AssociateName": "Mueller LLC",
    "AssociateId": 470,
    "UsePersonAddress": false,
    "ContactFax": "veniam",
    "Kanafname": "non",
    "Kanalname": "temporibus",
    "Post1": "aut",
    "Post2": "tempore",
    "Post3": "nisi",
    "EmailName": "noble.barton@hoeger.us",
    "ContactFullName": "Toney Renner",
    "ActiveErpLinks": 964,
    "TicketPriorityId": 12,
    "SupportLanguageId": 975,
    "SupportAssociateId": 16,
    "CategoryName": "VIP Customer",
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
  "Deleted": true,
  "Lastlogin": "2005-12-13T16:48:30.8949427+01:00",
  "Lastlogout": "2016-03-20T16:48:30.8949427+01:00",
  "EjUserId": 626,
  "RequestSignature": "nam",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "in",
      "DisplayValue": "sunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    },
    {
      "Type": {},
      "Value": "in",
      "DisplayValue": "sunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    }
  ],
  "UserName": "Ward Inc and Sons",
  "TicketCategories": [
    {
      "Id": 244,
      "Name": "Brakus, Hilpert and Keeling",
      "ToolTip": "Ab sint vel est eum.",
      "Deleted": true,
      "Rank": 270,
      "Type": "omnis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "suscipit",
      "ColorBlock": 137,
      "ExtraInfo": "quis",
      "StyleHint": "est",
      "FullName": "Ceasar Barrows",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "redefine extensible networks"
          },
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "NickName": "Stroman Group",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "animi"
  },
  "CustomFields": {
    "CustomFields1": "itaque",
    "CustomFields2": "eligendi"
  },
  "PostSaveCommands": [
    {
      "Name": "Langosh-Prosacco",
      "DisplayName": "Kertzmann, Moen and Schulist",
      "Description": "Persistent tertiary knowledge base",
      "ToolTip": "Rem sint recusandae nisi voluptatum iure vitae.",
      "Actions": "Implicit",
      "ActionData": "atque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 876
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
      "FieldLength": 759
    }
  }
}
```