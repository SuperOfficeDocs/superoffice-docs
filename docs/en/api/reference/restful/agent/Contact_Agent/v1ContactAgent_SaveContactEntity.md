---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 28,
  "Name": "Watsica-Marquardt",
  "Department": "",
  "OrgNr": "1398884",
  "Number1": "1512185",
  "Number2": "681948",
  "UpdatedDate": "2000-08-02T23:03:55.2701395+02:00",
  "CreatedDate": "1999-04-23T23:03:55.2701395+02:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "ut",
      "Description": "Multi-lateral non-volatile implementation"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "ut",
      "Description": "Multi-lateral non-volatile implementation"
    }
  ],
  "Interests": [
    {
      "Id": 608,
      "Name": "Dooley Group",
      "ToolTip": "Veritatis qui esse tempora quis et et soluta.",
      "Deleted": true,
      "Rank": 711,
      "Type": "non",
      "ColorBlock": 972,
      "IconHint": "ab",
      "Selected": false,
      "LastChanged": "2014-12-03T23:03:55.2716442+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "possimus",
      "StyleHint": "unde",
      "Hidden": false,
      "FullName": "Deven Cartwright"
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "voluptatem",
      "Description": "Fundamental bandwidth-monitored groupware"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "voluptatem",
      "Description": "Fundamental bandwidth-monitored groupware"
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "totam",
      "Description": "Reverse-engineered hybrid throughput"
    },
    {
      "Value": "aut",
      "StrippedValue": "totam",
      "Description": "Reverse-engineered hybrid throughput"
    }
  ],
  "Faxes": [
    {
      "Value": "dolor",
      "StrippedValue": "modi",
      "Description": "Optimized actuating frame"
    },
    {
      "Value": "dolor",
      "StrippedValue": "modi",
      "Description": "Optimized actuating frame"
    }
  ],
  "Description": "Vision-oriented explicit pricing structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quas",
      "PersonId": 424,
      "Mrmrs": "quod",
      "Firstname": "Adele",
      "Lastname": "Mayer",
      "MiddleName": "Lakin Group",
      "Title": "in",
      "Description": "Adaptive maximized leverage",
      "Email": "joesph_ullrich@kerluke.uk",
      "FullName": "Keeley Eichmann",
      "DirectPhone": "(270)915-5240 x241",
      "FormalName": "Price-Kshlerin",
      "CountryId": 451,
      "ContactId": 288,
      "ContactName": "Gerhold, Yost and Thompson",
      "Retired": 222,
      "Rank": 766,
      "ActiveInterests": 720,
      "ContactDepartment": "",
      "ContactCountryId": 153,
      "ContactOrgNr": "1315917",
      "FaxPhone": "776-482-4202 x36901",
      "MobilePhone": "(733)074-0857",
      "ContactPhone": "190.985.3414 x2530",
      "AssociateName": "Schaefer Inc and Sons",
      "AssociateId": 280,
      "UsePersonAddress": true,
      "ContactFax": "exercitationem",
      "Kanafname": "dicta",
      "Kanalname": "omnis",
      "Post1": "consequatur",
      "Post2": "autem",
      "Post3": "totam",
      "EmailName": "lazaro@larkin.com",
      "ContactFullName": "Karley Prosacco",
      "ActiveErpLinks": 432,
      "TicketPriorityId": 396,
      "SupportLanguageId": 876,
      "SupportAssociateId": 94,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "esse",
  "Xstop": false,
  "ActiveInterests": 284,
  "GroupId": 234,
  "ActiveStatusMonitorId": 532,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 308,
  "DbiAgentId": 378,
  "DbiLastSyncronized": "2019-10-27T23:03:55.2756385+01:00",
  "DbiKey": "eligendi",
  "DbiLastModified": "2020-12-27T23:03:55.2756385+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 512,
  "ActiveErpLinks": 455,
  "BounceEmails": [
    "alyce@wehnerskiles.uk",
    "edythe_goodwin@sauer.name"
  ],
  "Domains": [
    "libero",
    "placeat"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Antone Lilly Larson IV",
    "SuperOffice:2": "Brooklyn Vandervort Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "atque"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "corrupti"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 952,
  "Name": "Mosciski-Grant",
  "Department": "",
  "OrgNr": "1229251",
  "Number1": "1040911",
  "Number2": "1537123",
  "UpdatedDate": "2015-06-23T23:03:55.2866383+02:00",
  "CreatedDate": "2012-07-04T23:03:55.2866383+02:00",
  "Emails": [
    {
      "Value": "maxime",
      "StrippedValue": "ea",
      "Description": "Cross-group foreground encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 646
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "ea",
      "Description": "Cross-group foreground encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 646
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 905,
      "Name": "Erdman-Walsh",
      "ToolTip": "Quas earum omnis odio sunt placeat rerum.",
      "Deleted": true,
      "Rank": 755,
      "Type": "dicta",
      "ColorBlock": 691,
      "IconHint": "sunt",
      "Selected": false,
      "LastChanged": "2017-04-01T23:03:55.2866383+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quae",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Mr. Francisca Cormier PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quasi",
      "StrippedValue": "aut",
      "Description": "Compatible global forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 998
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "aut",
      "Description": "Compatible global forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 998
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "velit",
      "Description": "Face to face modular project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 125
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "velit",
      "Description": "Face to face modular project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 125
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nesciunt",
      "StrippedValue": "voluptatem",
      "Description": "Team-oriented scalable parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "voluptatem",
      "Description": "Team-oriented scalable parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    }
  ],
  "Description": "Versatile interactive matrices",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 160,
      "Mrmrs": "eaque",
      "Firstname": "Zoey",
      "Lastname": "Murray",
      "MiddleName": "Schumm, Parisian and Borer",
      "Title": "delectus",
      "Description": "Open-architected motivating customer loyalty",
      "Email": "lilly.torphy@tremblay.com",
      "FullName": "Morris Batz",
      "DirectPhone": "1-850-347-4327",
      "FormalName": "Doyle Inc and Sons",
      "CountryId": 241,
      "ContactId": 150,
      "ContactName": "Hagenes, Medhurst and Daniel",
      "Retired": 241,
      "Rank": 820,
      "ActiveInterests": 135,
      "ContactDepartment": "",
      "ContactCountryId": 483,
      "ContactOrgNr": "1092870",
      "FaxPhone": "1-498-654-6423 x33429",
      "MobilePhone": "291.869.8428",
      "ContactPhone": "187-294-0469",
      "AssociateName": "Miller-Hartmann",
      "AssociateId": 544,
      "UsePersonAddress": true,
      "ContactFax": "omnis",
      "Kanafname": "dolor",
      "Kanalname": "qui",
      "Post1": "necessitatibus",
      "Post2": "distinctio",
      "Post3": "ut",
      "EmailName": "trever@nienow.biz",
      "ContactFullName": "Priscilla Stehr",
      "ActiveErpLinks": 977,
      "TicketPriorityId": 583,
      "SupportLanguageId": 633,
      "SupportAssociateId": 705,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 913
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "odit",
  "Xstop": false,
  "ActiveInterests": 94,
  "GroupId": 941,
  "ActiveStatusMonitorId": 758,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 476,
  "DbiAgentId": 645,
  "DbiLastSyncronized": "2008-11-05T23:03:55.2911384+01:00",
  "DbiKey": "esse",
  "DbiLastModified": "2020-10-26T23:03:55.2911384+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 723,
  "ActiveErpLinks": 898,
  "BounceEmails": [
    "julio_schmitt@daniel.us",
    "nyah_hermann@ferry.info"
  ],
  "Domains": [
    "minima",
    "sit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Laila Cruickshank",
    "SuperOffice:2": "Oleta Carroll"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 379
    }
  }
}
```