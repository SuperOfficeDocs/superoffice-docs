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
  "UserName": "Lockman-Osinski",
  "User": {
    "AssociateId": 376,
    "Name": "Greenfelder-Schuppe",
    "Rank": 445,
    "Tooltip": "consequatur",
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
    "Lastlogin": "2006-04-13T18:28:50.4444119+02:00",
    "Lastlogout": "2019-10-03T18:28:50.4444119+02:00",
    "EjUserId": 705,
    "RequestSignature": "adipisci",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": true,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Hackett Inc and Sons",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Corkery-Moen",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "veniam",
      "ExtraFields2": "explicabo"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "adipisci"
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
  "AssociateId": 762,
  "Name": "Cruickshank, O'Keefe and Klocko",
  "Rank": 162,
  "Tooltip": "error",
  "LicenseOwners": [
    {
      "Name": "Murazik-Boehm",
      "Description": "Progressive assymetric task-force",
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
          "FieldLength": 947
        }
      }
    },
    {
      "Name": "Murazik-Boehm",
      "Description": "Progressive assymetric task-force",
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
          "FieldLength": 947
        }
      }
    }
  ],
  "Role": {
    "Id": 439,
    "Value": "minus",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 343
      }
    }
  },
  "UserGroup": {
    "Value": "quo",
    "Tooltip": "sit",
    "Id": 199,
    "Rank": 717,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 11
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "qui",
      "Tooltip": "maxime",
      "Id": 651,
      "Rank": 191,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 542
        }
      }
    }
  ],
  "Person": {
    "Position": "quibusdam",
    "PersonId": 711,
    "Mrmrs": "provident",
    "Firstname": "Marjolaine",
    "Lastname": "Koelpin",
    "MiddleName": "Senger-Runolfsson",
    "Title": "illum",
    "Description": "Intuitive object-oriented capability",
    "Email": "sheridan_gislason@legros.ca",
    "FullName": "Winnifred Yundt",
    "DirectPhone": "846-535-5426 x1166",
    "FormalName": "Fisher Inc and Sons",
    "CountryId": 766,
    "ContactId": 152,
    "ContactName": "Kunze LLC",
    "Retired": 997,
    "Rank": 243,
    "ActiveInterests": 560,
    "ContactDepartment": "",
    "ContactCountryId": 11,
    "ContactOrgNr": "1557129",
    "FaxPhone": "(646)753-0347",
    "MobilePhone": "(521)618-6082",
    "ContactPhone": "(781)344-0056",
    "AssociateName": "Emard, Abernathy and Nikolaus",
    "AssociateId": 442,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "rerum",
    "Kanalname": "voluptas",
    "Post1": "et",
    "Post2": "dolor",
    "Post3": "molestiae",
    "EmailName": "derek@osinski.biz",
    "ContactFullName": "Marcel Gerlach",
    "ActiveErpLinks": 902,
    "TicketPriorityId": 635,
    "SupportLanguageId": 372,
    "SupportAssociateId": 394,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 84
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2018-04-15T18:28:50.4494118+02:00",
  "Lastlogout": "2003-01-04T18:28:50.4494118+01:00",
  "EjUserId": 64,
  "RequestSignature": "nesciunt",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "aperiam",
      "DisplayValue": "explicabo",
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
    },
    {
      "Type": {},
      "Value": "aperiam",
      "DisplayValue": "explicabo",
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
  "UserName": "Satterfield Inc and Sons",
  "TicketCategories": [
    {
      "Id": 432,
      "Name": "Ward-Ratke",
      "ToolTip": "Debitis delectus non.",
      "Deleted": false,
      "Rank": 898,
      "Type": "omnis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sed",
      "ColorBlock": 572,
      "ExtraInfo": "id",
      "StyleHint": "rerum",
      "FullName": "Simone Hermiston",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 387
        }
      }
    }
  ],
  "NickName": "Emmerich LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "earum",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "aut"
  },
  "PostSaveCommands": [
    {
      "Name": "Rippin, Dietrich and Friesen",
      "DisplayName": "Turner, Keeling and Kshlerin",
      "Description": "Customizable tangible array",
      "ToolTip": "Aut animi cum voluptatem laboriosam.",
      "Actions": "Implicit",
      "ActionData": "est",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 747
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
        "Reason": "matrix turn-key architectures"
      },
      "FieldType": "System.String",
      "FieldLength": 137
    }
  }
}
```