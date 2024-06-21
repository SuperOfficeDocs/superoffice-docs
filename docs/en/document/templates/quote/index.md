---
uid: quote_templates_intro
title: Quote templates and merge fields
description: Quote templates and merge fields
keywords: quote, quote template, template, merge field
author: Bergfrid Dias, samuelholmstroem
date: 03.22.2024
topic: concept
---

# Quote templates and merge fields

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

## Main document vs. Quote details

The tags for the details such as lines and prices of the quote are generally in a document template separate from the *Quote Main Document*, the document that the sales rep writes and that is a cover letter for the whole quote.

If only the Main Document or the Details Document is chosen for the email, then it is generated and rendered as a PDF and included. However, if both documents exist, there are 2 possibilities:

* The [merge field][1] MERGEFIELD  QuoteDetails \* MERGEFORMAT "QuoteDetails" is found somewhere within the Main Document. If so, then the Details Document will be inserted at that point.

* No such merge field exists in the Main Document. The Details Document is appended at the end of the Main Document
In both cases, a single PDF results, and will be attached to the email.

> [!NOTE]
> Numbers, dates, and time are [culture-sensitive][2].

## VAT

When you want to correctly calculate VAT you must first subtract ALL discounts, including alternative discount (order discount). This must be done for each quoteline (product).

We call this the "Total price with alternative discount".

We multiply the "Total price with alternative discount" with the VAT (-Percentage). The resulting number we call **VATAmount**.

These values are summed up into the alternative's VATAmount field.

Finally, the alternatives TotalPrice and the alternatives VATAmount are then added together into the field we call **TotalPriceIncVAT**.

## Calculations

You can perform calculations with the merge fields.

### Net price per unit

To show the price per unit after discounts, you can add a merge field like this:

```text
{= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}
```

**Steps:**

1. Press Ctrl + F9 to add a new merge field. You will see two curly brackets { }.

1. Inside the brackets:

    1. Add "= " and press Ctrl + F9 again.
    1. Add "MERGEFIELD line/totalPrice" in a new set of brackets.
    1. Type "/" and then press Ctrl + F9.
    1. Add "MERGEFIELD line/quantity" in the last set of brackets.

1. Now you should have a field that looks like this: {= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}

## Related content

* [How to work with fields in Aspose Words][9]

<!-- Referenced links -->
[1]: mergefields.md
[2]: lang-culture.md
[9]: https://docs.aspose.com/words/net/fields-overview/
