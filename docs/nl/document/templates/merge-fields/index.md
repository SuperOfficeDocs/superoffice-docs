---
uid: help-nl-mergefield-ref
title: Referentie voor samenvoegvelden
description: Referentie voor samenvoegvelden
keywords: amenvoegveld, BTW
author: Bergfrid Dias
date: 07.31.2024
version: 10.3
content_type: reference
language: nl
index: true
---

# Referentie voor samenvoegvelden

> [!NOTE]
> Nummers, datums en tijden zijn [cultuurgevoelig][2].
>
> Als documenten zijn opgeslagen in Google Drive, worden samenvoegvelden niet ondersteund.

## BTW

Wanneer u de BTW correct wilt berekenen, moet u eerst ALLE kortingen aftrekken, inclusief alternatieve korting (bestelkorting). Dit moet voor elke offertelijn (product) worden gedaan.

We noemen dit de "Totale prijs met alternatieve korting".

We vermenigvuldigen de "Totale prijs met alternatieve korting" met de BTW (-Percentage). Het resulterende bedrag noemen we **VATAmount**.

Deze waarden worden opgeteld in het VATAmount-veld van het alternatief.

Ten slotte worden de TotalPrice van het alternatief en het VATAmount van het alternatief opgeteld in het veld dat we **TotalPriceIncVAT** noemen.

<!-- Referenced links -->
[2]: ../learn/quote-templates.md#culture
