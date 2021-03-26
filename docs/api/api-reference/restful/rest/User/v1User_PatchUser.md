---
title: PATCH User/{id}
id: v1User_PatchUser
---

# PATCH User/{id}

```http
PATCH /api/v1/User/{id}
```

Update a User with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IUserAgent} service SaveUser.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The User  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/User/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

SuperOffice User, with login credentials and an associated person.



User entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | User  updated. |
| 404 | User with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because User has changed since the requested If-Unmodified-Since timestamp. |

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
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/User/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "nulla",
    "value": {
      "value1": {
        "PrimaryKey": 345,
        "EntityName": "sale",
        "saleId": 345,
        "contactId": 9666,
        "name": "Lehner-Glover"
      },
      "value2": {
        "PrimaryKey": 3523,
        "EntityName": "sale",
        "saleId": 3523,
        "contactId": 10,
        "name": "Bednar-Grant"
      }
    }
  },
  {
    "op": "add",
    "path": "nulla",
    "value": {
      "value1": {
        "PrimaryKey": 345,
        "EntityName": "sale",
        "saleId": 345,
        "contactId": 9666,
        "name": "Lehner-Glover"
      },
      "value2": {
        "PrimaryKey": 3523,
        "EntityName": "sale",
        "saleId": 3523,
        "contactId": 10,
        "name": "Bednar-Grant"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 User  updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 3,
  "Name": "Effertz-Armstrong",
  "Rank": 498,
  "Tooltip": "modi",
  "LicenseOwners": [
    {
      "Name": "Satterfield, Skiles and Kautzer",
      "Description": "Future-proofed global implementation",
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
          "FieldLength": 319
        }
      }
    },
    {
      "Name": "Satterfield, Skiles and Kautzer",
      "Description": "Future-proofed global implementation",
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
          "FieldLength": 319
        }
      }
    }
  ],
  "Role": {
    "Id": 772,
    "Value": "porro",
    "Tooltip": "laudantium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 841
      }
    }
  },
  "UserGroup": {
    "Value": "odio",
    "Tooltip": "ipsam",
    "Id": 746,
    "Rank": 801,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 963
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "et",
      "Tooltip": "delectus",
      "Id": 438,
      "Rank": 372,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Person": {
    "Position": "aut",
    "PersonId": 594,
    "Mrmrs": "aperiam",
    "Firstname": "Stefanie",
    "Lastname": "Mann",
    "MiddleName": "Mills, Bashirian and Jacobson",
    "Title": "et",
    "Description": "Multi-lateral upward-trending interface",
    "Email": "katheryn_torp@funkfeeney.ca",
    "FullName": "Reina Romaguera",
    "DirectPhone": "027.136.3667 x60080",
    "FormalName": "Hammes, Lesch and Pfeffer",
    "CountryId": 499,
    "ContactId": 512,
    "ContactName": "Murray, Luettgen and Howell",
    "Retired": 586,
    "Rank": 855,
    "ActiveInterests": 773,
    "ContactDepartment": "",
    "ContactCountryId": 3,
    "ContactOrgNr": "229235",
    "FaxPhone": "1-572-118-4017",
    "MobilePhone": "747-322-2212 x42527",
    "ContactPhone": "857.674.7406 x6041",
    "AssociateName": "Hartmann-Beatty",
    "AssociateId": 809,
    "UsePersonAddress": false,
    "ContactFax": "quo",
    "Kanafname": "occaecati",
    "Kanalname": "minus",
    "Post1": "beatae",
    "Post2": "beatae",
    "Post3": "est",
    "EmailName": "heloise.little@greenholtblock.name",
    "ContactFullName": "Llewellyn Jones II",
    "ActiveErpLinks": 557,
    "TicketPriorityId": 553,
    "SupportLanguageId": 169,
    "SupportAssociateId": 792,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 196
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2006-05-20T09:41:00.0700585+02:00",
  "Lastlogout": "1996-05-23T09:41:00.0700585+02:00",
  "EjUserId": 72,
  "RequestSignature": "quia",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "voluptatibus",
      "DisplayValue": "provident",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 325
        }
      }
    },
    {
      "Type": {},
      "Value": "voluptatibus",
      "DisplayValue": "provident",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 325
        }
      }
    }
  ],
  "UserName": "Barton, Bauch and Witting",
  "TicketCategories": [
    {
      "Id": 829,
      "Name": "Gerlach-Green",
      "ToolTip": "Delectus consequatur.",
      "Deleted": false,
      "Rank": 900,
      "Type": "beatae",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quis",
      "ColorBlock": 794,
      "ExtraInfo": "sint",
      "StyleHint": "ipsa",
      "FullName": "Walter Borer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 58
        }
      }
    }
  ],
  "NickName": "Labadie, Nolan and Kuhic",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "dolor"
  },
  "PostSaveCommands": [
    {
      "Name": "Crist-Haley",
      "DisplayName": "Gerhold-Hahn",
      "Description": "Triple-buffered grid-enabled capacity",
      "ToolTip": "Animi neque dolor.",
      "Actions": "Implicit",
      "ActionData": "quasi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 616
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
      "FieldLength": 433
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```