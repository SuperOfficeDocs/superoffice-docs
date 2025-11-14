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
NsApiSlow threshold: 2000 ms.







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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 24 Aug 2006 02:30:52 G8T

{
  "PersonId": 930,
  "Firstname": "Terence",
  "MiddleName": "Harvey LLC",
  "Lastname": "Green",
  "Mrmrs": "neque",
  "Title": "ipsum",
  "UpdatedDate": "2006-08-24T02:30:52.6630355+02:00",
  "CreatedDate": "2019-11-28T02:30:52.6630355+01:00",
  "BirthDate": "2008-04-27T02:30:52.6630355+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "quam",
      "Description": "Networked hybrid benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 211
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "quam",
      "Description": "Networked hybrid benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 211
        }
      }
    }
  ],
  "Description": "Visionary stable definition",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dignissimos",
      "StrippedValue": "est",
      "Description": "Reverse-engineered multi-tasking algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 347
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "est",
      "Description": "Reverse-engineered multi-tasking algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 347
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nam",
      "StrippedValue": "adipisci",
      "Description": "Phased context-sensitive protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "adipisci",
      "Description": "Phased context-sensitive protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "vel",
      "Description": "Triple-buffered static software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 169
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "vel",
      "Description": "Triple-buffered static software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 169
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aliquid",
      "StrippedValue": "explicabo",
      "Description": "Versatile upward-trending task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "explicabo",
      "Description": "Versatile upward-trending task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Configurable 6th generation challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 59
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Configurable 6th generation challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 59
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
      "Id": 861,
      "Name": "Spinka, Jewess and Quigley",
      "ToolTip": "Aut fugiat consequatur qui modi id dignissimos quia.",
      "Deleted": false,
      "Rank": 714,
      "Type": "laudantium",
      "ColorBlock": 964,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2013-11-16T02:30:52.6630355+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "modi",
      "Hidden": false,
      "FullName": "Mrs. Matilda Douglas Homenick",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 990
        }
      }
    }
  ],
  "PersonNumber": "1214929",
  "FullName": "Dr. Alayna Crooks II",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "delectus",
      "StrippedValue": "incidunt",
      "Description": "Team-oriented explicit service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 433
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "incidunt",
      "Description": "Team-oriented explicit service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 433
        }
      }
    }
  ],
  "FormalName": "Steuber LLC",
  "Address": null,
  "Post3": "ab",
  "Post2": "ad",
  "Post1": "id",
  "Kanalname": "vel",
  "Kanafname": "tenetur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "labore",
  "ActiveInterests": 50,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 246,
  "DbiKey": "dicta",
  "DbiLastModified": "2020-12-12T02:30:52.6630355+01:00",
  "DbiLastSyncronized": "1999-11-29T02:30:52.6630355+01:00",
  "SentInfo": 37,
  "ShowContactTickets": 86,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "dolor",
      "StrippedValue": "nisi",
      "Description": "Switchable interactive Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 942
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "nisi",
      "Description": "Switchable interactive Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 942
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "blanditiis",
      "StrippedValue": "maxime",
      "Description": "Virtual tertiary capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 289
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "maxime",
      "Description": "Virtual tertiary capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 289
        }
      }
    }
  ],
  "Source": 492,
  "ActiveErpLinks": 15,
  "ShipmentTypes": [
    {
      "Id": 96,
      "Name": "Rice Group",
      "ToolTip": "Minus totam exercitationem.",
      "Deleted": true,
      "Rank": 834,
      "Type": "beatae",
      "ColorBlock": 898,
      "IconHint": "fugit",
      "Selected": false,
      "LastChanged": "2021-10-16T02:30:52.6630355+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "at",
      "Hidden": false,
      "FullName": "Dr. Hector Bailey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 917
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 808,
      "Comment": "ea",
      "Registered": "2009-10-27T02:30:52.6630355+01:00",
      "RegisteredAssociateId": 447,
      "Updated": "2023-02-18T02:30:52.6630355+01:00",
      "UpdatedAssociateId": 79,
      "LegalBaseId": 25,
      "LegalBaseKey": "et",
      "LegalBaseName": "Gleichner-Anderson",
      "ConsentPurposeId": 96,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Crist LLC",
      "ConsentSourceId": 415,
      "ConsentSourceKey": "ullam",
      "ConsentSourceName": "Nienow Inc and Sons",
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
  "BounceEmails": [
    "felipa_predovic@dietrich.us",
    "osvaldo_hermiston@hilpert.biz"
  ],
  "ActiveStatusMonitorId": 580,
  "CreatedByFormId": 610,
  "UtmParameters": null,
  "LeadstatusId": 862,
  "UserDefinedFields": {
    "SuperOffice:1": "Nicholas Hettinger",
    "SuperOffice:2": "Darron Aubrey Marquardt Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "vitae",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "numquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 694
    }
  }
}
```