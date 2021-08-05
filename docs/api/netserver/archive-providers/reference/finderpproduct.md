---
uid: FindErpProduct
title: FindErpProduct
description: Find products through a Quote Connector, either through the standard interface or by dispatching to a custom provider, if one is supplied.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "FindErpProduct"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "FindErpProduct"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.FindErpProductProvider">SuperOffice.CRM.ArchiveLists.FindErpProductProvider</see> inside NetServer's SODatabase assembly.

Find products through a Quote Connector, either through the standard interface or by dispatching to a custom provider, if one is supplied.

The mandatory quoteAlternativeId or quoteId is used to look up the correct connection/connector. If the connector
contains a provider called FindProductsXYZ, where XYZ is the same as the name specified in the connector's
<see cref="T:SuperOffice.CRM.QuoteConnectorAttribute" /> name, then that custom provider is called.
Otherwise, the FindProduct method of the connector will be called and its results transformed into
an archive provider result set.



From quoteAlternativeId or quoteId the currency of the sale will be derived and added as a <see cref="T:SuperOffice.CRM.ArchiveLists.ArchiveRestrictionInfo" /> to the search provider. The restriction name will be 'currencyName'





Default restrictions will also be added:
priceList/isActive,
priceList/validFrom and
priceList/validTo.




## Supported Entities
| Name | Description |
| ---- | ----- |

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |

## Sample

```http!
GET /api/v1/archive/FindErpProduct?$select=
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

