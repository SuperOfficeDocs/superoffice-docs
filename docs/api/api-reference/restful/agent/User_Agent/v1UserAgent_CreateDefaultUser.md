---
title: CreateDefaultUser
id: v1UserAgent_CreateDefaultUser
---

# CreateDefaultUser

```http
POST /api/v1/Agents/User/CreateDefaultUser
```

Set default values into a new User.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






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
POST /api/v1/Agents/User/CreateDefaultUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 879,
  "Name": "Berge, Kihn and Ernser",
  "Rank": 879,
  "Tooltip": "omnis",
  "LicenseOwners": [
    {
      "Name": "Nader LLC",
      "Description": "Focused tertiary Graphical User Interface",
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
          "FieldLength": 508
        }
      }
    },
    {
      "Name": "Nader LLC",
      "Description": "Focused tertiary Graphical User Interface",
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
          "FieldLength": 508
        }
      }
    }
  ],
  "Role": {
    "Id": 873,
    "Value": "voluptatum",
    "Tooltip": "quidem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 780
      }
    }
  },
  "UserGroup": {
    "Value": "facere",
    "Tooltip": "qui",
    "Id": 234,
    "Rank": 842,
    "Deleted": false,
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
  },
  "OtherGroups": [
    {
      "Value": "dolores",
      "Tooltip": "quia",
      "Id": 524,
      "Rank": 391,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    }
  ],
  "Person": {
    "Position": "autem",
    "PersonId": 712,
    "Mrmrs": "itaque",
    "Firstname": "Bud",
    "Lastname": "Dicki",
    "MiddleName": "Weber Group",
    "Title": "aspernatur",
    "Description": "Right-sized 24 hour internet solution",
    "Email": "hayley@hoppejohnston.biz",
    "FullName": "Marques Thompson",
    "DirectPhone": "1-421-247-0603 x6678",
    "FormalName": "Schmitt-Murray",
    "CountryId": 28,
    "ContactId": 686,
    "ContactName": "Bashirian, Wiza and Dooley",
    "Retired": 989,
    "Rank": 206,
    "ActiveInterests": 191,
    "ContactDepartment": "",
    "ContactCountryId": 801,
    "ContactOrgNr": "1085219",
    "FaxPhone": "076-370-8387 x36564",
    "MobilePhone": "405-040-1650 x1023",
    "ContactPhone": "1-054-580-4466",
    "AssociateName": "Schaden-Stroman",
    "AssociateId": 670,
    "UsePersonAddress": true,
    "ContactFax": "non",
    "Kanafname": "sunt",
    "Kanalname": "omnis",
    "Post1": "esse",
    "Post2": "aut",
    "Post3": "repellat",
    "EmailName": "precious_swift@lebsack.us",
    "ContactFullName": "Mr. Bradley Lesch",
    "ActiveErpLinks": 518,
    "TicketPriorityId": 43,
    "SupportLanguageId": 532,
    "SupportAssociateId": 844,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 319
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2013-09-06T14:58:05.5480543+02:00",
  "Lastlogout": "2007-10-25T14:58:05.5480543+02:00",
  "EjUserId": 967,
  "RequestSignature": "possimus",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "sed",
      "DisplayValue": "voluptatem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 927
        }
      }
    },
    {
      "Type": {},
      "Value": "sed",
      "DisplayValue": "voluptatem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 927
        }
      }
    }
  ],
  "UserName": "Leannon, Gibson and Heidenreich",
  "TicketCategories": [
    {
      "Id": 407,
      "Name": "Klocko Inc and Sons",
      "ToolTip": "Illo vero dolore.",
      "Deleted": true,
      "Rank": 90,
      "Type": "necessitatibus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sapiente",
      "ColorBlock": 535,
      "ExtraInfo": "rerum",
      "StyleHint": "voluptas",
      "FullName": "Dr. Carter Tremblay",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 412
        }
      }
    }
  ],
  "NickName": "Smitham-Von",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "tenetur",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "quae",
    "CustomFields2": "et"
  },
  "PostSaveCommands": [
    {
      "Name": "Mosciski, Goyette and Weber",
      "DisplayName": "Sawayn LLC",
      "Description": "Upgradable bifurcated capability",
      "ToolTip": "Ipsa aliquam adipisci numquam.",
      "Actions": "Implicit",
      "ActionData": "exercitationem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 645
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
      "FieldLength": 937
    }
  }
}
```