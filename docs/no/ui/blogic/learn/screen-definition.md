---
uid: help-no-service-screen-definition
title: Definisjon av skjerm
description: Definisjon av skjerm
author: SuperOffice RnD
date: 06.29.2022
keywords: definisjon av skjerm
topic: reference
language: no
---

# Definisjon av skjerm

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

Her kan du vise detaljene for det valgte bildet.

* **Rediger bilde**: Brukes til å redigere skjermen. Se [Egenskaper for bilde][1].

* **Rediger språk**: Brukes til å redigere skjermtekster for de tilgjengelige språkene. Velg en språkfane, og rediger de tilgjengelige tekstene.

* **Nytt element**: Brukes til å legge til et nytt element i bildet. Se elementegenskaper nedenfor.

* **Nytt skript**: Brukes til å legge til et nytt skript. Her kan du angi et skript som skal kjøres når brukeren klikker på knappen.

* **Ny makro**: Brukes til å [legge til en ny makro][5].

* **Vis bilde**: Viser skjermen.

* **Designmodus**: Viser skjermen i designmodus (se nedenfor).

* **Listemodus**: Viser alle bildeelementene i en liste, i motsetning til i designmodus.

## Egenskaper for skript for knapp

* **Navn**: Navnet på knappen.
* **Kontroller feltverdier først**: Hvis dette alternativet er aktivert, valideres innholdet i skjemafeltene før skriptet kjøres. Hvis en eller flere av verdiene er ugyldige, returneres brukeren til skjemaet hvor feilene vil være indikert.
* **Skript**: Her kan du angi skriptet som denne knappen kjører.

## Egenskaper for element

Her kan du redigere egenskapene for et bildeelement, inkludert et konstruksjonsskript for elementet og enkle verdier som er spesifikke for de ulike elementtypene (som tittel, navn). En slik egenskap er brødteksten, som mange elementer har, og fordi disse kan være svært lange, har de sitt eget vindu.

## Designmodus

I designmodus kan du dobbeltklikke på ønsket alternativ på verktøylinjen til høyre for å opprette et element. Hvert element har et rektangulær "håndtak" som du kan klikke på for å vise en meny, som f.eks. lar deg flytte elementet eller legge til elementtypen som er valgt på verktøylinjen.

Mange av elementene inneholder prøvedata når de settes inn, for å vise hvordan de ser ut når bildet kjøres.

 Her vises følgende faner:

* **Elementer**: Elementene i bildet.
* **Knapper**: Viser knappene som er koblet til handlinger i bildet.

<!-- Referenced links -->
[1]: screen-properties.md
[5]: ../../../automation/crmscript/learn/create-macro.md

<!-- Referenced images -->
