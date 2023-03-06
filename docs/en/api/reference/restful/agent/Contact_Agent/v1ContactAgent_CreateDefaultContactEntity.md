---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 309,
  "Name": "Homenick-Klein",
  "Department": "",
  "OrgNr": "1573904",
  "Number1": "874078",
  "Number2": "388412",
  "UpdatedDate": "2012-08-09T14:19:02.9480279+02:00",
  "CreatedDate": "2019-10-18T14:19:02.9480279+02:00",
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "ut",
      "Description": "Optional interactive approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 86
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "ut",
      "Description": "Optional interactive approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 86
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 900,
      "Name": "Cartwright Inc and Sons",
      "ToolTip": "Ut minus provident.",
      "Deleted": false,
      "Rank": 718,
      "Type": "voluptas",
      "ColorBlock": 640,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2005-02-13T14:19:02.9480279+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "cupiditate",
      "Hidden": true,
      "FullName": "Pattie Rippin Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 15
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "cumque",
      "StrippedValue": "accusantium",
      "Description": "Synchronised scalable Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 453
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "accusantium",
      "Description": "Synchronised scalable Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 453
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nam",
      "StrippedValue": "at",
      "Description": "Phased 4th generation conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "at",
      "Description": "Phased 4th generation conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "incidunt",
      "StrippedValue": "qui",
      "Description": "Progressive systemic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 636
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "qui",
      "Description": "Progressive systemic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 636
        }
      }
    }
  ],
  "Description": "Diverse next generation hub",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "iste",
      "PersonId": 657,
      "Mrmrs": "hic",
      "Firstname": "Judson",
      "Lastname": "Dickinson",
      "MiddleName": "Fay, Schuppe and Beer",
      "Title": "quis",
      "Description": "Grass-roots logistical projection",
      "Email": "jewel.jacobs@kundeledner.co.uk",
      "FullName": "Vivien Buckridge",
      "DirectPhone": "(665)229-5091",
      "FormalName": "Maggio, Wehner and Huel",
      "CountryId": 326,
      "ContactId": 342,
      "ContactName": "Marvin-Wisoky",
      "Retired": 482,
      "Rank": 407,
      "ActiveInterests": 945,
      "ContactDepartment": "",
      "ContactCountryId": 118,
      "ContactOrgNr": "1799128",
      "FaxPhone": "1-643-575-1055 x1664",
      "MobilePhone": "1-046-361-7100 x06353",
      "ContactPhone": "617.774.9334",
      "AssociateName": "Zulauf, Kunde and Abernathy",
      "AssociateId": 82,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "magni",
      "Kanalname": "vel",
      "Post1": "sed",
      "Post2": "animi",
      "Post3": "deserunt",
      "EmailName": "malinda@okeefe.ca",
      "ContactFullName": "Constantin Von",
      "ActiveErpLinks": 934,
      "TicketPriorityId": 647,
      "SupportLanguageId": 390,
      "SupportAssociateId": 41,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 258
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quae",
  "Xstop": true,
  "ActiveInterests": 962,
  "GroupId": 245,
  "ActiveStatusMonitorId": 433,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 917,
  "DbiAgentId": 121,
  "DbiLastSyncronized": "2011-04-20T14:19:02.9480279+02:00",
  "DbiKey": "et",
  "DbiLastModified": "1999-12-05T14:19:02.9480279+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 383,
  "ActiveErpLinks": 563,
  "BounceEmails": [
    "derrick_franecki@donnelly.info",
    "kaleigh.harris@schultzjones.biz"
  ],
  "Domains": [
    "deleniti",
    "nostrum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1707225030",
    "SuperOffice:2": "Efrain Bayer"
  },
  "ExtraFields": {
    "ExtraFields1": "alias",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "blanditiis",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 638
    }
  }
}
```