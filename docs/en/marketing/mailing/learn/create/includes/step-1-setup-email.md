<!-- markdownlint-disable-file MD041 -->
The first step in creating an e-mail mailing, is called **Setup**. Here you can set the e-mail header information such as sender, reply-to address and subject. You can also add attachments, set archive options for the mailing and select tracking options.

1. Enter a name in the **Name of mailing** field.

1. Enter the subject of the e-mail in the **E-mail subject** field.

1. In the **From** list, select **Always use** and enter the sender's e-mail address in the field below to use the same sender for all mailings. You can also choose a sales contact or support contact as the sender, if one is defined for this recipient. Enter an e-mail address to be used if no sales contact or support contact is available. If your admin has activated the [global e-mail validation preference][2], select the domain you want to send from in the drop-down list.

    > [!NOTE]
    > SuperOffice will conduct an SPF lookup to verify that the domain you are sending from has a valid SPF record. You will not be able to send the mailing from a domain that does not have a valid SPF record. (ONLINE ONLY)
    >
    > [What is Sender Policy Framework (SPF)?][20]

1. In the **Reply to** list, you have the same options as above. In addition, you can select **Use "From" as reply address**. Any replies will then be sent to the sender.

1. Select a folder to place the mailing in from the **Folder** list.

    [How do I create a mailing folder?][19]

1. In the **Selection** and **Project** fields, you can associate the mailing with a selection and/or a project. If you add a selection, any contacts in the selection are added as recipients in the mailing.

    [!include[Start typing to search](type-to-search.md)]

1. In the **Type** list, select the type of mailing you are creating. Select **(Any)** if the mailing matches two or more of the available types. Use **(Any)** after adding multiple recipients with multiple subscriptions and you want to send the mailing to all.

1. **Attachments**: To add one or more attachments to the mailing, use one of the following methods:

    * Click **Upload files (or drag here)** to browse to and add a file from a disk or server.
    * Drag and drop a file from Windows Explorer to the attachments field.
    * Click **Choose a CRM document** to select a document in SuperOffice CRM.

1. Under **Tracking** are the following options:

    [!include[Tracking options for mailing](mailing-tracking-options.md)]

1. Click **Next** to go to the next step.

## E-mail Domain Validation (ONLINE ONLY)

If your admin has activated the [global preference][2] **Only use approved e-mail domains**, the **From address** field will be split, and you need to select the domain you want to send from in the drop-down list of approved domains.
Attempting to send from a domain that does not have a valid SPF record will prompt a warning, and you will not be able to send from that domain. This applies to all e-mail domains even if the validation preference is not activated.

> [!NOTE]
> If the **Our contact address** has an e-mail domain that has not been validated, the mailing will automatically be sent from the address specified in the **Otherwise use** drop-down list options.

## Related topics

* [Maximize your email marketing success with these deliverability tips][1] - Community

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/email-deliverability-tips/
[2]: ../../../../../admin/lists/learn/add-items-to-mailing-domain.md
[19]: ../../../../learn/create-folder.md
[20]: https://docs.superoffice.com/en/email/mailgun/spf/index.html

<!-- Referenced images -->
