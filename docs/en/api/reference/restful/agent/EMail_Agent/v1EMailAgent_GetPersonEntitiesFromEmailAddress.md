---
title: POST Agents/EMail/GetPersonEntitiesFromEmailAddress
uid: v1EMailAgent_GetPersonEntitiesFromEmailAddress
generated: true
content_type: reference
---

# POST Agents/EMail/GetPersonEntitiesFromEmailAddress

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
```

Get all persons and contacts with the given email address


NsApiSlow threshold: 5000 ms.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress?$select=name,department,category/id
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

EmailAddress 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailAddress | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | int32 | The form id of the form that created the person |
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "kian@millerklein.biz"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 22,
    "Firstname": "Tianna",
    "MiddleName": "Lind-Will",
    "Lastname": "Heathcote",
    "Mrmrs": "molestiae",
    "Title": "aliquam",
    "UpdatedDate": "2014-10-23T03:40:46.8436443+02:00",
    "CreatedDate": "2024-05-31T03:40:46.8436443+02:00",
    "BirthDate": "2009-12-06T03:40:46.8436443+01:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "aliquid",
        "StrippedValue": "at",
        "Description": "Streamlined impactful superstructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 856
          }
        }
      },
      {
        "Value": "aliquid",
        "StrippedValue": "at",
        "Description": "Streamlined impactful superstructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 856
          }
        }
      }
    ],
    "Description": "Integrated exuding knowledge base",
    "IsAssociate": false,
    "PrivatePhones": [
      {
        "Value": "minima",
        "StrippedValue": "error",
        "Description": "Profound disintermediate database",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 508
          }
        }
      },
      {
        "Value": "minima",
        "StrippedValue": "error",
        "Description": "Profound disintermediate database",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 508
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "hic",
        "StrippedValue": "quasi",
        "Description": "Assimilated discrete concept",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 338
          }
        }
      },
      {
        "Value": "hic",
        "StrippedValue": "quasi",
        "Description": "Assimilated discrete concept",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 338
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "aut",
        "StrippedValue": "sit",
        "Description": "Future-proofed holistic hierarchy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 530
          }
        }
      },
      {
        "Value": "aut",
        "StrippedValue": "sit",
        "Description": "Future-proofed holistic hierarchy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 530
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "neque",
        "StrippedValue": "dolores",
        "Description": "Adaptive attitude-oriented architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 953
          }
        }
      },
      {
        "Value": "neque",
        "StrippedValue": "dolores",
        "Description": "Adaptive attitude-oriented architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 953
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "ut",
        "StrippedValue": "aut",
        "Description": "Customer-focused fault-tolerant strategy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 268
          }
        }
      },
      {
        "Value": "ut",
        "StrippedValue": "aut",
        "Description": "Customer-focused fault-tolerant strategy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 268
          }
        }
      }
    ],
    "Position": null,
    "UpdatedBy": null,
    "Contact": null,
    "Country": null,
    "Interests": [
      {
        "Id": 265,
        "Name": "Roberts LLC",
        "ToolTip": "Dolor aut.",
        "Deleted": false,
        "Rank": 377,
        "Type": "deserunt",
        "ColorBlock": 591,
        "IconHint": "facilis",
        "Selected": false,
        "LastChanged": "2014-02-05T03:40:46.8436443+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quod",
        "StyleHint": "modi",
        "Hidden": true,
        "FullName": "Prof. Tania Schneider",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 628
          }
        }
      }
    ],
    "PersonNumber": "552805",
    "FullName": "Saige Armstrong DDS",
    "NoMailing": false,
    "UsePersonAddress": false,
    "Retired": true,
    "Urls": [
      {
        "Value": "dolore",
        "StrippedValue": "quam",
        "Description": "Programmable didactic secured line",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 924
          }
        }
      },
      {
        "Value": "dolore",
        "StrippedValue": "quam",
        "Description": "Programmable didactic secured line",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 924
          }
        }
      }
    ],
    "FormalName": "Upton-Ratke",
    "Address": null,
    "Post3": "magni",
    "Post2": "nam",
    "Post1": "qui",
    "Kanalname": "ut",
    "Kanafname": "delectus",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "in",
    "ActiveInterests": 417,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 567,
    "DbiKey": "nemo",
    "DbiLastModified": "2004-04-02T03:40:46.8436443+02:00",
    "DbiLastSyncronized": "2012-01-21T03:40:46.8436443+01:00",
    "SentInfo": 475,
    "ShowContactTickets": 315,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "velit",
        "StrippedValue": "laudantium",
        "Description": "Upgradable full-range policy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 19
          }
        }
      },
      {
        "Value": "velit",
        "StrippedValue": "laudantium",
        "Description": "Upgradable full-range policy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 19
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "facere",
        "StrippedValue": "tenetur",
        "Description": "User-centric dedicated installation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 35
          }
        }
      },
      {
        "Value": "facere",
        "StrippedValue": "tenetur",
        "Description": "User-centric dedicated installation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 35
          }
        }
      }
    ],
    "Source": 72,
    "ActiveErpLinks": 232,
    "ShipmentTypes": [
      {
        "Id": 1000,
        "Name": "O'Reilly-Schumm",
        "ToolTip": "Quisquam autem tenetur assumenda officia eligendi ut.",
        "Deleted": false,
        "Rank": 130,
        "Type": "provident",
        "ColorBlock": 636,
        "IconHint": "ut",
        "Selected": true,
        "LastChanged": "2023-04-02T03:40:46.8436443+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quos",
        "StyleHint": "totam",
        "Hidden": true,
        "FullName": "Rod Mohr",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 37
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 478,
        "Comment": "in",
        "Registered": "2020-04-08T03:40:46.8436443+02:00",
        "RegisteredAssociateId": 629,
        "Updated": "2020-07-01T03:40:46.8436443+02:00",
        "UpdatedAssociateId": 419,
        "LegalBaseId": 84,
        "LegalBaseKey": "ea",
        "LegalBaseName": "Reynolds, Gutkowski and Tromp",
        "ConsentPurposeId": 831,
        "ConsentPurposeKey": "non",
        "ConsentPurposeName": "Waelchi Inc and Sons",
        "ConsentSourceId": 750,
        "ConsentSourceKey": "delectus",
        "ConsentSourceName": "Zulauf-Ortiz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 358
          }
        }
      }
    ],
    "BounceEmails": [
      "anabelle@dickihuel.ca",
      "eveline_zulauf@nader.com"
    ],
    "ActiveStatusMonitorId": 317,
    "CreatedByFormId": 81,
    "UtmParameters": null,
    "LeadstatusId": 655,
    "UserDefinedFields": {
      "SuperOffice:1": "347146105",
      "SuperOffice:2": "Jazmyne Deckow"
    },
    "ExtraFields": {
      "ExtraFields1": "fugit",
      "ExtraFields2": "vel"
    },
    "CustomFields": {
      "CustomFields1": "ducimus",
      "CustomFields2": "aut"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 348
      }
    }
  }
]
```