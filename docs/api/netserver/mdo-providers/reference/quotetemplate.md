---
uid: quotetemplate
title: quotetemplate
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "quotetemplate"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "quotetemplate" MDO List
This is a variant of the DocTmpl list - document templates - restricted to those that are of some quote document type.
Use AdditionalInfo 'DocTmplQuoteType=&lt;a valid DocTmplQuoteType enum string value&gt;' to specify which one it should be



Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteTemplateProvider">QuoteTemplateProvider</see> class.
The name of the MDO list is 'quotetemplate'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|DocTmplQuoteType enum value| DocTmplQuoteType|MainDocument|





## Sample Request

```http!
GET /api/v1/MDOList/quotetemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quotetemplate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|19|Order confirmation e-mail|||
|18|Order confirmation|||
|16|Quote - detailed|||
|17|Quote e-mail|||
|15|Quote|||


## Related MDO Lists

* "quotetemplateheadings"
* "quotetemplateheadingswithallitem"
* "quotetemplateheadingswithallitemwithnoselection"
* "quotetemplateheadingswithnoselection"
* "quotetemplatewithallitem"
* "quotetemplatewithallitemwithnoselection"
* "quotetemplatewithnoselection"
