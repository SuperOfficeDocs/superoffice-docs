---
title: POST Agents/User/CreateDefaultUserFromUserType
id: v1UserAgent_CreateDefaultUserFromUserType
---

# POST Agents/User/CreateDefaultUserFromUserType

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserType
```

Create default User providing the user type.

Only System and Anonymous users can be created without an exsisting person.  Use CreateDefaultUserFromUserTypeAndPersonId to create internal (i.e. Employee) or external users.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserType?$select=name,department,category/id
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

UserType 

| Property Name | Type |  Description |
|----------------|------|--------------|
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
POST /api/v1/Agents/User/CreateDefaultUserFromUserType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 966,
  "Name": "Will, Parker and Konopelski",
  "Rank": 520,
  "Tooltip": "omnis",
  "LicenseOwners": [
    {
      "Name": "Jaskolski, Marvin and Mayert",
      "Description": "Advanced incremental application",
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
          "FieldLength": 426
        }
      }
    },
    {
      "Name": "Jaskolski, Marvin and Mayert",
      "Description": "Advanced incremental application",
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
          "FieldLength": 426
        }
      }
    }
  ],
  "Role": {
    "Id": 989,
    "Value": "corrupti",
    "Tooltip": "mollitia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 994
      }
    }
  },
  "UserGroup": {
    "Value": "eius",
    "Tooltip": "rerum",
    "Id": 645,
    "Rank": 781,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 725
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "nihil",
      "Tooltip": "qui",
      "Id": 23,
      "Rank": 246,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 510
        }
      }
    }
  ],
  "Person": {
    "Position": "veritatis",
    "PersonId": 49,
    "Mrmrs": "eligendi",
    "Firstname": "Jarvis",
    "Lastname": "Weissnat",
    "MiddleName": "Welch-Schaden",
    "Title": "dolores",
    "Description": "Secured impactful task-force",
    "Email": "tre.ankunding@larsonschulist.biz",
    "FullName": "Kelton Murazik",
    "DirectPhone": "731.163.4135 x1005",
    "FormalName": "Wunsch Group",
    "CountryId": 860,
    "ContactId": 292,
    "ContactName": "Emmerich Inc and Sons",
    "Retired": 314,
    "Rank": 661,
    "ActiveInterests": 272,
    "ContactDepartment": "",
    "ContactCountryId": 112,
    "ContactOrgNr": "1251421",
    "FaxPhone": "1-380-610-7517",
    "MobilePhone": "1-343-618-8177",
    "ContactPhone": "234.604.8724 x7012",
    "AssociateName": "Haley LLC",
    "AssociateId": 316,
    "UsePersonAddress": true,
    "ContactFax": "rerum",
    "Kanafname": "sint",
    "Kanalname": "perspiciatis",
    "Post1": "et",
    "Post2": "aut",
    "Post3": "repellendus",
    "EmailName": "kellen@mullerprosacco.com",
    "ContactFullName": "Vince Hahn",
    "ActiveErpLinks": 699,
    "TicketPriorityId": 369,
    "SupportLanguageId": 554,
    "SupportAssociateId": 879,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 472
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2003-09-18T18:28:50.4764133+02:00",
  "Lastlogout": "2007-08-22T18:28:50.4764133+02:00",
  "EjUserId": 889,
  "RequestSignature": "qui",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "neque",
      "DisplayValue": "culpa",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 682
        }
      }
    },
    {
      "Type": {},
      "Value": "neque",
      "DisplayValue": "culpa",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 682
        }
      }
    }
  ],
  "UserName": "Kutch-Lindgren",
  "TicketCategories": [
    {
      "Id": 659,
      "Name": "Connelly Group",
      "ToolTip": "Accusamus harum enim hic.",
      "Deleted": true,
      "Rank": 364,
      "Type": "qui",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "doloribus",
      "ColorBlock": 218,
      "ExtraInfo": "eveniet",
      "StyleHint": "aut",
      "FullName": "Russ Funk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 734
        }
      }
    }
  ],
  "NickName": "Huels, Kozey and Donnelly",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "laborum",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "omnis"
  },
  "PostSaveCommands": [
    {
      "Name": "Streich, Schuster and Jaskolski",
      "DisplayName": "Borer Inc and Sons",
      "Description": "Customizable responsive pricing structure",
      "ToolTip": "Dolor nam reprehenderit ipsa.",
      "Actions": "Implicit",
      "ActionData": "expedita",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 725
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
      "FieldLength": 208
    }
  }
}
```