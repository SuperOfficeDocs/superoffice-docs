---
title: GET User/current
id: v1User_GetCurrentUser
---

# GET User/current

```http
GET /api/v1/User/current
```

Gets the currently logged in user's information: username, personal name, credentials, licenses.

Blocked in Online for safety. Calls the User agent service GetUser.






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
GET /api/v1/User/current
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 50,
  "Name": "Howe-Ullrich",
  "Rank": 162,
  "Tooltip": "placeat",
  "LicenseOwners": [
    {
      "Name": "Jerde-Abbott",
      "Description": "Fundamental non-volatile internet solution",
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
          "FieldLength": 498
        }
      }
    },
    {
      "Name": "Jerde-Abbott",
      "Description": "Fundamental non-volatile internet solution",
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
          "FieldLength": 498
        }
      }
    }
  ],
  "Role": {
    "Id": 610,
    "Value": "eius",
    "Tooltip": "iure",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 328
      }
    }
  },
  "UserGroup": {
    "Value": "quaerat",
    "Tooltip": "rem",
    "Id": 593,
    "Rank": 416,
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
  },
  "OtherGroups": [
    {
      "Value": "maxime",
      "Tooltip": "ducimus",
      "Id": 496,
      "Rank": 84,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "embrace ubiquitous web-readiness"
          },
          "FieldType": "System.String",
          "FieldLength": 178
        }
      }
    }
  ],
  "Person": {
    "Position": "facilis",
    "PersonId": 737,
    "Mrmrs": "distinctio",
    "Firstname": "Lloyd",
    "Lastname": "Stracke",
    "MiddleName": "Skiles, Smith and Kuhn",
    "Title": "earum",
    "Description": "Inverse upward-trending capability",
    "Email": "loy@wilderman.info",
    "FullName": "Omer Toy",
    "DirectPhone": "1-218-162-0276",
    "FormalName": "Bechtelar, Goyette and Muller",
    "CountryId": 309,
    "ContactId": 479,
    "ContactName": "Roob, Wilkinson and Bins",
    "Retired": 142,
    "Rank": 218,
    "ActiveInterests": 442,
    "ContactDepartment": "",
    "ContactCountryId": 623,
    "ContactOrgNr": "1009651",
    "FaxPhone": "(881)803-3675 x02255",
    "MobilePhone": "233.556.8677",
    "ContactPhone": "068.544.2375",
    "AssociateName": "Wilkinson, Ward and Goodwin",
    "AssociateId": 606,
    "UsePersonAddress": false,
    "ContactFax": "tempore",
    "Kanafname": "possimus",
    "Kanalname": "est",
    "Post1": "est",
    "Post2": "repudiandae",
    "Post3": "ut",
    "EmailName": "viva@conroygottlieb.com",
    "ContactFullName": "Willis Toy",
    "ActiveErpLinks": 40,
    "TicketPriorityId": 600,
    "SupportLanguageId": 772,
    "SupportAssociateId": 91,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 459
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2010-03-29T18:25:51.5511229+02:00",
  "Lastlogout": "2011-05-08T18:25:51.5511229+02:00",
  "EjUserId": 41,
  "RequestSignature": "tempore",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "blanditiis",
      "DisplayValue": "magnam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    },
    {
      "Type": {},
      "Value": "blanditiis",
      "DisplayValue": "magnam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    }
  ],
  "UserName": "Veum Inc and Sons",
  "TicketCategories": [
    {
      "Id": 727,
      "Name": "Roberts, Yost and Mueller",
      "ToolTip": "Et architecto et libero velit debitis.",
      "Deleted": false,
      "Rank": 232,
      "Type": "corrupti",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "adipisci",
      "ColorBlock": 77,
      "ExtraInfo": "ea",
      "StyleHint": "eius",
      "FullName": "Roberta Lowe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "NickName": "Christiansen Group",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "voluptatibus"
  },
  "PostSaveCommands": [
    {
      "Name": "Huel LLC",
      "DisplayName": "Osinski-Bahringer",
      "Description": "Re-contextualized assymetric paradigm",
      "ToolTip": "Sunt et quo impedit praesentium incidunt.",
      "Actions": "Implicit",
      "ActionData": "fugit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 569
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
      "FieldLength": 808
    }
  }
}
```