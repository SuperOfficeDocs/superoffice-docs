---
title: CreateDefaultUserFromUserTypeAndPersonId
id: v1UserAgent_CreateDefaultUserFromUserTypeAndPersonId
---

# CreateDefaultUserFromUserTypeAndPersonId

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndPersonId
```

Create default User providing the associate type and person id.

System and Anonymous users can be created without an exsisting person and permits person id to be 0.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndPersonId?$select=name,department,category/id
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

UserType, PersonId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserType | string |  |
| PersonId | int32 |  |


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
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndPersonId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "PersonId": 551
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 837,
  "Name": "Keebler LLC",
  "Rank": 137,
  "Tooltip": "reiciendis",
  "LicenseOwners": [
    {
      "Name": "Kerluke, Gutkowski and O'Connell",
      "Description": "Streamlined 24 hour budgetary management",
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
          "FieldLength": 3
        }
      }
    },
    {
      "Name": "Kerluke, Gutkowski and O'Connell",
      "Description": "Streamlined 24 hour budgetary management",
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
          "FieldLength": 3
        }
      }
    }
  ],
  "Role": {
    "Id": 424,
    "Value": "est",
    "Tooltip": "maiores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 276
      }
    }
  },
  "UserGroup": {
    "Value": "eum",
    "Tooltip": "iste",
    "Id": 592,
    "Rank": 910,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 489
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "omnis",
      "Tooltip": "ab",
      "Id": 545,
      "Rank": 278,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 804
        }
      }
    }
  ],
  "Person": {
    "Position": "nam",
    "PersonId": 837,
    "Mrmrs": "harum",
    "Firstname": "Crystal",
    "Lastname": "Lesch",
    "MiddleName": "Mohr LLC",
    "Title": "qui",
    "Description": "Monitored bottom-line flexibility",
    "Email": "anastasia_doyle@collins.name",
    "FullName": "Winona Padberg",
    "DirectPhone": "672.506.4366 x2553",
    "FormalName": "Anderson-Torphy",
    "CountryId": 634,
    "ContactId": 14,
    "ContactName": "Durgan, Leffler and Wintheiser",
    "Retired": 808,
    "Rank": 194,
    "ActiveInterests": 191,
    "ContactDepartment": "",
    "ContactCountryId": 525,
    "ContactOrgNr": "1133342",
    "FaxPhone": "547-471-5066",
    "MobilePhone": "(025)536-3300 x87417",
    "ContactPhone": "1-380-817-4507 x867",
    "AssociateName": "McGlynn Inc and Sons",
    "AssociateId": 191,
    "UsePersonAddress": true,
    "ContactFax": "est",
    "Kanafname": "similique",
    "Kanalname": "aut",
    "Post1": "consequatur",
    "Post2": "amet",
    "Post3": "facere",
    "EmailName": "eloy@mueller.biz",
    "ContactFullName": "Mathilde Ebert",
    "ActiveErpLinks": 779,
    "TicketPriorityId": 25,
    "SupportLanguageId": 581,
    "SupportAssociateId": 532,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 785
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2003-04-23T14:58:05.4662932+02:00",
  "Lastlogout": "2005-05-04T14:58:05.4662932+02:00",
  "EjUserId": 240,
  "RequestSignature": "amet",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "omnis",
      "DisplayValue": "sapiente",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    },
    {
      "Type": {},
      "Value": "omnis",
      "DisplayValue": "sapiente",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    }
  ],
  "UserName": "Powlowski-Ferry",
  "TicketCategories": [
    {
      "Id": 6,
      "Name": "O'Kon-Johns",
      "ToolTip": "Nostrum accusamus dolores doloribus nostrum.",
      "Deleted": true,
      "Rank": 463,
      "Type": "quasi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "consequatur",
      "ColorBlock": 158,
      "ExtraInfo": "et",
      "StyleHint": "quaerat",
      "FullName": "Alyson Lowe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "NickName": "Green Group",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "iure"
  },
  "PostSaveCommands": [
    {
      "Name": "Fay Group",
      "DisplayName": "Stokes, Hahn and Conroy",
      "Description": "Total maximized throughput",
      "ToolTip": "Laborum sit.",
      "Actions": "Implicit",
      "ActionData": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "strategize granular web-readiness"
          },
          "FieldType": "System.Int32",
          "FieldLength": 62
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
      "FieldLength": 293
    }
  }
}
```