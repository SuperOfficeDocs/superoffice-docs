<properties generated="1" SortOrder="990" />

# SaleDone Enum

Done (0=don&apos;t know, 1 = No, 2=Yes)

* Unknown = 0
* NotDone = 1
* Done = 2

## Usage
* [sale](sale.md).done - Sales  For every Sale record edited through the SuperOffice GUI, a copy of the previous version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.  
* [SaleHist](SaleHist.md).done - Mirror image of the Sale table, providing a full transaction history. Every time you edit a sale, the previous record of the sale is moved here. 

