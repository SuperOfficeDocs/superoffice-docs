---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Lehner LLC",
  "PersonFirstname": "Dejon",
  "PersonLastname": "Douglas",
  "EmailAddress": "fredy_russel@beckereffertz.com",
  "PhoneNumber": "1356171"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 528,
  "Firstname": "Marty",
  "MiddleName": "Dietrich, Watsica and Jerde",
  "Lastname": "Gusikowski",
  "Mrmrs": "qui",
  "Title": "ab",
  "UpdatedDate": "2011-04-07T14:19:03.79575+02:00",
  "CreatedDate": "2008-04-16T14:19:03.79575+02:00",
  "BirthDate": "2022-10-22T14:19:03.79575+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "consectetur",
      "StrippedValue": "rerum",
      "Description": "Profit-focused didactic standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "rerum",
      "Description": "Profit-focused didactic standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    }
  ],
  "Description": "Enterprise-wide cohesive time-frame",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "repellendus",
      "StrippedValue": "maiores",
      "Description": "Centralized needs-based software",
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
      "Value": "repellendus",
      "StrippedValue": "maiores",
      "Description": "Centralized needs-based software",
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
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "consequatur",
      "Description": "Digitized empowering support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "consequatur",
      "Description": "Digitized empowering support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "non",
      "StrippedValue": "consequuntur",
      "Description": "Fundamental methodical info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 442
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "consequuntur",
      "Description": "Fundamental methodical info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 442
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quas",
      "StrippedValue": "veritatis",
      "Description": "Enterprise-wide content-based support",
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
      "Value": "quas",
      "StrippedValue": "veritatis",
      "Description": "Enterprise-wide content-based support",
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
  "OtherPhones": [
    {
      "Value": "rerum",
      "StrippedValue": "sunt",
      "Description": "Profit-focused national benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "sunt",
      "Description": "Profit-focused national benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
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
      "Id": 914,
      "Name": "Reinger-Pfannerstill",
      "ToolTip": "Corrupti deleniti eos quibusdam et rerum ut.",
      "Deleted": false,
      "Rank": 32,
      "Type": "omnis",
      "ColorBlock": 119,
      "IconHint": "impedit",
      "Selected": false,
      "LastChanged": "2019-01-23T14:19:03.8113757+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Mrs. Matilda Reichert",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 529
        }
      }
    }
  ],
  "PersonNumber": "1091092",
  "FullName": "Prof. Leatha Hickle IV",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "quis",
      "StrippedValue": "in",
      "Description": "Diverse full-range utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 597
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "in",
      "Description": "Diverse full-range utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 597
        }
      }
    }
  ],
  "FormalName": "Bins-Grady",
  "Address": null,
  "Post3": "similique",
  "Post2": "debitis",
  "Post1": "exercitationem",
  "Kanalname": "asperiores",
  "Kanafname": "quos",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "accusantium",
  "ActiveInterests": 442,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 612,
  "DbiKey": "consequuntur",
  "DbiLastModified": "2007-02-06T14:19:03.8113757+01:00",
  "DbiLastSyncronized": "2010-06-29T14:19:03.8113757+02:00",
  "SentInfo": 71,
  "ShowContactTickets": 616,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "accusantium",
      "StrippedValue": "ut",
      "Description": "Optimized eco-centric concept",
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
      "Value": "accusantium",
      "StrippedValue": "ut",
      "Description": "Optimized eco-centric concept",
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
      "Value": "modi",
      "StrippedValue": "accusantium",
      "Description": "Inverse systemic budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 712
        }
      }
    },
    {
      "Value": "modi",
      "StrippedValue": "accusantium",
      "Description": "Inverse systemic budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 712
        }
      }
    }
  ],
  "Source": 932,
  "ActiveErpLinks": 457,
  "ShipmentTypes": [
    {
      "Id": 855,
      "Name": "Cassin, Hessel and Waters",
      "ToolTip": "Facilis saepe voluptates quia cupiditate tenetur impedit.",
      "Deleted": false,
      "Rank": 326,
      "Type": "libero",
      "ColorBlock": 274,
      "IconHint": "architecto",
      "Selected": false,
      "LastChanged": "2018-09-11T14:19:03.8113757+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eum",
      "StyleHint": "officiis",
      "Hidden": false,
      "FullName": "Sandy Koepp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 840,
      "Comment": "sit",
      "Registered": "2012-01-28T14:19:03.8113757+01:00",
      "RegisteredAssociateId": 820,
      "Updated": "2004-03-01T14:19:03.8113757+01:00",
      "UpdatedAssociateId": 390,
      "LegalBaseId": 633,
      "LegalBaseKey": "cumque",
      "LegalBaseName": "Beier Group",
      "ConsentPurposeId": 799,
      "ConsentPurposeKey": "error",
      "ConsentPurposeName": "Okuneva LLC",
      "ConsentSourceId": 125,
      "ConsentSourceKey": "quia",
      "ConsentSourceName": "Connelly LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 880
        }
      }
    }
  ],
  "BounceEmails": [
    "luther.maggio@blick.co.uk",
    "olin.effertz@barton.name"
  ],
  "ActiveStatusMonitorId": 738,
  "UserDefinedFields": {
    "SuperOffice:1": "Darwin Anderson",
    "SuperOffice:2": "Mrs. Landen Dicki"
  },
  "ExtraFields": {
    "ExtraFields1": "totam",
    "ExtraFields2": "repellendus"
  },
  "CustomFields": {
    "CustomFields1": "architecto",
    "CustomFields2": "deleniti"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 672
    }
  }
}
```