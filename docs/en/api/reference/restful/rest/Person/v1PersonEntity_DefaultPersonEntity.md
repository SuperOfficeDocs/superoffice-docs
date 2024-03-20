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
Last-Modified: Wed, 09 Feb 2005 12:19:53 G2T

{
  "PersonId": 627,
  "Firstname": "Elza",
  "MiddleName": "McCullough-Collins",
  "Lastname": "Dare",
  "Mrmrs": "est",
  "Title": "dolorem",
  "UpdatedDate": "2005-02-09T12:19:53.6179912+01:00",
  "CreatedDate": "1997-02-14T12:19:53.6179912+01:00",
  "BirthDate": "2019-03-24T12:19:53.6179912+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "nam",
      "StrippedValue": "quia",
      "Description": "Distributed national project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 974
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "quia",
      "Description": "Distributed national project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 974
        }
      }
    }
  ],
  "Description": "Advanced system-worthy intranet",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "hic",
      "StrippedValue": "eum",
      "Description": "Diverse zero administration info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 819
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "eum",
      "Description": "Diverse zero administration info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 819
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "qui",
      "Description": "Progressive client-server knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 530
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "qui",
      "Description": "Progressive client-server knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 530
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "impedit",
      "StrippedValue": "et",
      "Description": "Organic homogeneous installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 22
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "et",
      "Description": "Organic homogeneous installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 22
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "qui",
      "StrippedValue": "aut",
      "Description": "Front-line hybrid initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "aut",
      "Description": "Front-line hybrid initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "qui",
      "StrippedValue": "fugit",
      "Description": "Multi-channelled responsive capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "fugit",
      "Description": "Multi-channelled responsive capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 230
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
      "Id": 874,
      "Name": "Stoltenberg-Stehr",
      "ToolTip": "Nostrum odio occaecati repudiandae nesciunt eveniet autem facere.",
      "Deleted": false,
      "Rank": 734,
      "Type": "dicta",
      "ColorBlock": 716,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2005-05-29T12:19:53.6179912+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laudantium",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Ms. Colton Bradly Keebler PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 314
        }
      }
    }
  ],
  "PersonNumber": "874351",
  "FullName": "Emmet Ruecker",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "quibusdam",
      "StrippedValue": "voluptates",
      "Description": "Advanced impactful encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 109
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "voluptates",
      "Description": "Advanced impactful encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 109
        }
      }
    }
  ],
  "FormalName": "Parisian-Stanton",
  "Address": null,
  "Post3": "laboriosam",
  "Post2": "culpa",
  "Post1": "distinctio",
  "Kanalname": "consectetur",
  "Kanafname": "maxime",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "maxime",
  "ActiveInterests": 92,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 117,
  "DbiKey": "quas",
  "DbiLastModified": "2011-07-04T12:19:53.6179912+02:00",
  "DbiLastSyncronized": "2003-11-28T12:19:53.6179912+01:00",
  "SentInfo": 448,
  "ShowContactTickets": 102,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ut",
      "StrippedValue": "omnis",
      "Description": "Ergonomic user-facing database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 455
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "omnis",
      "Description": "Ergonomic user-facing database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 455
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Up-sized analyzing benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Up-sized analyzing benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "Source": 411,
  "ActiveErpLinks": 361,
  "ShipmentTypes": [
    {
      "Id": 983,
      "Name": "Boehm Inc and Sons",
      "ToolTip": "Odio necessitatibus quis eligendi est necessitatibus eligendi.",
      "Deleted": false,
      "Rank": 46,
      "Type": "corporis",
      "ColorBlock": 10,
      "IconHint": "voluptas",
      "Selected": true,
      "LastChanged": "2022-02-12T12:19:53.6336139+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Tamia Ortiz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 750,
      "Comment": "enim",
      "Registered": "2013-05-06T12:19:53.6336139+02:00",
      "RegisteredAssociateId": 545,
      "Updated": "2002-03-06T12:19:53.6336139+01:00",
      "UpdatedAssociateId": 795,
      "LegalBaseId": 950,
      "LegalBaseKey": "quo",
      "LegalBaseName": "Ullrich, Kihn and Friesen",
      "ConsentPurposeId": 170,
      "ConsentPurposeKey": "est",
      "ConsentPurposeName": "Brakus, Skiles and Koss",
      "ConsentSourceId": 470,
      "ConsentSourceKey": "ut",
      "ConsentSourceName": "Wilderman Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 592
        }
      }
    }
  ],
  "BounceEmails": [
    "nikko_thiel@gislason.co.uk",
    "kylie.lockman@powlowski.co.uk"
  ],
  "ActiveStatusMonitorId": 384,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Buster Haley",
    "SuperOffice:2": "Bonita Jessy Thiel III"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "quod"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "dolore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 684
    }
  }
}
```