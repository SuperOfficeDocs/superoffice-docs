---
uid: help-en-selection-board-view
title: Use board view in selections
description: Visualize selections using board view with grouping, filters, and drag-and-drop cards
keywords: board view, selection view, selection, sales board, project board, request board, kanban, group by, filter toolbar, sale date badge, days in stage, days since registered
author: digitaldiina
date: 12.02.2025
version: 11.7
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Use board view in selections <i class="ph ph-kanban" aria-hidden="true"></i>

Board view presents your [selection][2] in a column-based layout using cards. You can group and filter the selection members (records shown on the board), and use drag-and-drop to move cards between groups.

The functionality is the same across supported entities: you can drag cards, open task menus, and adjust board settings. The available grouping and filtering fields vary depending on whether you are working with company, contact, sales, projects, or requests.

![Board view showing sales grouped by stage -screenshot][img2]

## Open board view

1. Go to a selection.

1. In the upper-right corner, select the **board view** icon (<i class="ph ph-kanban" aria-label="Kanban board"></i>).

    ![Board view toggle icon in the upper-right corner of a selection][img1]

1. If your selection contains companies and contacts, the board view will only show one entity type at a time. To switch, click <i class="ph ph-gear-six" aria-label="Settings"></i>, then use the **View entity** dropdown to choose *Company* or *Contact*.

## Work with cards

* Click the card title to open the full record (for example, a sale card).

* Hover over a name or company to preview contact details.

    ![Hover preview showing contact details on a card -screenshot][img3]

* Drag cards between columns to update the grouping field (such as stage or owner).
  * If subgroups are enabled, you can also drag cards between rows.

* Click a card to view its details in the [side panel][11]. (Enable the preview by selecting it from the drop-down menu at the top of the side panel).

    ![Side panel preview showing project details -screenshot][img12]

* To edit a card, point to it and select the **Edit** button (<i class="ph ph-pencil" aria-hidden="true"></i>). This opens the same edit dialog used elsewhere in SuperOffice CRM—without leaving the board view.

  ![Cursor pointing to the edit button on a sale card -screenshot][img4]

* For more options, point to the card to reveal the **Task** menu (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>), then select it and choose from the available actions.

  * **Sales:** Edit, Create follow-up, Mark as sold/lost, Delete
  * **Projects:** Edit, Create follow-up, Create document, Mark as completed, Delete
  * **Requests:** Edit, Close request, Delete
  * **Company:** Edit, Create follow-up, Create sale, Move to next category, Delete
  * **Contact:** Edit, Create follow-up, Create sale, Delete

  ![Open task menu on a sale in board view showing available options -screenshot][img5]

<!-- markdownlint-disable-next-line MD013 -->
## Customize board layout <i class="ph ph-gear-six" aria-hidden="true"></i> <i class="ph ph-sliders-horizontal" aria-hidden="true"></i>

### Group and subgroup

To choose which columns appear:

1. Select the **settings** icon (<i class="ph ph-gear-six" aria-hidden="true"></i>).

1. Select **Group by**.

    ![Board view settings panel for sales selections showing grouping options -screenshot][img6]

1. Choose a field to define the column layout.

    ![Group-by menu showing available sales fields such as Stage and Owner -screenshot][img7]

1. Select the back arrow (<i class="ph ph-caret-left" aria-hidden="true"></i>) to return to the settings overview.

1. Optionally, choose a **Subgroup by** value to organize cards into separate rows within each column.

1. Optionally, select **Save settings for current selection only** to apply changes only to this board view.

1. Select **Done** to apply your settings.

Examples of grouping fields:

* **Sales:** Stage, Sale type, Owner
* **Projects:** Status, Responsible, Type
* **Requests:** Status, Request type, Priority, Owner
* **Company:** Category, Our contact
* **Contact:** Category, Our contact, Lead status

### Sort cards in columns

