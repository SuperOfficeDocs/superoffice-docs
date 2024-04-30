---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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

## Request Body: entity 

The PersonEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

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
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 730,
  "Firstname": "Berniece",
  "MiddleName": "Swift, Moen and Windler",
  "Lastname": "O'Conner",
  "Mrmrs": "fuga",
  "Title": "itaque",
  "UpdatedDate": "2000-07-30T11:16:09.4128276+02:00",
  "CreatedDate": "2000-01-12T11:16:09.4128276+01:00",
  "BirthDate": "2008-04-30T11:16:09.4128276+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aliquid",
      "StrippedValue": "qui",
      "Description": "Digitized intermediate emulation"
    },
    {
      "Value": "aliquid",
      "StrippedValue": "qui",
      "Description": "Digitized intermediate emulation"
    }
  ],
  "Description": "Right-sized human-resource instruction set",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "voluptates",
      "Description": "Versatile local projection"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "voluptates",
      "Description": "Versatile local projection"
    }
  ],
  "Faxes": [
    {
      "Value": "aliquam",
      "StrippedValue": "officia",
      "Description": "Customer-focused mission-critical monitoring"
    },
    {
      "Value": "aliquam",
      "StrippedValue": "officia",
      "Description": "Customer-focused mission-critical monitoring"
    }
  ],
  "MobilePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "eius",
      "Description": "Robust solution-oriented portal"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "eius",
      "Description": "Robust solution-oriented portal"
    }
  ],
  "OfficePhones": [
    {
      "Value": "sint",
      "StrippedValue": "voluptatem",
      "Description": "Open-source eco-centric conglomeration"
    },
    {
      "Value": "sint",
      "StrippedValue": "voluptatem",
      "Description": "Open-source eco-centric conglomeration"
    }
  ],
  "OtherPhones": [
    {
      "Value": "eos",
      "StrippedValue": "atque",
      "Description": "Profound secondary project"
    },
    {
      "Value": "eos",
      "StrippedValue": "atque",
      "Description": "Profound secondary project"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 432,
      "Name": "Daugherty Group",
      "ToolTip": "Eaque expedita velit tenetur eligendi quidem consequatur.",
      "Deleted": false,
      "Rank": 256,
      "Type": "quis",
      "ColorBlock": 879,
      "IconHint": "qui",
      "Selected": true,
      "LastChanged": "2003-12-05T11:16:09.4128276+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "numquam",
      "StyleHint": "rem",
      "Hidden": false,
      "FullName": "Carleton Flatley"
    }
  ],
  "PersonNumber": "180335",
  "FullName": "Marielle Ankunding",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "nobis",
      "Description": "Reduced national functionalities"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "nobis",
      "Description": "Reduced national functionalities"
    }
  ],
  "FormalName": "Schultz, Carroll and Lebsack",
  "Address": null,
  "Post3": "consequatur",
  "Post2": "quo",
  "Post1": "et",
  "Kanalname": "molestias",
  "Kanafname": "in",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "molestiae",
  "ActiveInterests": 972,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 86,
  "DbiKey": "voluptatibus",
  "DbiLastModified": "2021-12-05T11:16:09.4128276+01:00",
  "DbiLastSyncronized": "2015-01-31T11:16:09.4128276+01:00",
  "SentInfo": 816,
  "ShowContactTickets": 278,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nobis",
      "StrippedValue": "a",
      "Description": "Implemented encompassing service-desk"
    },
    {
      "Value": "nobis",
      "StrippedValue": "a",
      "Description": "Implemented encompassing service-desk"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "omnis",
      "Description": "Profound stable approach"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "omnis",
      "Description": "Profound stable approach"
    }
  ],
  "Source": 684,
  "ActiveErpLinks": 97,
  "ShipmentTypes": [
    {
      "Id": 320,
      "Name": "Hoeger LLC",
      "ToolTip": "Atque nobis quo.",
      "Deleted": false,
      "Rank": 631,
      "Type": "rem",
      "ColorBlock": 768,
      "IconHint": "esse",
      "Selected": false,
      "LastChanged": "2002-05-16T11:16:09.4128276+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quaerat",
      "StyleHint": "modi",
      "Hidden": false,
      "FullName": "Josie Bogan"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 630,
      "Comment": "ut",
      "Registered": "2022-04-17T11:16:09.4128276+02:00",
      "RegisteredAssociateId": 855,
      "Updated": "2012-07-07T11:16:09.4128276+02:00",
      "UpdatedAssociateId": 687,
      "LegalBaseId": 577,
      "LegalBaseKey": "aliquam",
      "LegalBaseName": "Gottlieb LLC",
      "ConsentPurposeId": 84,
      "ConsentPurposeKey": "eaque",
      "ConsentPurposeName": "Botsford-Wuckert",
      "ConsentSourceId": 239,
      "ConsentSourceKey": "incidunt",
      "ConsentSourceName": "Ziemann-Osinski"
    }
  ],
  "BounceEmails": [
    "oceane@bahringer.us",
    "norwood_robel@kerluke.uk"
  ],
  "ActiveStatusMonitorId": 895,
  "UserDefinedFields": {
    "SuperOffice:1": "2010821319",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "cumque"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 117,
  "Firstname": "Percy",
  "MiddleName": "Sporer Group",
  "Lastname": "Breitenberg",
  "Mrmrs": "quia",
  "Title": "quis",
  "UpdatedDate": "2021-01-25T11:16:09.428448+01:00",
  "CreatedDate": "2018-05-05T11:16:09.428448+02:00",
  "BirthDate": "2019-07-12T11:16:09.428448+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "corrupti",
      "StrippedValue": "est",
      "Description": "Decentralized mission-critical artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "est",
      "Description": "Decentralized mission-critical artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    }
  ],
  "Description": "Business-focused multimedia complexity",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "nam",
      "Description": "Profound neutral moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 26
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "nam",
      "Description": "Profound neutral moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 26
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quos",
      "StrippedValue": "illo",
      "Description": "Intuitive 5th generation circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "illo",
      "Description": "Intuitive 5th generation circuit",
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
  "MobilePhones": [
    {
      "Value": "quo",
      "StrippedValue": "ipsam",
      "Description": "Quality-focused radical access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 611
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "ipsam",
      "Description": "Quality-focused radical access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 611
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dicta",
      "StrippedValue": "laborum",
      "Description": "Cross-platform interactive approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "laborum",
      "Description": "Cross-platform interactive approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ut",
      "StrippedValue": "placeat",
      "Description": "Compatible local forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 894
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "placeat",
      "Description": "Compatible local forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 894
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
      "Id": 102,
      "Name": "Wintheiser Group",
      "ToolTip": "Commodi recusandae repellendus ratione ut.",
      "Deleted": false,
      "Rank": 862,
      "Type": "nihil",
      "ColorBlock": 621,
      "IconHint": "recusandae",
      "Selected": false,
      "LastChanged": "2006-04-20T11:16:09.428448+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Prof. Danyka Weimann Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 313
        }
      }
    }
  ],
  "PersonNumber": "998657",
  "FullName": "Dr. Luis Greenfelder DVM",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "ipsa",
      "StrippedValue": "quidem",
      "Description": "Face to face 24 hour encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 349
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "quidem",
      "Description": "Face to face 24 hour encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 349
        }
      }
    }
  ],
  "FormalName": "Hayes-Jewess",
  "Address": null,
  "Post3": "sapiente",
  "Post2": "nisi",
  "Post1": "est",
  "Kanalname": "sint",
  "Kanafname": "nemo",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ullam",
  "ActiveInterests": 447,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 673,
  "DbiKey": "fugiat",
  "DbiLastModified": "1997-09-10T11:16:09.428448+02:00",
  "DbiLastSyncronized": "2017-12-23T11:16:09.428448+01:00",
  "SentInfo": 56,
  "ShowContactTickets": 488,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptates",
      "StrippedValue": "aspernatur",
      "Description": "Expanded human-resource superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 963
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "aspernatur",
      "Description": "Expanded human-resource superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 963
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sit",
      "StrippedValue": "et",
      "Description": "Synchronised object-oriented focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "et",
      "Description": "Synchronised object-oriented focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    }
  ],
  "Source": 255,
  "ActiveErpLinks": 778,
  "ShipmentTypes": [
    {
      "Id": 31,
      "Name": "Ledner, King and Tillman",
      "ToolTip": "Voluptatem quo consectetur ut.",
      "Deleted": true,
      "Rank": 867,
      "Type": "et",
      "ColorBlock": 535,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2016-02-09T11:16:09.428448+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "impedit",
      "Hidden": true,
      "FullName": "Rodrick Auer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 595
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 747,
      "Comment": "voluptatem",
      "Registered": "1998-01-08T11:16:09.428448+01:00",
      "RegisteredAssociateId": 433,
      "Updated": "1998-03-03T11:16:09.428448+01:00",
      "UpdatedAssociateId": 107,
      "LegalBaseId": 365,
      "LegalBaseKey": "repudiandae",
      "LegalBaseName": "Wuckert Group",
      "ConsentPurposeId": 348,
      "ConsentPurposeKey": "sit",
      "ConsentPurposeName": "Runolfsdottir LLC",
      "ConsentSourceId": 812,
      "ConsentSourceKey": "praesentium",
      "ConsentSourceName": "Glover-Ziemann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 732
        }
      }
    }
  ],
  "BounceEmails": [
    "shayna@bahringerrunolfsson.com",
    "alize@wisozk.uk"
  ],
  "ActiveStatusMonitorId": 249,
  "UserDefinedFields": {
    "SuperOffice:1": "903574742",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "enim"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 146
    }
  }
}
```