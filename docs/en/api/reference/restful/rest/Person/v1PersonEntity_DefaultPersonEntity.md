---
title: GET Person/default
uid: v1PersonEntity_DefaultPersonEntity
generated: true
---

# GET Person/default

```http
GET /api/v1/Person/default
```

Set default values into a new PersonEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Person agent service CreateDefaultPersonEntity.







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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Person/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 13 Feb 2023 12:57:42 G2T

{
  "PersonId": 840,
  "Firstname": "Kelsie",
  "MiddleName": "Gleason LLC",
  "Lastname": "Graham",
  "Mrmrs": "et",
  "Title": "aut",
  "UpdatedDate": "2023-02-13T12:57:42.4794988+01:00",
  "CreatedDate": "2002-12-20T12:57:42.4794988+01:00",
  "BirthDate": "2011-08-01T12:57:42.4794988+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "perferendis",
      "StrippedValue": "ea",
      "Description": "Sharable tertiary service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 378
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "ea",
      "Description": "Sharable tertiary service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 378
        }
      }
    }
  ],
  "Description": "Automated asynchronous architecture",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "dolores",
      "StrippedValue": "eum",
      "Description": "Virtual client-server approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 853
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "eum",
      "Description": "Virtual client-server approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 853
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "ipsa",
      "Description": "Open-source contextually-based encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 530
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "ipsa",
      "Description": "Open-source contextually-based encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 530
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "alias",
      "StrippedValue": "asperiores",
      "Description": "Configurable actuating task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "asperiores",
      "Description": "Configurable actuating task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "distinctio",
      "Description": "Configurable maximized info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 295
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "distinctio",
      "Description": "Configurable maximized info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 295
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "omnis",
      "Description": "Networked 24 hour architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "omnis",
      "Description": "Networked 24 hour architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
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
      "Id": 863,
      "Name": "Gutkowski Inc and Sons",
      "ToolTip": "Voluptas ab sed et qui facere et praesentium.",
      "Deleted": false,
      "Rank": 993,
      "Type": "id",
      "ColorBlock": 422,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2010-12-21T12:57:42.4794988+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Aliza Doyle",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 40
        }
      }
    }
  ],
  "PersonNumber": "1618439",
  "FullName": "Joanie Morar",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "assumenda",
      "StrippedValue": "ut",
      "Description": "Visionary contextually-based ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 144
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "ut",
      "Description": "Visionary contextually-based ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 144
        }
      }
    }
  ],
  "FormalName": "Padberg-Emmerich",
  "Address": null,
  "Post3": "voluptate",
  "Post2": "consequatur",
  "Post1": "aut",
  "Kanalname": "saepe",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quis",
  "ActiveInterests": 968,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 641,
  "DbiKey": "ullam",
  "DbiLastModified": "2010-02-03T12:57:42.4794988+01:00",
  "DbiLastSyncronized": "2000-09-16T12:57:42.4794988+02:00",
  "SentInfo": 526,
  "ShowContactTickets": 808,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aut",
      "StrippedValue": "quas",
      "Description": "User-centric demand-driven time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 42
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quas",
      "Description": "User-centric demand-driven time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 42
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "libero",
      "Description": "Profound reciprocal monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "libero",
      "Description": "Profound reciprocal monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "Source": 505,
  "ActiveErpLinks": 922,
  "ShipmentTypes": [
    {
      "Id": 595,
      "Name": "Stoltenberg-Stehr",
      "ToolTip": "Consequatur itaque nostrum.",
      "Deleted": true,
      "Rank": 870,
      "Type": "est",
      "ColorBlock": 679,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "2005-03-03T12:57:42.4794988+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "dignissimos",
      "Hidden": false,
      "FullName": "Brain Lakin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 667,
      "Comment": "enim",
      "Registered": "2005-01-25T12:57:42.4794988+01:00",
      "RegisteredAssociateId": 452,
      "Updated": "2005-08-08T12:57:42.4794988+02:00",
      "UpdatedAssociateId": 394,
      "LegalBaseId": 230,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Corwin, Kulas and Ziemann",
      "ConsentPurposeId": 644,
      "ConsentPurposeKey": "ipsam",
      "ConsentPurposeName": "Pfeffer Group",
      "ConsentSourceId": 896,
      "ConsentSourceKey": "dolorem",
      "ConsentSourceName": "Christiansen, Aufderhar and Ruecker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    }
  ],
  "BounceEmails": [
    "bradley@jacobi.co.uk",
    "allene@stokespouros.uk"
  ],
  "ActiveStatusMonitorId": 356,
  "UserDefinedFields": {
    "SuperOffice:1": "Prudence Koch",
    "SuperOffice:2": "1500673738"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "veniam",
    "CustomFields2": "velit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 197
    }
  }
}
```