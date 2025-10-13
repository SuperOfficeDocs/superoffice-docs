---
uid: help-da-languages
title: Kundesprog
description: Kundesprog
keywords: sprog
author: digitaldiina
date: 10.09.2025
version: 11.5
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
category: localization
topic: language
redirect_from: /da/admin/options/learn/custlang/index
language: da
---

# Kundesprog

[!include[Requirement](../../learn/includes/req-cep.md)]

For at tilbyde en god kundeoplevelse skal du støtte dine kunder på deres lokale sprog, når de besøger dit kundecenter og i kommunikationen med kunden.

Ved at [oprette ekstra sprog][1] gør du det nemt for dine kunder at registrere, kommentere og kontrollere status for deres sager på deres foretrukne sprog. Derudover vil de have adgang til alle ofte stillede spørgsmål på deres valgte sprog.

## Sådan vælger SuperOffice kundesprog til nye personer

Når en ny person indsender en sag, forsøger SuperOffice at bestemme, hvilket kundesprog der skal vises for kunden.

### Scenarie 1

1. John, en ny person, registrerer en ny sag i kundecentret cs.liberty.com med e-mailadressen `john@coca-cola.se`.

2. Den nye sag sendes til systemets, hvor Johns e-maildomæne (coca-cola.se) bliver kontrolleret. coca-cola.se er registreret som domænenavn for firmaet Coca-Cola.

3. John tilføjes som ny person for Coca-Cola, i stedet for at blive tilføjet som en ny person uden et firma.

4. SuperOffice kontrollerer derefter, om e-maildomænet .se er knyttet til et af de registrerede kundesprog. .se er registreret som domæne for kundesproget svensk.

5. Kundesproget for personen John angives derfor som svensk.

6. SuperOffice sender en svensk svarskabelon (hvis denne er blevet oprettet) til John, om at sagen er modtaget og registreret.

7. John modtager et brugernavn og en adgangskode fra SuperOffice og kan logge på cs.liberty.com og få adgang til det svenske SuperOffice Customer Centre. John får også adgang til svenske FAQ'er, hvis de er konfigureret i SuperOffice.

### Scenarie 2

1. Maria, en ny person, registrerer en ny sag i kundecentret cs.liberty.com med e-mailadressen `maria@coca-cola.nl`.
2. SuperOffice kontrollerer e-maildomænet, som er registreret til firmaet Coca-Cola.
3. Maria tilføjes som ny person for Coca-Cola.
4. SuperOffice kontrollerer derefter, om e-maildomænet .nl er knyttet til et af de registrerede kundesprog. E-maildomænet .nl er *ikke* knyttet til et kundesprog, og derfor kan der ikke bestemmes noget kundesprog for Maria.
5. Maria får en svarskabelon på standardsproget for sit firma. SuperOffice Customer Centre og FAQ'er vises også på standardsproget.

### Scenarie 3

1. Hollandsk tilføjes som nyt kundesprog i SuperOffice og knyttes til domænet .nl.
2. Maria får ikke automatisk hollandsk som kundesprog. Dette skal gøres manuelt for personen. Kun nye personer kontrolleres mod nye kundesprog.

På installationstidspunktet blev der oprettet 6 mapper for kundesprog (DE, DK, EN, NL og NO) i mappen **\\skabeloner** på serveren. Du skal selv konfigurere disse kundesprog.

<!-- Referenced links -->
[1]: ../admin/add-customer-language.md

<!-- Referenced images -->
