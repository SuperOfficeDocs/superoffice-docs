# QuoteConnectorBase implementation

The QuoteConnectorBase implements most of the IQuoteConnector API and adds some useful default behavior to the basic API contract. For example – recalculate alternative is handled for you.

In addition to the IQuoteConnector interface, the base class adds a few public methods of its own.

ValidateQuoteVersion calls the **ValidateVersion** implementation method, which calls down the hierarchy in order.

## QuoteVersionResponseInfo ValidateVersion(QuoteVersionContextInfo context, bool clearOldValues = false)

Validates the version, looks for problems. Will typically change the Status and Reason fields.

Should for instance validate the alternatives and then concatenate the problems into the Status and reason fields.

## QuoteAlternativeWithLinesInfo ValidateAlternative(QuoteAlternativeWithLinesInfo quoteAlternativeWithLines, bool clearOldValues = false)

Check rules for the quote alternative and fill out the status and reason fields if there are one or more problems.

## QuoteLineInfo ValidateQuoteLine(QuoteLineInfo ql, bool clearOldValues = false)

Check rules for the quoteline and fill out the status and reason fields if there is a problem.

These functions are not part of the public API but are part of the connector base class’s implementation.

You need to supply your own:

* InitializeConnection
* CanProvideCapability
* OnAfterSaveQuote
* OnBeforeDeleteQuote
* FindProduct
* GetProduct
* GetProducts
* GetQuoteLinersFromProduct

The SuperOffice connector is built on top of the QuoteConnectorBase, but it is tightly coupled to the SoDatabase and SoCore assemblies. This means that if you sub-class the SuperOffice connector, you will break whenever a new version is released.

![42][img1]

<!-- Referenced images -->
[img1]: media/image042.png
