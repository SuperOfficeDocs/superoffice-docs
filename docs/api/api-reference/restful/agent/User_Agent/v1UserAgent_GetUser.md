---
title: GetUser
id: v1UserAgent_GetUser
---

# GetUser

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
POST /api/v1/Agents/User/GetUser?userId=736
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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 912,
  "Name": "Medhurst-Brekke",
  "Rank": 625,
  "Tooltip": "sit",
  "LicenseOwners": [
    {
      "Name": "Daugherty, Will and Wehner",
      "Description": "Organic hybrid encoding",
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
          "FieldLength": 303
        }
      }
    },
    {
      "Name": "Daugherty, Will and Wehner",
      "Description": "Organic hybrid encoding",
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
          "FieldLength": 303
        }
      }
    }
  ],
  "Role": {
    "Id": 196,
    "Value": "est",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 247
      }
    }
  },
  "UserGroup": {
    "Value": "tempore",
    "Tooltip": "culpa",
    "Id": 951,
    "Rank": 997,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 294
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "molestiae",
      "Tooltip": "adipisci",
      "Id": 355,
      "Rank": 352,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 116
        }
      }
    }
  ],
  "Person": {
    "Position": "qui",
    "PersonId": 416,
    "Mrmrs": "dolores",
    "Firstname": "Modesto",
    "Lastname": "Ziemann",
    "MiddleName": "Harvey-Bartoletti",
    "Title": "a",
    "Description": "Intuitive didactic functionalities",
    "Email": "yasmine@cristschaden.uk",
    "FullName": "Ruth Mosciski",
    "DirectPhone": "(745)444-1657",
    "FormalName": "Cummings-Cremin",
    "CountryId": 862,
    "ContactId": 622,
    "ContactName": "Reinger-Turner",
    "Retired": 261,
    "Rank": 810,
    "ActiveInterests": 972,
    "ContactDepartment": "",
    "ContactCountryId": 921,
    "ContactOrgNr": "1944283",
    "FaxPhone": "037-634-7422 x38745",
    "MobilePhone": "(638)176-4264",
    "ContactPhone": "721.454.5478 x847",
    "AssociateName": "Murazik-Mohr",
    "AssociateId": 349,
    "UsePersonAddress": true,
    "ContactFax": "voluptatem",
    "Kanafname": "ratione",
    "Kanalname": "molestiae",
    "Post1": "voluptatibus",
    "Post2": "reiciendis",
    "Post3": "nulla",
    "EmailName": "vito_weissnat@farrell.info",
    "ContactFullName": "Dayne Bradtke",
    "ActiveErpLinks": 833,
    "TicketPriorityId": 373,
    "SupportLanguageId": 764,
    "SupportAssociateId": 959,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 99
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2016-08-29T14:58:05.4356236+02:00",
  "Lastlogout": "1995-10-18T14:58:05.4356236+02:00",
  "EjUserId": 469,
  "RequestSignature": "distinctio",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "est",
      "DisplayValue": "magni",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 531
        }
      }
    },
    {
      "Type": {},
      "Value": "est",
      "DisplayValue": "magni",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 531
        }
      }
    }
  ],
  "UserName": "Howell, Hyatt and Mante",
  "TicketCategories": [
    {
      "Id": 607,
      "Name": "Heathcote Group",
      "ToolTip": "Ipsam quia neque omnis pariatur.",
      "Deleted": false,
      "Rank": 771,
      "Type": "distinctio",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptatem",
      "ColorBlock": 458,
      "ExtraInfo": "voluptatem",
      "StyleHint": "possimus",
      "FullName": "Damien O'Connell",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 979
        }
      }
    }
  ],
  "NickName": "Kassulke, Eichmann and Kiehn",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "animi"
  },
  "CustomFields": {
    "CustomFields1": "minima",
    "CustomFields2": "minima"
  },
  "PostSaveCommands": [
    {
      "Name": "Konopelski Group",
      "DisplayName": "Toy, Ullrich and Hammes",
      "Description": "Business-focused zero tolerance approach",
      "ToolTip": "Quasi est vel rerum accusantium optio sed.",
      "Actions": "Implicit",
      "ActionData": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "expedite interactive web services"
          },
          "FieldType": "System.String",
          "FieldLength": 79
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
      "FieldLength": 350
    }
  }
}
```