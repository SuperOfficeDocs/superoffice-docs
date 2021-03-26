---
title: POST Agents/User/SaveUserFromName
id: v1UserAgent_SaveUserFromName
---

# POST Agents/User/SaveUserFromName

```http
POST /api/v1/Agents/User/SaveUserFromName
```

Save a user, with lookup based on the user name.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/SaveUserFromName?$select=name,department,category/id
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

UserName, User 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserName | string |  |
| User |  | SuperOffice User, with login credentials and an associated person. <para /> Carrier object for User. Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |


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
POST /api/v1/Agents/User/SaveUserFromName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "UserName": "Upton Inc and Sons",
  "User": {
    "AssociateId": 295,
    "Name": "Mueller-O'Connell",
    "Rank": 835,
    "Tooltip": "voluptatibus",
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
    "Lastlogin": "1998-10-15T16:48:30.9869406+02:00",
    "Lastlogout": "2016-06-07T16:48:30.9869406+02:00",
    "EjUserId": 334,
    "RequestSignature": "eius",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": false,
    "IsOnTravel": false,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Fay, Breitenberg and Volkman",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Kiehn, Schimmel and Kunze",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "ut",
      "ExtraFields2": "velit"
    },
    "CustomFields": {
      "CustomFields1": "doloremque",
      "CustomFields2": "pariatur"
    },
    "PostSaveCommands": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 649,
  "Name": "Von LLC",
  "Rank": 786,
  "Tooltip": "molestiae",
  "LicenseOwners": [
    {
      "Name": "Hirthe, Hintz and Auer",
      "Description": "Optimized 3rd generation solution",
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
          "FieldLength": 589
        }
      }
    },
    {
      "Name": "Hirthe, Hintz and Auer",
      "Description": "Optimized 3rd generation solution",
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
          "FieldLength": 589
        }
      }
    }
  ],
  "Role": {
    "Id": 330,
    "Value": "qui",
    "Tooltip": "in",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 822
      }
    }
  },
  "UserGroup": {
    "Value": "quos",
    "Tooltip": "dolore",
    "Id": 596,
    "Rank": 115,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 774
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "hic",
      "Tooltip": "fuga",
      "Id": 841,
      "Rank": 155,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    }
  ],
  "Person": {
    "Position": "itaque",
    "PersonId": 961,
    "Mrmrs": "repellat",
    "Firstname": "Chester",
    "Lastname": "Wintheiser",
    "MiddleName": "Blanda-Blanda",
    "Title": "earum",
    "Description": "Integrated homogeneous projection",
    "Email": "henderson@luettgenturcotte.us",
    "FullName": "Diana McDermott",
    "DirectPhone": "167.210.1514",
    "FormalName": "Grant-Ebert",
    "CountryId": 118,
    "ContactId": 285,
    "ContactName": "Treutel, Renner and Predovic",
    "Retired": 76,
    "Rank": 10,
    "ActiveInterests": 406,
    "ContactDepartment": "integrate value-added eyeballs",
    "ContactCountryId": 970,
    "ContactOrgNr": "490535",
    "FaxPhone": "(163)073-1378 x731",
    "MobilePhone": "1-171-228-4054 x37571",
    "ContactPhone": "182.638.8127 x74762",
    "AssociateName": "Feeney-Durgan",
    "AssociateId": 870,
    "UsePersonAddress": true,
    "ContactFax": "expedita",
    "Kanafname": "nihil",
    "Kanalname": "eos",
    "Post1": "eos",
    "Post2": "maiores",
    "Post3": "ipsam",
    "EmailName": "stone@sauer.ca",
    "ContactFullName": "Theresa Adams DVM",
    "ActiveErpLinks": 402,
    "TicketPriorityId": 51,
    "SupportLanguageId": 961,
    "SupportAssociateId": 191,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 571
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "1995-07-09T16:48:30.9929339+02:00",
  "Lastlogout": "2020-06-05T16:48:30.9929339+02:00",
  "EjUserId": 968,
  "RequestSignature": "sed",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "illo",
      "DisplayValue": "laboriosam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    },
    {
      "Type": {},
      "Value": "illo",
      "DisplayValue": "laboriosam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    }
  ],
  "UserName": "Langworth, Ledner and Simonis",
  "TicketCategories": [
    {
      "Id": 633,
      "Name": "Gleason-Abbott",
      "ToolTip": "Voluptatum autem voluptatem hic magnam est.",
      "Deleted": false,
      "Rank": 419,
      "Type": "autem",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "itaque",
      "ColorBlock": 400,
      "ExtraInfo": "corporis",
      "StyleHint": "ex",
      "FullName": "Santino Kerluke",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "NickName": "Abshire Group",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "dignissimos"
  },
  "PostSaveCommands": [
    {
      "Name": "Goldner, Moen and Jakubowski",
      "DisplayName": "Walker-Reinger",
      "Description": "Devolved cohesive access",
      "ToolTip": "At modi non minima.",
      "Actions": "Implicit",
      "ActionData": "error",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 406
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
      "FieldLength": 579
    }
  }
}
```