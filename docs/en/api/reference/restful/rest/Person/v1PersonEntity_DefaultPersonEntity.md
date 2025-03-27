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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 24 Nov 2006 02:38:26 G11T

{
  "PersonId": 825,
  "Firstname": "Blake",
  "MiddleName": "Kunde-Feil",
  "Lastname": "Lang",
  "Mrmrs": "dolores",
  "Title": "et",
  "UpdatedDate": "2006-11-24T02:38:26.1360573+01:00",
  "CreatedDate": "2023-11-25T02:38:26.1360573+01:00",
  "BirthDate": "2023-08-12T02:38:26.1360573+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "incidunt",
      "StrippedValue": "nostrum",
      "Description": "Devolved content-based infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "nostrum",
      "Description": "Devolved content-based infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    }
  ],
  "Description": "Cloned incremental concept",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "nihil",
      "Description": "Persevering 24 hour task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "nihil",
      "Description": "Persevering 24 hour task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eum",
      "StrippedValue": "similique",
      "Description": "Assimilated optimal application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 844
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "similique",
      "Description": "Assimilated optimal application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 844
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "veritatis",
      "StrippedValue": "aperiam",
      "Description": "Up-sized neutral strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 659
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "aperiam",
      "Description": "Up-sized neutral strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 659
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "doloribus",
      "Description": "Seamless 24/7 model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 581
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "doloribus",
      "Description": "Seamless 24/7 model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 581
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "deleniti",
      "StrippedValue": "aut",
      "Description": "Re-contextualized bottom-line alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 801
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "aut",
      "Description": "Re-contextualized bottom-line alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 801
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
      "Id": 813,
      "Name": "Feil Group",
      "ToolTip": "Dolores minus quam sit.",
      "Deleted": true,
      "Rank": 937,
      "Type": "et",
      "ColorBlock": 781,
      "IconHint": "totam",
      "Selected": false,
      "LastChanged": "2007-09-21T02:38:26.1360573+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "magnam",
      "Hidden": false,
      "FullName": "Harold Hane",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    }
  ],
  "PersonNumber": "385985",
  "FullName": "Leta Bode",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "tempore",
      "Description": "Versatile leading edge portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 296
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "tempore",
      "Description": "Versatile leading edge portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 296
        }
      }
    }
  ],
  "FormalName": "Walker-Sipes",
  "Address": null,
  "Post3": "aut",
  "Post2": "dolorum",
  "Post1": "facere",
  "Kanalname": "autem",
  "Kanafname": "at",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "debitis",
  "ActiveInterests": 456,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 167,
  "DbiKey": "sed",
  "DbiLastModified": "2020-07-25T02:38:26.1360573+02:00",
  "DbiLastSyncronized": "2024-03-14T02:38:26.1360573+01:00",
  "SentInfo": 693,
  "ShowContactTickets": 480,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "occaecati",
      "StrippedValue": "explicabo",
      "Description": "Customizable upward-trending workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "explicabo",
      "Description": "Customizable upward-trending workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eveniet",
      "StrippedValue": "pariatur",
      "Description": "Visionary 24 hour array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 534
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "pariatur",
      "Description": "Visionary 24 hour array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 534
        }
      }
    }
  ],
  "Source": 986,
  "ActiveErpLinks": 619,
  "ShipmentTypes": [
    {
      "Id": 80,
      "Name": "Schultz Inc and Sons",
      "ToolTip": "Est nam vero cum earum sed eum.",
      "Deleted": false,
      "Rank": 840,
      "Type": "sequi",
      "ColorBlock": 516,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2019-02-03T02:38:26.1360573+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "numquam",
      "StyleHint": "deleniti",
      "Hidden": true,
      "FullName": "Delphine Flo Zulauf I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 645
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 403,
      "Comment": "nesciunt",
      "Registered": "2001-09-09T02:38:26.1360573+02:00",
      "RegisteredAssociateId": 69,
      "Updated": "2010-07-09T02:38:26.1360573+02:00",
      "UpdatedAssociateId": 898,
      "LegalBaseId": 64,
      "LegalBaseKey": "eos",
      "LegalBaseName": "Pacocha-Wolff",
      "ConsentPurposeId": 80,
      "ConsentPurposeKey": "aliquam",
      "ConsentPurposeName": "Wiegand, Kunze and Mitchell",
      "ConsentSourceId": 916,
      "ConsentSourceKey": "ullam",
      "ConsentSourceName": "Bernier Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    }
  ],
  "BounceEmails": [
    "maribel.prohaska@klein.co.uk",
    "ruthie_koepp@hauck.ca"
  ],
  "ActiveStatusMonitorId": 466,
  "CreatedByFormId": 654,
  "UserDefinedFields": {
    "SuperOffice:1": "53161128",
    "SuperOffice:2": "606358944"
  },
  "ExtraFields": {
    "ExtraFields1": "animi",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "nemo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 441
    }
  }
}
```