---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
generated: true
content_type: reference
---

# POST Agents/Person/GetSalesRep

```http
POST /api/v1/Agents/Person/GetSalesRep
```

Returns the sales representative for an external user.


If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetSalesRep?$select=name,department,category/id
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

ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactName | String |  |
| PersonFirstname | String |  |
| PersonLastname | String |  |
| EmailAddress | String |  |
| PhoneNumber | String |  |

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
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Bins, McKenzie and Crist",
  "PersonFirstname": "Zena",
  "PersonLastname": "Schamberger",
  "EmailAddress": "dewayne.tillman@kessler.biz",
  "PhoneNumber": "1160629"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 85,
  "Firstname": "Omer",
  "MiddleName": "Harvey, Baumbach and O'Reilly",
  "Lastname": "Sauer",
  "Mrmrs": "odit",
  "Title": "nesciunt",
  "UpdatedDate": "2010-04-18T03:41:53.8088462+02:00",
  "CreatedDate": "1999-10-04T03:41:53.8088462+02:00",
  "BirthDate": "2011-11-12T03:41:53.8088462+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "a",
      "StrippedValue": "possimus",
      "Description": "Triple-buffered secondary strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "possimus",
      "Description": "Triple-buffered secondary strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    }
  ],
  "Description": "Quality-focused coherent application",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "nam",
      "Description": "Stand-alone solution-oriented open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "nam",
      "Description": "Stand-alone solution-oriented open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempora",
      "StrippedValue": "iusto",
      "Description": "Secured discrete Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "iusto",
      "Description": "Secured discrete Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "soluta",
      "StrippedValue": "dolorem",
      "Description": "Robust bifurcated circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "dolorem",
      "Description": "Robust bifurcated circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "temporibus",
      "StrippedValue": "error",
      "Description": "Ameliorated modular productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 668
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "error",
      "Description": "Ameliorated modular productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 668
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "hic",
      "StrippedValue": "dolores",
      "Description": "Fundamental foreground task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 477
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "dolores",
      "Description": "Fundamental foreground task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 477
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
      "Id": 903,
      "Name": "Jones, Hoppe and Marvin",
      "ToolTip": "Est illum inventore ut doloribus illum est velit.",
      "Deleted": false,
      "Rank": 410,
      "Type": "qui",
      "ColorBlock": 487,
      "IconHint": "quo",
      "Selected": true,
      "LastChanged": "2011-01-08T03:41:53.8088462+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "quisquam",
      "Hidden": false,
      "FullName": "Reinhold Haley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 221
        }
      }
    }
  ],
  "PersonNumber": "569639",
  "FullName": "Kade Jovan Dickens I",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "ad",
      "StrippedValue": "repudiandae",
      "Description": "Up-sized radical collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "repudiandae",
      "Description": "Up-sized radical collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    }
  ],
  "FormalName": "Kertzmann, Hand and Rodriguez",
  "Address": null,
  "Post3": "consequatur",
  "Post2": "et",
  "Post1": "deleniti",
  "Kanalname": "nemo",
  "Kanafname": "aliquam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "molestiae",
  "ActiveInterests": 665,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 225,
  "DbiKey": "quidem",
  "DbiLastModified": "2002-07-21T03:41:53.8088462+02:00",
  "DbiLastSyncronized": "2025-05-12T03:41:53.8088462+02:00",
  "SentInfo": 346,
  "ShowContactTickets": 131,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "blanditiis",
      "StrippedValue": "architecto",
      "Description": "Optimized mobile leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "architecto",
      "Description": "Optimized mobile leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "facilis",
      "StrippedValue": "quis",
      "Description": "Cross-platform directional definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 466
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "quis",
      "Description": "Cross-platform directional definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 466
        }
      }
    }
  ],
  "Source": 972,
  "ActiveErpLinks": 981,
  "ShipmentTypes": [
    {
      "Id": 591,
      "Name": "Barton, Willms and Schuster",
      "ToolTip": "Ullam aliquid sequi.",
      "Deleted": true,
      "Rank": 171,
      "Type": "et",
      "ColorBlock": 495,
      "IconHint": "ab",
      "Selected": false,
      "LastChanged": "2001-06-18T03:41:53.8088462+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "sed",
      "Hidden": true,
      "FullName": "Jaycee Goldner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 539,
      "Comment": "placeat",
      "Registered": "2025-09-18T03:41:53.8088462+02:00",
      "RegisteredAssociateId": 975,
      "Updated": "2012-02-16T03:41:53.8088462+01:00",
      "UpdatedAssociateId": 431,
      "LegalBaseId": 160,
      "LegalBaseKey": "voluptas",
      "LegalBaseName": "Jaskolski Group",
      "ConsentPurposeId": 928,
      "ConsentPurposeKey": "tempore",
      "ConsentPurposeName": "Stoltenberg Inc and Sons",
      "ConsentSourceId": 377,
      "ConsentSourceKey": "in",
      "ConsentSourceName": "Friesen LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "BounceEmails": [
    "valerie.nikolaus@swaniawski.com",
    "janae_zieme@gerlach.us"
  ],
  "ActiveStatusMonitorId": 346,
  "CreatedByFormId": 359,
  "UtmParameters": null,
  "LeadstatusId": 257,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Miss Emmett Yost V"
  },
  "ExtraFields": {
    "ExtraFields1": "minima",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "praesentium",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 254
    }
  }
}
```