Use the settings panel (<i class="ph ph-gear-six" aria-hidden="true"></i>) to configure **Sort by** and **Sort order**, such as by sale date.

### Set filters

1. Select <i class="ph ph-sliders-horizontal" aria-label="Toggle filter toolbar"></i> to show the filter toolbar.

    ![Filter toolbar in a sales selection board view -screenshot][img9]

1. To choose which filters are available:

    1. Click <i class="ph ph-gear-six" aria-hidden="true"></i> to open the Settings panel.
    1. Select **Filter toolbar** and enable filters using the checkboxes.
    1. Click the back arrow (<i class="ph ph-caret-left" aria-hidden="true"></i>) to return to the main settings and then click **Done**.

    ![Filter settings showing available sales fields such as Stage and Owner -screenshot][img8]

1. In the toolbar, expand a filter (for example, **Owner**) to show a list of items.

    * Select or deselect items to include them.
    * Select **Clear** at the bottom of a dropdown to reset that filter.
    * Select the **X** on the right edge of the toolbar to reset **all** filters at once.

    ![Filter toolbar, sale type expanded -screenshot][img10]

Examples of filters:

* **Sales:** Sale type, Owner, Stage, Next activity, Sale date
* **Projects:** Type, Responsible, Status, Next milestone, End date
* **Requests:** Request category, Owner, Status, Created, Deadline, Priority
* **Company:** Our contact, Registered date, Next activity, Category, Country
* **Contact:** Our contact, Owner group, Registered date, Next activity, Lead status, Category, Country

### Summarize (sales only)

You can display totals for numeric fields in the board view for sales.

1. Select <i class="ph ph-gear-six" aria-hidden="true"></i> to open the Settings panel.
2. Select **Summarize by**.
3. Choose a numeric field, such as **Amount** or **Weighted amount**.

The total value appears **next to each column name**, helping you track value distribution across stages, owners, or other grouping fields.

![Sales board view showing summarized values for amount next to each column name -screenshot][img11]

### Sale date badge (sales only)

You can control what the **gray badge** on each sale card shows in the board view. This helps you understand aging at a glance—either how long a sale has been open or how long it has stayed in its current stage.

1. Select <i class="ph ph-gear-six" aria-hidden="true"></i> to open the **Settings** panel.

    ![Sales board settings panel showing options for grouping, sorting, summarizing, filters, sale date badge, and hide closed sales. -screenshot][img13]

1. Select **Sale date badge**.

1. Choose one of the following options:

    * **Days in stage:** Shows how many days the sale has stayed in its current stage.
    * **Days since registered:** Shows how long ago the sale was created.

    ![Sale date badge settings dialog with the options Days in stage and Days since registered. -screenshot][img14]

The selected metric appears as a **gray badge** on every sale in the board view. A **red badge** is still used to mark overdue sales.

## Use cases

Board view supports different roles and workflows. Here are examples for sales representatives, project members, support agents, and managers:

### Sales representatives

* **Visualize your open sales** and track where each opportunity is in the pipeline.
* **Drag a card to another column** to update the sale stage.
* **Filter by sale date** to focus on what needs attention now.
* **Open the task menu** to create a follow-up, or mark a sale as sold or lost.
* **Quickly edit a card** to update details, such as a new contact person.

### Sales managers

* **Visualize the entire pipeline** and understand the distribution of sales across stages.
* **Summarize by amount** to support forecasting.
* **Filter by sale type** to focus on new business or specific campaign types.
* **Group by owner** to check workload per sales rep and rebalance using drag and drop.
* **Use stage as group and sale type as subgroup** to get a strategic overview by category and phase.

### Project members

* **Visualize your active projects** and track progress through different statuses.
* **Drag a card to another column** to update the project status.
* **Filter by next milestone or end date** to focus on urgent deliverables.
* **Group by responsible** to see ownership of projects across the team.
* **Open the task menu** to create a follow-up or document, or to mark the project as completed.

### Project managers

