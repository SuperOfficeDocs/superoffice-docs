---
uid: help-en-quote-create-document
title: Create a quote document
description: Create a quote document for your SuperOffice Quote proposal to send to the customer.
keywords: create quote document, change quote document, quote document, quote
author: Bergfrid Dias
date: 04.09.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: /en/quote/learn/create-quote-document
---

# Create a quote document

After you have created the quote and added the products, you can generate the quote document. This is the "letter" that is sent to the customer. The list of products that are being offered is added when the quote is sent to the customer.

You can create the document either from the **Quote** section tab of a sale or from inside the **Edit quote** dialog.

> [!TIP]
> Use [a template with quote-specific merge fields][3] to include quote details in the document.

## Create the quote document

1. If you are already editing the quote, click **Click to create quote document** at the top of the **Edit quote** dialog.

    *Otherwise*, go to the **Quote** section tab on the sale and click **Click to create quote document**.

    > [!NOTE]
    > The quote must be in **Draft** state. If it is already sent, [create a new version][1] first.

1. In the **Document** dialog, [complete the required fields][2].

1. Click **Create** to create a new document based on the selected template.

1. Edit the content in Word (or other default editor), then save and close the file.

    The document appears on the **Quote** section tab and is linked to the quote. It is also listed in the **Activities** section tab on the sale (and in the Company and Diary screens).

## <a id="replace"></a>Replace the quote document

To change the contents or template used for a quote document, choose one of the following options:

### Option 1: Replace the file only

Use this method if you want to keep the document metadata but upload a revised file from your computer.

1. On the **Quote** section tab, click the document.

1. In the document dialog, uncheck **Completed**.

1. Click **Replace**, select the new file, and upload it.

1. Click **Save**.

### Option 2: Delete and re-create the document

Use this method if you want to discard the quote document and start from scratch.

1. On the **Quote** section tab, click the existing document.

1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Delete** from the **Task** menu.

1. Click **Click to create quote document** to generate a new file.

### Option 3: Create and link a new document

Use this method to manually create a new document using your preferred template, then associate it with the quote. This preserves the existing quote document.

1. Click **New** on the top bar and select **Document**.

1. In the **Document** dialog, select a quote template, choose the sale you want to link it to, and click **Create**.

1. Go to the **Quote** section tab on the sale and click **Open**.

1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Change quote document** from the **Task** menu.

1. Select the new document from the list.

    The list shows all quote documents registered for the current sale.

> [!TIP]
> For minor changes, open the existing document, make edits, and save. No need to replace the file or delete the document.

## How quote templates work

The templates for quote documents, quote details, and order confirmations differ from ordinary document templates. They use **merge fields** in addition to standard template variables.

* If the `<<QuoteDetails>>` merge field is present in the main document, the quote details are inserted at that location.
* If the `<<QuoteDetails>>` merge field is not present, the quote details are appended at the end.

## Related content

* [Send a quote][4]
* [Place an order][5]
* [Edit a document][2]
* [Quote document templates][6]
* [Template variables and merge fields][3]

<!-- Referenced links -->
[1]: send.md#versions
[2]: ../../../document/learn/edit.md
[3]: ../../../document/templates/merge-fields/quote.md
[6]: ../../../document/templates/learn/quote-templates.md
[4]: send.md
[5]: place-order.md
