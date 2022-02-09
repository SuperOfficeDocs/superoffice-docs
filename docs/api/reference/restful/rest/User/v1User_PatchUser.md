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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "voluptatem",
    "value": {
      "value1": {
        "PrimaryKey": 5080,
        "EntityName": "person",
        "personId": 5080,
        "fullName": "Marian Conroy"
      },
      "value2": {
        "PrimaryKey": 1426,
        "EntityName": "sale",
        "saleId": 1426,
        "contactId": 7766,
        "name": "Heaney-Orn"
      }
    }
  },
  {
    "op": "add",
    "path": "voluptatem",
    "value": {
      "value1": {
        "PrimaryKey": 5080,
        "EntityName": "person",
        "personId": 5080,
        "fullName": "Marian Conroy"
      },
      "value2": {
        "PrimaryKey": 1426,
        "EntityName": "sale",
        "saleId": 1426,
        "contactId": 7766,
        "name": "Heaney-Orn"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 User  updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 605,
  "Name": "Grimes, Renner and Jacobi",
  "Rank": 334,
  "Tooltip": "incidunt",
  "LicenseOwners": [
    {
      "Name": "Haag-Mitchell",
      "Description": "Up-sized client-server throughput",
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
          "FieldLength": 650
        }
      }
    },
    {
      "Name": "Haag-Mitchell",
      "Description": "Up-sized client-server throughput",
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
          "FieldLength": 650
        }
      }
    }
  ],
  "Role": {
    "Id": 146,
    "Value": "fugiat",
    "Tooltip": "illo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 824
      }
    }
  },
  "UserGroup": {
    "Value": "unde",
    "Tooltip": "enim",
    "Id": 930,
    "Rank": 217,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 14
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "quaerat",
      "Tooltip": "tenetur",
      "Id": 547,
      "Rank": 115,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 476
        }
      }
    }
  ],
  "Person": {
    "Position": "deleniti",
    "PersonId": 911,
    "Mrmrs": "adipisci",
    "Firstname": "Manuel",
    "Lastname": "Bogan",
    "MiddleName": "Beer, Reichel and Bogisich",
    "Title": "earum",
    "Description": "Public-key even-keeled workforce",
    "Email": "meggie_daniel@conroy.us",
    "FullName": "Imogene Thiel",
    "DirectPhone": "825.216.4631 x07674",
    "FormalName": "Dickens Group",
    "CountryId": 5,
    "ContactId": 271,
    "ContactName": "Carroll Inc and Sons",
    "Retired": 648,
    "Rank": 383,
    "ActiveInterests": 465,
    "ContactDepartment": "",
    "ContactCountryId": 899,
    "ContactOrgNr": "615554",
    "FaxPhone": "(671)770-7211 x55466",
    "MobilePhone": "(360)113-5678 x086",
    "ContactPhone": "567.220.5052 x337",
    "AssociateName": "Muller LLC",
    "AssociateId": 812,
    "UsePersonAddress": false,
    "ContactFax": "aut",
    "Kanafname": "eius",
    "Kanalname": "aliquid",
    "Post1": "nemo",
    "Post2": "laboriosam",
    "Post3": "eveniet",
    "EmailName": "sage@monahanmarks.name",
    "ContactFullName": "Daisha Jaskolski",
    "ActiveErpLinks": 649,
    "TicketPriorityId": 920,
    "SupportLanguageId": 386,
    "SupportAssociateId": 37,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 618
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2017-11-14T18:25:51.4781475+01:00",
  "Lastlogout": "2013-08-06T18:25:51.4781475+02:00",
  "EjUserId": 111,
  "RequestSignature": "veniam",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "excepturi",
      "DisplayValue": "delectus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 748
        }
      }
    },
    {
      "Type": {},
      "Value": "excepturi",
      "DisplayValue": "delectus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 748
        }
      }
    }
  ],
  "UserName": "Lind Group",
  "TicketCategories": [
    {
      "Id": 215,
      "Name": "Rogahn-Schamberger",
      "ToolTip": "Omnis doloribus inventore qui sit.",
      "Deleted": true,
      "Rank": 571,
      "Type": "eligendi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "adipisci",
      "ColorBlock": 713,
      "ExtraInfo": "consequatur",
      "StyleHint": "vero",
      "FullName": "Chesley Crist",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    }
  ],
  "NickName": "Hills, Grant and Purdy",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "exercitationem"
  },
  "PostSaveCommands": [
    {
      "Name": "Hyatt, Durgan and Murray",
      "DisplayName": "Lehner, Goldner and Gerlach",
      "Description": "Assimilated disintermediate time-frame",
      "ToolTip": "Delectus sapiente qui.",
      "Actions": "Implicit",
      "ActionData": "sunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incentivize viral web-readiness"
          },
          "FieldType": "System.String",
          "FieldLength": 387
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "empower world-class users"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 285
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```