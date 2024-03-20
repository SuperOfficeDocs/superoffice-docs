---
title: POST Agents/Person/CreateDefaultPersonEntity
uid: v1PersonAgent_CreateDefaultPersonEntity
generated: true
---

# POST Agents/Person/CreateDefaultPersonEntity

```http
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
```

Set default values into a new PersonEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 43,
  "Firstname": "Joannie",
  "MiddleName": "Ondricka, Will and Glover",
  "Lastname": "Fay",
  "Mrmrs": "quo",
  "Title": "recusandae",
  "UpdatedDate": "2013-08-29T12:19:45.617185+02:00",
  "CreatedDate": "2004-07-03T12:19:45.617185+02:00",
  "BirthDate": "2002-04-12T12:19:45.617185+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "animi",
      "StrippedValue": "minima",
      "Description": "Realigned multi-tasking knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "minima",
      "Description": "Realigned multi-tasking knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    }
  ],
  "Description": "Balanced motivating moratorium",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "veniam",
      "StrippedValue": "aut",
      "Description": "Stand-alone 24 hour benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "aut",
      "Description": "Stand-alone 24 hour benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "reprehenderit",
      "Description": "Phased methodical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "reprehenderit",
      "Description": "Phased methodical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "soluta",
      "StrippedValue": "aut",
      "Description": "Synchronised dedicated customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "aut",
      "Description": "Synchronised dedicated customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quasi",
      "StrippedValue": "ut",
      "Description": "Customizable leading edge process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "ut",
      "Description": "Customizable leading edge process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "at",
      "StrippedValue": "officiis",
      "Description": "Digitized 6th generation array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "officiis",
      "Description": "Digitized 6th generation array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
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
      "Id": 855,
      "Name": "Conroy-Fadel",
      "ToolTip": "Illum quis perspiciatis sit.",
      "Deleted": false,
      "Rank": 474,
      "Type": "reiciendis",
      "ColorBlock": 48,
      "IconHint": "maiores",
      "Selected": true,
      "LastChanged": "2021-06-10T12:19:45.617185+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "ipsa",
      "Hidden": false,
      "FullName": "Ms. Mariana Myron Lehner MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 185
        }
      }
    }
  ],
  "PersonNumber": "1046351",
  "FullName": "Seth Lebsack",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "dolores",
      "StrippedValue": "pariatur",
      "Description": "Diverse solution-oriented service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 54
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "pariatur",
      "Description": "Diverse solution-oriented service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 54
        }
      }
    }
  ],
  "FormalName": "Eichmann-Funk",
  "Address": null,
  "Post3": "qui",
  "Post2": "reiciendis",
  "Post1": "nam",
  "Kanalname": "temporibus",
  "Kanafname": "hic",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptates",
  "ActiveInterests": 813,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 274,
  "DbiKey": "labore",
  "DbiLastModified": "2021-05-27T12:19:45.617185+02:00",
  "DbiLastSyncronized": "2003-09-09T12:19:45.617185+02:00",
  "SentInfo": 896,
  "ShowContactTickets": 59,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ex",
      "StrippedValue": "ut",
      "Description": "Implemented even-keeled model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 241
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "ut",
      "Description": "Implemented even-keeled model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 241
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Right-sized context-sensitive data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Right-sized context-sensitive data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    }
  ],
  "Source": 949,
  "ActiveErpLinks": 43,
  "ShipmentTypes": [
    {
      "Id": 8,
      "Name": "Blick-Brown",
      "ToolTip": "Illum in voluptate suscipit.",
      "Deleted": false,
      "Rank": 979,
      "Type": "ipsum",
      "ColorBlock": 473,
      "IconHint": "dicta",
      "Selected": false,
      "LastChanged": "2022-09-08T12:19:45.617185+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "harum",
      "StyleHint": "reprehenderit",
      "Hidden": false,
      "FullName": "Prof. Cecilia Lambert McClure IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 983,
      "Comment": "eveniet",
      "Registered": "2001-01-03T12:19:45.617185+01:00",
      "RegisteredAssociateId": 164,
      "Updated": "2018-09-28T12:19:45.617185+02:00",
      "UpdatedAssociateId": 481,
      "LegalBaseId": 268,
      "LegalBaseKey": "soluta",
      "LegalBaseName": "Abernathy-Douglas",
      "ConsentPurposeId": 790,
      "ConsentPurposeKey": "voluptates",
      "ConsentPurposeName": "Boyer, Kovacek and Howe",
      "ConsentSourceId": 77,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Sawayn Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 479
        }
      }
    }
  ],
  "BounceEmails": [
    "constantin@lakin.us",
    "art@bahringeroconnell.info"
  ],
  "ActiveStatusMonitorId": 939,
  "UserDefinedFields": {
    "SuperOffice:1": "908938483",
    "SuperOffice:2": "Elbert Labadie"
  },
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "ullam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 642
    }
  }
}
```