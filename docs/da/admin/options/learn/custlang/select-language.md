---
uid: help-da-languages-selection
title: Kundesprog til nye personer
description: Sådan vælger SuperOffice kundesprog til nye personer
author: SuperOffice RnD
date: 06.29.2022
keywords: sprog
topic: howto
language: da
---

# Sådan vælger SuperOffice kundesprog til nye personer

Når en ny person indsender en sag, forsøger SuperOffice at bestemme, hvilket kundesprog der skal vises for kunden.

## Scenarie 1

1. John, en ny person, registrerer en ny sag i kundecentret cs.liberty.com med e-mailadressen <john@coca-cola.se>.

2. Den nye sag sendes til systemets, hvor Johns e-maildomæne (coca-cola.se) bliver kontrolleret. coca-cola.se er registreret som domænenavn for firmaet Coca-Cola.

3. John tilføjes som ny person for Coca-Cola, i stedet for at blive tilføjet som en ny person uden et firma.

4. SuperOffice kontrollerer derefter, om e-maildomænet .se er knyttet til et af de registrerede kundesprog. .se er registreret som domæne for kundesproget svensk.

5. Kundesproget for personen John angives derfor som svensk.

6. SuperOffice sender en svensk svarskabelon (hvis denne er blevet oprettet) til John, om at sagen er modtaget og registreret.

7. John modtager et brugernavn og en adgangskode fra SuperOffice og kan logge på cs.liberty.com og få adgang til det svenske SuperOffice Customer Centre. John får også adgang til svenske FAQ'er, hvis de er konfigureret i SuperOffice.

## Scenarie 2

1. Maria, en ny person, registrerer en ny sag i kundecentret cs.liberty.com med e-mailadressen <maria@coca-cola.nl>.
2. SuperOffice kontrollerer e-maildomænet, som er registreret til firmaet Coca-Cola.
3. Maria tilføjes som ny person for Coca-Cola.
4. SuperOffice kontrollerer derefter, om e-maildomænet .nl er knyttet til et af de registrerede kundesprog. E-maildomænet .nl er *ikke* knyttet til et kundesprog, og derfor kan der ikke bestemmes noget kundesprog for Maria.
5. Maria får en svarskabelon på standardsproget for sit firma. SuperOffice Customer Centre og FAQ'er vises også på standardsproget.

## Scenarie 3

1. Hollandsk tilføjes som nyt kundesprog i SuperOffice og knyttes til domænet .nl.
2. Maria får ikke automatisk hollandsk som kundesprog. Dette skal gøres manuelt for personen. Kun nye personer kontrolleres mod nye kundesprog.
