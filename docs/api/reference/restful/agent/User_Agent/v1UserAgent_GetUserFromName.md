---
title: POST Agents/User/GetUserFromName
id: v1UserAgent_GetUserFromName
---

# POST Agents/User/GetUserFromName

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "UserName": "Herzog, McKenzie and Goyette"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 464,
  "Name": "Treutel, Ledner and Gleichner",
  "Rank": 33,
  "Tooltip": "explicabo",
  "LicenseOwners": [
    {
      "Name": "Dibbert, Konopelski and Crooks",
      "Description": "Intuitive object-oriented productivity",
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
          "FieldLength": 224
        }
      }
    },
    {
      "Name": "Dibbert, Konopelski and Crooks",
      "Description": "Intuitive object-oriented productivity",
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
          "FieldLength": 224
        }
      }
    }
  ],
  "Role": {
    "Id": 657,
    "Value": "veniam",
    "Tooltip": "recusandae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "recontextualize integrated deliverables"
        },
        "FieldType": "System.String",
        "FieldLength": 440
      }
    }
  },
  "UserGroup": {
    "Value": "maiores",
    "Tooltip": "quibusdam",
    "Id": 472,
    "Rank": 715,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 343
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "molestiae",
      "Tooltip": "praesentium",
      "Id": 13,
      "Rank": 810,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 370
        }
      }
    }
  ],
  "Person": {
    "Position": "maxime",
    "PersonId": 181,
    "Mrmrs": "delectus",
    "Firstname": "Verner",
    "Lastname": "Cremin",
    "MiddleName": "Gibson LLC",
    "Title": "placeat",
    "Description": "Universal client-driven parallelism",
    "Email": "emile.zboncak@kutch.us",
    "FullName": "Nadia Denesik",
    "DirectPhone": "1-013-573-1085",
    "FormalName": "Rogahn, Sipes and Collins",
    "CountryId": 673,
    "ContactId": 638,
    "ContactName": "Hilll, Parker and Simonis",
    "Retired": 285,
    "Rank": 283,
    "ActiveInterests": 874,
    "ContactDepartment": "extend visionary users",
    "ContactCountryId": 866,
    "ContactOrgNr": "653501",
    "FaxPhone": "1-777-078-6436 x172",
    "MobilePhone": "511-712-2037 x722",
    "ContactPhone": "852-740-0880 x76272",
    "AssociateName": "Corwin LLC",
    "AssociateId": 555,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "doloremque",
    "Kanalname": "consectetur",
    "Post1": "et",
    "Post2": "voluptatem",
    "Post3": "similique",
    "EmailName": "selena_reynolds@goldnerheaney.us",
    "ContactFullName": "Leland Dare",
    "ActiveErpLinks": 37,
    "TicketPriorityId": 35,
    "SupportLanguageId": 387,
    "SupportAssociateId": 988,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 677
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2001-05-24T18:28:50.4434119+02:00",
  "Lastlogout": "2005-03-08T18:28:50.4434119+01:00",
  "EjUserId": 606,
  "RequestSignature": "a",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "numquam",
      "DisplayValue": "sapiente",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    },
    {
      "Type": {},
      "Value": "numquam",
      "DisplayValue": "sapiente",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    }
  ],
  "UserName": "Metz Group",
  "TicketCategories": [
    {
      "Id": 878,
      "Name": "Gutkowski Inc and Sons",
      "ToolTip": "Omnis fuga repellat soluta quia.",
      "Deleted": false,
      "Rank": 75,
      "Type": "ut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "qui",
      "ColorBlock": 28,
      "ExtraInfo": "iusto",
      "StyleHint": "consequuntur",
      "FullName": "April Koepp",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 176
        }
      }
    }
  ],
  "NickName": "Grant, Marquardt and Champlin",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "quibusdam",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "voluptatibus",
    "CustomFields2": "sit"
  },
  "PostSaveCommands": [
    {
      "Name": "Bruen Inc and Sons",
      "DisplayName": "Connelly, Hettinger and Moore",
      "Description": "Visionary fresh-thinking approach",
      "ToolTip": "Eum qui.",
      "Actions": "Implicit",
      "ActionData": "veritatis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 337
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
      "FieldLength": 946
    }
  }
}
```