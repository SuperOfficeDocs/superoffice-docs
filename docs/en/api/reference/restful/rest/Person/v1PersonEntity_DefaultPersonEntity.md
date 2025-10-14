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
Last-Modified: Thu, 23 Mar 2000 03:40:55 G3T

{
  "PersonId": 501,
  "Firstname": "Pedro",
  "MiddleName": "Sawayn LLC",
  "Lastname": "Botsford",
  "Mrmrs": "est",
  "Title": "qui",
  "UpdatedDate": "2000-03-23T03:40:55.804273+01:00",
  "CreatedDate": "2014-04-06T03:40:55.804273+02:00",
  "BirthDate": "2001-01-20T03:40:55.804273+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "praesentium",
      "StrippedValue": "eum",
      "Description": "Team-oriented neutral core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "eum",
      "Description": "Team-oriented neutral core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    }
  ],
  "Description": "Exclusive demand-driven infrastructure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "alias",
      "StrippedValue": "dolore",
      "Description": "Function-based national access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "dolore",
      "Description": "Function-based national access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempore",
      "StrippedValue": "aut",
      "Description": "Expanded needs-based algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 713
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "aut",
      "Description": "Expanded needs-based algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 713
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Multi-layered interactive extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 641
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Multi-layered interactive extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 641
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "animi",
      "Description": "Digitized responsive instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "animi",
      "Description": "Digitized responsive instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quis",
      "StrippedValue": "quia",
      "Description": "Programmable bottom-line extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 385
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "quia",
      "Description": "Programmable bottom-line extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 385
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
      "Id": 175,
      "Name": "Kuhn-Price",
      "ToolTip": "Vel quia vero quo blanditiis laboriosam fuga excepturi.",
      "Deleted": true,
      "Rank": 501,
      "Type": "ut",
      "ColorBlock": 975,
      "IconHint": "incidunt",
      "Selected": true,
      "LastChanged": "2017-03-06T03:40:55.804273+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorum",
      "StyleHint": "dolore",
      "Hidden": false,
      "FullName": "Verna Jenkins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 888
        }
      }
    }
  ],
  "PersonNumber": "680918",
  "FullName": "Mr. Antone Ledner II",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "eligendi",
      "StrippedValue": "necessitatibus",
      "Description": "Networked multimedia encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 845
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "necessitatibus",
      "Description": "Networked multimedia encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 845
        }
      }
    }
  ],
  "FormalName": "Hahn Inc and Sons",
  "Address": null,
  "Post3": "fuga",
  "Post2": "dolorem",
  "Post1": "est",
  "Kanalname": "aspernatur",
  "Kanafname": "porro",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptas",
  "ActiveInterests": 502,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 5,
  "DbiKey": "eos",
  "DbiLastModified": "1998-11-02T03:40:55.8198992+01:00",
  "DbiLastSyncronized": "2001-10-21T03:40:55.8198992+02:00",
  "SentInfo": 643,
  "ShowContactTickets": 312,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quibusdam",
      "StrippedValue": "sed",
      "Description": "Business-focused upward-trending knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 844
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "sed",
      "Description": "Business-focused upward-trending knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 844
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nobis",
      "StrippedValue": "consequuntur",
      "Description": "Re-engineered bifurcated hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 612
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "consequuntur",
      "Description": "Re-engineered bifurcated hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 612
        }
      }
    }
  ],
  "Source": 607,
  "ActiveErpLinks": 775,
  "ShipmentTypes": [
    {
      "Id": 408,
      "Name": "Conn, Ferry and Barrows",
      "ToolTip": "Sed reiciendis ut saepe magnam ut doloremque placeat.",
      "Deleted": false,
      "Rank": 521,
      "Type": "repellat",
      "ColorBlock": 536,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2025-09-11T03:40:55.8198992+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "explicabo",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Mr. Arielle Devyn Metz PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 938
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 360,
      "Comment": "modi",
      "Registered": "1999-01-30T03:40:55.8198992+01:00",
      "RegisteredAssociateId": 464,
      "Updated": "2017-12-18T03:40:55.8198992+01:00",
      "UpdatedAssociateId": 139,
      "LegalBaseId": 893,
      "LegalBaseKey": "eos",
      "LegalBaseName": "Windler, Aufderhar and McDermott",
      "ConsentPurposeId": 297,
      "ConsentPurposeKey": "corrupti",
      "ConsentPurposeName": "Weber LLC",
      "ConsentSourceId": 941,
      "ConsentSourceKey": "laboriosam",
      "ConsentSourceName": "Davis, O'Conner and Schmeler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    }
  ],
  "BounceEmails": [
    "lambert.barrows@gorczany.uk",
    "melvin.beier@rippinmetz.co.uk"
  ],
  "ActiveStatusMonitorId": 495,
  "CreatedByFormId": 617,
  "UtmParameters": null,
  "LeadstatusId": 686,
  "UserDefinedFields": {
    "SuperOffice:1": "634349450",
    "SuperOffice:2": "Mr. Tate Dalton Legros"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "nam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 869
    }
  }
}
```