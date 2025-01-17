<!-- markdownlint-disable-file MD041 -->
> [!TIP]
> To view and print an existing document mailing, close the **Setup** step (click **Cancel** or **Save + Close**). Select the **Mailings** tab, locate the document, click ![icon][img1] and select **View**. Click the button under **Download generated document**. The document is downloaded to your browser. Open and print the document.

Using the document mailing workflow you can generate a PDF document to print and send to your customers. The first step in creating a document mailing, is called **Setup**. Here you can set the name of the mailing, the heading and attention text in the document, and set archive options for the mailing.

You can connect the document mailing to a specific project. This can be relevant if you are creating mailings where the recipients are project members from a SuperOffice CRM project. By using template variables in the template, you can add project data to your mailing.

You can connect the document mailing to a specific sale. This can be relevant if you are creating mailings where the recipients are sale stakeholders from a SuperOffice CRM sale. By using template variables in the template, you can add sales data to your mailing.

**Steps:**

1. Enter a name in the **Name of mailing** field.

2. In the **Heading** field, enter the document title.

3. In the **Attention** field, you must select to whom the mailing should be directed. Select one of the following options:

    * **If none defined**: Select this option to use the recipients' names by default, or, if no recipient name is found, use the recipient you enter in the text field. If you are creating a mailing directed at IT professionals in a company, you can enter "IT department" or similar.

    * **Use always**: Select this option to override the recipients' names and only use the recipient you enter in the text field.

4. Optional: Start writing in the **Project** field to search for a SuperOffice CRM project.

5. Optional: Start writing in the **Sale** field to search for a SuperOffice CRM sale.

6. In the **Our ref** field, enter the name that should appear as our reference in the document. You can use SuperOffice CRM [template variables][1] in this field.

    > [!NOTE]
    > For variables such as sale ID or project ID to work, you must link the document mailing to a sale or project.

7. Select a folder to place the mailing in from the **Folder** list.

    [How do I create a mailing folder?][19]

8. In the **Selection** and **Project** fields, you can associate the mailing with a selection and/or a project.

    [!include[Start typing to search](type-to-search.md)]

9. Click **Next** to go to the next step.

> [!TIP]
> Click the **Save + close** button to save the mailing and close it. You can continue working on the mailing later.

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/index.html
[19]: ../../../../learn/create-folder.md

<!-- Referenced images -->
[img1]: ../../../../../../media/icons/btn-menu.png
