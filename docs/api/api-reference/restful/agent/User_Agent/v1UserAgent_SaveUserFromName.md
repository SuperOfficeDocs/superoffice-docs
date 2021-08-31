---
title: SaveUserFromName
id: v1UserAgent_SaveUserFromName
---

# SaveUserFromName

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UserName": "Boehm, Steuber and Hahn",
  "User": {
    "AssociateId": 213,
    "Name": "Lind, Jacobs and Keeling",
    "Rank": 885,
    "Tooltip": "facere",
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
    "Lastlogin": "2003-08-22T14:58:05.4436236+02:00",
    "Lastlogout": "1999-07-12T14:58:05.4436236+02:00",
    "EjUserId": 238,
    "RequestSignature": "quia",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": true,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Reinger LLC",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Schmidt-White",
    "WaitingForApproval": false,
    "ExtraFields": {
      "ExtraFields1": "aut",
      "ExtraFields2": "nesciunt"
    },
    "CustomFields": {
      "CustomFields1": "est",
      "CustomFields2": "ut"
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
  "AssociateId": 63,
  "Name": "Will, Lebsack and Kautzer",
  "Rank": 984,
  "Tooltip": "in",
  "LicenseOwners": [
    {
      "Name": "Ullrich, Swift and Boyle",
      "Description": "Persevering non-volatile hub",
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
            "Reason": "empower holistic web-readiness"
          },
          "FieldType": "System.Int32",
          "FieldLength": 51
        }
      }
    },
    {
      "Name": "Ullrich, Swift and Boyle",
      "Description": "Persevering non-volatile hub",
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
            "Reason": "empower holistic web-readiness"
          },
          "FieldType": "System.Int32",
          "FieldLength": 51
        }
      }
    }
  ],
  "Role": {
    "Id": 872,
    "Value": "rerum",
    "Tooltip": "ex",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 304
      }
    }
  },
  "UserGroup": {
    "Value": "in",
    "Tooltip": "nemo",
    "Id": 784,
    "Rank": 314,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 873
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "odio",
      "Tooltip": "ut",
      "Id": 869,
      "Rank": 461,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "unleash 24/365 models"
          },
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "Person": {
    "Position": "doloribus",
    "PersonId": 639,
    "Mrmrs": "fuga",
    "Firstname": "Eugene",
    "Lastname": "Olson",
    "MiddleName": "Mills-Osinski",
    "Title": "consequatur",
    "Description": "Intuitive national standardization",
    "Email": "vito@langosh.uk",
    "FullName": "Wilson Fisher PhD",
    "DirectPhone": "224.768.2621",
    "FormalName": "Klein Inc and Sons",
    "CountryId": 213,
    "ContactId": 166,
    "ContactName": "Cartwright, DuBuque and Kunze",
    "Retired": 54,
    "Rank": 333,
    "ActiveInterests": 765,
    "ContactDepartment": "",
    "ContactCountryId": 792,
    "ContactOrgNr": "703662",
    "FaxPhone": "457-506-8310",
    "MobilePhone": "(031)840-8320 x25076",
    "ContactPhone": "043-624-8614 x48617",
    "AssociateName": "Satterfield Inc and Sons",
    "AssociateId": 191,
    "UsePersonAddress": true,
    "ContactFax": "reprehenderit",
    "Kanafname": "voluptas",
    "Kanalname": "inventore",
    "Post1": "sit",
    "Post2": "sit",
    "Post3": "officiis",
    "EmailName": "shanon@skiles.ca",
    "ContactFullName": "Jailyn Heidenreich",
    "ActiveErpLinks": 818,
    "TicketPriorityId": 26,
    "SupportLanguageId": 514,
    "SupportAssociateId": 24,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "orchestrate granular schemas"
        },
        "FieldType": "System.String",
        "FieldLength": 591
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "1996-10-25T14:58:05.4482906+02:00",
  "Lastlogout": "2004-03-04T14:58:05.4482906+01:00",
  "EjUserId": 303,
  "RequestSignature": "et",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "aut",
      "DisplayValue": "tempore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    },
    {
      "Type": {},
      "Value": "aut",
      "DisplayValue": "tempore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "UserName": "Krajcik Group",
  "TicketCategories": [
    {
      "Id": 652,
      "Name": "McKenzie-Mayer",
      "ToolTip": "Aliquam vel laboriosam.",
      "Deleted": false,
      "Rank": 854,
      "Type": "quia",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "veniam",
      "ColorBlock": 689,
      "ExtraInfo": "corporis",
      "StyleHint": "dicta",
      "FullName": "Ellen West",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 276
        }
      }
    }
  ],
  "NickName": "Johnston, Swaniawski and Simonis",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "itaque"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "explicabo"
  },
  "PostSaveCommands": [
    {
      "Name": "Brekke-Veum",
      "DisplayName": "Bernier, O'Kon and Treutel",
      "Description": "Seamless fault-tolerant support",
      "ToolTip": "Aut deleniti amet aspernatur qui nihil aspernatur.",
      "Actions": "Implicit",
      "ActionData": "non",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 951
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
      "FieldLength": 680
    }
  }
}
```