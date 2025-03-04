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
Last-Modified: Fri, 24 Apr 2009 14:13:48 G4T

{
  "PersonId": 32,
  "Firstname": "Calista",
  "MiddleName": "Bruen-Luettgen",
  "Lastname": "Champlin",
  "Mrmrs": "corporis",
  "Title": "qui",
  "UpdatedDate": "2009-04-24T14:13:48.914944+02:00",
  "CreatedDate": "2022-08-07T14:13:48.914944+02:00",
  "BirthDate": "2016-03-16T14:13:48.914944+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "incidunt",
      "StrippedValue": "voluptas",
      "Description": "Inverse attitude-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "voluptas",
      "Description": "Inverse attitude-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "Description": "Mandatory systematic conglomeration",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quia",
      "StrippedValue": "eius",
      "Description": "Grass-roots 24 hour function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 476
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "eius",
      "Description": "Grass-roots 24 hour function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 476
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "assumenda",
      "StrippedValue": "qui",
      "Description": "Visionary discrete open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "qui",
      "Description": "Visionary discrete open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ducimus",
      "StrippedValue": "vitae",
      "Description": "Open-architected asynchronous utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "vitae",
      "Description": "Open-architected asynchronous utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "omnis",
      "Description": "Organic 5th generation complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 863
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "omnis",
      "Description": "Organic 5th generation complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 863
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "consequuntur",
      "StrippedValue": "delectus",
      "Description": "Realigned neutral function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 370
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "delectus",
      "Description": "Realigned neutral function",
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
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 283,
      "Name": "Ryan, Braun and Lockman",
      "ToolTip": "Aut odio nihil aut amet.",
      "Deleted": false,
      "Rank": 769,
      "Type": "qui",
      "ColorBlock": 807,
      "IconHint": "totam",
      "Selected": true,
      "LastChanged": "2024-12-15T14:13:48.914944+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Nella Hudson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 35
        }
      }
    }
  ],
  "PersonNumber": "783631",
  "FullName": "Loyce Dooley",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "perferendis",
      "StrippedValue": "numquam",
      "Description": "Persistent eco-centric migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 873
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "numquam",
      "Description": "Persistent eco-centric migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 873
        }
      }
    }
  ],
  "FormalName": "O'Connell, Ward and Ryan",
  "Address": null,
  "Post3": "quasi",
  "Post2": "est",
  "Post1": "facilis",
  "Kanalname": "voluptate",
  "Kanafname": "non",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "nihil",
  "ActiveInterests": 827,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 635,
  "DbiKey": "nisi",
  "DbiLastModified": "2019-09-17T14:13:48.914944+02:00",
  "DbiLastSyncronized": "2022-11-05T14:13:48.914944+01:00",
  "SentInfo": 260,
  "ShowContactTickets": 536,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eligendi",
      "StrippedValue": "est",
      "Description": "Monitored fault-tolerant leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 399
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "est",
      "Description": "Monitored fault-tolerant leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 399
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sed",
      "StrippedValue": "ut",
      "Description": "Realigned non-volatile function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "ut",
      "Description": "Realigned non-volatile function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    }
  ],
  "Source": 319,
  "ActiveErpLinks": 883,
  "ShipmentTypes": [
    {
      "Id": 700,
      "Name": "Orn, Beahan and Dach",
      "ToolTip": "Velit non dolores vel voluptate temporibus vel.",
      "Deleted": false,
      "Rank": 71,
      "Type": "quia",
      "ColorBlock": 303,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "2007-12-28T14:13:48.914944+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "fugit",
      "Hidden": true,
      "FullName": "Martina Gerlach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 751,
      "Comment": "aut",
      "Registered": "2017-09-04T14:13:48.914944+02:00",
      "RegisteredAssociateId": 335,
      "Updated": "2012-07-29T14:13:48.914944+02:00",
      "UpdatedAssociateId": 45,
      "LegalBaseId": 496,
      "LegalBaseKey": "molestiae",
      "LegalBaseName": "Altenwerth-Herman",
      "ConsentPurposeId": 555,
      "ConsentPurposeKey": "dolorem",
      "ConsentPurposeName": "Parisian LLC",
      "ConsentSourceId": 178,
      "ConsentSourceKey": "vel",
      "ConsentSourceName": "Reilly, Schoen and Schowalter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    }
  ],
  "BounceEmails": [
    "jamir@prohaska.com",
    "cecilia@goldner.ca"
  ],
  "ActiveStatusMonitorId": 165,
  "CreatedByFormId": 28,
  "UserDefinedFields": {
    "SuperOffice:1": "1651660166",
    "SuperOffice:2": "855115601"
  },
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "labore",
    "CustomFields2": "cum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 739
    }
  }
}
```