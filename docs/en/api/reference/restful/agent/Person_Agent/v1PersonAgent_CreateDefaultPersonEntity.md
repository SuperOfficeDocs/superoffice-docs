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
  "PersonId": 223,
  "Firstname": "Hardy",
  "MiddleName": "Torp, Ward and Ullrich",
  "Lastname": "Gottlieb",
  "Mrmrs": "pariatur",
  "Title": "facilis",
  "UpdatedDate": "2016-01-02T16:54:55.6855066+01:00",
  "CreatedDate": "2000-07-03T16:54:55.6855066+02:00",
  "BirthDate": "2007-12-20T16:54:55.6855066+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "vero",
      "StrippedValue": "cum",
      "Description": "Synergistic grid-enabled support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 992
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "cum",
      "Description": "Synergistic grid-enabled support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 992
        }
      }
    }
  ],
  "Description": "Automated web-enabled leverage",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "optio",
      "StrippedValue": "iusto",
      "Description": "Open-source local benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "iusto",
      "Description": "Open-source local benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nostrum",
      "StrippedValue": "quibusdam",
      "Description": "Progressive grid-enabled projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 376
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "quibusdam",
      "Description": "Progressive grid-enabled projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 376
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "unde",
      "StrippedValue": "eum",
      "Description": "Upgradable system-worthy process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 189
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "eum",
      "Description": "Upgradable system-worthy process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 189
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "distinctio",
      "Description": "Digitized context-sensitive moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 418
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "distinctio",
      "Description": "Digitized context-sensitive moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 418
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "et",
      "Description": "Diverse user-facing application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 446
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "et",
      "Description": "Diverse user-facing application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 446
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
      "Id": 284,
      "Name": "Ferry-Abernathy",
      "ToolTip": "In earum blanditiis omnis soluta sapiente aut.",
      "Deleted": false,
      "Rank": 328,
      "Type": "voluptatum",
      "ColorBlock": 635,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2011-06-27T16:54:55.6885067+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "hic",
      "StyleHint": "consequatur",
      "Hidden": true,
      "FullName": "Autumn Windler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 430
        }
      }
    }
  ],
  "PersonNumber": "1569898",
  "FullName": "Dorris Reta Rogahn V",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "voluptatem",
      "Description": "Intuitive fresh-thinking moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "voluptatem",
      "Description": "Intuitive fresh-thinking moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    }
  ],
  "FormalName": "Dach-Daugherty",
  "Address": null,
  "Post3": "amet",
  "Post2": "quia",
  "Post1": "inventore",
  "Kanalname": "facere",
  "Kanafname": "debitis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "consectetur",
  "ActiveInterests": 117,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 736,
  "DbiKey": "corporis",
  "DbiLastModified": "1997-12-19T16:54:55.6905078+01:00",
  "DbiLastSyncronized": "2006-05-11T16:54:55.6905078+02:00",
  "SentInfo": 521,
  "ShowContactTickets": 61,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "est",
      "StrippedValue": "nostrum",
      "Description": "Triple-buffered object-oriented open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 786
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "nostrum",
      "Description": "Triple-buffered object-oriented open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 786
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "qui",
      "StrippedValue": "reiciendis",
      "Description": "Diverse user-facing matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 800
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "reiciendis",
      "Description": "Diverse user-facing matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 800
        }
      }
    }
  ],
  "Source": 340,
  "ActiveErpLinks": 413,
  "ShipmentTypes": [
    {
      "Id": 121,
      "Name": "Dooley, Ziemann and Towne",
      "ToolTip": "Laboriosam blanditiis aut repellat.",
      "Deleted": false,
      "Rank": 759,
      "Type": "dolor",
      "ColorBlock": 583,
      "IconHint": "qui",
      "Selected": false,
      "LastChanged": "2014-08-28T16:54:55.6905078+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "voluptas",
      "Hidden": true,
      "FullName": "Mr. Daniela Conroy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 899
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 232,
      "Comment": "adipisci",
      "Registered": "2020-11-10T16:54:55.6905078+01:00",
      "RegisteredAssociateId": 571,
      "Updated": "2015-10-26T16:54:55.6905078+01:00",
      "UpdatedAssociateId": 36,
      "LegalBaseId": 434,
      "LegalBaseKey": "sed",
      "LegalBaseName": "Kutch, Kihn and Fadel",
      "ConsentPurposeId": 473,
      "ConsentPurposeKey": "veritatis",
      "ConsentPurposeName": "O'Kon, Gibson and Rice",
      "ConsentSourceId": 901,
      "ConsentSourceKey": "voluptatem",
      "ConsentSourceName": "Hartmann-Kirlin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    }
  ],
  "BounceEmails": [
    "sammy@herman.name",
    "viola@tremblay.biz"
  ],
  "ActiveStatusMonitorId": 687,
  "UserDefinedFields": {
    "SuperOffice:1": "Angela Ledner",
    "SuperOffice:2": "Carter Schaden DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatibus",
    "ExtraFields2": "nobis"
  },
  "CustomFields": {
    "CustomFields1": "cumque",
    "CustomFields2": "ipsum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 805
    }
  }
}
```