* **Get a full overview of all projects** to monitor status and identify delays.
* **Summarize by type** to compare customer projects, internal initiatives, or development work.
* **Filter by responsible** to balance workload among team members.
* **Group by status** to see how projects move through phases, or by type to align with business priorities.

### Support agents

* **Visualize your assigned requests** and track them across statuses such as new, in progress, and closed.
* **Drag a card to another column** to update the request status.
* **Filter by deadline or priority** to work on urgent cases first.
* **Group by status** to follow progress, or by request type to focus on specific categories.
* **Open the task menu** to close the request.

### Support managers

* **Get a full overview of incoming requests** and see distribution by status.
* **Summarize by priority** to ensure high-importance requests are handled quickly.
* **Filter by category or created date** to analyze trends in customer issues.
* **Group by owner** to monitor workload across agents and reassign requests as needed.
* **Use status as group and priority as subgroup** to get a structured overview for analysis and reporting.

Use grouping creatively to organize and act on data efficiently.

## Troubleshooting and tips

* **New sales are missing:** Click <i class="ph ph-arrow-clockwise" aria-label="Refresh icon"></i> to reload the board view and fetch the latest data.

* **Filter toolbar not visible:** Toggle the filter toolbar on or off using the <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> icon.

* **A column is empty:** You may have filtered out its contents. Check the active filters in the toolbar.

* **Cannot find a filter field:** Open **Settings** (<i class="ph ph-gear-six" aria-hidden="true"></i>) > **Filter toolbar** and enable the field you want to use.

* **Need to edit the selection itself (not a card)?** Click <i class="ph ph-subtract-square" aria-label="Selection icon"></i> to return to selection view. Edit and task buttons for the selection are not available in board view.

* **Search the board by name:** Use the **Filter by title** field at the top to narrow down visible cards by name.

* **Save layout per use case:** Select **Save settings for current selection only** if you want to preserve a specific board layout, filters, or grouping for one selection only.

## Related content

* [Create a selection][1]
* [Create a sale / fields in the Sale card][12]
* [Configure sale stages][13]
* [Create a request / request properties][14]
* [Create request status][15]
* [Create request category][16]
* [Create a project / fields in the Project card][17]
* [Configure project status][18]
* [Configure project types][19]

<!-- Referenced links -->
[1]: create.md
[2]: index.md
[11]: ../../../learn/getting-started/main-screen/side-panel.md
[12]: ../../../sale/learn/create.md
[13]: ../../../sale/admin/sale-stage.md
[14]: ../../../request/learn/create.md
[15]: ../../../request/admin/status/create.md
[16]: ../../../request/admin/category/create.md
[17]: ../../../project/learn/create.md
[18]: ../../../project/admin/project-status.md
[19]: ../../../project/admin/project-type.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/search-options/board-view-toggle.png
[img2]: ../../../../media/loc/en/search-options/board-view.png
[img3]: ../../../../media/loc/en/search-options/board-view-preview-contact-on-hover.png
[img4]: ../../../../media/loc/en/search-options/board-view-card-edit-icon.png
[img5]: ../../../../media/loc/en/search-options/board-view-card-task-menu.png
[img6]: ../../../../media/loc/en/search-options/board-view-settings.png
[img7]: ../../../../media/loc/en/search-options/board-view-settings-group-by.png
[img8]: ../../../../media/loc/en/search-options/board-view-settings-filter.png
[img9]: ../../../../media/loc/en/search-options/board-view-filter-toolbar.png
[img10]: ../../../../media/loc/en/search-options/board-view-filter-on-sale-type.png
[img11]: ../../../../media/loc/en/search-options/board-view-summarized-sale-amount-per-column.png
[img12]: ../../../../media/loc/en/search-options/selection-board-view-project-preview.png
[img13]: ../../../../media/loc/en/search-options/board-view-settings-for-sales.png
[img14]: ../../../../media/loc/en/search-options/sale-date-badge-setting.png
