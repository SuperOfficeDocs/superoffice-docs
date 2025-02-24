---
uid: help-sv-languages-selection
title: Kundspråk för nya kontakter
description: Så väljer SuperOffice kundspråk för nya kontakter
author: SuperOffice RnD
date: 06.29.2022
keywords: språk
topic: howto
language: sv
---

# Så väljer SuperOffice kundspråk för nya kontakter

När en ny kontakt skickar in ett ärende försöker SuperOffice avgöra vilket kundspråk som ska användas för kontakten.

## Scenario 1

1. John är en ny kontakt som registrerar ett nytt ärende i kundcentret cs.liberty.com med e-postadressen <john@coca-cola.se>.

2. Det nya ärendet skickas till systemet där Johns e-postdomän (coca-cola.se) kontrolleras. coca-cola.se är registrerad som domän för företaget Coca-Cola.

3. John läggs till som ny kontakt för Coca-Cola i stället för att läggas till som ny kontakt utan företag.

4. SuperOffice kontrollerar sedan om e-postdomänen .se är kopplad till något av de registrerade kundspråken. .se är registrerad som domän för kundspråket svenska.

5. Kundspråket för kontakten John sätts därför till svenska.

6. SuperOffice skickar en svarsmall på svenska (om en sådan har skapats) till John med information om att ärendet har mottagits och registrerats.

7. John får ett användarnamn och lösenord från SuperOffice och kan logga in på cs.liberty.com och komma åt den svenska versionen av SuperOffice Kundcenter. John får också tillgång till svenska FAQ-poster om detta har konfigurerats i SuperOffice.

## Scenario 2

1. Maria är en ny kontakt som registrerar ett nytt ärende i kundcentret cs.liberty.com med e-postadressen <maria@coca-cola.nl>.
2. SuperOffice kontrollerar e-postdomänen, som är registrerad på företaget Coca-Cola.
3. Maria läggs till som ny kontakt för Coca-Cola.
4. SuperOffice kontrollerar sedan om e-postdomänen .nl är kopplad till något av de registrerade kundspråken. E-postdomänen .nl är *inte* kopplad till något kundspråk och systemet kan därför inte fastställa något kundspråk för Maria.
5. Maria får en svarsmall på företagets standardspråk. SuperOffice Kundcenter och FAQ visas också på standardspråket.

## Scenario 3

1. Nederländska läggs till som ett nytt kundspråk i SuperOffice och kopplas till domänen .nl.
2. Maria får då inte nederländska som kundspråk automatiskt. Detta måste ställas in manuellt för kontakten. Endast nya kontakter kontrolleras mot nya kundspråk.
