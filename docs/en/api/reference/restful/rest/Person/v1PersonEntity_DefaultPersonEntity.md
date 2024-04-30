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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 09 Dec 1996 11:44:42 G12T

{
  "PersonId": 212,
  "Firstname": "Fletcher",
  "MiddleName": "Von-Ledner",
  "Lastname": "Balistreri",
  "Mrmrs": "labore",
  "Title": "magni",
  "UpdatedDate": "1996-12-09T11:44:42.0233848+01:00",
  "CreatedDate": "2003-07-03T11:44:42.0233848+02:00",
  "BirthDate": "2020-11-11T11:44:42.0233848+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "est",
      "Description": "Customer-focused high-level service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 839
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "est",
      "Description": "Customer-focused high-level service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 839
        }
      }
    }
  ],
  "Description": "Expanded actuating orchestration",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "aliquid",
      "StrippedValue": "eius",
      "Description": "Business-focused background approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 282
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "eius",
      "Description": "Business-focused background approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 282
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "nam",
      "Description": "Mandatory asynchronous definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 176
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "nam",
      "Description": "Mandatory asynchronous definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 176
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dicta",
      "StrippedValue": "tempore",
      "Description": "Operative radical time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 397
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "tempore",
      "Description": "Operative radical time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 397
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "unde",
      "StrippedValue": "nesciunt",
      "Description": "Self-enabling zero tolerance firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 481
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "nesciunt",
      "Description": "Self-enabling zero tolerance firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 481
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nisi",
      "StrippedValue": "est",
      "Description": "Total fresh-thinking hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 931
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "est",
      "Description": "Total fresh-thinking hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 931
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
      "Id": 781,
      "Name": "Braun Inc and Sons",
      "ToolTip": "Et ut sunt sapiente laboriosam dicta.",
      "Deleted": true,
      "Rank": 307,
      "Type": "consequatur",
      "ColorBlock": 606,
      "IconHint": "sunt",
      "Selected": false,
      "LastChanged": "1998-09-23T11:44:42.0233848+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perferendis",
      "StyleHint": "rem",
      "Hidden": false,
      "FullName": "Tiara Schamberger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 337
        }
      }
    }
  ],
  "PersonNumber": "907841",
  "FullName": "Tina Waelchi",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "exercitationem",
      "Description": "Grass-roots non-volatile hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "exercitationem",
      "Description": "Grass-roots non-volatile hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    }
  ],
  "FormalName": "Reichert-Jacobson",
  "Address": null,
  "Post3": "non",
  "Post2": "beatae",
  "Post1": "ducimus",
  "Kanalname": "aperiam",
  "Kanafname": "optio",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatem",
  "ActiveInterests": 804,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 247,
  "DbiKey": "distinctio",
  "DbiLastModified": "2009-09-29T11:44:42.0233848+02:00",
  "DbiLastSyncronized": "2019-11-01T11:44:42.0233848+01:00",
  "SentInfo": 393,
  "ShowContactTickets": 814,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptas",
      "StrippedValue": "eos",
      "Description": "Mandatory well-modulated ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "eos",
      "Description": "Mandatory well-modulated ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "fuga",
      "Description": "Pre-emptive clear-thinking encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "fuga",
      "Description": "Pre-emptive clear-thinking encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 78
        }
      }
    }
  ],
  "Source": 847,
  "ActiveErpLinks": 353,
  "ShipmentTypes": [
    {
      "Id": 46,
      "Name": "Spencer, Heathcote and West",
      "ToolTip": "Doloremque quam.",
      "Deleted": true,
      "Rank": 246,
      "Type": "nam",
      "ColorBlock": 294,
      "IconHint": "tenetur",
      "Selected": false,
      "LastChanged": "2024-02-22T11:44:42.0233848+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "illo",
      "Hidden": true,
      "FullName": "Katelin Fay",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 725
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 633,
      "Comment": "molestiae",
      "Registered": "2017-12-05T11:44:42.0233848+01:00",
      "RegisteredAssociateId": 561,
      "Updated": "2009-01-02T11:44:42.0233848+01:00",
      "UpdatedAssociateId": 632,
      "LegalBaseId": 781,
      "LegalBaseKey": "natus",
      "LegalBaseName": "Mills Inc and Sons",
      "ConsentPurposeId": 465,
      "ConsentPurposeKey": "eveniet",
      "ConsentPurposeName": "Zieme LLC",
      "ConsentSourceId": 116,
      "ConsentSourceKey": "rem",
      "ConsentSourceName": "Weissnat, Zulauf and Jakubowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 92
        }
      }
    }
  ],
  "BounceEmails": [
    "novella@nader.us",
    "nikki.schulist@christiansen.co.uk"
  ],
  "ActiveStatusMonitorId": 375,
  "UserDefinedFields": {
    "SuperOffice:1": "Thad Becker",
    "SuperOffice:2": "Afton Edison Breitenberg MD"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatum",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "optio",
    "CustomFields2": "laboriosam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 720
    }
  }
}
```