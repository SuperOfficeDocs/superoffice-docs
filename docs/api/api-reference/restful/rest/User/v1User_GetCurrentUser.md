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
  "AssociateId": 210,
  "Name": "Friesen LLC",
  "Rank": 874,
  "Tooltip": "vero",
  "LicenseOwners": [
    {
      "Name": "Ryan-Stracke",
      "Description": "Profound secondary forecast",
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
          "FieldLength": 659
        }
      }
    },
    {
      "Name": "Ryan-Stracke",
      "Description": "Profound secondary forecast",
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
          "FieldLength": 659
        }
      }
    }
  ],
  "Role": {
    "Id": 199,
    "Value": "et",
    "Tooltip": "quod",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 961
      }
    }
  },
  "UserGroup": {
    "Value": "rerum",
    "Tooltip": "asperiores",
    "Id": 167,
    "Rank": 482,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 104
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "nihil",
      "Tooltip": "ut",
      "Id": 163,
      "Rank": 538,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 961
        }
      }
    }
  ],
  "Person": {
    "Position": "error",
    "PersonId": 398,
    "Mrmrs": "doloremque",
    "Firstname": "Willa",
    "Lastname": "Tremblay",
    "MiddleName": "Deckow-Kihn",
    "Title": "repudiandae",
    "Description": "Enhanced uniform algorithm",
    "Email": "maximo.marks@daugherty.info",
    "FullName": "Eveline Blick",
    "DirectPhone": "1-184-386-7056 x427",
    "FormalName": "Glover LLC",
    "CountryId": 164,
    "ContactId": 513,
    "ContactName": "Muller, Champlin and Roob",
    "Retired": 459,
    "Rank": 100,
    "ActiveInterests": 792,
    "ContactDepartment": "",
    "ContactCountryId": 783,
    "ContactOrgNr": "1752545",
    "FaxPhone": "668.322.8384 x181",
    "MobilePhone": "627.018.5254 x34434",
    "ContactPhone": "1-800-006-3370 x6752",
    "AssociateName": "Crist-Marquardt",
    "AssociateId": 484,
    "UsePersonAddress": true,
    "ContactFax": "velit",
    "Kanafname": "facilis",
    "Kanalname": "sint",
    "Post1": "aspernatur",
    "Post2": "delectus",
    "Post3": "temporibus",
    "EmailName": "pamela@mante.name",
    "ContactFullName": "Terrill Windler DVM",
    "ActiveErpLinks": 456,
    "TicketPriorityId": 212,
    "SupportLanguageId": 105,
    "SupportAssociateId": 175,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 944
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "1997-03-14T09:41:00.1051803+01:00",
  "Lastlogout": "1994-04-01T09:41:00.1051803+02:00",
  "EjUserId": 60,
  "RequestSignature": "exercitationem",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "est",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    },
    {
      "Type": {},
      "Value": "est",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    }
  ],
  "UserName": "Hudson Group",
  "TicketCategories": [
    {
      "Id": 432,
      "Name": "Jerde LLC",
      "ToolTip": "Provident a molestias ut.",
      "Deleted": false,
      "Rank": 91,
      "Type": "possimus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quisquam",
      "ColorBlock": 932,
      "ExtraInfo": "quam",
      "StyleHint": "repudiandae",
      "FullName": "Marlin Veum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    }
  ],
  "NickName": "Cummerata, Thompson and Vandervort",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "provident"
  },
  "PostSaveCommands": [
    {
      "Name": "Ratke-Stehr",
      "DisplayName": "Ankunding Group",
      "Description": "Triple-buffered foreground policy",
      "ToolTip": "Esse voluptas.",
      "Actions": "Implicit",
      "ActionData": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 295
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
      "FieldLength": 994
    }
  }
}
```