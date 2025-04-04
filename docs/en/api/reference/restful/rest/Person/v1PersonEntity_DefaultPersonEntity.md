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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 31 Mar 2000 13:14:08 G3T

{
  "PersonId": 342,
  "Firstname": "Pete",
  "MiddleName": "Bartell Group",
  "Lastname": "Kiehn",
  "Mrmrs": "assumenda",
  "Title": "reiciendis",
  "UpdatedDate": "2000-03-31T13:14:08.789767+02:00",
  "CreatedDate": "2024-05-24T13:14:08.789767+02:00",
  "BirthDate": "2012-04-01T13:14:08.789767+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aliquam",
      "StrippedValue": "consequatur",
      "Description": "Reactive zero administration matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "consequatur",
      "Description": "Reactive zero administration matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    }
  ],
  "Description": "Inverse reciprocal hub",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "animi",
      "StrippedValue": "velit",
      "Description": "Sharable zero defect database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 844
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "velit",
      "Description": "Sharable zero defect database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 844
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nihil",
      "StrippedValue": "officiis",
      "Description": "Vision-oriented fault-tolerant infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "officiis",
      "Description": "Vision-oriented fault-tolerant infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "tempora",
      "StrippedValue": "et",
      "Description": "Cloned dedicated forecast",
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
      "Value": "tempora",
      "StrippedValue": "et",
      "Description": "Cloned dedicated forecast",
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
  "OfficePhones": [
    {
      "Value": "dolor",
      "StrippedValue": "adipisci",
      "Description": "Optional bandwidth-monitored project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "adipisci",
      "Description": "Optional bandwidth-monitored project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ex",
      "StrippedValue": "numquam",
      "Description": "Sharable explicit application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 181
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "numquam",
      "Description": "Sharable explicit application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 181
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
      "Id": 857,
      "Name": "O'Reilly, Jewess and Purdy",
      "ToolTip": "Minus molestiae dolores sed dignissimos.",
      "Deleted": false,
      "Rank": 587,
      "Type": "nihil",
      "ColorBlock": 787,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2014-11-11T13:14:08.789767+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "voluptates",
      "Hidden": false,
      "FullName": "Cathy Murray",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 366
        }
      }
    }
  ],
  "PersonNumber": "842364",
  "FullName": "Jarrett Kris IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "quas",
      "StrippedValue": "quia",
      "Description": "Persevering optimal complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "quia",
      "Description": "Persevering optimal complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    }
  ],
  "FormalName": "Stracke, Bernhard and Hane",
  "Address": null,
  "Post3": "et",
  "Post2": "temporibus",
  "Post1": "et",
  "Kanalname": "voluptas",
  "Kanafname": "veniam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ipsa",
  "ActiveInterests": 121,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 429,
  "DbiKey": "modi",
  "DbiLastModified": "2002-03-05T13:14:08.789767+01:00",
  "DbiLastSyncronized": "2016-04-23T13:14:08.789767+02:00",
  "SentInfo": 913,
  "ShowContactTickets": 66,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quod",
      "StrippedValue": "eaque",
      "Description": "Multi-lateral methodical leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 62
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "eaque",
      "Description": "Multi-lateral methodical leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 62
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nulla",
      "StrippedValue": "quia",
      "Description": "Organic stable task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 42
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "quia",
      "Description": "Organic stable task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 42
        }
      }
    }
  ],
  "Source": 134,
  "ActiveErpLinks": 963,
  "ShipmentTypes": [
    {
      "Id": 301,
      "Name": "VonRueden-Johnston",
      "ToolTip": "Voluptate asperiores consequatur in mollitia nulla laboriosam.",
      "Deleted": false,
      "Rank": 878,
      "Type": "praesentium",
      "ColorBlock": 304,
      "IconHint": "accusamus",
      "Selected": false,
      "LastChanged": "2013-12-17T13:14:08.789767+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "praesentium",
      "StyleHint": "cumque",
      "Hidden": true,
      "FullName": "Sam Hermann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 22
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 758,
      "Comment": "dolorem",
      "Registered": "2004-03-11T13:14:08.789767+01:00",
      "RegisteredAssociateId": 412,
      "Updated": "2007-08-01T13:14:08.789767+02:00",
      "UpdatedAssociateId": 660,
      "LegalBaseId": 749,
      "LegalBaseKey": "quasi",
      "LegalBaseName": "Lemke, Hauck and Spencer",
      "ConsentPurposeId": 726,
      "ConsentPurposeKey": "ea",
      "ConsentPurposeName": "Ritchie Inc and Sons",
      "ConsentSourceId": 606,
      "ConsentSourceKey": "sint",
      "ConsentSourceName": "Gerlach Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 804
        }
      }
    }
  ],
  "BounceEmails": [
    "melisa@gerholdschimmel.uk",
    "harmon_stanton@jewess.biz"
  ],
  "ActiveStatusMonitorId": 931,
  "CreatedByFormId": 279,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Zakary Elise Dibbert DDS",
    "SuperOffice:2": "Noe Mary Roberts PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "natus",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "veritatis",
    "CustomFields2": "eos"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 225
    }
  }
}
```