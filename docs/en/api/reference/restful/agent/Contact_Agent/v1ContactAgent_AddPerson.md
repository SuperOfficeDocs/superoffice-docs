---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 49,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 175,
  "Firstname": "Wilbert",
  "MiddleName": "Glover, West and Swaniawski",
  "Lastname": "Cummings",
  "Mrmrs": "aut",
  "Title": "omnis",
  "UpdatedDate": "2008-08-09T03:41:53.3088673+02:00",
  "CreatedDate": "2018-11-19T03:41:53.3088673+01:00",
  "BirthDate": "2015-12-22T03:41:53.3088673+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "tempore",
      "StrippedValue": "sequi",
      "Description": "Diverse object-oriented throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 764
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "sequi",
      "Description": "Diverse object-oriented throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 764
        }
      }
    }
  ],
  "Description": "Reactive multimedia firmware",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "assumenda",
      "StrippedValue": "ut",
      "Description": "Monitored upward-trending projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 281
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "ut",
      "Description": "Monitored upward-trending projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 281
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Reduced cohesive standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Reduced cohesive standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "in",
      "StrippedValue": "repellat",
      "Description": "Decentralized client-driven flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 71
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "repellat",
      "Description": "Decentralized client-driven flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 71
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quasi",
      "StrippedValue": "et",
      "Description": "Phased analyzing application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 305
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "et",
      "Description": "Phased analyzing application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 305
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "autem",
      "StrippedValue": "sequi",
      "Description": "Integrated context-sensitive Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 570
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "sequi",
      "Description": "Integrated context-sensitive Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 570
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
      "Id": 985,
      "Name": "Pfannerstill, Little and Johnson",
      "ToolTip": "Porro at labore ut doloremque qui nulla occaecati.",
      "Deleted": false,
      "Rank": 92,
      "Type": "ut",
      "ColorBlock": 985,
      "IconHint": "sed",
      "Selected": true,
      "LastChanged": "2001-09-09T03:41:53.3088673+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "soluta",
      "Hidden": true,
      "FullName": "Mr. Eveline Chelsea Breitenberg MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 700
        }
      }
    }
  ],
  "PersonNumber": "216317",
  "FullName": "Brock Mante Jr.",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "maxime",
      "StrippedValue": "consequatur",
      "Description": "Business-focused multi-state throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "consequatur",
      "Description": "Business-focused multi-state throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    }
  ],
  "FormalName": "Kassulke, Klocko and Torp",
  "Address": null,
  "Post3": "quasi",
  "Post2": "qui",
  "Post1": "quia",
  "Kanalname": "quas",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "maiores",
  "ActiveInterests": 295,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 275,
  "DbiKey": "et",
  "DbiLastModified": "2013-08-19T03:41:53.3088673+02:00",
  "DbiLastSyncronized": "2008-05-28T03:41:53.3088673+02:00",
  "SentInfo": 948,
  "ShowContactTickets": 341,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aut",
      "StrippedValue": "sed",
      "Description": "Organic hybrid synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 157
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "sed",
      "Description": "Organic hybrid synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 157
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "qui",
      "StrippedValue": "expedita",
      "Description": "Polarised bandwidth-monitored methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 971
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "expedita",
      "Description": "Polarised bandwidth-monitored methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 971
        }
      }
    }
  ],
  "Source": 668,
  "ActiveErpLinks": 343,
  "ShipmentTypes": [
    {
      "Id": 970,
      "Name": "Torp-Flatley",
      "ToolTip": "Omnis reprehenderit nobis eaque rerum eligendi.",
      "Deleted": true,
      "Rank": 120,
      "Type": "maiores",
      "ColorBlock": 854,
      "IconHint": "sequi",
      "Selected": false,
      "LastChanged": "2013-10-21T03:41:53.3088673+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sapiente",
      "StyleHint": "a",
      "Hidden": false,
      "FullName": "Delphia Mills",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 459
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 438,
      "Comment": "enim",
      "Registered": "2001-12-04T03:41:53.3088673+01:00",
      "RegisteredAssociateId": 338,
      "Updated": "2006-11-23T03:41:53.3088673+01:00",
      "UpdatedAssociateId": 533,
      "LegalBaseId": 17,
      "LegalBaseKey": "itaque",
      "LegalBaseName": "Lakin, Lakin and Lebsack",
      "ConsentPurposeId": 32,
      "ConsentPurposeKey": "sequi",
      "ConsentPurposeName": "Smitham, Von and Will",
      "ConsentSourceId": 615,
      "ConsentSourceKey": "non",
      "ConsentSourceName": "Ernser-Murray",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "BounceEmails": [
    "emily@pollichkemmer.info",
    "izaiah@funkwilliamson.com"
  ],
  "ActiveStatusMonitorId": 647,
  "CreatedByFormId": 69,
  "UtmParameters": null,
  "LeadstatusId": 276,
  "UserDefinedFields": {
    "SuperOffice:1": "Jamal Durgan",
    "SuperOffice:2": "Fern Joana Walter II"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "necessitatibus",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 67
    }
  }
}
```