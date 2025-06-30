<!-- markdownlint-disable-file MD041 MD034 -->
When creating a mailing, you must select the recipients of the mailing. You can add recipients from multiple sources. In addition, you can set various mailing options here and also preview the mailing.

Your target list is the group of people you believe will respond best to your message. If you tailor your marketing message specifically to that group, you get a better chance of success and avoid wasting time and effort on people who are not interested.

You can use selections, projects or add single contacts in SuperOffice CRM.

Due to the GDPR legislation, only the contacts that have expressed consent to be legally saved in SuperOffice CRM database and receive information can be added as recipients.

![You can add your recipients from either selection, project, a single contact or an external list that you need to import -screenshot][img3]

### Add recipients from selections and projects

You can add recipients from selections (from both SuperOffice CRM and SuperOffice Service) and projects (from SuperOffice CRM).

1. Under **Add recipients**, click **Selection** or **Project**.

2. Click in the field below and start typing the name of the selection or project you want to add. As you type, a dynamic list displays the matches.

3. Click a selection or a project in the list.

4. Click **+**. The selection or project is added to the **Recipient sources** list, and the **Recipients** list is updated.

5. Repeat steps 1-4 to add more selections or projects.

> [!NOTE]
> If you selected a selection under **Archive mailing** in **Setup** (step 1), this selection is listed under **Recipient sources**. You can delete this selection if necessary.

### Add contacts from SuperOffice

You can add individual contacts from SuperOffice.

1. Under **Add recipients**, click **Contact**.

2. Click in the field below and start typing the name of the contact you want to add, in the field below. You can also enter a company name to display all contacts for a company.

3. Select the contact you want from the list that appears.

4. Click **+**. The contact is added to the **Recipient sources** list, and the **Recipients** list is updated.

5. Repeat steps 2-5 to add more contacts. Additional contacts will be added to the same row in the **Recipient sources** list, and the number of contacts will display in the **Name** column.

### Import a list of recipients (contacts) from an external file

You can add recipients to a mailing by importing them from an external comma-separated file (for example a .txt file created in Notepad or a .csv file created in Excel).

When you import a list of names and email addresses, SuperOffice Marketing will try to locate the imported recipients in the SuperOffice database. If matches are found, the recipients' companies are listed in the **Company** column in the **Recipients** list. Any names or email addresses that are **not** found in SuperOffice, are filtered out and not included in the mailing. This is due to GDPR regulations.

#### Steps

1. Click **Select file**.

2. Locate the relevant file (.txt, .csv or similar text format).

3. Click **+**. The list is added to the **Recipient sources** list, and the **Recipients** list is updated.

4. Repeat steps 2-4 to add more recipients. Additional recipients will be added to the same row in the **Recipient sources** list. The total number of recipients will display in the **Name** column.

> [!NOTE]
> Import is not available for document mailings.

#### Import file format

* Each recipient must be on its own line (row).

* Each recipient (row) consist of the full name and email address.

    Example: "John Smith, john@company.com"

    > [!NOTE]
    > You can also specify just the email address. The name will then not be available as a template variable.

* Onsite: Each recipient (row) can also contain a mobile phone number (after the email address) if you are creating SMS mailings. For example: "John Smith, john@company.com, 99999999". Requires the Marketing SMS licence.

> [!NOTE]
> If you only have the mobile phone number and want to send an SMS, you can enter the following: " , , 99887766".

### Recipient options

Under **Options** in the lower part of the **Recipients** screen, you can select options for the mailing based on its type.

**Availability per mailing type:**

| Option | Document | Email | SMS |
|---|:-:|:-:|:-:|
| Override consent and subscription | x | x | x |
| Only one message per email address | | x | x |
| Update recipient list when sending | | x | x |
| Include companies | x | x | |
| Prefer company | x | x | |

* **Override consent and subscription**: Select this option to also send the mailing to contacts who have not given their consent to receiving e-marketing or are not subscribing to this mailing type. These contacts are listed with the status **No consent** in the **Recipients** list.

* **Only one message per email address**: Select this option to remove duplicate email addresses in the recipient list (indicated by **Duplicate** in the **Status** column). This will update the **Recipients** list.

* **Update recipient list when sending**: Select this option to automatically update the recipients list before sending the mailing. See **Update recipients list** below.

* **Include companies**: Select this option to include companies as recipients.

    > [!NOTE]
    > If a company has no email address, the mailing will instead be sent to all related contacts in the recipient list.

* **Prefer company**: Select this option to send the mailing only to the companies in the recipient list (and not the related contacts). Each company will only receive one mailing. Contacts that do not belong to a company, will still receive the mailing.

    > [!NOTE]
    > The **Prefer company** option is only available if you selected **Include companies** above.

### Preview the mailing

After adding recipients to the **Recipients** list, you can preview the mailing as it will look for one of the recipients. Preview is not available for document and SMS mailings.

> [!NOTE]
> The mailing will **not** be sent to the recipient when previewing.

1. Click a recipient in the **Recipients** list.

2. Click the **Preview** button. The **Preview** window displays the mailing as it will look for the selected recipient. Any template variables (for example, name and company) are replaced by actual contact data.

3. Click links to check that they work, but remember to reset them if they are tracked.

4. Click X to close the **Preview** window.

### Review and update the Recipients list

When you add selections, projects, contacts and import lists, the **Recipients** list is automatically updated. If you selected **Update recipient list when sending**, the projects and selections are checked before sending the mailing, if contacts were added, removed or edited.

In addition, you can click the **Update list** button below the **Recipients** list to update the list manually. Some of the contacts on the list might have changed their consent after you added them.

> [!NOTE]
> The list displays only the first 50 recipients. Click **Load all** at the bottom of the list to display all recipients.

Click **Next** to go to Step 5: Confirm. You can still revisit the **Recipients** step to edit the recipients list.

<!-- Referenced images -->
[img3]: ../../../../../../media/loc/en/marketing/add-target-list.png
