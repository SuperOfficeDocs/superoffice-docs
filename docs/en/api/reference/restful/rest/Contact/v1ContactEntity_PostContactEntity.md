---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

## Request Body: newEntity 

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

### Response body: ContactEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 947,
  "Name": "Rau-Murphy",
  "Department": "",
  "OrgNr": "1386392",
  "Number1": "625067",
  "Number2": "663825",
  "UpdatedDate": "2012-12-29T23:04:03.9210182+01:00",
  "CreatedDate": "2017-09-22T23:04:03.9210182+02:00",
  "Emails": [
    {
      "Value": "debitis",
      "StrippedValue": "deserunt",
      "Description": "Multi-layered solution-oriented workforce"
    },
    {
      "Value": "debitis",
      "StrippedValue": "deserunt",
      "Description": "Multi-layered solution-oriented workforce"
    }
  ],
  "Interests": [
    {
      "Id": 256,
      "Name": "Kulas, Monahan and Shanahan",
      "ToolTip": "Eum earum quisquam voluptatem nesciunt accusantium quae deleniti.",
      "Deleted": false,
      "Rank": 795,
      "Type": "voluptatem",
      "ColorBlock": 239,
      "IconHint": "totam",
      "Selected": false,
      "LastChanged": "1998-12-18T23:04:03.9215227+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "possimus",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Lincoln Schinner"
    }
  ],
  "Urls": [
    {
      "Value": "distinctio",
      "StrippedValue": "omnis",
      "Description": "Grass-roots real-time moratorium"
    },
    {
      "Value": "distinctio",
      "StrippedValue": "omnis",
      "Description": "Grass-roots real-time moratorium"
    }
  ],
  "Phones": [
    {
      "Value": "nulla",
      "StrippedValue": "et",
      "Description": "Mandatory context-sensitive array"
    },
    {
      "Value": "nulla",
      "StrippedValue": "et",
      "Description": "Mandatory context-sensitive array"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "pariatur",
      "Description": "Object-based maximized utilisation"
    },
    {
      "Value": "et",
      "StrippedValue": "pariatur",
      "Description": "Object-based maximized utilisation"
    }
  ],
  "Description": "De-engineered analyzing encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 738,
      "Mrmrs": "eum",
      "Firstname": "Merritt",
      "Lastname": "Breitenberg",
      "MiddleName": "Bergstrom-Wilderman",
      "Title": "soluta",
      "Description": "Enhanced discrete budgetary management",
      "Email": "hilda.reichel@nienow.ca",
      "FullName": "Arne Bashirian Sr.",
      "DirectPhone": "(651)827-6829",
      "FormalName": "Schoen-Hills",
      "CountryId": 707,
      "ContactId": 724,
      "ContactName": "Ziemann, Auer and Skiles",
      "Retired": 5,
      "Rank": 405,
      "ActiveInterests": 17,
      "ContactDepartment": "",
      "ContactCountryId": 331,
      "ContactOrgNr": "756681",
      "FaxPhone": "(230)813-6049 x094",
      "MobilePhone": "1-966-659-4223",
      "ContactPhone": "997.950.1885",
      "AssociateName": "Ebert, Powlowski and Moen",
      "AssociateId": 538,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "ut",
      "Kanalname": "eligendi",
      "Post1": "hic",
      "Post2": "reprehenderit",
      "Post3": "corrupti",
      "EmailName": "adrianna.schmidt@brakus.info",
      "ContactFullName": "Emmitt Cummings",
      "ActiveErpLinks": 692,
      "TicketPriorityId": 334,
      "SupportLanguageId": 673,
      "SupportAssociateId": 341,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "ipsam",
  "Xstop": false,
  "ActiveInterests": 906,
  "GroupId": 759,
  "ActiveStatusMonitorId": 210,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 66,
  "DbiAgentId": 993,
  "DbiLastSyncronized": "2021-10-18T23:04:03.9270206+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "1997-04-07T23:04:03.9270206+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 462,
  "ActiveErpLinks": 911,
  "BounceEmails": [
    "evan@larsonwatsica.co.uk",
    "garry_sauer@hartmannmaggio.co.uk"
  ],
  "Domains": [
    "eveniet",
    "sapiente"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "759377145",
    "SuperOffice:2": "Clark Hoeger"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "a"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 997,
  "Name": "Marquardt, Kuhic and Sawayn",
  "Department": "",
  "OrgNr": "1017334",
  "Number1": "569986",
  "Number2": "1393359",
  "UpdatedDate": "2015-02-24T23:04:03.9385221+01:00",
  "CreatedDate": "2010-05-19T23:04:03.9385221+02:00",
  "Emails": [
    {
      "Value": "eos",
      "StrippedValue": "est",
      "Description": "Multi-channelled zero administration system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 630
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "est",
      "Description": "Multi-channelled zero administration system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 630
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 789,
      "Name": "Morar Inc and Sons",
      "ToolTip": "Molestiae veritatis ullam sapiente ut minus quia officia.",
      "Deleted": false,
      "Rank": 467,
      "Type": "ut",
      "ColorBlock": 852,
      "IconHint": "porro",
      "Selected": false,
      "LastChanged": "2016-03-13T23:04:03.9390201+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "reiciendis",
      "Hidden": true,
      "FullName": "Dock Bernier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 630
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ad",
      "StrippedValue": "dignissimos",
      "Description": "Public-key demand-driven challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "dignissimos",
      "Description": "Public-key demand-driven challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "aut",
      "Description": "Vision-oriented encompassing throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 830
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "aut",
      "Description": "Vision-oriented encompassing throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 830
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laudantium",
      "StrippedValue": "amet",
      "Description": "Object-based tangible website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 276
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "amet",
      "Description": "Object-based tangible website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 276
        }
      }
    }
  ],
  "Description": "Seamless 24/7 flexibility",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sequi",
      "PersonId": 233,
      "Mrmrs": "asperiores",
      "Firstname": "Cruz",
      "Lastname": "Johnson",
      "MiddleName": "Dare Group",
      "Title": "exercitationem",
      "Description": "Upgradable mobile superstructure",
      "Email": "chadrick@franecki.info",
      "FullName": "Ms. Alfonzo Cristina Legros II",
      "DirectPhone": "1-980-010-8626 x2815",
      "FormalName": "Klocko Group",
      "CountryId": 752,
      "ContactId": 685,
      "ContactName": "Tillman Group",
      "Retired": 508,
      "Rank": 686,
      "ActiveInterests": 954,
      "ContactDepartment": "",
      "ContactCountryId": 235,
      "ContactOrgNr": "1633228",
      "FaxPhone": "092-674-3233 x686",
      "MobilePhone": "1-833-179-1923 x905",
      "ContactPhone": "479.002.0521",
      "AssociateName": "Strosin-Torp",
      "AssociateId": 538,
      "UsePersonAddress": false,
      "ContactFax": "corporis",
      "Kanafname": "earum",
      "Kanalname": "tenetur",
      "Post1": "officia",
      "Post2": "consequuntur",
      "Post3": "temporibus",
      "EmailName": "nikita_wilkinson@lehner.info",
      "ContactFullName": "Ressie Harber Sr.",
      "ActiveErpLinks": 408,
      "TicketPriorityId": 220,
      "SupportLanguageId": 412,
      "SupportAssociateId": 681,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "at",
  "Xstop": false,
  "ActiveInterests": 301,
  "GroupId": 331,
  "ActiveStatusMonitorId": 541,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 303,
  "DbiAgentId": 616,
  "DbiLastSyncronized": "1996-11-04T23:04:03.9435205+01:00",
  "DbiKey": "nisi",
  "DbiLastModified": "2006-01-22T23:04:03.9435205+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 917,
  "ActiveErpLinks": 994,
  "BounceEmails": [
    "samir@westhuel.us",
    "martina.kemmer@blick.biz"
  ],
  "Domains": [
    "commodi",
    "dolor"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mr. Avis Dortha Wiza MD"
  },
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quibusdam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 665
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```