---
title: POST Agents/Person/CreateDefaultByContactId
uid: v1PersonAgent_CreateDefaultByContactId
generated: true
---

# POST Agents/Person/CreateDefaultByContactId

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId
```

Creates a PersonEntity with default values based on the contactId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Person/CreateDefaultByContactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 353
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 137,
  "Firstname": "Madge",
  "MiddleName": "Kemmer-Bauch",
  "Lastname": "Lebsack",
  "Mrmrs": "similique",
  "Title": "pariatur",
  "UpdatedDate": "2018-07-23T11:16:09.4753184+02:00",
  "CreatedDate": "2014-04-14T11:16:09.4753184+02:00",
  "BirthDate": "2016-07-11T11:16:09.4753184+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "et",
      "Description": "Synchronised encompassing algorithm",
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
      "Value": "sint",
      "StrippedValue": "et",
      "Description": "Synchronised encompassing algorithm",
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
  "Description": "Self-enabling stable infrastructure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "amet",
      "StrippedValue": "aut",
      "Description": "Reduced dedicated internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 693
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "aut",
      "Description": "Reduced dedicated internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 693
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "sint",
      "Description": "Cross-platform uniform toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 537
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sint",
      "Description": "Cross-platform uniform toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 537
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quia",
      "StrippedValue": "veritatis",
      "Description": "Horizontal fault-tolerant time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "veritatis",
      "Description": "Horizontal fault-tolerant time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quas",
      "StrippedValue": "velit",
      "Description": "Operative fault-tolerant core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 528
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "velit",
      "Description": "Operative fault-tolerant core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 528
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nesciunt",
      "StrippedValue": "aut",
      "Description": "Polarised solution-oriented monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 282
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "aut",
      "Description": "Polarised solution-oriented monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 282
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
      "Id": 343,
      "Name": "Beer LLC",
      "ToolTip": "Sint facere ab eveniet iste accusantium.",
      "Deleted": true,
      "Rank": 843,
      "Type": "corporis",
      "ColorBlock": 499,
      "IconHint": "repudiandae",
      "Selected": true,
      "LastChanged": "2012-09-24T11:16:09.4753184+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Emanuel Ziemann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
        }
      }
    }
  ],
  "PersonNumber": "465819",
  "FullName": "Veda Feest",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "accusamus",
      "StrippedValue": "occaecati",
      "Description": "Re-engineered discrete workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "occaecati",
      "Description": "Re-engineered discrete workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    }
  ],
  "FormalName": "Littel-Hessel",
  "Address": null,
  "Post3": "consequatur",
  "Post2": "voluptas",
  "Post1": "quasi",
  "Kanalname": "officia",
  "Kanafname": "non",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "asperiores",
  "ActiveInterests": 661,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 64,
  "DbiKey": "est",
  "DbiLastModified": "2013-06-07T11:16:09.4753184+02:00",
  "DbiLastSyncronized": "2017-07-18T11:16:09.4753184+02:00",
  "SentInfo": 61,
  "ShowContactTickets": 458,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "est",
      "StrippedValue": "harum",
      "Description": "De-engineered dedicated application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "harum",
      "Description": "De-engineered dedicated application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "aliquam",
      "Description": "Quality-focused coherent matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 307
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "aliquam",
      "Description": "Quality-focused coherent matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 307
        }
      }
    }
  ],
  "Source": 661,
  "ActiveErpLinks": 722,
  "ShipmentTypes": [
    {
      "Id": 768,
      "Name": "Huel-Shanahan",
      "ToolTip": "Iusto dolorem consequatur perferendis consequatur.",
      "Deleted": false,
      "Rank": 900,
      "Type": "et",
      "ColorBlock": 366,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2000-07-07T11:16:09.4753184+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laborum",
      "StyleHint": "optio",
      "Hidden": false,
      "FullName": "Freda Bechtelar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 688,
      "Comment": "maxime",
      "Registered": "2006-05-27T11:16:09.4753184+02:00",
      "RegisteredAssociateId": 356,
      "Updated": "2015-05-24T11:16:09.4753184+02:00",
      "UpdatedAssociateId": 779,
      "LegalBaseId": 180,
      "LegalBaseKey": "omnis",
      "LegalBaseName": "Emmerich, Kuhic and Goldner",
      "ConsentPurposeId": 296,
      "ConsentPurposeKey": "totam",
      "ConsentPurposeName": "Nienow, Braun and Greenholt",
      "ConsentSourceId": 486,
      "ConsentSourceKey": "dolorem",
      "ConsentSourceName": "Ernser LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 898
        }
      }
    }
  ],
  "BounceEmails": [
    "clyde@powlowskitorp.biz",
    "henry@wintheiser.com"
  ],
  "ActiveStatusMonitorId": 824,
  "UserDefinedFields": {
    "SuperOffice:1": "100651097",
    "SuperOffice:2": "Ike Kuphal"
  },
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "eius",
    "CustomFields2": "necessitatibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 177
    }
  }
}
```