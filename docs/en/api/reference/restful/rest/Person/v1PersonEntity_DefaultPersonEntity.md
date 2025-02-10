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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 19 Jul 2000 12:01:32 G7T

{
  "PersonId": 848,
  "Firstname": "Ashtyn",
  "MiddleName": "Grimes-Abbott",
  "Lastname": "Konopelski",
  "Mrmrs": "dolorem",
  "Title": "totam",
  "UpdatedDate": "2000-07-19T12:01:32.933188+02:00",
  "CreatedDate": "2003-01-17T12:01:32.933188+01:00",
  "BirthDate": "2004-03-17T12:01:32.933188+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "id",
      "Description": "Visionary object-oriented attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1000
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "id",
      "Description": "Visionary object-oriented attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1000
        }
      }
    }
  ],
  "Description": "Business-focused high-level service-desk",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "itaque",
      "StrippedValue": "enim",
      "Description": "Vision-oriented holistic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 507
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "enim",
      "Description": "Vision-oriented holistic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 507
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iure",
      "StrippedValue": "aliquam",
      "Description": "Versatile multimedia instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 643
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "aliquam",
      "Description": "Versatile multimedia instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 643
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Public-key mission-critical local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 25
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Public-key mission-critical local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 25
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "neque",
      "StrippedValue": "itaque",
      "Description": "Up-sized maximized support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "itaque",
      "Description": "Up-sized maximized support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ab",
      "StrippedValue": "sit",
      "Description": "Horizontal explicit core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "sit",
      "Description": "Horizontal explicit core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 835
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
      "Id": 747,
      "Name": "West Group",
      "ToolTip": "Repellat non ut omnis exercitationem voluptates.",
      "Deleted": false,
      "Rank": 885,
      "Type": "ea",
      "ColorBlock": 877,
      "IconHint": "illum",
      "Selected": true,
      "LastChanged": "1999-02-08T12:01:32.933188+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quos",
      "StyleHint": "nulla",
      "Hidden": false,
      "FullName": "Octavia West",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    }
  ],
  "PersonNumber": "1225340",
  "FullName": "Morton Bogan PhD",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "quo",
      "Description": "Extended holistic function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "quo",
      "Description": "Extended holistic function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    }
  ],
  "FormalName": "Hackett, Connelly and Reinger",
  "Address": null,
  "Post3": "qui",
  "Post2": "magnam",
  "Post1": "eos",
  "Kanalname": "dolores",
  "Kanafname": "accusantium",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "consectetur",
  "ActiveInterests": 608,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 556,
  "DbiKey": "ratione",
  "DbiLastModified": "2017-11-19T12:01:32.933188+01:00",
  "DbiLastSyncronized": "1999-09-19T12:01:32.933188+02:00",
  "SentInfo": 575,
  "ShowContactTickets": 200,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "molestiae",
      "StrippedValue": "ut",
      "Description": "De-engineered local matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 130
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "ut",
      "Description": "De-engineered local matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 130
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "vitae",
      "StrippedValue": "reprehenderit",
      "Description": "Cross-platform tangible internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "reprehenderit",
      "Description": "Cross-platform tangible internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    }
  ],
  "Source": 569,
  "ActiveErpLinks": 284,
  "ShipmentTypes": [
    {
      "Id": 600,
      "Name": "Hahn-Bahringer",
      "ToolTip": "Aliquid sunt consequuntur ipsa tempore est consequatur quo.",
      "Deleted": true,
      "Rank": 255,
      "Type": "et",
      "ColorBlock": 70,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2020-08-18T12:01:32.933188+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Ms. Mariana Morar PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 656,
      "Comment": "aut",
      "Registered": "2011-10-20T12:01:32.933188+02:00",
      "RegisteredAssociateId": 698,
      "Updated": "2023-05-23T12:01:32.933188+02:00",
      "UpdatedAssociateId": 99,
      "LegalBaseId": 585,
      "LegalBaseKey": "hic",
      "LegalBaseName": "Robel, Hansen and Dooley",
      "ConsentPurposeId": 934,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Schamberger, Kirlin and Bogisich",
      "ConsentSourceId": 515,
      "ConsentSourceKey": "est",
      "ConsentSourceName": "Wiegand-Lindgren",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "BounceEmails": [
    "gregg@ohara.uk",
    "aliyah.keebler@klingwolf.info"
  ],
  "ActiveStatusMonitorId": 152,
  "CreatedByFormId": 43,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Haskell Cruickshank V",
    "SuperOffice:2": "Gaston Quitzon"
  },
  "ExtraFields": {
    "ExtraFields1": "reiciendis",
    "ExtraFields2": "temporibus"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 200
    }
  }
}
```