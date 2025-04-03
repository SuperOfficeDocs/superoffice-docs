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
Last-Modified: Sun, 29 Jan 2012 14:28:26 G1T

{
  "PersonId": 289,
  "Firstname": "Jerrod",
  "MiddleName": "Durgan Inc and Sons",
  "Lastname": "Altenwerth",
  "Mrmrs": "perspiciatis",
  "Title": "harum",
  "UpdatedDate": "2012-01-29T14:28:26.961443+01:00",
  "CreatedDate": "1999-10-22T14:28:26.961443+02:00",
  "BirthDate": "2022-01-17T14:28:26.961443+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "veritatis",
      "Description": "Customizable reciprocal structure",
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
      "Value": "quia",
      "StrippedValue": "veritatis",
      "Description": "Customizable reciprocal structure",
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
  "Description": "Implemented foreground algorithm",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "corporis",
      "StrippedValue": "voluptatem",
      "Description": "Proactive clear-thinking encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 75
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "voluptatem",
      "Description": "Proactive clear-thinking encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 75
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iusto",
      "StrippedValue": "eos",
      "Description": "Intuitive encompassing local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "eos",
      "Description": "Intuitive encompassing local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "aperiam",
      "StrippedValue": "non",
      "Description": "Quality-focused bifurcated neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "non",
      "Description": "Quality-focused bifurcated neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "consectetur",
      "Description": "Synchronised system-worthy initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "consectetur",
      "Description": "Synchronised system-worthy initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "sed",
      "StrippedValue": "dolorum",
      "Description": "Compatible heuristic superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "dolorum",
      "Description": "Compatible heuristic superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
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
      "Id": 779,
      "Name": "Schinner Group",
      "ToolTip": "Voluptatibus consectetur pariatur.",
      "Deleted": true,
      "Rank": 539,
      "Type": "libero",
      "ColorBlock": 203,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2007-05-05T14:28:26.961443+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "animi",
      "StyleHint": "neque",
      "Hidden": false,
      "FullName": "Miss Jocelyn Elsie Morissette",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 494
        }
      }
    }
  ],
  "PersonNumber": "957980",
  "FullName": "Marcus Johns",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Multi-channelled local collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Multi-channelled local collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    }
  ],
  "FormalName": "O'Reilly-Hodkiewicz",
  "Address": null,
  "Post3": "ut",
  "Post2": "id",
  "Post1": "voluptatem",
  "Kanalname": "deserunt",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "omnis",
  "ActiveInterests": 34,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 413,
  "DbiKey": "hic",
  "DbiLastModified": "2010-09-15T14:28:26.961443+02:00",
  "DbiLastSyncronized": "2020-05-15T14:28:26.961443+02:00",
  "SentInfo": 671,
  "ShowContactTickets": 24,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "corrupti",
      "StrippedValue": "quisquam",
      "Description": "Polarised stable firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 53
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "quisquam",
      "Description": "Polarised stable firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 53
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quo",
      "StrippedValue": "fugit",
      "Description": "Networked upward-trending local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "fugit",
      "Description": "Networked upward-trending local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    }
  ],
  "Source": 276,
  "ActiveErpLinks": 805,
  "ShipmentTypes": [
    {
      "Id": 568,
      "Name": "McGlynn-Olson",
      "ToolTip": "Excepturi consequuntur.",
      "Deleted": true,
      "Rank": 622,
      "Type": "omnis",
      "ColorBlock": 538,
      "IconHint": "recusandae",
      "Selected": true,
      "LastChanged": "2007-07-05T14:28:26.961443+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "animi",
      "Hidden": false,
      "FullName": "Junius Weber",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 155
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 293,
      "Comment": "sequi",
      "Registered": "2009-02-19T14:28:26.961443+01:00",
      "RegisteredAssociateId": 778,
      "Updated": "1999-06-07T14:28:26.961443+02:00",
      "UpdatedAssociateId": 28,
      "LegalBaseId": 463,
      "LegalBaseKey": "est",
      "LegalBaseName": "White, Thiel and Fritsch",
      "ConsentPurposeId": 751,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Hilll Group",
      "ConsentSourceId": 24,
      "ConsentSourceKey": "sit",
      "ConsentSourceName": "Kshlerin, White and Stracke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 406
        }
      }
    }
  ],
  "BounceEmails": [
    "gerda@fay.com",
    "dayna.treutel@oconnellkiehn.us"
  ],
  "ActiveStatusMonitorId": 771,
  "CreatedByFormId": 809,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Rahul Raphael Dietrich I",
    "SuperOffice:2": "Ms. Oceane Letitia Trantow"
  },
  "ExtraFields": {
    "ExtraFields1": "commodi",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "ipsam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 895
    }
  }
}
```