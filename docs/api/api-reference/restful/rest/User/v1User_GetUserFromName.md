---
title: GET User/{userName}
id: v1User_GetUserFromName
---

# GET User/{userName}

```http
GET /api/v1/User/{userName}
```

Get a user, with lookup based on user name.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| userName | string | User name of the user to get. **Required** |



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
GET /api/v1/User/{userName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 717,
  "Name": "Wilkinson, Gerlach and Ratke",
  "Rank": 164,
  "Tooltip": "repellendus",
  "LicenseOwners": [
    {
      "Name": "Hagenes-Hilpert",
      "Description": "Secured dynamic productivity",
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
          "FieldLength": 678
        }
      }
    },
    {
      "Name": "Hagenes-Hilpert",
      "Description": "Secured dynamic productivity",
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
          "FieldLength": 678
        }
      }
    }
  ],
  "Role": {
    "Id": 662,
    "Value": "autem",
    "Tooltip": "dolorem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 115
      }
    }
  },
  "UserGroup": {
    "Value": "voluptatem",
    "Tooltip": "a",
    "Id": 975,
    "Rank": 247,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 764
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "sed",
      "Tooltip": "a",
      "Id": 849,
      "Rank": 195,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 982
        }
      }
    }
  ],
  "Person": {
    "Position": "fugiat",
    "PersonId": 682,
    "Mrmrs": "aut",
    "Firstname": "Eulah",
    "Lastname": "Doyle",
    "MiddleName": "Eichmann, Bergnaum and Haag",
    "Title": "ea",
    "Description": "Open-source context-sensitive forecast",
    "Email": "kay@gaylord.com",
    "FullName": "Sasha Casper",
    "DirectPhone": "(758)521-5663",
    "FormalName": "Welch Inc and Sons",
    "CountryId": 945,
    "ContactId": 327,
    "ContactName": "Cremin Group",
    "Retired": 500,
    "Rank": 490,
    "ActiveInterests": 139,
    "ContactDepartment": "",
    "ContactCountryId": 629,
    "ContactOrgNr": "1577219",
    "FaxPhone": "1-220-357-8044",
    "MobilePhone": "561-457-7043 x08705",
    "ContactPhone": "583.017.0825",
    "AssociateName": "Schulist LLC",
    "AssociateId": 39,
    "UsePersonAddress": true,
    "ContactFax": "repellendus",
    "Kanafname": "ut",
    "Kanalname": "voluptas",
    "Post1": "corrupti",
    "Post2": "dolor",
    "Post3": "veniam",
    "EmailName": "callie.franecki@yundt.us",
    "ContactFullName": "Mr. Jimmy Pollich",
    "ActiveErpLinks": 750,
    "TicketPriorityId": 722,
    "SupportLanguageId": 281,
    "SupportAssociateId": 164,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 613
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2014-05-14T18:25:51.4841466+02:00",
  "Lastlogout": "2004-02-20T18:25:51.4841466+01:00",
  "EjUserId": 146,
  "RequestSignature": "omnis",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "qui",
      "DisplayValue": "vel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "scale compelling portals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    },
    {
      "Type": {},
      "Value": "qui",
      "DisplayValue": "vel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "scale compelling portals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    }
  ],
  "UserName": "Runolfsson Inc and Sons",
  "TicketCategories": [
    {
      "Id": 345,
      "Name": "Legros Group",
      "ToolTip": "Quae vero praesentium.",
      "Deleted": true,
      "Rank": 750,
      "Type": "et",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "et",
      "ColorBlock": 203,
      "ExtraInfo": "cumque",
      "StyleHint": "reprehenderit",
      "FullName": "Larry Gottlieb",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 613
        }
      }
    }
  ],
  "NickName": "Doyle-O'Kon",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "omnis"
  },
  "PostSaveCommands": [
    {
      "Name": "Abbott-Roob",
      "DisplayName": "Russel LLC",
      "Description": "Enterprise-wide non-volatile info-mediaries",
      "ToolTip": "Possimus maxime commodi.",
      "Actions": "Implicit",
      "ActionData": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 220
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
      "FieldLength": 581
    }
  }
}
```