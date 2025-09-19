---
title: POST Agents/Person/GetPersonEntity
uid: v1PersonAgent_GetPersonEntity
generated: true
content_type: reference
---

# POST Agents/Person/GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The identifier of the PersonEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=504
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 615,
  "Firstname": "Edgardo",
  "MiddleName": "Kautzer Group",
  "Lastname": "Cummerata",
  "Mrmrs": "eius",
  "Title": "dolorum",
  "UpdatedDate": "2017-09-02T03:41:53.7932225+02:00",
  "CreatedDate": "2025-01-25T03:41:53.7932225+01:00",
  "BirthDate": "2008-11-12T03:41:53.7932225+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "labore",
      "StrippedValue": "fugit",
      "Description": "Universal object-oriented capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 546
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "fugit",
      "Description": "Universal object-oriented capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 546
        }
      }
    }
  ],
  "Description": "Progressive upward-trending core",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "tempore",
      "StrippedValue": "nam",
      "Description": "Multi-layered high-level application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 5
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "nam",
      "Description": "Multi-layered high-level application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 5
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "ut",
      "Description": "Advanced neutral forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 842
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "ut",
      "Description": "Advanced neutral forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 842
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "cum",
      "StrippedValue": "quia",
      "Description": "Programmable logistical firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "quia",
      "Description": "Programmable logistical firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "placeat",
      "StrippedValue": "dolorem",
      "Description": "Future-proofed zero administration neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 865
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "dolorem",
      "Description": "Future-proofed zero administration neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 865
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "maxime",
      "StrippedValue": "praesentium",
      "Description": "Persevering homogeneous groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "praesentium",
      "Description": "Persevering homogeneous groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
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
      "Id": 66,
      "Name": "Roob-Gottlieb",
      "ToolTip": "Sint ea perferendis harum sint.",
      "Deleted": false,
      "Rank": 434,
      "Type": "quod",
      "ColorBlock": 490,
      "IconHint": "necessitatibus",
      "Selected": false,
      "LastChanged": "2015-09-05T03:41:53.7932225+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "delectus",
      "StyleHint": "illo",
      "Hidden": false,
      "FullName": "Maryse Kuphal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    }
  ],
  "PersonNumber": "579069",
  "FullName": "Guy Toy",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "autem",
      "StrippedValue": "quas",
      "Description": "Distributed content-based paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 431
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "quas",
      "Description": "Distributed content-based paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 431
        }
      }
    }
  ],
  "FormalName": "Parker Group",
  "Address": null,
  "Post3": "necessitatibus",
  "Post2": "aut",
  "Post1": "quos",
  "Kanalname": "in",
  "Kanafname": "rerum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "laudantium",
  "ActiveInterests": 923,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 209,
  "DbiKey": "quam",
  "DbiLastModified": "2013-07-06T03:41:53.7932225+02:00",
  "DbiLastSyncronized": "2010-11-17T03:41:53.7932225+01:00",
  "SentInfo": 48,
  "ShowContactTickets": 596,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "facilis",
      "Description": "Intuitive zero administration definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 533
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "facilis",
      "Description": "Intuitive zero administration definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 533
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "dolor",
      "StrippedValue": "vitae",
      "Description": "Extended mobile internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "vitae",
      "Description": "Extended mobile internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    }
  ],
  "Source": 902,
  "ActiveErpLinks": 178,
  "ShipmentTypes": [
    {
      "Id": 475,
      "Name": "Doyle, Luettgen and Cruickshank",
      "ToolTip": "Soluta rem.",
      "Deleted": false,
      "Rank": 831,
      "Type": "necessitatibus",
      "ColorBlock": 51,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2010-02-06T03:41:53.7932225+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sunt",
      "StyleHint": "laudantium",
      "Hidden": false,
      "FullName": "Mr. Gust Walter V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 241
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 441,
      "Comment": "aut",
      "Registered": "2012-02-28T03:41:53.7932225+01:00",
      "RegisteredAssociateId": 982,
      "Updated": "2006-03-10T03:41:53.7932225+01:00",
      "UpdatedAssociateId": 202,
      "LegalBaseId": 374,
      "LegalBaseKey": "quia",
      "LegalBaseName": "Rau LLC",
      "ConsentPurposeId": 921,
      "ConsentPurposeKey": "tempore",
      "ConsentPurposeName": "Watsica, Hermann and Prohaska",
      "ConsentSourceId": 509,
      "ConsentSourceKey": "dolores",
      "ConsentSourceName": "Davis Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 677
        }
      }
    }
  ],
  "BounceEmails": [
    "aiden@adamsfriesen.co.uk",
    "kaley.hermann@schowalter.us"
  ],
  "ActiveStatusMonitorId": 680,
  "CreatedByFormId": 54,
  "UtmParameters": null,
  "LeadstatusId": 557,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Bethel Hegmann PhD",
    "SuperOffice:2": "Ellie Rippin IV"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "soluta"
  },
  "CustomFields": {
    "CustomFields1": "ullam",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 357
    }
  }
}
```