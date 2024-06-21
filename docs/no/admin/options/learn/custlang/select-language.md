---
uid: help-no-languages-selection
title: Kundespråk for nye personer
description: Slik velger SuperOffice kundespråket for nye personer
author: SuperOffice RnD
date: 06.29.2022
keywords: språk
topic: help
language: no
---

# Slik velger SuperOffice kundespråket for nye personer

Når en ny person sender inn en sak, prøver SuperOffice å finne ut hvilket kundespråk som skal vises for personen.

## Scenario 1

1. John, en ny person, registrerer en ny sak i kundesenteret cs.liberty.com med e-postadressen john@coca-cola.se.

2. Den nye saken sendes til systemet, der Johns e-postdomene (coca-cola.se) kontrolleres. coca-cola.se er registrert som domene for selskapet Coca-Cola.

3. John legges til som ny person for Coca-Cola, i stedet for å bli lagt inn som en ny person uten firma.

4. SuperOffice undersøker deretter om e-postdomenet .se er knyttet til et av de registrerte kundespråkene. .se er registrert som domene for kundespråket svensk.

5. Kundespråket til John blir dermed satt til svensk.

6. SuperOffice sender en svensk svarmal (hvis det er opprettet) til John og informerer ham om at saken er mottatt og registrert.

7. John mottar brukernavn og passord fra SuperOffice Service og kan logge seg på cs.liberty.com og få tilgang til den svenske versjonen av SuperOffice Customer Centre. John får også tilgang til svenske FAQ-er, hvis det er konfigurert i SuperOffice.

## Scenario 2

1. Maria, en ny person, registrerer en ny sak i kundesenteret cs.liberty.com med e-postadressen maria@coca-cola.nl.
2. SuperOffice undersøker e-postdomenet, og det er tilhører selskapet Coca-Cola.
3. Maria legges til som ny person for Coca-Cola.
4. SuperOffice undersøker deretter om e-postdomenet .nl er knyttet til et av de registrerte kundespråkene. E-postdomenet .nl er *ikke* knyttet til et kundespråk, og dermed er det ikke mulig å fastsette et kundespråk for Maria.
5. Maria mottar en svarmal på standardspråket for firmaet sitt. SuperOffice Customer Centre og FAQ-er vises også på standardspråket.

## Scenario 3

1. Nederlandsk legges til som nytt kundespråk i SuperOffice og knyttes til domenet .nl.
2. Maria får ikke automatisk nederlandsk som kundespråk. Dette må gjøres manuelt for personen. Bare nye personer kontrolleres mot nye kundespråk.
