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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "User": {
    "AssociateId": 588,
    "Name": "Bergnaum Inc and Sons",
    "Rank": 279,
    "Tooltip": "fugit",
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
    "Lastlogin": "2016-06-02T18:28:50.4054145+02:00",
    "Lastlogout": "2008-05-01T18:28:50.4054145+02:00",
    "EjUserId": 22,
    "RequestSignature": "tempore",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": false,
    "IsOnTravel": true,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Senger-Raynor",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Gerlach Inc and Sons",
    "WaitingForApproval": false,
    "ExtraFields": {
      "ExtraFields1": "ex",
      "ExtraFields2": "mollitia"
    },
    "CustomFields": {
      "CustomFields1": "aliquam",
      "CustomFields2": "autem"
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
  "AssociateId": 740,
  "Name": "Leffler Group",
  "Rank": 595,
  "Tooltip": "dolor",
  "LicenseOwners": [
    {
      "Name": "Flatley, Witting and Sipes",
      "Description": "Cloned multi-state website",
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
          "FieldLength": 282
        }
      }
    },
    {
      "Name": "Flatley, Witting and Sipes",
      "Description": "Cloned multi-state website",
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
          "FieldLength": 282
        }
      }
    }
  ],
  "Role": {
    "Id": 720,
    "Value": "placeat",
    "Tooltip": "in",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 765
      }
    }
  },
  "UserGroup": {
    "Value": "ut",
    "Tooltip": "veritatis",
    "Id": 9,
    "Rank": 948,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 130
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "dicta",
      "Tooltip": "consequatur",
      "Id": 100,
      "Rank": 347,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 351
        }
      }
    }
  ],
  "Person": {
    "Position": "et",
    "PersonId": 201,
    "Mrmrs": "ratione",
    "Firstname": "Lorna",
    "Lastname": "Sawayn",
    "MiddleName": "Schneider, Mueller and Schoen",
    "Title": "ut",
    "Description": "Horizontal intangible support",
    "Email": "bryon.bernhard@halvorsonschiller.us",
    "FullName": "Vivian Hoeger",
    "DirectPhone": "(060)058-0870 x78172",
    "FormalName": "Ernser-Romaguera",
    "CountryId": 585,
    "ContactId": 6,
    "ContactName": "Kerluke-Corwin",
    "Retired": 151,
    "Rank": 605,
    "ActiveInterests": 125,
    "ContactDepartment": "",
    "ContactCountryId": 208,
    "ContactOrgNr": "959225",
    "FaxPhone": "1-128-705-6683",
    "MobilePhone": "063-185-0207 x3325",
    "ContactPhone": "744.078.8656 x182",
    "AssociateName": "Labadie, Zieme and Moore",
    "AssociateId": 660,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "dignissimos",
    "Kanalname": "sit",
    "Post1": "est",
    "Post2": "nihil",
    "Post3": "aut",
    "EmailName": "destiny.rodriguez@hackett.ca",
    "ContactFullName": "Brandt Yundt",
    "ActiveErpLinks": 726,
    "TicketPriorityId": 483,
    "SupportLanguageId": 723,
    "SupportAssociateId": 666,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 882
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2002-04-07T18:28:50.411412+02:00",
  "Lastlogout": "2012-05-20T18:28:50.411412+02:00",
  "EjUserId": 221,
  "RequestSignature": "inventore",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "quia",
      "DisplayValue": "laboriosam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 730
        }
      }
    },
    {
      "Type": {},
      "Value": "quia",
      "DisplayValue": "laboriosam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 730
        }
      }
    }
  ],
  "UserName": "Corwin, Grady and Pfeffer",
  "TicketCategories": [
    {
      "Id": 741,
      "Name": "Emmerich Inc and Sons",
      "ToolTip": "Vitae sapiente rem sint.",
      "Deleted": true,
      "Rank": 335,
      "Type": "perspiciatis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "neque",
      "ColorBlock": 293,
      "ExtraInfo": "voluptatem",
      "StyleHint": "dolor",
      "FullName": "Dr. Tessie Lockman",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    }
  ],
  "NickName": "Weber Group",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "mollitia"
  },
  "CustomFields": {
    "CustomFields1": "hic",
    "CustomFields2": "reiciendis"
  },
  "PostSaveCommands": [
    {
      "Name": "Sawayn LLC",
      "DisplayName": "Spencer LLC",
      "Description": "Secured responsive migration",
      "ToolTip": "Est sint laudantium.",
      "Actions": "Implicit",
      "ActionData": "dolor",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 763
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
      "FieldLength": 95
    }
  }
}
```