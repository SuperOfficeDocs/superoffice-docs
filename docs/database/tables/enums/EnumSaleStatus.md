<properties generated="1" SortOrder="990" />

# SaleStatus Enum

Sale status: 0 = Unknown, 1 = open, 2 = closed, 3 = lost, 4 = all sales

* Unknown = 0
* Open = 1
* Sold = 2
* Lost = 3
* Stalled = 4
* SaintAll = 1000

## Usage
* [sale](sale.md).status - Sales  For every Sale record edited through the SuperOffice GUI, a copy of the previous version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.  
* [SaleHist](SaleHist.md).status - Mirror image of the Sale table, providing a full transaction history. Every time you edit a sale, the previous record of the sale is moved here. 
* [CounterValue](CounterValue.md).sale_status - Visible for rights

