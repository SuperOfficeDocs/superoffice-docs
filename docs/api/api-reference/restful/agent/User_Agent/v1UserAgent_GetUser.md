---
title: POST Agents/User/GetUser
id: v1UserAgent_GetUser
---

# POST Agents/User/GetUser

```http
POST /api/v1/Agents/User/GetUser
```

Gets a User object.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| userId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUser?userId=505
POST /api/v1/Agents/User/GetUser?$select=name,department,category/id
```


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
POST /api/v1/Agents/User/GetUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 204,
  "Name": "Hand Group",
  "Rank": 469,
  "Tooltip": "voluptate",
  "LicenseOwners": [
    {
      "Name": "Heller Group",
      "Description": "Adaptive human-resource system engine",
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
          "FieldLength": 726
        }
      }
    },
    {
      "Name": "Heller Group",
      "Description": "Adaptive human-resource system engine",
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
          "FieldLength": 726
        }
      }
    }
  ],
  "Role": {
    "Id": 140,
    "Value": "deleniti",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 684
      }
    }
  },
  "UserGroup": {
    "Value": "doloribus",
    "Tooltip": "dolorem",
    "Id": 219,
    "Rank": 121,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "envisioneer front-end technologies"
        },
        "FieldType": "System.String",
        "FieldLength": 907
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "et",
      "Tooltip": "voluptas",
      "Id": 613,
      "Rank": 39,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 391
        }
      }
    }
  ],
  "Person": {
    "Position": "est",
    "PersonId": 439,
    "Mrmrs": "ut",
    "Firstname": "Margaret",
    "Lastname": "Hansen",
    "MiddleName": "Schaden Inc and Sons",
    "Title": "id",
    "Description": "Digitized object-oriented success",
    "Email": "eliza_hessel@haag.info",
    "FullName": "Brooke Dickens",
    "DirectPhone": "567.387.7434",
    "FormalName": "Murray Inc and Sons",
    "CountryId": 171,
    "ContactId": 986,
    "ContactName": "Dietrich, Gerlach and Upton",
    "Retired": 601,
    "Rank": 726,
    "ActiveInterests": 393,
    "ContactDepartment": "",
    "ContactCountryId": 803,
    "ContactOrgNr": "1164568",
    "FaxPhone": "(075)174-8502",
    "MobilePhone": "538-327-5641",
    "ContactPhone": "066.255.2101",
    "AssociateName": "Predovic Group",
    "AssociateId": 630,
    "UsePersonAddress": false,
    "ContactFax": "nemo",
    "Kanafname": "ipsam",
    "Kanalname": "a",
    "Post1": "neque",
    "Post2": "et",
    "Post3": "nemo",
    "EmailName": "renee@lang.name",
    "ContactFullName": "Obie Turcotte",
    "ActiveErpLinks": 486,
    "TicketPriorityId": 599,
    "SupportLanguageId": 893,
    "SupportAssociateId": 282,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 885
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2002-06-11T18:28:50.4364116+02:00",
  "Lastlogout": "2016-09-15T18:28:50.4364116+02:00",
  "EjUserId": 790,
  "RequestSignature": "totam",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "nihil",
      "DisplayValue": "quas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 356
        }
      }
    },
    {
      "Type": {},
      "Value": "nihil",
      "DisplayValue": "quas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 356
        }
      }
    }
  ],
  "UserName": "Hahn Group",
  "TicketCategories": [
    {
      "Id": 637,
      "Name": "Romaguera-Bernier",
      "ToolTip": "Recusandae nulla impedit quaerat aperiam dolor et.",
      "Deleted": true,
      "Rank": 282,
      "Type": "temporibus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "occaecati",
      "ColorBlock": 752,
      "ExtraInfo": "quibusdam",
      "StyleHint": "dolorem",
      "FullName": "Dejon Carroll",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 972
        }
      }
    }
  ],
  "NickName": "Green, Marvin and Haag",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "a",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "voluptatem"
  },
  "PostSaveCommands": [
    {
      "Name": "Jacobson LLC",
      "DisplayName": "Fadel-Blick",
      "Description": "Upgradable grid-enabled service-desk",
      "ToolTip": "A magni cumque deleniti.",
      "Actions": "Implicit",
      "ActionData": "maxime",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 289
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
      "FieldLength": 30
    }
  }
}
```