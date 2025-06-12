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
Last-Modified: Sun, 21 Oct 2012 17:54:08 G10T

{
  "PersonId": 650,
  "Firstname": "Roscoe",
  "MiddleName": "Harris LLC",
  "Lastname": "Fay",
  "Mrmrs": "sunt",
  "Title": "porro",
  "UpdatedDate": "2012-10-21T17:54:08.2730803+02:00",
  "CreatedDate": "2012-05-11T17:54:08.2730803+02:00",
  "BirthDate": "2003-08-07T17:54:08.2730803+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "animi",
      "Description": "Object-based user-facing hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 71
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "animi",
      "Description": "Object-based user-facing hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 71
        }
      }
    }
  ],
  "Description": "Business-focused systemic interface",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "repellat",
      "StrippedValue": "ea",
      "Description": "Virtual needs-based task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 565
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "ea",
      "Description": "Virtual needs-based task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 565
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "autem",
      "StrippedValue": "est",
      "Description": "Expanded intermediate encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "est",
      "Description": "Expanded intermediate encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sit",
      "StrippedValue": "explicabo",
      "Description": "Vision-oriented context-sensitive local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 609
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "explicabo",
      "Description": "Vision-oriented context-sensitive local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 609
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "nesciunt",
      "StrippedValue": "aut",
      "Description": "Team-oriented upward-trending middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 307
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "aut",
      "Description": "Team-oriented upward-trending middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 307
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "iste",
      "Description": "Multi-channelled human-resource moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "iste",
      "Description": "Multi-channelled human-resource moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
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
      "Id": 147,
      "Name": "King LLC",
      "ToolTip": "Eveniet sit.",
      "Deleted": false,
      "Rank": 200,
      "Type": "adipisci",
      "ColorBlock": 776,
      "IconHint": "explicabo",
      "Selected": false,
      "LastChanged": "2015-01-14T17:54:08.2730803+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "pariatur",
      "Hidden": true,
      "FullName": "Lilliana Satterfield",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    }
  ],
  "PersonNumber": "534638",
  "FullName": "Jay Blick",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "ut",
      "Description": "Switchable static projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 881
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "ut",
      "Description": "Switchable static projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 881
        }
      }
    }
  ],
  "FormalName": "Abshire Group",
  "Address": null,
  "Post3": "commodi",
  "Post2": "molestiae",
  "Post1": "laudantium",
  "Kanalname": "quidem",
  "Kanafname": "est",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dolor",
  "ActiveInterests": 30,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 201,
  "DbiKey": "consectetur",
  "DbiLastModified": "2002-10-21T17:54:08.2730803+02:00",
  "DbiLastSyncronized": "1999-09-04T17:54:08.2730803+02:00",
  "SentInfo": 188,
  "ShowContactTickets": 240,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nobis",
      "StrippedValue": "sit",
      "Description": "Devolved clear-thinking budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "sit",
      "Description": "Devolved clear-thinking budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "velit",
      "StrippedValue": "omnis",
      "Description": "Phased client-driven migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 264
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "omnis",
      "Description": "Phased client-driven migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 264
        }
      }
    }
  ],
  "Source": 885,
  "ActiveErpLinks": 499,
  "ShipmentTypes": [
    {
      "Id": 993,
      "Name": "Torp Inc and Sons",
      "ToolTip": "Omnis ipsa et rerum consequuntur id dolore dolores.",
      "Deleted": true,
      "Rank": 685,
      "Type": "et",
      "ColorBlock": 894,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2017-05-20T17:54:08.2730803+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "molestiae",
      "Hidden": false,
      "FullName": "Dr. Autumn Jada Parker PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 227
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 759,
      "Comment": "maiores",
      "Registered": "2014-11-10T17:54:08.2730803+01:00",
      "RegisteredAssociateId": 291,
      "Updated": "2005-03-03T17:54:08.2730803+01:00",
      "UpdatedAssociateId": 48,
      "LegalBaseId": 511,
      "LegalBaseKey": "corporis",
      "LegalBaseName": "O'Keefe Inc and Sons",
      "ConsentPurposeId": 222,
      "ConsentPurposeKey": "quos",
      "ConsentPurposeName": "Gislason, Jenkins and Rau",
      "ConsentSourceId": 574,
      "ConsentSourceKey": "cum",
      "ConsentSourceName": "Rau Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    }
  ],
  "BounceEmails": [
    "felton@zulauf.us",
    "madilyn_cartwright@johnson.ca"
  ],
  "ActiveStatusMonitorId": 624,
  "CreatedByFormId": 278,
  "UserDefinedFields": {
    "SuperOffice:1": "Elsa Hills",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "quidem"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "veritatis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 707
    }
  }
}
```