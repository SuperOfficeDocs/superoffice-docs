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
Last-Modified: Thu, 08 Apr 2010 14:23:55 G4T

{
  "PersonId": 372,
  "Firstname": "Jada",
  "MiddleName": "Cassin-Wuckert",
  "Lastname": "Koelpin",
  "Mrmrs": "ut",
  "Title": "quia",
  "UpdatedDate": "2010-04-08T14:23:55.2127043+02:00",
  "CreatedDate": "2021-02-19T14:23:55.2127043+01:00",
  "BirthDate": "2023-09-01T14:23:55.2127043+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "delectus",
      "Description": "Phased scalable leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "delectus",
      "Description": "Phased scalable leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    }
  ],
  "Description": "Optimized responsive customer loyalty",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "illo",
      "StrippedValue": "tempore",
      "Description": "Profound non-volatile portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 445
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "tempore",
      "Description": "Profound non-volatile portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 445
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quas",
      "StrippedValue": "voluptatem",
      "Description": "Extended human-resource help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 650
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "voluptatem",
      "Description": "Extended human-resource help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 650
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "quia",
      "Description": "Synchronised heuristic throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 589
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "quia",
      "Description": "Synchronised heuristic throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 589
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Fully-configurable executive alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Fully-configurable executive alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "excepturi",
      "Description": "Distributed mobile open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 523
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "excepturi",
      "Description": "Distributed mobile open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 523
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
      "Id": 884,
      "Name": "Ortiz, Emard and Kling",
      "ToolTip": "Voluptatem id facere hic ratione.",
      "Deleted": false,
      "Rank": 58,
      "Type": "est",
      "ColorBlock": 130,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2010-11-19T14:23:55.2127043+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "quo",
      "Hidden": true,
      "FullName": "Russ Gleason",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 30
        }
      }
    }
  ],
  "PersonNumber": "644192",
  "FullName": "Thomas Krystina Ebert V",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "odit",
      "StrippedValue": "magnam",
      "Description": "Programmable optimal utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "magnam",
      "Description": "Programmable optimal utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    }
  ],
  "FormalName": "Blanda LLC",
  "Address": null,
  "Post3": "quia",
  "Post2": "repellendus",
  "Post1": "perspiciatis",
  "Kanalname": "eos",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "tenetur",
  "ActiveInterests": 966,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 579,
  "DbiKey": "ipsam",
  "DbiLastModified": "2014-07-29T14:23:55.2127043+02:00",
  "DbiLastSyncronized": "2021-09-16T14:23:55.2127043+02:00",
  "SentInfo": 155,
  "ShowContactTickets": 194,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "illo",
      "StrippedValue": "numquam",
      "Description": "Monitored tertiary process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 982
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "numquam",
      "Description": "Monitored tertiary process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 982
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "esse",
      "Description": "Devolved holistic parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "esse",
      "Description": "Devolved holistic parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "Source": 429,
  "ActiveErpLinks": 813,
  "ShipmentTypes": [
    {
      "Id": 91,
      "Name": "Balistreri-Dooley",
      "ToolTip": "Ex sunt.",
      "Deleted": true,
      "Rank": 940,
      "Type": "labore",
      "ColorBlock": 756,
      "IconHint": "quod",
      "Selected": false,
      "LastChanged": "2020-05-03T14:23:55.2127043+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "recusandae",
      "StyleHint": "soluta",
      "Hidden": false,
      "FullName": "Miss Bernita Skiles MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 97,
      "Comment": "autem",
      "Registered": "2020-07-08T14:23:55.2127043+02:00",
      "RegisteredAssociateId": 794,
      "Updated": "2022-05-20T14:23:55.2127043+02:00",
      "UpdatedAssociateId": 608,
      "LegalBaseId": 933,
      "LegalBaseKey": "dolorem",
      "LegalBaseName": "Schmeler, Rohan and Bechtelar",
      "ConsentPurposeId": 843,
      "ConsentPurposeKey": "quas",
      "ConsentPurposeName": "Bernhard LLC",
      "ConsentSourceId": 172,
      "ConsentSourceKey": "odio",
      "ConsentSourceName": "Zulauf-Wilderman",
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
  "BounceEmails": [
    "jayce@bechtelar.biz",
    "brannon.nienow@reichert.com"
  ],
  "ActiveStatusMonitorId": 801,
  "UserDefinedFields": {
    "SuperOffice:1": "Fanny Bogisich",
    "SuperOffice:2": "Constance Wisozk"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "autem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 859
    }
  }
}
```