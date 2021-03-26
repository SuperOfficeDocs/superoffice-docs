---
title: POST Agents/User/CreateDefaultUserFromUserTypeAndPersonId
id: v1UserAgent_CreateDefaultUserFromUserTypeAndPersonId
---

# POST Agents/User/CreateDefaultUserFromUserTypeAndPersonId

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndPersonId
```

Create default User providing the associate type and person id.

System and Anonymous users can be created without an exsisting person and permits person id to be 0.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndPersonId?$select=name,department,category/id
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

UserType, PersonId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserType | string |  |
| PersonId | int32 |  |


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
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndPersonId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "PersonId": 914
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 403,
  "Name": "Thiel-Shields",
  "Rank": 860,
  "Tooltip": "minima",
  "LicenseOwners": [
    {
      "Name": "Harvey, Schmidt and Reichel",
      "Description": "Open-source value-added framework",
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
          "FieldLength": 193
        }
      }
    },
    {
      "Name": "Harvey, Schmidt and Reichel",
      "Description": "Open-source value-added framework",
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
          "FieldLength": 193
        }
      }
    }
  ],
  "Role": {
    "Id": 552,
    "Value": "dolor",
    "Tooltip": "dolor",
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
  "UserGroup": {
    "Value": "vero",
    "Tooltip": "nobis",
    "Id": 310,
    "Rank": 146,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark dynamic e-commerce"
        },
        "FieldType": "System.Int32",
        "FieldLength": 463
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "a",
      "Tooltip": "error",
      "Id": 671,
      "Rank": 41,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    }
  ],
  "Person": {
    "Position": "pariatur",
    "PersonId": 573,
    "Mrmrs": "voluptas",
    "Firstname": "Dagmar",
    "Lastname": "Green",
    "MiddleName": "Jacobi Group",
    "Title": "et",
    "Description": "Cross-group fresh-thinking function",
    "Email": "royal@kerluke.ca",
    "FullName": "Wilfrid Kirlin I",
    "DirectPhone": "076-111-5442",
    "FormalName": "Grimes-Hilpert",
    "CountryId": 406,
    "ContactId": 93,
    "ContactName": "Weber-Schamberger",
    "Retired": 290,
    "Rank": 342,
    "ActiveInterests": 644,
    "ContactDepartment": "empower value-added web services",
    "ContactCountryId": 367,
    "ContactOrgNr": "1082019",
    "FaxPhone": "471-861-3414 x7057",
    "MobilePhone": "(556)010-2117",
    "ContactPhone": "855.178.6703",
    "AssociateName": "Haag LLC",
    "AssociateId": 283,
    "UsePersonAddress": false,
    "ContactFax": "porro",
    "Kanafname": "nihil",
    "Kanalname": "accusantium",
    "Post1": "numquam",
    "Post2": "velit",
    "Post3": "non",
    "EmailName": "julien.parisian@braun.info",
    "ContactFullName": "Ada Murray",
    "ActiveErpLinks": 937,
    "TicketPriorityId": 290,
    "SupportLanguageId": 732,
    "SupportAssociateId": 861,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 39
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2006-07-17T16:48:30.8409406+02:00",
  "Lastlogout": "2019-06-09T16:48:30.8409406+02:00",
  "EjUserId": 565,
  "RequestSignature": "quod",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "ad",
      "DisplayValue": "eos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "facilitate out-of-the-box mindshare"
          },
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Type": {},
      "Value": "ad",
      "DisplayValue": "eos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "facilitate out-of-the-box mindshare"
          },
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "UserName": "Bradtke Group",
  "TicketCategories": [
    {
      "Id": 218,
      "Name": "Pollich, Kub and Auer",
      "ToolTip": "Et natus ut.",
      "Deleted": true,
      "Rank": 661,
      "Type": "explicabo",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "cumque",
      "ColorBlock": 815,
      "ExtraInfo": "cupiditate",
      "StyleHint": "non",
      "FullName": "Juvenal DuBuque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 376
        }
      }
    }
  ],
  "NickName": "Ullrich Inc and Sons",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "error"
  },
  "PostSaveCommands": [
    {
      "Name": "Ernser Group",
      "DisplayName": "Nicolas LLC",
      "Description": "Expanded 24/7 superstructure",
      "ToolTip": "Recusandae architecto.",
      "Actions": "Implicit",
      "ActionData": "sunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 200
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
      "FieldLength": 851
    }
  }
}
```