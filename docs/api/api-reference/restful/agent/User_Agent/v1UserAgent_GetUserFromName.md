---
title: GetUserFromName
id: v1UserAgent_GetUserFromName
---

# GetUserFromName

```http
POST /api/v1/Agents/User/GetUserFromName
```

Get a user, with lookup based on user name.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUserFromName?$select=name,department,category/id
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

UserName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserName | string |  |


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
POST /api/v1/Agents/User/GetUserFromName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UserName": "Friesen-Klocko"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 628,
  "Name": "Gislason Inc and Sons",
  "Rank": 429,
  "Tooltip": "qui",
  "LicenseOwners": [
    {
      "Name": "Cremin-Klocko",
      "Description": "Re-engineered foreground projection",
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
          "FieldLength": 858
        }
      }
    },
    {
      "Name": "Cremin-Klocko",
      "Description": "Re-engineered foreground projection",
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
          "FieldLength": 858
        }
      }
    }
  ],
  "Role": {
    "Id": 708,
    "Value": "dolorem",
    "Tooltip": "ex",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "harness out-of-the-box infomediaries"
        },
        "FieldType": "System.Int32",
        "FieldLength": 905
      }
    }
  },
  "UserGroup": {
    "Value": "rerum",
    "Tooltip": "ea",
    "Id": 663,
    "Rank": 107,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 652
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "sed",
      "Tooltip": "sed",
      "Id": 103,
      "Rank": 260,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    }
  ],
  "Person": {
    "Position": "sapiente",
    "PersonId": 353,
    "Mrmrs": "enim",
    "Firstname": "Arielle",
    "Lastname": "Crooks",
    "MiddleName": "Pacocha, Roob and Kiehn",
    "Title": "dolores",
    "Description": "Organized bi-directional alliance",
    "Email": "caroline@millsking.info",
    "FullName": "Donny Haley III",
    "DirectPhone": "1-000-555-4450 x075",
    "FormalName": "Ortiz Inc and Sons",
    "CountryId": 895,
    "ContactId": 453,
    "ContactName": "Kozey-Windler",
    "Retired": 972,
    "Rank": 222,
    "ActiveInterests": 566,
    "ContactDepartment": "",
    "ContactCountryId": 118,
    "ContactOrgNr": "1419905",
    "FaxPhone": "602.851.5517 x800",
    "MobilePhone": "(002)857-5276 x850",
    "ContactPhone": "(464)867-7878 x07056",
    "AssociateName": "Moen-Koelpin",
    "AssociateId": 854,
    "UsePersonAddress": true,
    "ContactFax": "quos",
    "Kanafname": "qui",
    "Kanalname": "itaque",
    "Post1": "blanditiis",
    "Post2": "natus",
    "Post3": "alias",
    "EmailName": "petra@keeling.co.uk",
    "ContactFullName": "Dasia Miller Sr.",
    "ActiveErpLinks": 270,
    "TicketPriorityId": 384,
    "SupportLanguageId": 939,
    "SupportAssociateId": 760,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 214
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2009-07-08T14:58:05.4416229+02:00",
  "Lastlogout": "2002-05-25T14:58:05.4416229+02:00",
  "EjUserId": 547,
  "RequestSignature": "maiores",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "voluptates",
      "DisplayValue": "libero",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    },
    {
      "Type": {},
      "Value": "voluptates",
      "DisplayValue": "libero",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    }
  ],
  "UserName": "Johnson Inc and Sons",
  "TicketCategories": [
    {
      "Id": 253,
      "Name": "Emmerich-Morar",
      "ToolTip": "Dicta tempora non quia nisi ipsum voluptates.",
      "Deleted": false,
      "Rank": 47,
      "Type": "ut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "qui",
      "ColorBlock": 128,
      "ExtraInfo": "voluptas",
      "StyleHint": "corporis",
      "FullName": "Erin Daniel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    }
  ],
  "NickName": "Lockman LLC",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "animi",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "saepe"
  },
  "PostSaveCommands": [
    {
      "Name": "Klein LLC",
      "DisplayName": "Langworth LLC",
      "Description": "Seamless full-range policy",
      "ToolTip": "Sunt quaerat.",
      "Actions": "Implicit",
      "ActionData": "sed",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 653
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
      "FieldLength": 277
    }
  }
}
```