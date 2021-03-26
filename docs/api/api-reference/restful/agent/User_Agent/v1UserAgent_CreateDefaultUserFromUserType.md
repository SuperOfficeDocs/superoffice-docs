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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 739,
  "Name": "Hegmann, Keeling and Brown",
  "Rank": 508,
  "Tooltip": "est",
  "LicenseOwners": [
    {
      "Name": "Pfannerstill Inc and Sons",
      "Description": "Expanded tertiary budgetary management",
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
          "FieldLength": 157
        }
      }
    },
    {
      "Name": "Pfannerstill Inc and Sons",
      "Description": "Expanded tertiary budgetary management",
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
          "FieldLength": 157
        }
      }
    }
  ],
  "Role": {
    "Id": 224,
    "Value": "facere",
    "Tooltip": "consequuntur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reintermediate value-added solutions"
        },
        "FieldType": "System.Int32",
        "FieldLength": 600
      }
    }
  },
  "UserGroup": {
    "Value": "quam",
    "Tooltip": "libero",
    "Id": 223,
    "Rank": 743,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 513
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "sed",
      "Tooltip": "consequatur",
      "Id": 273,
      "Rank": 367,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 974
        }
      }
    }
  ],
  "Person": {
    "Position": "officiis",
    "PersonId": 388,
    "Mrmrs": "voluptas",
    "Firstname": "Kyler",
    "Lastname": "Hahn",
    "MiddleName": "Kreiger-Turcotte",
    "Title": "nihil",
    "Description": "Synergized responsive task-force",
    "Email": "terrell@toy.us",
    "FullName": "Jackie Morissette",
    "DirectPhone": "372.502.8784",
    "FormalName": "Erdman Group",
    "CountryId": 869,
    "ContactId": 884,
    "ContactName": "Kautzer LLC",
    "Retired": 787,
    "Rank": 696,
    "ActiveInterests": 861,
    "ContactDepartment": "",
    "ContactCountryId": 341,
    "ContactOrgNr": "689256",
    "FaxPhone": "873.108.3414 x187",
    "MobilePhone": "(407)486-6083",
    "ContactPhone": "(168)474-1032 x03633",
    "AssociateName": "King, Osinski and Jewess",
    "AssociateId": 7,
    "UsePersonAddress": false,
    "ContactFax": "quas",
    "Kanafname": "illum",
    "Kanalname": "et",
    "Post1": "pariatur",
    "Post2": "hic",
    "Post3": "aut",
    "EmailName": "sibyl@koch.uk",
    "ContactFullName": "Yasmine Upton",
    "ActiveErpLinks": 434,
    "TicketPriorityId": 28,
    "SupportLanguageId": 387,
    "SupportAssociateId": 624,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engage user-centric e-services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 484
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2010-12-30T16:48:30.8469397+01:00",
  "Lastlogout": "2008-12-02T16:48:30.8469397+01:00",
  "EjUserId": 169,
  "RequestSignature": "quo",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "dolorum",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    },
    {
      "Type": {},
      "Value": "dolorum",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    }
  ],
  "UserName": "Leffler-Green",
  "TicketCategories": [
    {
      "Id": 462,
      "Name": "Mills Inc and Sons",
      "ToolTip": "Quo adipisci officia omnis.",
      "Deleted": false,
      "Rank": 990,
      "Type": "mollitia",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "laborum",
      "ColorBlock": 922,
      "ExtraInfo": "explicabo",
      "StyleHint": "non",
      "FullName": "Elza Bartell",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 264
        }
      }
    }
  ],
  "NickName": "O'Reilly LLC",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "eligendi"
  },
  "PostSaveCommands": [
    {
      "Name": "Larkin, Leannon and Stroman",
      "DisplayName": "D'Amore-Champlin",
      "Description": "Reactive motivating project",
      "ToolTip": "Illo repellat laborum voluptatem sit.",
      "Actions": "Implicit",
      "ActionData": "at",
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
      "FieldLength": 538
    }
  }
}
```