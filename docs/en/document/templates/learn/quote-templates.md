---
uid: help-en-quote-template
title: Quote templates and merge fields
description: Quote templates and merge fields
keywords: quote, quote template, template, quote document, quote details, merge field
author: Bergfrid Dias
date: 07.31.2024
version: 10
topic: concept
language: en
---

# Quote templates and merge fields

This guide outlines the different types of quote templates available in SuperOffice CRM, along with instructions for using merge fields to customize quotes and order confirmations. These templates include the main quote document, quote details, order confirmations, and associated email templates.

A quote often consists of more than one product. It is therefore necessary to create a quote details template (and an order confirmation template) in which each product is listed in a table with different groupings (such as alternatives). The user will only be able to edit the quote document in Word. The quote details and the order confirmation will only be generated as a PDF and cannot be edited by the user. All quote templates can be edited in the normal way in Settings and maintenance.

## <a id="types"></a>Types of quote document templates

SuperOffice provides various templates for generating quotes. These templates can be accessed and customized in Settings and maintenance under **Lists**.

| Type | Description | Format | Example |
|---|---|---|---|
| Quotation | Main quote document template | .doc or .docx | marked in yellow |
| Quote details | Details template for quotes | .pdf | marked in purple |
| Order confirmation | Confirmation template for orders | .pdf | marked in pink |
| Email template | Templates for quote and order confirmation emails | | marked in orange |

![Quote - Document template -screenshot][img1]

![Quote - Email template -screenshot][img2]

### Quotation – Main quote document template

The **quotation** template is a combination of the main quote text (cover letter written by the sales rep) and the quote details. The quote document is generated when you [create a new quote][7] or open an existing quote and select **Click to create quote document**. The document is generated in a .doc or .docx format, allowing for post-creation editing. It is automatically saved under the **Activities** tab in the sales record. It is also available via the link on the **Quote** section tab.

### Quote details template

