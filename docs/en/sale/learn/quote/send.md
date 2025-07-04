---
uid: help-en-quote-send
title: Send a quote
description: Learn how to send, approve, and version quotes in SuperOffice CRM.
keywords: send quote, approve quote, edit sent quote, send, publish, approval, quote version, Attachments tab, quote
author: Bergfrid Dias
date: 04.09.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/quote/learn/approve
  - /en/quote/learn/send
  - /en/quote/learn/versions
---

# Send a quote

After you add products and create a quote document, you can send the quote to the customer. The quote is marked as **Sent** and locked for editing.

## Prepare the quote

1. Go to the **Quote** section tab on the sale and click **Open** to edit the quote.

1. Confirm the following:

    * All required product information is filled in.
    * The quote document is created.
    * Relevant attachments are selected in the **Attachments** tab (if required). These files will be included when you send the quote to the customer.
    * The correct alternative is set as the **Favorite alternative**.
    * No [warnings][4] are present.

> [!NOTE]
> You cannot send a quote if it has warnings, errors, or needs approval. The **Send** button appears dimmed until all issues are resolved.

## <a id="approve"></a>Approval required?

Some quotes must be approved before sending, for example, if the earnings are too low or a discount is too high. Approval requirements are set per sale type in Settings and maintenance. Go to **Settings and maintenance** > **Lists** > **Sale - Type, Stages, Quote**.

* If approval is required, the quote gets the status **Needs approval**
* A banner appears in the **Edit quote** dialog, and warning icons are shown

### To approve a quote

1. A user with approval rights opens the quote.

1. Click **Approve** or **Reject**.

1. The status updates to **Approved** (<i class="ph ph-check-square" aria-hidden="true"></i>) or **Rejected** (<i class="ph ph-x-square" aria-hidden="true"></i>).

## <a id="send"></a>Send the quote

1. In the **Edit quote** dialog, click **Send**.

    The **Publish/send a quote** dialog opens.

    ![Send quote dialog -screenshot][img1]

2. In the **Valid to** field, adjust the expiration date of the quote (default is 30 days).

3. Choose the **Quote layout** (template) and **Language** for the quote.

4. If the quote contains alternatives, you can select **Use favorite alternative only** to include just that one. Otherwise all alternatives are included in the quote.

5. In the **Publish** section, select how the quote should be delivered:

    * **Send as e-mail and archive as PDF** (select an e-mail template)
    * **Archive as PDF only** (you must send the quote separately)

6. (Optional) Select **Create follow-up**, then enter a note and select a follow-up date to create a reminder to yourself.

7. Click **Preview** to review the quote PDF.

8. Click **OK** to send and/or archive the quote.

    If sending by email, the **New email** dialog opens so you can customize the message.

### After sending

* The quote is marked as **Sent**.
* The current version is locked.
* The **State** includes the expiration date (for example: *Sent (Valid to - 5/3/2025)*).
* The icon changes from <i class="ph ph-pencil-simple" aria-label="Draft icon"></i> to an envelope (<i class="ph ph-envelope" aria-label="Sent icon"></i>).
* The PDF is archived in the **Activities** section tab.

    ![Quote section tab when quote has been sent -screenshot][img2]

## <a id="versions"></a>Edit a sent quote

After sending, the quote becomes read-only. To make changes (for example, in response to a customer request), you must create a new version.

1. Click **Open** on the **Quote** section tab.
2. In the **Edit quote** dialog, click **Edit**.
3. A new version is created with the status **Draft**. The previous version is archived (<i class="ph ph-folder-simple" aria-hidden="true"></i>).

You can toggle between versions using the **Version** dropdown at the top of the dialog.

> [!TIP]
> Changes in the new version do not affect the original. You must send the new version when ready.

## Related content

* [Create a quote document][1]
* [Replace the quote document][2]
* [Place an order][3]
* [Configure quote approval rules][5] in Settings and maintenance

<!-- Referenced links -->
[1]: create-quote-document.md
[2]: create-quote-document.md#replace
[3]: place-order.md
[4]: create.md#warning
[5]: ../../admin/sale-type.md#quote-fields

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/send-quote-dialog.png
[img2]: ../../../../media/loc/en/sale/sent-quote.png
