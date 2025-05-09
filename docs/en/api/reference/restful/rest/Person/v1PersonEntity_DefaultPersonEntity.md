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
Last-Modified: Fri, 21 Jun 2013 16:32:47 G6T

{
  "PersonId": 696,
  "Firstname": "Haley",
  "MiddleName": "Ledner LLC",
  "Lastname": "Mills",
  "Mrmrs": "accusantium",
  "Title": "et",
  "UpdatedDate": "2013-06-21T16:32:47.5870675+02:00",
  "CreatedDate": "1998-10-02T16:32:47.5870675+02:00",
  "BirthDate": "1998-06-25T16:32:47.5870675+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "vero",
      "StrippedValue": "quas",
      "Description": "Mandatory zero defect website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "quas",
      "Description": "Mandatory zero defect website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    }
  ],
  "Description": "Managed responsive utilisation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "enim",
      "StrippedValue": "sit",
      "Description": "Inverse human-resource local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 293
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "sit",
      "Description": "Inverse human-resource local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 293
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestias",
      "StrippedValue": "corporis",
      "Description": "Self-enabling upward-trending ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 378
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "corporis",
      "Description": "Self-enabling upward-trending ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 378
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "rem",
      "StrippedValue": "consequuntur",
      "Description": "Multi-lateral disintermediate artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "consequuntur",
      "Description": "Multi-lateral disintermediate artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ea",
      "StrippedValue": "porro",
      "Description": "Optional fault-tolerant intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 294
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "porro",
      "Description": "Optional fault-tolerant intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 294
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nobis",
      "StrippedValue": "et",
      "Description": "Inverse transitional neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "et",
      "Description": "Inverse transitional neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
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
      "Id": 583,
      "Name": "Mraz, Murphy and Miller",
      "ToolTip": "Dolore eos nam iusto aut asperiores.",
      "Deleted": false,
      "Rank": 976,
      "Type": "voluptatem",
      "ColorBlock": 652,
      "IconHint": "dolores",
      "Selected": false,
      "LastChanged": "2002-04-14T16:32:47.5870675+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "repellat",
      "Hidden": false,
      "FullName": "Lavonne Kautzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "PersonNumber": "1343783",
  "FullName": "Prof. Alivia Holden Graham",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptate",
      "StrippedValue": "ut",
      "Description": "Persistent encompassing access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 215
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "ut",
      "Description": "Persistent encompassing access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 215
        }
      }
    }
  ],
  "FormalName": "Nicolas, Daniel and Boyle",
  "Address": null,
  "Post3": "veritatis",
  "Post2": "aut",
  "Post1": "architecto",
  "Kanalname": "in",
  "Kanafname": "omnis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ipsum",
  "ActiveInterests": 759,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 676,
  "DbiKey": "minima",
  "DbiLastModified": "2019-08-16T16:32:47.5870675+02:00",
  "DbiLastSyncronized": "1999-07-15T16:32:47.5870675+02:00",
  "SentInfo": 366,
  "ShowContactTickets": 859,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "adipisci",
      "StrippedValue": "sed",
      "Description": "Robust global focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 52
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "sed",
      "Description": "Robust global focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 52
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "iusto",
      "StrippedValue": "eos",
      "Description": "Open-source value-added local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "eos",
      "Description": "Open-source value-added local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    }
  ],
  "Source": 389,
  "ActiveErpLinks": 158,
  "ShipmentTypes": [
    {
      "Id": 885,
      "Name": "Considine, Hilpert and Turcotte",
      "ToolTip": "Sit eveniet eos incidunt molestiae voluptatum.",
      "Deleted": true,
      "Rank": 426,
      "Type": "dolor",
      "ColorBlock": 352,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2013-05-15T16:32:47.5870675+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eveniet",
      "StyleHint": "odio",
      "Hidden": true,
      "FullName": "Reyes Hilll",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 75,
      "Comment": "nobis",
      "Registered": "2015-01-30T16:32:47.5870675+01:00",
      "RegisteredAssociateId": 535,
      "Updated": "1998-11-14T16:32:47.5870675+01:00",
      "UpdatedAssociateId": 510,
      "LegalBaseId": 915,
      "LegalBaseKey": "quidem",
      "LegalBaseName": "Raynor, Will and Glover",
      "ConsentPurposeId": 483,
      "ConsentPurposeKey": "veniam",
      "ConsentPurposeName": "Schimmel, Wilkinson and Kassulke",
      "ConsentSourceId": 130,
      "ConsentSourceKey": "perspiciatis",
      "ConsentSourceName": "Leffler LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 890
        }
      }
    }
  ],
  "BounceEmails": [
    "maude.baumbach@pollich.com",
    "leonora@batz.com"
  ],
  "ActiveStatusMonitorId": 684,
  "CreatedByFormId": 515,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1809276484"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "nesciunt"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 155
    }
  }
}
```