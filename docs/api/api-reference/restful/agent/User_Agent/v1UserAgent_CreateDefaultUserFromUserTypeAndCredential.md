---
title: POST Agents/User/CreateDefaultUserFromUserTypeAndCredential
id: v1UserAgent_CreateDefaultUserFromUserTypeAndCredential
---

# POST Agents/User/CreateDefaultUserFromUserTypeAndCredential

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndCredential
```

Creates a PersonEntity with default values based on the contactId and credentials.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndCredential?$select=name,department,category/id
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

UserType, ContactId, CredentialType, CredentialValue, CredentialDisplayValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserType | string |  |
| ContactId | int32 |  |
| CredentialType | string |  |
| CredentialValue | string |  |
| CredentialDisplayValue | string |  |


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
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "ContactId": 354,
  "CredentialType": "similique",
  "CredentialValue": "sunt",
  "CredentialDisplayValue": "impedit"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 6,
  "Name": "Reichert Group",
  "Rank": 905,
  "Tooltip": "maiores",
  "LicenseOwners": [
    {
      "Name": "Roberts-Hills",
      "Description": "Reverse-engineered optimizing interface",
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
          "FieldLength": 772
        }
      }
    },
    {
      "Name": "Roberts-Hills",
      "Description": "Reverse-engineered optimizing interface",
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
          "FieldLength": 772
        }
      }
    }
  ],
  "Role": {
    "Id": 873,
    "Value": "minima",
    "Tooltip": "dolores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 926
      }
    }
  },
  "UserGroup": {
    "Value": "et",
    "Tooltip": "aliquid",
    "Id": 139,
    "Rank": 697,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 668
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "illum",
      "Tooltip": "eligendi",
      "Id": 924,
      "Rank": 612,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 739
        }
      }
    }
  ],
  "Person": {
    "Position": "vel",
    "PersonId": 804,
    "Mrmrs": "quibusdam",
    "Firstname": "Hester",
    "Lastname": "Reilly",
    "MiddleName": "Bruen-Ernser",
    "Title": "reiciendis",
    "Description": "Open-architected assymetric neural-net",
    "Email": "darius@mitchell.biz",
    "FullName": "Ofelia Ryan",
    "DirectPhone": "(152)732-1258",
    "FormalName": "Lockman, Schaden and Treutel",
    "CountryId": 718,
    "ContactId": 961,
    "ContactName": "Kirlin LLC",
    "Retired": 289,
    "Rank": 842,
    "ActiveInterests": 738,
    "ContactDepartment": "",
    "ContactCountryId": 244,
    "ContactOrgNr": "504828",
    "FaxPhone": "270.000.2574",
    "MobilePhone": "684-681-7741 x7744",
    "ContactPhone": "1-414-805-0083",
    "AssociateName": "Treutel-Schowalter",
    "AssociateId": 523,
    "UsePersonAddress": true,
    "ContactFax": "debitis",
    "Kanafname": "unde",
    "Kanalname": "quos",
    "Post1": "odit",
    "Post2": "praesentium",
    "Post3": "autem",
    "EmailName": "abel.willms@legrosrau.ca",
    "ContactFullName": "Mr. Samson Kiehn",
    "ActiveErpLinks": 963,
    "TicketPriorityId": 612,
    "SupportLanguageId": 856,
    "SupportAssociateId": 616,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 21
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "1995-07-14T18:28:50.4184115+02:00",
  "Lastlogout": "1997-12-21T18:28:50.4184115+01:00",
  "EjUserId": 13,
  "RequestSignature": "earum",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "laborum",
      "DisplayValue": "id",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 504
        }
      }
    },
    {
      "Type": {},
      "Value": "laborum",
      "DisplayValue": "id",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 504
        }
      }
    }
  ],
  "UserName": "Wisoky-Hickle",
  "TicketCategories": [
    {
      "Id": 93,
      "Name": "Huels, Connelly and Altenwerth",
      "ToolTip": "Qui quia.",
      "Deleted": false,
      "Rank": 158,
      "Type": "dolores",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "qui",
      "ColorBlock": 56,
      "ExtraInfo": "magni",
      "StyleHint": "culpa",
      "FullName": "Novella Tillman",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 355
        }
      }
    }
  ],
  "NickName": "Osinski, Heaney and Rosenbaum",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "similique",
    "CustomFields2": "alias"
  },
  "PostSaveCommands": [
    {
      "Name": "Hermiston LLC",
      "DisplayName": "Macejkovic Inc and Sons",
      "Description": "Cross-group dynamic concept",
      "ToolTip": "Reprehenderit delectus fugit.",
      "Actions": "Implicit",
      "ActionData": "animi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "synergize seamless systems"
          },
          "FieldType": "System.Int32",
          "FieldLength": 915
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
      "FieldLength": 314
    }
  }
}
```