---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
generated: true
---

# POST Agents/Contact/AddPerson

```http
POST /api/v1/Agents/Contact/AddPerson
```

Add a person to the given contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/AddPerson?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ContactId, NewPersonEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| NewPersonEntity | PersonEntity |  |

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
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 706,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 881,
  "Firstname": "Ole",
  "MiddleName": "Kunze, Fritsch and Hansen",
  "Lastname": "Harber",
  "Mrmrs": "sed",
  "Title": "asperiores",
  "UpdatedDate": "2006-06-18T04:22:26.2778085+02:00",
  "CreatedDate": "2008-07-14T04:22:26.2778085+02:00",
  "BirthDate": "2005-04-01T04:22:26.2778085+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "repudiandae",
      "StrippedValue": "minus",
      "Description": "Balanced reciprocal array",
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
      "Value": "repudiandae",
      "StrippedValue": "minus",
      "Description": "Balanced reciprocal array",
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
  "Description": "Decentralized 4th generation moratorium",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "esse",
      "StrippedValue": "voluptatum",
      "Description": "User-friendly background toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "voluptatum",
      "Description": "User-friendly background toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "cum",
      "StrippedValue": "velit",
      "Description": "Team-oriented heuristic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "velit",
      "Description": "Team-oriented heuristic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "eos",
      "StrippedValue": "sequi",
      "Description": "Compatible grid-enabled support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 772
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "sequi",
      "Description": "Compatible grid-enabled support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 772
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "assumenda",
      "Description": "User-centric grid-enabled solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "assumenda",
      "Description": "User-centric grid-enabled solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ea",
      "StrippedValue": "impedit",
      "Description": "Assimilated fault-tolerant solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "impedit",
      "Description": "Assimilated fault-tolerant solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
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
      "Id": 511,
      "Name": "Larkin Group",
      "ToolTip": "Iste molestiae vitae omnis blanditiis facilis est perspiciatis.",
      "Deleted": true,
      "Rank": 264,
      "Type": "incidunt",
      "ColorBlock": 570,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2018-05-18T04:22:26.2934337+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "exercitationem",
      "StyleHint": "quidem",
      "Hidden": false,
      "FullName": "Mr. Lorenzo Hudson Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 458
        }
      }
    }
  ],
  "PersonNumber": "572789",
  "FullName": "Laney Gulgowski",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "beatae",
      "Description": "Switchable incremental system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 682
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "beatae",
      "Description": "Switchable incremental system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 682
        }
      }
    }
  ],
  "FormalName": "Jerde Inc and Sons",
  "Address": null,
  "Post3": "et",
  "Post2": "odio",
  "Post1": "qui",
  "Kanalname": "aut",
  "Kanafname": "rem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "soluta",
  "ActiveInterests": 874,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 312,
  "DbiKey": "impedit",
  "DbiLastModified": "2023-06-01T04:22:26.2934337+02:00",
  "DbiLastSyncronized": "2002-02-15T04:22:26.2934337+01:00",
  "SentInfo": 171,
  "ShowContactTickets": 268,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Quality-focused value-added frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 738
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Quality-focused value-added frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 738
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nulla",
      "StrippedValue": "nostrum",
      "Description": "Secured foreground algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "nostrum",
      "Description": "Secured foreground algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    }
  ],
  "Source": 823,
  "ActiveErpLinks": 173,
  "ShipmentTypes": [
    {
      "Id": 761,
      "Name": "O'Reilly LLC",
      "ToolTip": "Eos non voluptas voluptatem saepe quis.",
      "Deleted": false,
      "Rank": 37,
      "Type": "temporibus",
      "ColorBlock": 585,
      "IconHint": "necessitatibus",
      "Selected": false,
      "LastChanged": "2018-05-11T04:22:26.2934337+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "voluptate",
      "Hidden": false,
      "FullName": "Evangeline Little",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 670
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 670,
      "Comment": "ut",
      "Registered": "2001-04-15T04:22:26.2934337+02:00",
      "RegisteredAssociateId": 491,
      "Updated": "2019-05-13T04:22:26.2934337+02:00",
      "UpdatedAssociateId": 764,
      "LegalBaseId": 635,
      "LegalBaseKey": "et",
      "LegalBaseName": "Block, Pfeffer and Hilpert",
      "ConsentPurposeId": 905,
      "ConsentPurposeKey": "voluptas",
      "ConsentPurposeName": "Sporer, Turner and Maggio",
      "ConsentSourceId": 824,
      "ConsentSourceKey": "voluptatem",
      "ConsentSourceName": "Dach-Gutkowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 919
        }
      }
    }
  ],
  "BounceEmails": [
    "georgiana@schimmelfranecki.us",
    "hortense_trantow@wilkinson.info"
  ],
  "ActiveStatusMonitorId": 171,
  "CreatedByFormId": 246,
  "UserDefinedFields": {
    "SuperOffice:1": "Ibrahim Altenwerth",
    "SuperOffice:2": "Henderson Stanton III"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "sapiente",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 230
    }
  }
}
```