---
title: POST Agents/Person/GetMyPerson
uid: v1PersonAgent_GetMyPerson
generated: true
---

# POST Agents/Person/GetMyPerson

```http
POST /api/v1/Agents/Person/GetMyPerson
```

Gets the person info belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetMyPerson?$select=name,department,category/id
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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 319,
  "Firstname": "Malvina",
  "MiddleName": "Predovic, Friesen and D'Amore",
  "Lastname": "Ankunding",
  "Mrmrs": "officia",
  "Title": "omnis",
  "UpdatedDate": "2021-06-25T12:19:45.6640503+02:00",
  "CreatedDate": "2001-09-10T12:19:45.6640503+02:00",
  "BirthDate": "2001-06-29T12:19:45.6640503+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quidem",
      "StrippedValue": "consequatur",
      "Description": "Automated local instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 98
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "consequatur",
      "Description": "Automated local instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 98
        }
      }
    }
  ],
  "Description": "Optimized attitude-oriented installation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "amet",
      "StrippedValue": "sit",
      "Description": "Grass-roots bandwidth-monitored array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "sit",
      "Description": "Grass-roots bandwidth-monitored array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "voluptatum",
      "Description": "Triple-buffered next generation conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 752
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "voluptatum",
      "Description": "Triple-buffered next generation conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 752
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "numquam",
      "Description": "Up-sized system-worthy support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 902
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "numquam",
      "Description": "Up-sized system-worthy support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 902
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dignissimos",
      "StrippedValue": "iste",
      "Description": "Balanced directional neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 454
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "iste",
      "Description": "Balanced directional neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 454
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quis",
      "StrippedValue": "ut",
      "Description": "Business-focused context-sensitive structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 197
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "ut",
      "Description": "Business-focused context-sensitive structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 197
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
      "Id": 18,
      "Name": "Sipes, Stamm and Ankunding",
      "ToolTip": "Voluptatem voluptatibus autem omnis nihil similique.",
      "Deleted": true,
      "Rank": 303,
      "Type": "saepe",
      "ColorBlock": 707,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "2020-01-25T12:19:45.6640503+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "iusto",
      "Hidden": false,
      "FullName": "Mrs. Monique Reichert",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 949
        }
      }
    }
  ],
  "PersonNumber": "394293",
  "FullName": "Tyrel Vandervort",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "quasi",
      "Description": "Re-engineered static algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quasi",
      "Description": "Re-engineered static algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "FormalName": "Schaden, Adams and Champlin",
  "Address": null,
  "Post3": "sed",
  "Post2": "hic",
  "Post1": "aut",
  "Kanalname": "quisquam",
  "Kanafname": "voluptatem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "assumenda",
  "ActiveInterests": 882,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 857,
  "DbiKey": "laborum",
  "DbiLastModified": "2013-01-10T12:19:45.6796709+01:00",
  "DbiLastSyncronized": "1998-10-16T12:19:45.6796709+02:00",
  "SentInfo": 192,
  "ShowContactTickets": 456,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "officiis",
      "StrippedValue": "qui",
      "Description": "Digitized exuding local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 240
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "qui",
      "Description": "Digitized exuding local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 240
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "consequuntur",
      "StrippedValue": "est",
      "Description": "Team-oriented systematic archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "est",
      "Description": "Team-oriented systematic archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    }
  ],
  "Source": 462,
  "ActiveErpLinks": 61,
  "ShipmentTypes": [
    {
      "Id": 386,
      "Name": "Prohaska, Kreiger and Considine",
      "ToolTip": "Illo qui id quod rerum minima.",
      "Deleted": true,
      "Rank": 852,
      "Type": "vero",
      "ColorBlock": 545,
      "IconHint": "distinctio",
      "Selected": true,
      "LastChanged": "2006-06-07T12:19:45.6796709+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "nemo",
      "Hidden": false,
      "FullName": "Therese Aufderhar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 640,
      "Comment": "consequuntur",
      "Registered": "2010-08-07T12:19:45.6796709+02:00",
      "RegisteredAssociateId": 138,
      "Updated": "2024-02-18T12:19:45.6796709+01:00",
      "UpdatedAssociateId": 609,
      "LegalBaseId": 968,
      "LegalBaseKey": "occaecati",
      "LegalBaseName": "Stiedemann-Ferry",
      "ConsentPurposeId": 709,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Heathcote, Kihn and Johns",
      "ConsentSourceId": 675,
      "ConsentSourceKey": "nulla",
      "ConsentSourceName": "Champlin, Nienow and Durgan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 476
        }
      }
    }
  ],
  "BounceEmails": [
    "shea.moen@dare.uk",
    "laverna@gusikowski.info"
  ],
  "ActiveStatusMonitorId": 969,
  "UserDefinedFields": {
    "SuperOffice:1": "156055289",
    "SuperOffice:2": "2066126395"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "necessitatibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 572
    }
  }
}
```