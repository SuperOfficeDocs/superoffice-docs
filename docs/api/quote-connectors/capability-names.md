---
title: quote_connectors_capability_names      
description: Quote connector capability names
author: {github-id}             # Your GitHub alias.
so.date:
keywords: quote
so.topic: reference
---

# Capability names

| Capability | Description |
|---|---|
| iproductprovider_provide_cost | Can the Product Provider fill in the Cost price value?<br>Determines if the Cost field is shown in the GUI. |
| iproductprovider_provide_minimumprice | Can the Product Provider fill in the Minimum price value? Determines if the Minimum Price field is shown in the GUI. |
| iproductprovider_provide_stockdata | Can the product provider supply Stock data?<br>Determines whether the Stock values are shown in the GUI or not. |
| iproductprovider_provide_extradata | Does the Product Provider fill in any ExtraData. Determines if the extra data fields are shown in the GUI. |
| iproductprovider_provide_thumbnails | Can the Product Provider supply thumbnails of products? |
| iproductprovider_provide_picture | Can the Product Provider supply any pictures? Determines if the picture field is shown in the dialog. |
| ipriceprovider_compute_price | Can the connector calculate a price value for a quote? If the ERP system is not available (on travel) then the connector might fall back on the list price. |
| iorderconsumer_place_order | Can the connector place orders?<br>If not then the PlaceOrder method is not called.<br> The ACCEPT button and the PlaceOrder dialog is still shown, but the connector is not called. |
| iorderconsumer_provide_orderstate | Can the connector check order status in the ERP system. If the capability is FALSE, then no GET STATUS button appears after an order has been accepted. |
| ilistprovider_provide_productcategorylist | Can the connector provide the Product category list? |
| ilistprovider_provide_productfamilylist | Can the connector provide the Product family list? |
| ilistprovider_provide_producttypelist | Can the connector provide the Product type list? |
| ilistprovider_provide_paymenttermslist | Can the connector provide the Payment terms list? |
| ilistprovider_provide_paymenttypelist | Can the connector provide the Payment type list? |
| ilistprovider_provide_deliverytermslist | Can the connector provide the Delivery terms list? |
| ilistprovider_provide_deliverytypelist | Can the connector provide the Delivery type list? |
| iconnector_perform_complexsearch | Can the connector perform a complex search? Will make the UI show the advanced find button. |
| iaddressprovider_provide_addresses | Can the connector provide addresses at all? |
