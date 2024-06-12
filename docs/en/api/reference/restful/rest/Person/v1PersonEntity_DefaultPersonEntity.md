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
Last-Modified: Sat, 21 Dec 2002 04:22:35 G12T

{
  "PersonId": 894,
  "Firstname": "Serena",
  "MiddleName": "Heaney, Maggio and Considine",
  "Lastname": "Stoltenberg",
  "Mrmrs": "amet",
  "Title": "voluptas",
  "UpdatedDate": "2002-12-21T04:22:35.0323337+01:00",
  "CreatedDate": "2018-06-25T04:22:35.0323337+02:00",
  "BirthDate": "2007-04-23T04:22:35.0323337+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "id",
      "StrippedValue": "at",
      "Description": "Programmable intangible archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 726
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "at",
      "Description": "Programmable intangible archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 726
        }
      }
    }
  ],
  "Description": "Grass-roots full-range moratorium",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "velit",
      "StrippedValue": "officia",
      "Description": "Advanced zero defect encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "officia",
      "Description": "Advanced zero defect encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eaque",
      "StrippedValue": "ut",
      "Description": "Customer-focused multi-tasking capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 468
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "ut",
      "Description": "Customer-focused multi-tasking capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 468
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "quam",
      "Description": "Networked fault-tolerant access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "quam",
      "Description": "Networked fault-tolerant access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "ex",
      "Description": "Switchable assymetric functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 175
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "ex",
      "Description": "Switchable assymetric functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 175
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "praesentium",
      "Description": "Realigned zero tolerance infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 361
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "praesentium",
      "Description": "Realigned zero tolerance infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 361
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
      "Id": 180,
      "Name": "Quigley LLC",
      "ToolTip": "Et voluptatem aut expedita.",
      "Deleted": true,
      "Rank": 445,
      "Type": "voluptates",
      "ColorBlock": 476,
      "IconHint": "explicabo",
      "Selected": false,
      "LastChanged": "1999-02-08T04:22:35.0323337+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Prof. Adriana Tobin Muller Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 29
        }
      }
    }
  ],
  "PersonNumber": "416139",
  "FullName": "Lura Cora Jenkins I",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "repellendus",
      "StrippedValue": "nisi",
      "Description": "Compatible executive methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "nisi",
      "Description": "Compatible executive methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "FormalName": "Leannon-Wunsch",
  "Address": null,
  "Post3": "harum",
  "Post2": "rerum",
  "Post1": "tempore",
  "Kanalname": "ipsa",
  "Kanafname": "rerum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ut",
  "ActiveInterests": 693,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 3,
  "DbiKey": "eum",
  "DbiLastModified": "1999-09-15T04:22:35.0323337+02:00",
  "DbiLastSyncronized": "2002-08-02T04:22:35.0323337+02:00",
  "SentInfo": 807,
  "ShowContactTickets": 707,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "fugiat",
      "StrippedValue": "dolores",
      "Description": "Operative local superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "dolores",
      "Description": "Operative local superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "doloremque",
      "Description": "Progressive well-modulated benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 990
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "doloremque",
      "Description": "Progressive well-modulated benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 990
        }
      }
    }
  ],
  "Source": 80,
  "ActiveErpLinks": 163,
  "ShipmentTypes": [
    {
      "Id": 616,
      "Name": "West Group",
      "ToolTip": "Harum eum tempore optio aut.",
      "Deleted": false,
      "Rank": 911,
      "Type": "nulla",
      "ColorBlock": 432,
      "IconHint": "culpa",
      "Selected": true,
      "LastChanged": "2010-05-08T04:22:35.0323337+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "assumenda",
      "Hidden": false,
      "FullName": "Rashad Wolf",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 747,
      "Comment": "occaecati",
      "Registered": "2023-04-16T04:22:35.0323337+02:00",
      "RegisteredAssociateId": 727,
      "Updated": "2018-04-22T04:22:35.0323337+02:00",
      "UpdatedAssociateId": 771,
      "LegalBaseId": 636,
      "LegalBaseKey": "vel",
      "LegalBaseName": "Kassulke, Rau and Fahey",
      "ConsentPurposeId": 272,
      "ConsentPurposeKey": "sint",
      "ConsentPurposeName": "Hegmann, D'Amore and Gusikowski",
      "ConsentSourceId": 11,
      "ConsentSourceKey": "quas",
      "ConsentSourceName": "Ritchie-Zboncak",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 829
        }
      }
    }
  ],
  "BounceEmails": [
    "giovanna.maggio@hintz.ca",
    "cheyanne@padberg.name"
  ],
  "ActiveStatusMonitorId": 772,
  "CreatedByFormId": 77,
  "UserDefinedFields": {
    "SuperOffice:1": "1068286238",
    "SuperOffice:2": "1468298059"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "eligendi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 673
    }
  }
}
```