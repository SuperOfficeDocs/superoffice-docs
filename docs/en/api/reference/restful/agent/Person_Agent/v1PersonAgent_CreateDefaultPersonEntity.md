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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
  "PersonId": 702,
  "Firstname": "Richard",
  "MiddleName": "Olson, Powlowski and Boyle",
  "Lastname": "Herzog",
  "Mrmrs": "aut",
  "Title": "ab",
  "UpdatedDate": "2016-07-25T04:22:27.1122473+02:00",
  "CreatedDate": "2011-09-30T04:22:27.1122473+02:00",
  "BirthDate": "2022-06-06T04:22:27.1122473+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolor",
      "StrippedValue": "laudantium",
      "Description": "Expanded transitional architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 20
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "laudantium",
      "Description": "Expanded transitional architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 20
        }
      }
    }
  ],
  "Description": "Multi-tiered solution-oriented analyzer",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "eius",
      "StrippedValue": "magnam",
      "Description": "Future-proofed mission-critical moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "magnam",
      "Description": "Future-proofed mission-critical moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ab",
      "StrippedValue": "quas",
      "Description": "Front-line optimizing strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 239
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "quas",
      "Description": "Front-line optimizing strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 239
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "velit",
      "StrippedValue": "consectetur",
      "Description": "Persistent incremental complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "consectetur",
      "Description": "Persistent incremental complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "nesciunt",
      "Description": "Grass-roots system-worthy standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "nesciunt",
      "Description": "Grass-roots system-worthy standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "assumenda",
      "StrippedValue": "fugiat",
      "Description": "Ameliorated background portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "fugiat",
      "Description": "Ameliorated background portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
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
      "Id": 300,
      "Name": "Hoppe-Morissette",
      "ToolTip": "Eum et ratione eaque asperiores modi commodi.",
      "Deleted": true,
      "Rank": 720,
      "Type": "voluptas",
      "ColorBlock": 799,
      "IconHint": "eos",
      "Selected": true,
      "LastChanged": "2002-03-16T04:22:27.1122473+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "facere",
      "Hidden": false,
      "FullName": "Novella Stehr",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 15
        }
      }
    }
  ],
  "PersonNumber": "462986",
  "FullName": "Leo Rowe Jr.",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "odio",
      "Description": "Progressive clear-thinking initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 350
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "odio",
      "Description": "Progressive clear-thinking initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 350
        }
      }
    }
  ],
  "FormalName": "Wiza Inc and Sons",
  "Address": null,
  "Post3": "aut",
  "Post2": "est",
  "Post1": "ducimus",
  "Kanalname": "provident",
  "Kanafname": "fugit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "earum",
  "ActiveInterests": 931,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 66,
  "DbiKey": "quis",
  "DbiLastModified": "2021-06-14T04:22:27.1122473+02:00",
  "DbiLastSyncronized": "2012-02-20T04:22:27.1122473+01:00",
  "SentInfo": 894,
  "ShowContactTickets": 760,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "veniam",
      "StrippedValue": "voluptatibus",
      "Description": "User-centric discrete middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 945
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "voluptatibus",
      "Description": "User-centric discrete middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 945
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "iste",
      "Description": "Multi-channelled encompassing capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 922
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "iste",
      "Description": "Multi-channelled encompassing capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 922
        }
      }
    }
  ],
  "Source": 6,
  "ActiveErpLinks": 233,
  "ShipmentTypes": [
    {
      "Id": 676,
      "Name": "Davis Group",
      "ToolTip": "Vel voluptas.",
      "Deleted": false,
      "Rank": 887,
      "Type": "labore",
      "ColorBlock": 692,
      "IconHint": "architecto",
      "Selected": false,
      "LastChanged": "2003-09-24T04:22:27.1122473+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "mollitia",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Silas Schinner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 135,
      "Comment": "rerum",
      "Registered": "1997-04-05T04:22:27.1122473+02:00",
      "RegisteredAssociateId": 493,
      "Updated": "2001-09-07T04:22:27.1122473+02:00",
      "UpdatedAssociateId": 821,
      "LegalBaseId": 569,
      "LegalBaseKey": "eaque",
      "LegalBaseName": "Howe Inc and Sons",
      "ConsentPurposeId": 442,
      "ConsentPurposeKey": "beatae",
      "ConsentPurposeName": "Zieme-Pfeffer",
      "ConsentSourceId": 487,
      "ConsentSourceKey": "sed",
      "ConsentSourceName": "Beer-Schaden",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 210
        }
      }
    }
  ],
  "BounceEmails": [
    "polly.pouros@luettgenupton.com",
    "tamara@lind.info"
  ],
  "ActiveStatusMonitorId": 223,
  "CreatedByFormId": 437,
  "UserDefinedFields": {
    "SuperOffice:1": "Darian Ziemann Jr.",
    "SuperOffice:2": "Dr. Ryleigh Turcotte Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "a",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "quasi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 675
    }
  }
}
```