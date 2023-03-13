---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 293,
  "Name": "Mills-Waters",
  "Department": "",
  "OrgNr": "774535",
  "Number1": "1608894",
  "Number2": "966051",
  "UpdatedDate": "2015-03-11T12:15:18.5457603+01:00",
  "CreatedDate": "2009-01-09T12:15:18.5457603+01:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Fundamental bottom-line hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 892
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Fundamental bottom-line hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 892
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 522,
      "Name": "Vandervort, Schowalter and Ernser",
      "ToolTip": "Doloribus animi pariatur accusantium.",
      "Deleted": false,
      "Rank": 221,
      "Type": "reprehenderit",
      "ColorBlock": 900,
      "IconHint": "tempora",
      "Selected": false,
      "LastChanged": "2015-03-16T12:15:18.5457603+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "voluptatum",
      "Hidden": false,
      "FullName": "Destiny Koelpin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 428
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "sit",
      "Description": "Horizontal interactive encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 586
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "sit",
      "Description": "Horizontal interactive encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 586
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ex",
      "StrippedValue": "aut",
      "Description": "Focused uniform utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 676
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "aut",
      "Description": "Focused uniform utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 676
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "voluptatem",
      "Description": "User-centric user-facing intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 603
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "voluptatem",
      "Description": "User-centric user-facing intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 603
        }
      }
    }
  ],
  "Description": "Progressive coherent application",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "pariatur",
      "PersonId": 26,
      "Mrmrs": "labore",
      "Firstname": "Gregg",
      "Lastname": "D'Amore",
      "MiddleName": "Dickens-Stanton",
      "Title": "impedit",
      "Description": "Balanced holistic parallelism",
      "Email": "reta_konopelski@bergstromgusikowski.com",
      "FullName": "Prof. Monserrate Blake Turner",
      "DirectPhone": "1-270-337-9575 x2247",
      "FormalName": "Beatty, Ledner and Stiedemann",
      "CountryId": 716,
      "ContactId": 73,
      "ContactName": "Durgan LLC",
      "Retired": 750,
      "Rank": 33,
      "ActiveInterests": 211,
      "ContactDepartment": "",
      "ContactCountryId": 947,
      "ContactOrgNr": "1270234",
      "FaxPhone": "(645)304-6877 x830",
      "MobilePhone": "013.138.3036 x84774",
      "ContactPhone": "(388)572-9044",
      "AssociateName": "Steuber-Jerde",
      "AssociateId": 98,
      "UsePersonAddress": false,
      "ContactFax": "autem",
      "Kanafname": "quam",
      "Kanalname": "tempore",
      "Post1": "omnis",
      "Post2": "et",
      "Post3": "corrupti",
      "EmailName": "alberto.goldner@lebsack.com",
      "ContactFullName": "Scotty Stehr",
      "ActiveErpLinks": 129,
      "TicketPriorityId": 214,
      "SupportLanguageId": 975,
      "SupportAssociateId": 468,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 632
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": true,
  "ActiveInterests": 613,
  "GroupId": 34,
  "ActiveStatusMonitorId": 302,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 835,
  "DbiAgentId": 347,
  "DbiLastSyncronized": "2018-12-27T12:15:18.5507582+01:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "2003-01-06T12:15:18.5507582+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 413,
  "ActiveErpLinks": 184,
  "BounceEmails": [
    "lottie.streich@hillsspinka.info",
    "rod.pagac@labadie.biz"
  ],
  "Domains": [
    "doloribus",
    "tenetur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1386295512",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 660
    }
  }
}
```