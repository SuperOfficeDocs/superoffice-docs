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
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 360,
  "Name": "Hane-Kirlin",
  "Department": "",
  "OrgNr": "1116406",
  "Number1": "557245",
  "Number2": "335710",
  "UpdatedDate": "2021-06-02T12:01:32.7769271+02:00",
  "CreatedDate": "2012-08-29T12:01:32.7769271+02:00",
  "Emails": [
    {
      "Value": "reiciendis",
      "StrippedValue": "et",
      "Description": "Upgradable systematic success"
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "et",
      "Description": "Upgradable systematic success"
    }
  ],
  "Interests": [
    {
      "Id": 869,
      "Name": "Halvorson Inc and Sons",
      "ToolTip": "Ad fugiat aut illum.",
      "Deleted": false,
      "Rank": 56,
      "Type": "ut",
      "ColorBlock": 419,
      "IconHint": "atque",
      "Selected": true,
      "LastChanged": "2005-05-05T12:01:32.7769271+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "consectetur",
      "Hidden": true,
      "FullName": "Ms. Micheal Lafayette Lemke"
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "dolores",
      "Description": "Future-proofed zero tolerance orchestration"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "dolores",
      "Description": "Future-proofed zero tolerance orchestration"
    }
  ],
  "Phones": [
    {
      "Value": "atque",
      "StrippedValue": "ipsum",
      "Description": "Reactive tertiary methodology"
    },
    {
      "Value": "atque",
      "StrippedValue": "ipsum",
      "Description": "Reactive tertiary methodology"
    }
  ],
  "Faxes": [
    {
      "Value": "consectetur",
      "StrippedValue": "cum",
      "Description": "Future-proofed foreground product"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "cum",
      "Description": "Future-proofed foreground product"
    }
  ],
  "Description": "Upgradable human-resource functionalities",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 401,
      "Mrmrs": "voluptates",
      "Firstname": "Sigurd",
      "Lastname": "Prohaska",
      "MiddleName": "Douglas Group",
      "Title": "aliquid",
      "Description": "Sharable web-enabled process improvement",
      "Email": "hertha@schinner.com",
      "FullName": "Mrs. Bertram Kovacek",
      "DirectPhone": "882.817.7809 x217",
      "FormalName": "Waters-Dach",
      "CountryId": 192,
      "ContactId": 422,
      "ContactName": "Bergnaum Inc and Sons",
      "Retired": 420,
      "Rank": 260,
      "ActiveInterests": 741,
      "ContactDepartment": "",
      "ContactCountryId": 583,
      "ContactOrgNr": "871331",
      "FaxPhone": "198-844-3181",
      "MobilePhone": "266.301.6718 x23062",
      "ContactPhone": "003-375-1774 x29815",
      "AssociateName": "Wunsch-Leffler",
      "AssociateId": 278,
      "UsePersonAddress": false,
      "ContactFax": "nemo",
      "Kanafname": "ex",
      "Kanalname": "ipsa",
      "Post1": "beatae",
      "Post2": "et",
      "Post3": "aliquid",
      "EmailName": "madelynn_torphy@donnelly.name",
      "ContactFullName": "Prof. Gavin Jacobi",
      "ActiveErpLinks": 796,
      "TicketPriorityId": 654,
      "SupportLanguageId": 310,
      "SupportAssociateId": 133,
      "CategoryName": "VIP Customer",
      "PersonNumber": "391302"
    }
  ],
  "NoMailing": false,
  "Kananame": "consequatur",
  "Xstop": true,
  "ActiveInterests": 130,
  "GroupId": 297,
  "ActiveStatusMonitorId": 429,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 492,
  "DbiAgentId": 865,
  "DbiLastSyncronized": "2020-10-20T12:01:32.7925531+02:00",
  "DbiKey": "laborum",
  "DbiLastModified": "2015-08-21T12:01:32.7925531+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 36,
  "ActiveErpLinks": 450,
  "BounceEmails": [
    "nils_bartell@treutelhand.us",
    "marquise.kuphal@eichmannrice.name"
  ],
  "Domains": [
    "voluptates",
    "tenetur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1782955336",
    "SuperOffice:2": "Arnaldo Boehm"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "atque"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 322,
  "Name": "Senger Inc and Sons",
  "Department": "",
  "OrgNr": "495069",
  "Number1": "1355289",
  "Number2": "693605",
  "UpdatedDate": "2017-12-14T12:01:32.7925531+01:00",
  "CreatedDate": "1999-04-15T12:01:32.7925531+02:00",
  "Emails": [
    {
      "Value": "odio",
      "StrippedValue": "cum",
      "Description": "Virtual bottom-line throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "cum",
      "Description": "Virtual bottom-line throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 673,
      "Name": "Langworth Group",
      "ToolTip": "Asperiores voluptatem eum excepturi dolores minus nobis.",
      "Deleted": false,
      "Rank": 652,
      "Type": "qui",
      "ColorBlock": 828,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "1999-03-17T12:01:32.7925531+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequuntur",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Vernie Beer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 522
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "est",
      "Description": "Universal global orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 578
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "est",
      "Description": "Universal global orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 578
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "est",
      "Description": "Fundamental regional solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "est",
      "Description": "Fundamental regional solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "totam",
      "Description": "Advanced encompassing emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "totam",
      "Description": "Advanced encompassing emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    }
  ],
  "Description": "Quality-focused needs-based capacity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quos",
      "PersonId": 324,
      "Mrmrs": "fugit",
      "Firstname": "Alexie",
      "Lastname": "Stanton",
      "MiddleName": "Barrows-O'Reilly",
      "Title": "voluptatum",
      "Description": "Business-focused actuating leverage",
      "Email": "daniella@huelsmcclure.uk",
      "FullName": "Hilda Bruen",
      "DirectPhone": "(096)434-2604 x173",
      "FormalName": "Steuber LLC",
      "CountryId": 422,
      "ContactId": 341,
      "ContactName": "Grimes-Bradtke",
      "Retired": 651,
      "Rank": 220,
      "ActiveInterests": 116,
      "ContactDepartment": "",
      "ContactCountryId": 399,
      "ContactOrgNr": "795483",
      "FaxPhone": "(872)709-4418 x446",
      "MobilePhone": "(678)841-5097",
      "ContactPhone": "(409)399-0187",
      "AssociateName": "Lemke-Hagenes",
      "AssociateId": 89,
      "UsePersonAddress": true,
      "ContactFax": "officia",
      "Kanafname": "explicabo",
      "Kanalname": "error",
      "Post1": "omnis",
      "Post2": "architecto",
      "Post3": "aut",
      "EmailName": "lexus@auer.com",
      "ContactFullName": "Miss Ida Rose Metz",
      "ActiveErpLinks": 609,
      "TicketPriorityId": 233,
      "SupportLanguageId": 588,
      "SupportAssociateId": 879,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1011944",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 819
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 967,
  "GroupId": 566,
  "ActiveStatusMonitorId": 707,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 247,
  "DbiAgentId": 109,
  "DbiLastSyncronized": "2006-01-14T12:01:32.7925531+01:00",
  "DbiKey": "excepturi",
  "DbiLastModified": "2016-06-29T12:01:32.7925531+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 884,
  "ActiveErpLinks": 256,
  "BounceEmails": [
    "noah@huels.us",
    "heather@pacocha.ca"
  ],
  "Domains": [
    "id",
    "sit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "dignissimos",
    "CustomFields2": "molestiae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 559
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```