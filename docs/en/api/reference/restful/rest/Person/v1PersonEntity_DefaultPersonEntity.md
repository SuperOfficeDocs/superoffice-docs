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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 20 Dec 2009 03:41:58 G12T

{
  "PersonId": 515,
  "Firstname": "Keyshawn",
  "MiddleName": "Koss, Kerluke and Price",
  "Lastname": "Haag",
  "Mrmrs": "nam",
  "Title": "natus",
  "UpdatedDate": "2009-12-20T03:41:58.7773879+01:00",
  "CreatedDate": "2011-03-04T03:41:58.7773879+01:00",
  "BirthDate": "2008-07-08T03:41:58.7773879+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "laudantium",
      "StrippedValue": "ea",
      "Description": "Customer-focused composite throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "ea",
      "Description": "Customer-focused composite throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "Description": "Automated global utilisation",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "sed",
      "StrippedValue": "quo",
      "Description": "Focused interactive forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 122
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "quo",
      "Description": "Focused interactive forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 122
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "delectus",
      "StrippedValue": "ex",
      "Description": "Function-based 4th generation instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 392
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "ex",
      "Description": "Function-based 4th generation instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 392
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "facilis",
      "StrippedValue": "reiciendis",
      "Description": "Cross-group eco-centric support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 753
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "reiciendis",
      "Description": "Cross-group eco-centric support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 753
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "omnis",
      "Description": "Assimilated multimedia methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "omnis",
      "Description": "Assimilated multimedia methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "vero",
      "Description": "User-centric discrete contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 220
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "vero",
      "Description": "User-centric discrete contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 220
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
      "Id": 206,
      "Name": "Strosin-Eichmann",
      "ToolTip": "Vero commodi autem omnis.",
      "Deleted": false,
      "Rank": 908,
      "Type": "fuga",
      "ColorBlock": 69,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2015-01-25T03:41:58.7773879+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "animi",
      "StyleHint": "eum",
      "Hidden": false,
      "FullName": "Kaitlyn Muller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 968
        }
      }
    }
  ],
  "PersonNumber": "1700320",
  "FullName": "Ernestina Trantow",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "distinctio",
      "Description": "Configurable bifurcated projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 232
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "distinctio",
      "Description": "Configurable bifurcated projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 232
        }
      }
    }
  ],
  "FormalName": "Marvin, Swaniawski and Parker",
  "Address": null,
  "Post3": "laudantium",
  "Post2": "explicabo",
  "Post1": "voluptas",
  "Kanalname": "eaque",
  "Kanafname": "hic",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sed",
  "ActiveInterests": 871,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 477,
  "DbiKey": "ratione",
  "DbiLastModified": "2010-05-08T03:41:58.7773879+02:00",
  "DbiLastSyncronized": "2021-05-15T03:41:58.7773879+02:00",
  "SentInfo": 58,
  "ShowContactTickets": 608,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "at",
      "StrippedValue": "cupiditate",
      "Description": "Up-sized stable knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "cupiditate",
      "Description": "Up-sized stable knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "recusandae",
      "Description": "Exclusive uniform hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "recusandae",
      "Description": "Exclusive uniform hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    }
  ],
  "Source": 836,
  "ActiveErpLinks": 909,
  "ShipmentTypes": [
    {
      "Id": 245,
      "Name": "Lindgren Inc and Sons",
      "ToolTip": "Architecto aut sunt enim dolores.",
      "Deleted": false,
      "Rank": 373,
      "Type": "quibusdam",
      "ColorBlock": 333,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2025-05-29T03:41:58.7773879+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maxime",
      "StyleHint": "consequuntur",
      "Hidden": false,
      "FullName": "Mrs. Elsa Bernhard",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 644
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 757,
      "Comment": "et",
      "Registered": "2002-04-27T03:41:58.7773879+02:00",
      "RegisteredAssociateId": 497,
      "Updated": "2002-07-06T03:41:58.7773879+02:00",
      "UpdatedAssociateId": 969,
      "LegalBaseId": 969,
      "LegalBaseKey": "nihil",
      "LegalBaseName": "Legros, Dickinson and Marks",
      "ConsentPurposeId": 512,
      "ConsentPurposeKey": "debitis",
      "ConsentPurposeName": "Pfannerstill-Ziemann",
      "ConsentSourceId": 657,
      "ConsentSourceKey": "molestias",
      "ConsentSourceName": "Braun Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 797
        }
      }
    }
  ],
  "BounceEmails": [
    "delaney_becker@ruecker.ca",
    "betsy.kling@bernhard.com"
  ],
  "ActiveStatusMonitorId": 421,
  "CreatedByFormId": 153,
  "UtmParameters": null,
  "LeadstatusId": 544,
  "UserDefinedFields": {
    "SuperOffice:1": "Madaline Hessel",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "fugiat"
  },
  "CustomFields": {
    "CustomFields1": "cumque",
    "CustomFields2": "labore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 528
    }
  }
}
```