The **quote details** template is [automatically merged](#usage) into the main quote document where the merge field `<<QuoteDetails>>` is placed. To generate the quote details document, click **Send** in the Quote screen. This opens a dialog where you can select the desired layout and choose which quote details template to use. The document is created in .pdf format and cannot be edited once generated.

![Quote details layout -screenshot][img3]

### Order confirmation template

To generate an **order confirmation** document, click the **Place Order** button. This opens a dialog where you can either select **Send order confirmation via email** or generate the document directly. The order confirmation template is selected based on the sales type and set in Settings and maintenance under **List** > **Sale – Type, Stages, Quote**. The document is created in .pdf format and cannot be edited after it is generated.

![Quote order confirmation template selection -screenshot][img4]

### Email text template for quote and order confirmation

When sending quotes or order confirmations via email, you can select an email text template. For quotes, click the **Send** button and choose the template from the **Email text** list. For order confirmations, click **Place order**, select **Send order confirmation via email**, choose the email text template and the language, then click **OK** to send.

![Quote send email -screenshot][img5]

![Quote send order confirmation -screenshot][img6]

## Merge fields in quote templates

**Merge fields** in SuperOffice CRM quote templates enable dynamic insertion of details such as product lines and alternatives. Unlike [standard template variables][1], merge fields follow a specific structure, or hierarchy, to ensure proper data integration.

You can customize quote and order confirmation templates using merge fields in Microsoft Word. Merge fields allow you to insert specific quote information into templates, while standard template variables retrieve customer data and other details.

### <a id="structure"></a>Structure of merge fields

Merge fields must follow a hierarchical order: quote > alternative > group > line. This structure is defined using **TableStart** and **TableEnd** fields, which delineate the start and end of each table area:

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

* quote: The outermost level, representing the entire quote.
* alternative: Nested within quote, used for different product alternatives.
* group: Nested within alternative, used to group products (optional).
* line: Nested within group, representing individual product lines.

> [!NOTE]
> Every template must conform to the nesting order and always start with the outermost level (quote). It need not go all the way down, but cannot start with alternative or anything else than quote.

### <a id="usage"></a>Usage of merge fields

Quote details include detailed information like lines, prices, and product names, typically placed in a separate template from the main quote document. If both the main document and quote details are used:

* If the `<<QuoteDetails>>` merge field is present in the main document, the quote details are inserted at that location.
* If the `<<QuoteDetails>>` merge field is not present, the quote details are appended at the end.

In both cases, a single PDF is generated and attached to the email.

Tags for a particular table are available from that table's TableStart: tag to its end.

**Example:**

[Line fields][2] (such as *line/name*) can only be placed within the line table (`«TableStart:line» «TableEnd:line»`), while alternative fields can be placed within both the alternative table and the underlying tables (group and line).

![Quote details example, TableStart:line -screenshot][img7]

### Grouping and sorting

**Grouping:** You can group products in the template using the **GroupBy** tag, with a line-level suffix, such as `GroupBy:productFamilyKey` to group products by their family.

* The GroupBy tag is case sensitive and can be placed anywhere in the document. At runtime, this tag will disappear without leaving any text.
* Only one GroupBy tag is allowed per template.

When a GroupBy tag is present, use **TableStart** and **TableEnd** to mark the beginning and end of group-related sections. The **group/groupField** tag will contain the value of the group field (for example, productFamily). The section between TableStart and TableEnd will repeat for each unique value of the group field.

* You can have multiple sets of TableStart and TableEnd sections. For example, you might want a summary table with totals and separate tables for the lines in each group. In this case, the summary table should not include an inner TableStart:line/TableEnd:line section.

Within the group (between TableStart and TableEnd), you can add fields that are specific to the group.

**Sorting:** By default, quote lines are listed in rank order, as seen in the quote line archives. If grouping is used, groups are sorted alphabetically, and the lines within each group are sorted by rank.

To change the order of quote lines, use the **OrderBy** tag, with a line-level suffix. For example, `OrderBy:name` sorts products alphabetically by name, and `OrderBy:vatInfo` sorts products by VAT status. Only one level of sorting is supported.

### <a id ="culture"></a>Formatting numeric and date data

Numeric and date fields can be formatted to match the selected language/culture settings (affecting the display order and separators):

* **Numeric fields:** For decimal values, you can specify the number of decimals (0, 2, or 5). For example, `line/totalPrice:2` ensures two decimal places. The decimal separator is always according to the selected language/culture.

* **Date and time fields:** Available formats include ShortDate, ShortTime, ShortDateTime, LongDate, LongTime, and LongDateTime. For example, `quote/sent:LongDateTime` for full date and time.

If no specific formatting is set, the default for the selected language is used.

The actual formatting (decimal separator, day/month order, and so on) reflects the user's selected culture, which is specified in the **Send Quote** and **Place Order** dialogs. For specific formatting needs, you can include the **Culture:** merge field in the template, specifying a [.NET culture code][11] (such as, `Culture:de-CH` for Swiss German) to override the user's choice. This implies that such a culture code should be embedded in a special template called *Offer to Swiss customers* or something similar.

> [!NOTE]
> Do not use the *Table of Language Culture Names, Codes, and ISO Values Method* of the [C++ AppConfig object][12] as a reference, there are slight differences.

By following these guidelines, you can effectively use merge fields to create detailed, customized quote and order confirmation templates in SuperOffice CRM.

## Related content

* [Update quote template][5]
* [Tutorial][6]
* [Merge field reference][3]
* [Template variable reference][4]
* [System.Globalization.CultureInfo][11]
* [Aspose][13] (handles document generation)

<!-- Referenced links -->
[1]: template-variables.md
[2]: ../merge-fields/line.md
[3]: ../merge-fields/index.md
[4]: ../variables/for-quote-line.md
[5]: ../admin/update-template.md
[6]: ../admin/tutorial.md
[7]: ../../../quote/learn/create.md
[11]: https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-5.0
[12]: https://docs.microsoft.com/en-us/previous-versions/commerce-server/ee825488(v=cs.20)
[13]: http://www.aspose.com

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/quote-list-document-template.png
[img2]: ../../../../media/loc/en/document/quote-list-email-template.png
[img3]: ../../../../media/loc/en/document/quote-layout.png
[img4]: ../../../../media/loc/en/document/quote-order-confirmation-template.png
[img5]: ../../../../media/loc/en/document/quote-send-email.png
[img6]: ../../../../media/loc/en/document/quote-send-confirmation.png
[img7]: ../../../../media/loc/en/document/tablestart-line.png
