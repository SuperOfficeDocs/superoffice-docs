---
title: ChangeUserType
id: v1UserAgent_ChangeUserType
---

# ChangeUserType

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "User": {
    "AssociateId": 855,
    "Name": "Nienow, Stanton and Erdman",
    "Rank": 305,
    "Tooltip": "ipsa",
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
    "Lastlogin": "2013-05-11T14:58:05.4086237+02:00",
    "Lastlogout": "2010-07-05T14:58:05.4086237+02:00",
    "EjUserId": 467,
    "RequestSignature": "qui",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": true,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Fay-Klein",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Kirlin, Schmidt and Kris",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "et",
      "ExtraFields2": "fugiat"
    },
    "CustomFields": {
      "CustomFields1": "aut",
      "CustomFields2": "omnis"
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
  "AssociateId": 514,
  "Name": "Koch-Olson",
  "Rank": 852,
  "Tooltip": "aut",
  "LicenseOwners": [
    {
      "Name": "Lehner-Ortiz",
      "Description": "Grass-roots composite model",
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
          "FieldLength": 901
        }
      }
    },
    {
      "Name": "Lehner-Ortiz",
      "Description": "Grass-roots composite model",
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
          "FieldLength": 901
        }
      }
    }
  ],
  "Role": {
    "Id": 811,
    "Value": "aut",
    "Tooltip": "nostrum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 307
      }
    }
  },
  "UserGroup": {
    "Value": "et",
    "Tooltip": "omnis",
    "Id": 499,
    "Rank": 552,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 650
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "amet",
      "Tooltip": "animi",
      "Id": 880,
      "Rank": 898,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 701
        }
      }
    }
  ],
  "Person": {
    "Position": "dolore",
    "PersonId": 426,
    "Mrmrs": "dolor",
    "Firstname": "Clair",
    "Lastname": "Gibson",
    "MiddleName": "Carter Inc and Sons",
    "Title": "perspiciatis",
    "Description": "Team-oriented contextually-based service-desk",
    "Email": "celestino_bogisich@lakinbode.co.uk",
    "FullName": "Linda O'Hara",
    "DirectPhone": "238-473-4241",
    "FormalName": "Hilpert, Watsica and Thompson",
    "CountryId": 675,
    "ContactId": 738,
    "ContactName": "Lind-Nikolaus",
    "Retired": 11,
    "Rank": 373,
    "ActiveInterests": 46,
    "ContactDepartment": "",
    "ContactCountryId": 203,
    "ContactOrgNr": "927445",
    "FaxPhone": "121-814-8071 x401",
    "MobilePhone": "1-837-431-5734",
    "ContactPhone": "(857)146-3083 x02147",
    "AssociateName": "Stracke, Stamm and Lynch",
    "AssociateId": 62,
    "UsePersonAddress": true,
    "ContactFax": "nam",
    "Kanafname": "soluta",
    "Kanalname": "impedit",
    "Post1": "libero",
    "Post2": "ex",
    "Post3": "impedit",
    "EmailName": "courtney@crona.uk",
    "ContactFullName": "Avery Denesik DVM",
    "ActiveErpLinks": 945,
    "TicketPriorityId": 74,
    "SupportLanguageId": 722,
    "SupportAssociateId": 10,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 989
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2010-06-24T14:58:05.4136234+02:00",
  "Lastlogout": "2009-05-02T14:58:05.4136234+02:00",
  "EjUserId": 498,
  "RequestSignature": "ea",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "suscipit",
      "DisplayValue": "repellat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    },
    {
      "Type": {},
      "Value": "suscipit",
      "DisplayValue": "repellat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    }
  ],
  "UserName": "Schaefer, Bechtelar and Kuphal",
  "TicketCategories": [
    {
      "Id": 127,
      "Name": "Heaney, Gutkowski and Pacocha",
      "ToolTip": "Est laboriosam cumque aspernatur.",
      "Deleted": true,
      "Rank": 50,
      "Type": "sequi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "et",
      "ColorBlock": 717,
      "ExtraInfo": "facere",
      "StyleHint": "molestiae",
      "FullName": "Hattie Rowe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 489
        }
      }
    }
  ],
  "NickName": "Rice, Morar and Johns",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "repudiandae"
  },
  "PostSaveCommands": [
    {
      "Name": "Harris LLC",
      "DisplayName": "Cartwright, Murphy and Turner",
      "Description": "Face to face exuding knowledge user",
      "ToolTip": "Aperiam omnis.",
      "Actions": "Implicit",
      "ActionData": "quas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 602
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
      "FieldLength": 350
    }
  }
}
```