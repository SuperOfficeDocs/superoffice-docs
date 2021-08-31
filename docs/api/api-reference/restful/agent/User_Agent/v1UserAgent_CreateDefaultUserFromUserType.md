---
title: CreateDefaultUserFromUserType
id: v1UserAgent_CreateDefaultUserFromUserType
---

# CreateDefaultUserFromUserType

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 677,
  "Name": "Heathcote Inc and Sons",
  "Rank": 889,
  "Tooltip": "tenetur",
  "LicenseOwners": [
    {
      "Name": "Wolf-Romaguera",
      "Description": "Up-sized cohesive budgetary management",
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
          "FieldLength": 703
        }
      }
    },
    {
      "Name": "Wolf-Romaguera",
      "Description": "Up-sized cohesive budgetary management",
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
          "FieldLength": 703
        }
      }
    }
  ],
  "Role": {
    "Id": 243,
    "Value": "quod",
    "Tooltip": "aliquid",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 627
      }
    }
  },
  "UserGroup": {
    "Value": "consectetur",
    "Tooltip": "inventore",
    "Id": 50,
    "Rank": 160,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 773
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "nisi",
      "Tooltip": "dolorem",
      "Id": 778,
      "Rank": 986,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    }
  ],
  "Person": {
    "Position": "molestiae",
    "PersonId": 677,
    "Mrmrs": "quidem",
    "Firstname": "Daryl",
    "Lastname": "Kulas",
    "MiddleName": "Sporer Group",
    "Title": "voluptatem",
    "Description": "Persevering radical toolset",
    "Email": "meghan_roberts@koelpinkiehn.uk",
    "FullName": "Stanton Nikolaus",
    "DirectPhone": "1-338-682-1253 x34111",
    "FormalName": "Weimann-Bosco",
    "CountryId": 82,
    "ContactId": 969,
    "ContactName": "Schoen Inc and Sons",
    "Retired": 661,
    "Rank": 57,
    "ActiveInterests": 431,
    "ContactDepartment": "",
    "ContactCountryId": 766,
    "ContactOrgNr": "1032275",
    "FaxPhone": "682.088.1883 x43422",
    "MobilePhone": "1-327-457-6752 x254",
    "ContactPhone": "(360)354-8026 x711",
    "AssociateName": "Ledner-Johnson",
    "AssociateId": 537,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "dolores",
    "Kanalname": "aperiam",
    "Post1": "hic",
    "Post2": "voluptatum",
    "Post3": "expedita",
    "EmailName": "johathan.kulas@smith.co.uk",
    "ContactFullName": "Mitchel Muller",
    "ActiveErpLinks": 273,
    "TicketPriorityId": 32,
    "SupportLanguageId": 86,
    "SupportAssociateId": 681,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 323
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2000-10-01T14:58:05.5270544+02:00",
  "Lastlogout": "1997-01-08T14:58:05.5270544+01:00",
  "EjUserId": 827,
  "RequestSignature": "reiciendis",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "libero",
      "DisplayValue": "nihil",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 288
        }
      }
    },
    {
      "Type": {},
      "Value": "libero",
      "DisplayValue": "nihil",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 288
        }
      }
    }
  ],
  "UserName": "Mraz, Labadie and Pollich",
  "TicketCategories": [
    {
      "Id": 112,
      "Name": "Murazik-Boehm",
      "ToolTip": "Numquam laudantium est.",
      "Deleted": true,
      "Rank": 894,
      "Type": "adipisci",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quis",
      "ColorBlock": 894,
      "ExtraInfo": "nobis",
      "StyleHint": "sint",
      "FullName": "Santa Gleichner Jr.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 674
        }
      }
    }
  ],
  "NickName": "Boyer-Huel",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "fuga",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "commodi"
  },
  "PostSaveCommands": [
    {
      "Name": "Keeling, Halvorson and Pfeffer",
      "DisplayName": "Johns Inc and Sons",
      "Description": "Extended dynamic open architecture",
      "ToolTip": "Id beatae odit.",
      "Actions": "Implicit",
      "ActionData": "voluptas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 80
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
      "FieldLength": 171
    }
  }
}
```