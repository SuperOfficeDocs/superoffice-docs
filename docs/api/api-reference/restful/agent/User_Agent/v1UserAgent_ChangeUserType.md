---
title: POST Agents/User/ChangeUserType
id: v1UserAgent_ChangeUserType
---

# POST Agents/User/ChangeUserType

```http
POST /api/v1/Agents/User/ChangeUserType
```

Get a user from the user name.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/ChangeUserType?$select=name,department,category/id
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

User, UserType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| User |  | SuperOffice User, with login credentials and an associated person. <para /> Carrier object for User. Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |
| UserType | string |  |


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
POST /api/v1/Agents/User/ChangeUserType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "User": {
    "AssociateId": 991,
    "Name": "Schultz-Muller",
    "Rank": 252,
    "Tooltip": "dolorum",
    "LicenseOwners": [
      {},
      {}
    ],
    "Role": {},
    "UserGroup": {},
    "OtherGroups": [
      {},
      {}
    ],
    "Person": {},
    "Deleted": true,
    "Lastlogin": "1997-05-31T16:48:30.8579054+02:00",
    "Lastlogout": "1996-06-09T16:48:30.8579054+02:00",
    "EjUserId": 316,
    "RequestSignature": "nihil",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": false,
    "IsOnTravel": false,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Sawayn, Satterfield and O'Kon",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Yundt-Bergstrom",
    "WaitingForApproval": false,
    "ExtraFields": {
      "ExtraFields1": "rerum",
      "ExtraFields2": "est"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "architecto"
    },
    "PostSaveCommands": [
      {},
      {}
    ]
  },
  "UserType": "AnonymousAssociate"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 256,
  "Name": "Gleason-Bergstrom",
  "Rank": 677,
  "Tooltip": "aliquam",
  "LicenseOwners": [
    {
      "Name": "Fritsch, Goodwin and Cartwright",
      "Description": "Decentralized needs-based challenge",
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
          "FieldLength": 820
        }
      }
    },
    {
      "Name": "Fritsch, Goodwin and Cartwright",
      "Description": "Decentralized needs-based challenge",
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
          "FieldLength": 820
        }
      }
    }
  ],
  "Role": {
    "Id": 331,
    "Value": "voluptatum",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 216
      }
    }
  },
  "UserGroup": {
    "Value": "id",
    "Tooltip": "ut",
    "Id": 290,
    "Rank": 361,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 323
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "eius",
      "Tooltip": "quia",
      "Id": 152,
      "Rank": 468,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 928
        }
      }
    }
  ],
  "Person": {
    "Position": "consectetur",
    "PersonId": 574,
    "Mrmrs": "dolorum",
    "Firstname": "Grant",
    "Lastname": "Dickinson",
    "MiddleName": "Turner, Ryan and Vandervort",
    "Title": "recusandae",
    "Description": "Centralized discrete ability",
    "Email": "phyllis.oconnell@ratkeklein.name",
    "FullName": "Ms. Elisa Veum",
    "DirectPhone": "1-236-634-6636",
    "FormalName": "Hand Inc and Sons",
    "CountryId": 365,
    "ContactId": 547,
    "ContactName": "Lueilwitz Inc and Sons",
    "Retired": 101,
    "Rank": 861,
    "ActiveInterests": 459,
    "ContactDepartment": "",
    "ContactCountryId": 71,
    "ContactOrgNr": "1621359",
    "FaxPhone": "(366)710-2653",
    "MobilePhone": "844-424-0224",
    "ContactPhone": "874.210.6037",
    "AssociateName": "Buckridge, Crooks and Bartoletti",
    "AssociateId": 3,
    "UsePersonAddress": false,
    "ContactFax": "recusandae",
    "Kanafname": "in",
    "Kanalname": "consectetur",
    "Post1": "et",
    "Post2": "unde",
    "Post3": "qui",
    "EmailName": "adelbert_krajcik@armstrong.us",
    "ContactFullName": "Stacey Farrell",
    "ActiveErpLinks": 15,
    "TicketPriorityId": 515,
    "SupportLanguageId": 1000,
    "SupportAssociateId": 353,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 492
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "1995-11-26T16:48:30.8639348+01:00",
  "Lastlogout": "2008-11-13T16:48:30.8639348+01:00",
  "EjUserId": 294,
  "RequestSignature": "qui",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "molestias",
      "DisplayValue": "porro",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    },
    {
      "Type": {},
      "Value": "molestias",
      "DisplayValue": "porro",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    }
  ],
  "UserName": "Hodkiewicz-Corkery",
  "TicketCategories": [
    {
      "Id": 206,
      "Name": "Graham Group",
      "ToolTip": "Vel eum.",
      "Deleted": true,
      "Rank": 196,
      "Type": "nihil",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "neque",
      "ColorBlock": 848,
      "ExtraInfo": "dolorem",
      "StyleHint": "exercitationem",
      "FullName": "Laurel Keebler Sr.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    }
  ],
  "NickName": "Koepp-Davis",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "rem",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "quod"
  },
  "PostSaveCommands": [
    {
      "Name": "Koss Group",
      "DisplayName": "Leannon LLC",
      "Description": "Distributed composite infrastructure",
      "ToolTip": "Quisquam molestias repellendus maiores veniam repellendus porro.",
      "Actions": "Implicit",
      "ActionData": "molestiae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 922
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
      "FieldLength": 920
    }
  }
}
```