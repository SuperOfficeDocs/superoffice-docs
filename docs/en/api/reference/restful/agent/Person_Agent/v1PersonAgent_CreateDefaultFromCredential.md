---
title: POST Agents/Person/CreateDefaultFromCredential
uid: v1PersonAgent_CreateDefaultFromCredential
generated: true
content_type: reference
---

# POST Agents/Person/CreateDefaultFromCredential

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential
```

Creates a PersonEntity with default values based on the contactId and credentials.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential?$select=name,department,category/id
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

ContactId, CredentialType, CredentialValue, CredentialDisplayValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| CredentialType | String |  |
| CredentialValue | String |  |
| CredentialDisplayValue | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

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
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 267,
  "CredentialType": "dicta",
  "CredentialValue": "exercitationem",
  "CredentialDisplayValue": "enim"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 556,
  "Firstname": "Waino",
  "MiddleName": "Schumm-VonRueden",
  "Lastname": "Murazik",
  "Mrmrs": "unde",
  "Title": "ab",
  "UpdatedDate": "1998-05-27T11:24:48.3438973+02:00",
  "CreatedDate": "2020-10-08T11:24:48.3438973+02:00",
  "BirthDate": "2024-10-01T11:24:48.3438973+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolorum",
      "StrippedValue": "ut",
      "Description": "Function-based intangible circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 621
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "ut",
      "Description": "Function-based intangible circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 621
        }
      }
    }
  ],
  "Description": "Optimized scalable structure",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "autem",
      "StrippedValue": "ut",
      "Description": "Object-based zero tolerance model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "ut",
      "Description": "Object-based zero tolerance model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "similique",
      "StrippedValue": "corrupti",
      "Description": "Ameliorated background data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 914
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "corrupti",
      "Description": "Ameliorated background data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 914
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "debitis",
      "StrippedValue": "sit",
      "Description": "Enhanced uniform moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "sit",
      "Description": "Enhanced uniform moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "molestias",
      "Description": "Future-proofed client-server success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 689
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "molestias",
      "Description": "Future-proofed client-server success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 689
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "quod",
      "Description": "Programmable system-worthy core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "quod",
      "Description": "Programmable system-worthy core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
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
      "Id": 276,
      "Name": "Rogahn-Balistreri",
      "ToolTip": "Natus dolorum non ab architecto rerum sed.",
      "Deleted": true,
      "Rank": 814,
      "Type": "quia",
      "ColorBlock": 934,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2024-12-12T11:24:48.3595217+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "libero",
      "StyleHint": "illo",
      "Hidden": true,
      "FullName": "Prof. Mervin Gloria Marvin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    }
  ],
  "PersonNumber": "1491427",
  "FullName": "Shemar Treva Crona DVM",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "earum",
      "StrippedValue": "et",
      "Description": "Vision-oriented 3rd generation hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 702
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "et",
      "Description": "Vision-oriented 3rd generation hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 702
        }
      }
    }
  ],
  "FormalName": "Pollich, Fadel and Schultz",
  "Address": null,
  "Post3": "sint",
  "Post2": "odit",
  "Post1": "sed",
  "Kanalname": "possimus",
  "Kanafname": "tempore",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sequi",
  "ActiveInterests": 13,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 609,
  "DbiKey": "unde",
  "DbiLastModified": "2013-10-22T11:24:48.3595217+02:00",
  "DbiLastSyncronized": "2018-10-15T11:24:48.3595217+02:00",
  "SentInfo": 353,
  "ShowContactTickets": 766,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "minus",
      "StrippedValue": "aliquam",
      "Description": "Proactive attitude-oriented algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 101
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "aliquam",
      "Description": "Proactive attitude-oriented algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 101
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "magnam",
      "StrippedValue": "et",
      "Description": "Enhanced real-time approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 799
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "et",
      "Description": "Enhanced real-time approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 799
        }
      }
    }
  ],
  "Source": 402,
  "ActiveErpLinks": 9,
  "ShipmentTypes": [
    {
      "Id": 906,
      "Name": "Graham, Rempel and Lakin",
      "ToolTip": "Asperiores labore veritatis dignissimos sit et.",
      "Deleted": false,
      "Rank": 227,
      "Type": "delectus",
      "ColorBlock": 109,
      "IconHint": "voluptas",
      "Selected": true,
      "LastChanged": "2025-03-27T11:24:48.3595217+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "ipsa",
      "Hidden": false,
      "FullName": "Miss Rod Mario Labadie",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 213
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 134,
      "Comment": "adipisci",
      "Registered": "2003-08-23T11:24:48.3595217+02:00",
      "RegisteredAssociateId": 964,
      "Updated": "2007-09-06T11:24:48.3595217+02:00",
      "UpdatedAssociateId": 794,
      "LegalBaseId": 662,
      "LegalBaseKey": "dicta",
      "LegalBaseName": "Sporer LLC",
      "ConsentPurposeId": 910,
      "ConsentPurposeKey": "numquam",
      "ConsentPurposeName": "Satterfield-Lueilwitz",
      "ConsentSourceId": 276,
      "ConsentSourceKey": "laborum",
      "ConsentSourceName": "Schmidt, Little and D'Amore",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 428
        }
      }
    }
  ],
  "BounceEmails": [
    "vanessa.wiza@gibson.info",
    "claude_donnelly@ruecker.info"
  ],
  "ActiveStatusMonitorId": 630,
  "CreatedByFormId": 454,
  "UtmParameters": null,
  "LeadstatusId": 748,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. June Green",
    "SuperOffice:2": "794223895"
  },
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "quod"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 3
    }
  }
}
```