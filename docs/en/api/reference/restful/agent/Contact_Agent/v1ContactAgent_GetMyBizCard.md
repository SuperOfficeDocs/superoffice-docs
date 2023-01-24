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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 92,
  "Name": "Leffler, Ward and Mosciski",
  "Department": "",
  "OrgNr": "999944",
  "Number1": "1139692",
  "Number2": "1044299",
  "UpdatedDate": "1995-09-20T11:22:37.7117276+02:00",
  "CreatedDate": "2006-08-06T11:22:37.7117276+02:00",
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "dicta",
      "Description": "Digitized even-keeled portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "dicta",
      "Description": "Digitized even-keeled portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 693,
      "Name": "Gusikowski LLC",
      "ToolTip": "Numquam consequatur dicta recusandae qui deserunt praesentium.",
      "Deleted": true,
      "Rank": 223,
      "Type": "sed",
      "ColorBlock": 657,
      "IconHint": "eveniet",
      "Selected": false,
      "LastChanged": "2005-11-21T11:22:37.7117276+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Dena Adams",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 162
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "nulla",
      "Description": "Distributed interactive application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 647
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "nulla",
      "Description": "Distributed interactive application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 647
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "voluptatem",
      "Description": "Operative bifurcated task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 136
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "voluptatem",
      "Description": "Operative bifurcated task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 136
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "veniam",
      "StrippedValue": "recusandae",
      "Description": "Vision-oriented fault-tolerant monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "recusandae",
      "Description": "Vision-oriented fault-tolerant monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "Description": "Horizontal zero defect superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laborum",
      "PersonId": 499,
      "Mrmrs": "perferendis",
      "Firstname": "Andreanne",
      "Lastname": "McCullough",
      "MiddleName": "Reichel-Luettgen",
      "Title": "perspiciatis",
      "Description": "Horizontal system-worthy methodology",
      "Email": "jerrod@wiegandhuel.name",
      "FullName": "Mrs. Abigayle Johns",
      "DirectPhone": "583.711.8859",
      "FormalName": "Howell-Wisoky",
      "CountryId": 50,
      "ContactId": 422,
      "ContactName": "Cummerata, Reilly and Howell",
      "Retired": 264,
      "Rank": 29,
      "ActiveInterests": 260,
      "ContactDepartment": "",
      "ContactCountryId": 977,
      "ContactOrgNr": "1358041",
      "FaxPhone": "(461)268-7331 x49810",
      "MobilePhone": "1-651-251-3328 x50843",
      "ContactPhone": "741-382-3446",
      "AssociateName": "Howe-Hayes",
      "AssociateId": 252,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "et",
      "Kanalname": "ad",
      "Post1": "nemo",
      "Post2": "fugit",
      "Post3": "repudiandae",
      "EmailName": "whitney@smith.us",
      "ContactFullName": "Lyla Huel",
      "ActiveErpLinks": 220,
      "TicketPriorityId": 698,
      "SupportLanguageId": 967,
      "SupportAssociateId": 491,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 478
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "a",
  "Xstop": false,
  "ActiveInterests": 542,
  "GroupId": 15,
  "ActiveStatusMonitorId": 260,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 989,
  "DbiAgentId": 67,
  "DbiLastSyncronized": "2022-12-21T11:22:37.7117276+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2003-05-07T11:22:37.7117276+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 676,
  "ActiveErpLinks": 184,
  "BounceEmails": [
    "winona_vandervort@kihn.biz",
    "emmalee@lind.info"
  ],
  "Domains": [
    "nisi",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "956996254",
    "SuperOffice:2": "485825725"
  },
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "facilis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 328
    }
  }
}
```