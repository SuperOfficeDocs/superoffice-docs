---
uid: quotedocuments
title: quotedocuments
keywords: mdoprovider mdo provider quotedocuments
description: MDO provider for the list of current / candidate "main document" for a given quote
generated: true
content_type: reference
envir: onsite, online
---

# "quotedocuments" MDO List
MDO provider for the list of current / candidate "main document" for a given quote

We need those document rows that point to documents connected to
the same sale as the quote record, with document template of type <see cref="F:SuperOffice.Data.DocTmplQuoteType.MainDocument" />,
and we'd like the id, header &amp; long text please.


Pass in <b>QuoteId=&lt;id&gt;</b> to identify the quote you want documents for, in AdditionalInfo.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteDocuments">QuoteDocuments</see> class.
The name of the MDO list is 'quotedocuments'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Quote to get documents for.| QuoteId|123|





## Sample Request

```http!
GET /api/v1/MDOList/quotedocuments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("quotedocuments", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "quotedocumentsheadings"
* "quotedocumentsheadingswithallitem"
* "quotedocumentsheadingswithallitemwithnoselection"
* "quotedocumentsheadingswithnoselection"
* "quotedocumentswithallitem"
* "quotedocumentswithallitemwithnoselection"
* "quotedocumentswithnoselection"
