---
title: POST Agents/Person/CreateDefaultPersonEntity
uid: v1PersonAgent_CreateDefaultPersonEntity
generated: true
content_type: reference
---

# POST Agents/Person/CreateDefaultPersonEntity

```http
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
```

Loading default values into a new PersonEntity.








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
  "PersonId": 989,
  "Firstname": "Kelvin",
  "MiddleName": "Dibbert Inc and Sons",
  "Lastname": "Stracke",
  "Mrmrs": "maxime",
  "Title": "blanditiis",
  "UpdatedDate": "2022-03-27T11:24:48.2813999+02:00",
  "CreatedDate": "2008-07-10T11:24:48.2813999+02:00",
  "BirthDate": "2025-05-27T11:24:48.2813999+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "praesentium",
      "Description": "User-centric encompassing parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "praesentium",
      "Description": "User-centric encompassing parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "Description": "Multi-layered zero administration open architecture",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "eum",
      "StrippedValue": "qui",
      "Description": "Persistent dynamic hierarchy",
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
      "Value": "eum",
      "StrippedValue": "qui",
      "Description": "Persistent dynamic hierarchy",
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
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "eius",
      "Description": "Reverse-engineered transitional project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 398
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "eius",
      "Description": "Reverse-engineered transitional project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 398
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sit",
      "StrippedValue": "hic",
      "Description": "Extended well-modulated circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 61
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "hic",
      "Description": "Extended well-modulated circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 61
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "quis",
      "Description": "Mandatory hybrid challenge",
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
      "Value": "consequatur",
      "StrippedValue": "quis",
      "Description": "Mandatory hybrid challenge",
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
  "OtherPhones": [
    {
      "Value": "aut",
      "StrippedValue": "rerum",
      "Description": "Multi-layered maximized framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 189
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "rerum",
      "Description": "Multi-layered maximized framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 189
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
      "Id": 189,
      "Name": "Erdman-Parisian",
      "ToolTip": "Nostrum et magnam.",
      "Deleted": false,
      "Rank": 777,
      "Type": "voluptatem",
      "ColorBlock": 396,
      "IconHint": "vel",
      "Selected": true,
      "LastChanged": "2014-01-28T11:24:48.2813999+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Dorothea Pfeffer I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    }
  ],
  "PersonNumber": "1429969",
  "FullName": "Marina Legros",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "voluptate",
      "Description": "Object-based incremental groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "voluptate",
      "Description": "Object-based incremental groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    }
  ],
  "FormalName": "Jacobs, Champlin and Gusikowski",
  "Address": null,
  "Post3": "magni",
  "Post2": "qui",
  "Post1": "sint",
  "Kanalname": "praesentium",
  "Kanafname": "non",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "libero",
  "ActiveInterests": 260,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 478,
  "DbiKey": "vel",
  "DbiLastModified": "2007-11-30T11:24:48.2813999+01:00",
  "DbiLastSyncronized": "2016-06-02T11:24:48.2813999+02:00",
  "SentInfo": 723,
  "ShowContactTickets": 960,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vitae",
      "StrippedValue": "atque",
      "Description": "Profound 24/7 protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 766
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "atque",
      "Description": "Profound 24/7 protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 766
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Future-proofed explicit secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 878
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Future-proofed explicit secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 878
        }
      }
    }
  ],
  "Source": 348,
  "ActiveErpLinks": 817,
  "ShipmentTypes": [
    {
      "Id": 679,
      "Name": "Bartell, Bernhard and Stiedemann",
      "ToolTip": "Corrupti quaerat rerum dolorem ipsa fugit deleniti.",
      "Deleted": false,
      "Rank": 859,
      "Type": "id",
      "ColorBlock": 167,
      "IconHint": "quibusdam",
      "Selected": true,
      "LastChanged": "2000-08-09T11:24:48.2813999+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "adipisci",
      "Hidden": true,
      "FullName": "Mrs. Jalon Beer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 9
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 308,
      "Comment": "enim",
      "Registered": "2016-01-27T11:24:48.2813999+01:00",
      "RegisteredAssociateId": 31,
      "Updated": "1999-06-23T11:24:48.2813999+02:00",
      "UpdatedAssociateId": 932,
      "LegalBaseId": 293,
      "LegalBaseKey": "soluta",
      "LegalBaseName": "Hintz, Johnson and Reynolds",
      "ConsentPurposeId": 548,
      "ConsentPurposeKey": "reprehenderit",
      "ConsentPurposeName": "Mosciski, Kunze and Kuvalis",
      "ConsentSourceId": 514,
      "ConsentSourceKey": "perferendis",
      "ConsentSourceName": "Roberts, Zulauf and Raynor",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 831
        }
      }
    }
  ],
  "BounceEmails": [
    "granville@murazikbrown.ca",
    "audra@lakin.info"
  ],
  "ActiveStatusMonitorId": 763,
  "CreatedByFormId": 485,
  "UtmParameters": null,
  "LeadstatusId": 718,
  "UserDefinedFields": {
    "SuperOffice:1": "2119377460",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "adipisci"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 157
    }
  }
}
```