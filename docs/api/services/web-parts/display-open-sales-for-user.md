---
# Mandatory fields.
title: display_open_sales_for_user       # (Required) Very important for SEO.
description: Display the open sales of this user in web parts # (Required) Important for SEO.including spaces.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Display the open sales of this user in web parts

Here we are using web parts and displaying the open sales [for the authenticated user][1]. The code below shows how this is done.

## Set up WebPartManager and zones for the Sales page

```html
<div>
  <asp:WebPartManager ID="WebPartManager1" runat="server">
  </asp:WebPartManager>&nbsp; &nbsp;
    <asp:CatalogZone ID="Catalog" runat="server" BackColor="#E0E0E0" BorderColor="Cyan" BorderStyle="Double" Height="71px"
      Style="z-index: 102; left: 172px; position: absolute; top: 436px" Width="393px">
      <ZoneTemplate>
        <asp:PageCatalogPart ID="PageCatalog" runat="server" />
      </ZoneTemplate>
    </asp:CatalogZone>
</div>
<asp:WebPartZone ID="SalesZone" runat="server" Height="336px" Style="z-index: 101;left: 81px; position: absolute; top: 48px" Width="556px" BorderColor="Blue">
  <ZoneTemplate>
    <asp:Table ID="tblSale" runat="server" Height="230px" Caption="Sales" BorderColor="Blue" CaptionAlign="Top" Width="454px">
    </asp:Table>
  </ZoneTemplate>
</asp:WebPartZone>
```

Below is an image of the **Sales** page.

![03][img1]

> [!NOTE]
> You have the option to minimize or close the sales table. If you close it, you can restore using the Page catalog.

## Retrieve sales data and populate page

```csharp
using System.Collections.Generic;
using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.Security.Principal;
using SuperOffice.CRM.ArchiveLists;

public partial class SalesData : System.Web.UI.Page
{
  SoSession mySession;
  protected void Page_Load(object sender, EventArgs e)
  {
    if (Session["MySession"]==null)
    {
      //Redirect to login page
      Response.Redirect("Default.aspx");
    }

    if (Session["MySession"] != null)
    {
      using(mySession = SoSession.Continue((string)Session["MySession"]))
      {
        //Set the web part mangers to Catalog Display Mode
        WebPartManager1.DisplayMode = WebPartManager.CatalogDisplayMode;

        //Set the Parameters of the Provider
        //Parameter - Archive provider
        string archiveProviderName = "sale";

        //Parameter - columns - An array of the names of the columns wanted.
        string[] archiveColumns = new string[] { "saleId", "associate/associateDbId", "personId", "saleDate", "amount", "saleStatus" };

        //Parameter - sortOrder - Sort order for the archive
        ArchiveOrderByInfo[] archiveSrtOrd = new ArchiveOrderByInfo[1];
        archiveSrtOrd[0] = new ArchiveOrderByInfo("saleId", SuperOffice.Util.OrderBySortType.ASC);

        //Parameter - restriction - Archive restrictions
        ArchiveRestrictionInfo[] archiveRest = new ArchiveRestrictionInfo[2];

        //restriction 1 - sale.status=open(1)
        archiveRest[0] = new ArchiveRestrictionInfo("saleStatus", "=", "1");

        //restriction 2 - sale.associate= current user
        archiveRest[1] = new ArchiveRestrictionInfo("associate/associateDbId", "=", SoContext.CurrentPrincipal.AssociateId.ToString());

        //Parameter - entities - Which entities to include
        string[] desiredEntities = { "sale" };

        //Parameter - page - Page number, page 0 is the first page
        int page = 0;

        //Parameter - pageSize - Page size
        int pageSize = 10;

        //Initializing an Archive Agent
        using(ArchiveAgent newArcAgt = new ArchiveAgent())
        {
          // Get a page of results for an archive list, explicitly specifying the restrictions, orderby and chosen columns
          ArchiveListItem[] arcLstItm = newArcAgt.GetArchiveListByColumns(archiveProviderName, archiveColumns, archiveSrtOrd, archiveRest, desiredEntities,page,  pageSize);

          //Display the result in the table
          int rowNo = 1;

          foreach (ArchiveListItem archiveRow in arcLstItm)
          {
            if (rowNo == 1)
            {
              TableRow tbRow = new TableRow();
              foreach (KeyValuePair<string, ArchiveColumnData> column in archiveRow.ColumnData)
              {
                TableCell tbCell = new TableCell();
                tbCell.Text = column.Key + "\t";
                tbRow.Cells.Add(tbCell);
              }
              tblSale.Rows.Add(tbRow);
            }

            // extract and display the displayValue of each cell
            // (you need to parse culturally sensitive values such as dates to get the correct client display format)
            TableRow tbRow2 = new TableRow();
            foreach (ArchiveColumnData archiveCell in archiveRow.ColumnData.Values)
            {
              TableCell newCell = new TableCell();
              newCell.Text = archiveCell.DisplayValue + "\t";
              tbRow2.Cells.Add(newCell);
            }
            tblSale.Rows.Add(tbRow2);
            ++rowNo;
          }
        }
      }
    }
  }
}
```

In the example, we have first added a web-part manager, web-part zone, and a catalog zone to the **Sales** page. Then a table is added to the web-part zone. When user control is added to a web-part zone it will become a web part.

In the code, we have first set the `WebPartManager`’s display mode to catalog display mode. Then the [archive service][2] is used to retrieve sale data. Finally, the retrieved data is added to the table.

<!-- Referenced links -->
[1]: authenticate-user.md
[2]: ../../search/iarchiveagent/iarchiveagent.md

<!-- Referenced images -->
[img1]: media/image003.jpg
