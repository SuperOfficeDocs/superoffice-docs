---
title: GET Person/default
uid: v1PersonEntity_DefaultPersonEntity
generated: true
content_type: reference
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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating this person, readonly fields |
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
Last-Modified: Mon, 29 Jun 2015 03:47:00 G6T

{
  "PersonId": 412,
  "Firstname": "Cruz",
  "MiddleName": "Cole LLC",
  "Lastname": "Luettgen",
  "Mrmrs": "hic",
  "Title": "ut",
  "UpdatedDate": "2015-06-29T03:47:00.0349452+02:00",
  "CreatedDate": "2020-02-28T03:47:00.0349452+01:00",
  "BirthDate": "2020-11-05T03:47:00.0349452+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "illum",
      "StrippedValue": "distinctio",
      "Description": "Distributed uniform benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 587
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "distinctio",
      "Description": "Distributed uniform benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 587
        }
      }
    }
  ],
  "Description": "Multi-lateral dynamic instruction set",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "laborum",
      "Description": "Monitored stable moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "laborum",
      "Description": "Monitored stable moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "itaque",
      "Description": "Pre-emptive upward-trending matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 254
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "itaque",
      "Description": "Pre-emptive upward-trending matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 254
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "velit",
      "StrippedValue": "perferendis",
      "Description": "Profit-focused impactful functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 201
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "perferendis",
      "Description": "Profit-focused impactful functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 201
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolore",
      "StrippedValue": "dicta",
      "Description": "Enhanced analyzing portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "dicta",
      "Description": "Enhanced analyzing portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nemo",
      "StrippedValue": "a",
      "Description": "Optimized assymetric matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 976
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "a",
      "Description": "Optimized assymetric matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 976
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
      "Id": 548,
      "Name": "Crist-Oberbrunner",
      "ToolTip": "Vitae cupiditate sit incidunt.",
      "Deleted": false,
      "Rank": 123,
      "Type": "aut",
      "ColorBlock": 944,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2004-02-04T03:47:00.0505611+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "laborum",
      "Hidden": false,
      "FullName": "Angel Carole Jacobi Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 370
        }
      }
    }
  ],
  "PersonNumber": "849034",
  "FullName": "Shanon Kemmer",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "accusantium",
      "Description": "Versatile global frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "accusantium",
      "Description": "Versatile global frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    }
  ],
  "FormalName": "Gottlieb-Pfannerstill",
  "Address": null,
  "Post3": "hic",
  "Post2": "possimus",
  "Post1": "distinctio",
  "Kanalname": "occaecati",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "illum",
  "ActiveInterests": 171,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 58,
  "DbiKey": "est",
  "DbiLastModified": "2024-11-03T03:47:00.0505611+01:00",
  "DbiLastSyncronized": "2013-08-21T03:47:00.0505611+02:00",
  "SentInfo": 649,
  "ShowContactTickets": 35,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "magni",
      "Description": "Enterprise-wide responsive time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 849
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "magni",
      "Description": "Enterprise-wide responsive time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 849
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "vel",
      "Description": "Organic dedicated function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "vel",
      "Description": "Organic dedicated function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    }
  ],
  "Source": 68,
  "ActiveErpLinks": 840,
  "ShipmentTypes": [
    {
      "Id": 965,
      "Name": "Kulas, Farrell and Marvin",
      "ToolTip": "Et quaerat cumque ut.",
      "Deleted": true,
      "Rank": 964,
      "Type": "aut",
      "ColorBlock": 861,
      "IconHint": "adipisci",
      "Selected": true,
      "LastChanged": "1999-11-04T03:47:00.0505611+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "debitis",
      "StyleHint": "perspiciatis",
      "Hidden": false,
      "FullName": "Carole Jerde",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 495
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 38,
      "Comment": "consequuntur",
      "Registered": "2015-02-07T03:47:00.0505611+01:00",
      "RegisteredAssociateId": 25,
      "Updated": "2007-07-13T03:47:00.0505611+02:00",
      "UpdatedAssociateId": 28,
      "LegalBaseId": 1000,
      "LegalBaseKey": "cumque",
      "LegalBaseName": "Green-Effertz",
      "ConsentPurposeId": 983,
      "ConsentPurposeKey": "quia",
      "ConsentPurposeName": "Kuvalis, Crooks and Bartoletti",
      "ConsentSourceId": 580,
      "ConsentSourceKey": "nihil",
      "ConsentSourceName": "Langosh Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 335
        }
      }
    }
  ],
  "BounceEmails": [
    "keith.feeney@wilderman.com",
    "merritt.kertzmann@rutherfordkonopelski.name"
  ],
  "ActiveStatusMonitorId": 288,
  "CreatedByFormId": 138,
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "1928909502",
    "SuperOffice:2": "18301610"
  },
  "ExtraFields": {
    "ExtraFields1": "dicta",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "hic"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 685
    }
  }
}
```