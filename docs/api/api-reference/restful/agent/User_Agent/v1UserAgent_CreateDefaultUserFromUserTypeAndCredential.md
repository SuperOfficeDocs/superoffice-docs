---
title: CreateDefaultUserFromUserTypeAndCredential
id: v1UserAgent_CreateDefaultUserFromUserTypeAndCredential
---

# CreateDefaultUserFromUserTypeAndCredential

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
  "ContactId": 499,
  "CredentialType": "perspiciatis",
  "CredentialValue": "animi",
  "CredentialDisplayValue": "autem"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 816,
  "Name": "Rempel, Morissette and Padberg",
  "Rank": 962,
  "Tooltip": "harum",
  "LicenseOwners": [
    {
      "Name": "Becker Group",
      "Description": "Robust executive forecast",
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
          "FieldLength": 55
        }
      }
    },
    {
      "Name": "Becker Group",
      "Description": "Robust executive forecast",
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
          "FieldLength": 55
        }
      }
    }
  ],
  "Role": {
    "Id": 959,
    "Value": "autem",
    "Tooltip": "officia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 654
      }
    }
  },
  "UserGroup": {
    "Value": "voluptatem",
    "Tooltip": "earum",
    "Id": 105,
    "Rank": 15,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synthesize enterprise channels"
        },
        "FieldType": "System.String",
        "FieldLength": 505
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "perspiciatis",
      "Tooltip": "sed",
      "Id": 425,
      "Rank": 262,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 384
        }
      }
    }
  ],
  "Person": {
    "Position": "placeat",
    "PersonId": 209,
    "Mrmrs": "voluptatem",
    "Firstname": "Mia",
    "Lastname": "Bosco",
    "MiddleName": "Hackett Inc and Sons",
    "Title": "est",
    "Description": "Cross-group regional process improvement",
    "Email": "david.dooley@streich.ca",
    "FullName": "Jace Krajcik",
    "DirectPhone": "1-217-275-1235",
    "FormalName": "Schumm, Osinski and Becker",
    "CountryId": 364,
    "ContactId": 354,
    "ContactName": "Schumm Inc and Sons",
    "Retired": 756,
    "Rank": 658,
    "ActiveInterests": 500,
    "ContactDepartment": "",
    "ContactCountryId": 954,
    "ContactOrgNr": "1256383",
    "FaxPhone": "1-586-672-8712 x384",
    "MobilePhone": "435.432.7832 x836",
    "ContactPhone": "787-610-5267 x056",
    "AssociateName": "Fay Inc and Sons",
    "AssociateId": 889,
    "UsePersonAddress": false,
    "ContactFax": "dolor",
    "Kanafname": "consequuntur",
    "Kanalname": "quos",
    "Post1": "esse",
    "Post2": "est",
    "Post3": "voluptate",
    "EmailName": "garth_lindgren@dickinson.biz",
    "ContactFullName": "Johathan Wyman",
    "ActiveErpLinks": 226,
    "TicketPriorityId": 666,
    "SupportLanguageId": 828,
    "SupportAssociateId": 403,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 695
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2011-01-06T14:58:05.4196237+01:00",
  "Lastlogout": "2020-06-28T14:58:05.4196237+02:00",
  "EjUserId": 966,
  "RequestSignature": "nostrum",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "optio",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    },
    {
      "Type": {},
      "Value": "optio",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    }
  ],
  "UserName": "Conn Inc and Sons",
  "TicketCategories": [
    {
      "Id": 39,
      "Name": "Ebert-Blanda",
      "ToolTip": "Adipisci non laudantium voluptas explicabo reprehenderit fugiat.",
      "Deleted": true,
      "Rank": 995,
      "Type": "sit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "velit",
      "ColorBlock": 972,
      "ExtraInfo": "voluptate",
      "StyleHint": "inventore",
      "FullName": "Bianka D'Amore Jr.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 722
        }
      }
    }
  ],
  "NickName": "Kihn, Koss and O'Kon",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "delectus",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "nostrum"
  },
  "PostSaveCommands": [
    {
      "Name": "Streich Inc and Sons",
      "DisplayName": "Kreiger, Gorczany and Denesik",
      "Description": "Expanded asynchronous success",
      "ToolTip": "Consectetur sed voluptatem a repellendus fugit.",
      "Actions": "Implicit",
      "ActionData": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 628
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
      "FieldLength": 620
    }
  }
}
```