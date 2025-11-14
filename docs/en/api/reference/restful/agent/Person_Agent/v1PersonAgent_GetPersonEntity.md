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


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The identifier of the PersonEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=614
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 232,
  "Firstname": "Esteban",
  "MiddleName": "Shanahan Inc and Sons",
  "Lastname": "Kreiger",
  "Mrmrs": "incidunt",
  "Title": "et",
  "UpdatedDate": "2000-10-16T02:30:47.5069516+02:00",
  "CreatedDate": "2007-02-26T02:30:47.5069516+01:00",
  "BirthDate": "2017-12-28T02:30:47.5069516+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "et",
      "Description": "Realigned reciprocal success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 328
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "et",
      "Description": "Realigned reciprocal success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 328
        }
      }
    }
  ],
  "Description": "Realigned foreground local area network",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "qui",
      "Description": "Expanded fault-tolerant alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 570
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "qui",
      "Description": "Expanded fault-tolerant alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 570
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "odit",
      "StrippedValue": "consequuntur",
      "Description": "Automated encompassing database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 966
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "consequuntur",
      "Description": "Automated encompassing database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 966
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "facere",
      "StrippedValue": "quod",
      "Description": "Networked value-added moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 783
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "quod",
      "Description": "Networked value-added moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 783
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "nesciunt",
      "Description": "Fully-configurable homogeneous approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 296
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "nesciunt",
      "Description": "Fully-configurable homogeneous approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 296
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "quo",
      "Description": "User-friendly non-volatile matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 863
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "quo",
      "Description": "User-friendly non-volatile matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 863
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
      "Id": 274,
      "Name": "Quigley, Feil and Bosco",
      "ToolTip": "Ex neque veritatis minima omnis assumenda omnis enim.",
      "Deleted": true,
      "Rank": 24,
      "Type": "quasi",
      "ColorBlock": 200,
      "IconHint": "non",
      "Selected": true,
      "LastChanged": "2013-11-17T02:30:47.5069516+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "earum",
      "Hidden": true,
      "FullName": "Monserrat Bogan PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 23
        }
      }
    }
  ],
  "PersonNumber": "1511946",
  "FullName": "Evelyn Bernier",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "animi",
      "StrippedValue": "ut",
      "Description": "Grass-roots modular process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 792
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "ut",
      "Description": "Grass-roots modular process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 792
        }
      }
    }
  ],
  "FormalName": "Altenwerth-Ebert",
  "Address": null,
  "Post3": "et",
  "Post2": "velit",
  "Post1": "totam",
  "Kanalname": "nihil",
  "Kanafname": "reprehenderit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "non",
  "ActiveInterests": 611,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 640,
  "DbiKey": "ex",
  "DbiLastModified": "2007-09-30T02:30:47.5069516+02:00",
  "DbiLastSyncronized": "2020-10-11T02:30:47.5069516+02:00",
  "SentInfo": 217,
  "ShowContactTickets": 180,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nostrum",
      "StrippedValue": "iusto",
      "Description": "Centralized tertiary superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 773
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "iusto",
      "Description": "Centralized tertiary superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 773
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "aperiam",
      "StrippedValue": "dolor",
      "Description": "Automated solution-oriented implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "dolor",
      "Description": "Automated solution-oriented implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    }
  ],
  "Source": 711,
  "ActiveErpLinks": 128,
  "ShipmentTypes": [
    {
      "Id": 37,
      "Name": "Bosco Group",
      "ToolTip": "Tempore nobis.",
      "Deleted": false,
      "Rank": 403,
      "Type": "accusamus",
      "ColorBlock": 614,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2025-10-24T02:30:47.5069516+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laborum",
      "StyleHint": "molestiae",
      "Hidden": false,
      "FullName": "Mrs. Lelah Carmella Howe III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 353
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 824,
      "Comment": "esse",
      "Registered": "2023-08-08T02:30:47.5069516+02:00",
      "RegisteredAssociateId": 799,
      "Updated": "2003-02-15T02:30:47.5069516+01:00",
      "UpdatedAssociateId": 922,
      "LegalBaseId": 924,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Metz, Schoen and Pollich",
      "ConsentPurposeId": 313,
      "ConsentPurposeKey": "dolorem",
      "ConsentPurposeName": "Jones, Adams and Deckow",
      "ConsentSourceId": 77,
      "ConsentSourceKey": "rem",
      "ConsentSourceName": "Hansen, O'Hara and Renner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 338
        }
      }
    }
  ],
  "BounceEmails": [
    "walker.keeling@blick.ca",
    "alfred_farrell@dare.uk"
  ],
  "ActiveStatusMonitorId": 655,
  "CreatedByFormId": 389,
  "UtmParameters": null,
  "LeadstatusId": 277,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Raphaelle Sid Kuhn",
    "SuperOffice:2": "Prof. Rozella Franecki PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "quas"
  },
  "CustomFields": {
    "CustomFields1": "aperiam",
    "CustomFields2": "eaque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 134
    }
  }
}
```