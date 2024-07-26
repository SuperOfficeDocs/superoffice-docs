---
uid: help-en-quote-template
title: Quote templates and merge fields
description: Quote templates and merge fields
keywords: quote, quote template, template, merge field
author: Bergfrid Dias
date: 07.31.2024
topic: concept
language: en
---

# Quote templates and merge fields

## Main document vs. Quote details

The tags for the details such as lines and prices of the quote are generally in a document template separate from the *Quote Main Document*, the document that the sales rep writes and that is a cover letter for the whole quote.

If only the Main Document or the Details Document is chosen for the email, then it is generated and rendered as a PDF and included. However, if both documents exist, there are 2 possibilities:

* The merge field MERGEFIELD  QuoteDetails \* MERGEFORMAT "QuoteDetails" is found somewhere within the Main Document. If so, then the Details Document will be inserted at that point.

* No such merge field exists in the Main Document. The Details Document is appended at the end of the Main Document
In both cases, a single PDF results, and will be attached to the email.

## Tables and nesting

Table names are quote, alternative, group and line – nested in this order. Tags for a particular table are available from that table’s TableStart: tag on downwards. It’s possible to use (for instance) the quote/currency tag when inside a TableStart:line level.

Every template must conform to the nesting order and always start with the outermost level (quote). It need not go all the way down, but cannot start with alternative or anything else than quote.

```text
«TableStart:quote»
«TableStart:alternative»
«GroupBy:productFamilyKey»«TableStart:group»
«TableStart:line»
«TableEnd:line»
«TableEnd:group»
«TableEnd:alternative»
«TableEnd:quote»
```

## Grouping

Templates support grouping, which is **a user-defined level in between alternative and line**. Grouping is activated using a special tag, **GroupBy:xxx**, where xxx is (in principle) any string field on the line level (but without the line/ prefix). As an example, you can use **GroupBy:productFamilyKey** to activate grouping by product family.

The GroupBy: tag is case sensitive and can be located anywhere in the document. At runtime it will disappear (no text is inserted in its place). There can be at most one GroupBy: tag in a template.

If GroupBy is present, then TableStart:group and TableEnd:group can be used to mark the start and end of group-related sections. group/groupField is a tag that will contain the value of the group field (productFamily in the example above), and the part of the document between TableStart:group and TableEnd:group will be repeated for each distinct value of the group field.

It is possible to have more than one set of TableStart:group / TableEnd:group sections, for instance if you want a summary table with just the sums, and elsewhere tables with the lines that actually make up each group. In this case, the summary table would not contain an inner TableStart:line / TableEnd:line.

## Order of lines

Quote lines are, by default, listed in rank order, which is the same that you see in the quote line archives. If grouping is used, then groups come in alphabetical order, and the lines that belong to each group come in rank order.

The OrderBy:xxx tag can be used to change the order of quote lines. Similarly to GroupBy:, it is case sensitive and can occur at most once, anywhere within the document. It can refer to any field on the line level, without the line/ prefix. Example: OrderBy:vatInfo to sort lines by the VAT status. Only one level of sorting is supported.

## <a id ="culture" />Numeric and date data, culture settings

Numeric tags that have decimal values (all amounts and percentages) have 4 variants of the tag, with different formats. The decimal separator is always according to the selected language/culture (drop-downs in the **Send Quote** and **Order Confirmation** dialogs). The number of decimals is either the default or 0, 2, or 5 depending on the tag name suffix. Thus, line/totalPrice:2 will force 2 decimals, while line/totalPrice will have whatever the default number of decimals is for the culture.

Date and time tags have a similar set of variants. The tag alone will produce a "short date", with the following variants  also available:

* :ShortDate
* :ShortTime
* :ShortDateTime
* :LongDate
* :LongTime
* :LongDateTime

The actual formatting (day/month order, and so on) is always according to the selected culture.

Culture is selected by the user in the **Send Quote** and **Place Order** dialogs. The language chosen there directs the system to the correct template subfolder (English template vs. German). It also sets the .NET Culture used for the numeric and date formatting. However, sometimes the culture is not completely specified, such as German – do you mean Germany, or Switzerland, with different number formats‌.

In such cases it is possible to include the merge field Culture: in the template, specifying a .NET culture code, taken from [System.Globalization.CultureInfo][1]. For Switzerland, use "Culture:de-CH", and you will get the Swiss number formats regardless of the user's choice. This implies that such a culture code should be embedded in a special template called *Offer to Swiss customers* or something similar. Arabic-Kuwait (ar-KW) will give you 23 ﺳﺒﺘﻤﺒﺮ, 2013 as the quote/sent:LongDate.

> [!NOTE]
> Do not use the *Table of Language Culture Names, Codes, and ISO Values Method* of the [C++ AppConfig object][2] as a reference, there are slight differences.

<!-- Referenced links -->
[1]: https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-5.0
[2]: https://docs.microsoft.com/en-us/previous-versions/commerce-server/ee825488(v=cs.20)
