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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 485,
  "Name": "Baumbach LLC",
  "Rank": 31,
  "Tooltip": "alias",
  "LicenseOwners": [
    {
      "Name": "Halvorson-Zemlak",
      "Description": "Public-key context-sensitive middleware",
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
          "FieldLength": 107
        }
      }
    },
    {
      "Name": "Halvorson-Zemlak",
      "Description": "Public-key context-sensitive middleware",
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
          "FieldLength": 107
        }
      }
    }
  ],
  "Role": {
    "Id": 412,
    "Value": "quos",
    "Tooltip": "autem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 738
      }
    }
  },
  "UserGroup": {
    "Value": "aperiam",
    "Tooltip": "natus",
    "Id": 436,
    "Rank": 312,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 470
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "quis",
      "Tooltip": "id",
      "Id": 534,
      "Rank": 604,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 521
        }
      }
    }
  ],
  "Person": {
    "Position": "et",
    "PersonId": 75,
    "Mrmrs": "aliquid",
    "Firstname": "Walker",
    "Lastname": "Smitham",
    "MiddleName": "Carroll LLC",
    "Title": "nostrum",
    "Description": "Business-focused zero administration functionalities",
    "Email": "keagan.rowe@murazik.us",
    "FullName": "Dr. Nia Bechtelar",
    "DirectPhone": "128.016.4468 x4873",
    "FormalName": "Kuhlman Inc and Sons",
    "CountryId": 959,
    "ContactId": 769,
    "ContactName": "Spinka LLC",
    "Retired": 73,
    "Rank": 470,
    "ActiveInterests": 765,
    "ContactDepartment": "",
    "ContactCountryId": 638,
    "ContactOrgNr": "992810",
    "FaxPhone": "1-317-381-2172 x8273",
    "MobilePhone": "(872)278-0888",
    "ContactPhone": "142-201-6852 x04481",
    "AssociateName": "Borer, Koelpin and Ebert",
    "AssociateId": 570,
    "UsePersonAddress": true,
    "ContactFax": "adipisci",
    "Kanafname": "sunt",
    "Kanalname": "ipsa",
    "Post1": "possimus",
    "Post2": "incidunt",
    "Post3": "velit",
    "EmailName": "verlie@trantow.biz",
    "ContactFullName": "Terrance Schneider",
    "ActiveErpLinks": 4,
    "TicketPriorityId": 894,
    "SupportLanguageId": 317,
    "SupportAssociateId": 855,
    "CategoryName": "VIP Customer",
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
  "Deleted": false,
  "Lastlogin": "2002-05-31T15:05:43.1859039+02:00",
  "Lastlogout": "2011-10-22T15:05:43.1859039+02:00",
  "EjUserId": 361,
  "RequestSignature": "veniam",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "recusandae",
      "DisplayValue": "quis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    },
    {
      "Type": {},
      "Value": "recusandae",
      "DisplayValue": "quis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    }
  ],
  "UserName": "Hessel Group",
  "TicketCategories": [
    {
      "Id": 536,
      "Name": "Koelpin Inc and Sons",
      "ToolTip": "Vero adipisci officiis est praesentium.",
      "Deleted": false,
      "Rank": 155,
      "Type": "autem",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ipsum",
      "ColorBlock": 52,
      "ExtraInfo": "qui",
      "StyleHint": "laboriosam",
      "FullName": "Kaylin Moen",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 967
        }
      }
    }
  ],
  "NickName": "Ferry-Kuhn",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "fugit",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "est"
  },
  "PostSaveCommands": [
    {
      "Name": "Parisian LLC",
      "DisplayName": "Hermiston Group",
      "Description": "Operative uniform flexibility",
      "ToolTip": "Accusantium laborum.",
      "Actions": "Implicit",
      "ActionData": "quidem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 501
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
      "FieldLength": 968
    }
  }
}
```