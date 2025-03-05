---
uid: help-da-company-contact-relations
title: Firma- og personrelationer i SuperOffice CRM
description: Lær hvordan du kan se, tilføje og administrere relationer mellem firmaer og personer i SuperOffice CRM, så du nemmere kan holde styr på komplekse strukturer og tilpassede forbindelser.
keywords: tilføje relation, slette relation, relation, person, kontakt, firma
author: Bergfrid Skaara Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Firma- og personrelationer i SuperOffice CRM

Relationer i SuperOffice CRM giver dig mulighed for at etablere forbindelser mellem firmaer og personer. Relationer skal altid have to parter: en aktiv og en passiv. For eksempel, "Firma A ejer Firma B," hvor Firma A er den aktive part og Firma B er den passive. Denne vejledning giver en oversigt over, hvordan du kan se, tilføje og administrere disse relationer, hvilket gør det nemmere at holde styr på komplekse strukturer, samarbejder eller tilpassede relationer, som din virksomhed kræver.

## Eksempler på relationer

Eksempler inkluderer ejerstrukturer, partnerskabsaftaler eller personlige forbindelser mellem personer.

| Type | Aktiv | Passiv |
|---|---|---|
| Firma - firma | Firma ABC A/S samarbejder med Konsulentfirma Co. | Konsulentfirma ABC A/S samarbejder med Firma Co. |
| Firma - person | Firma ABC A/S ansætter Greg Campbell (Konsulentfirma Co.) | Greg Campbell (Konsulentfirma ABC A/S) ansættes af Firma Co. |
| Person - firma | Peter Johnson ejer Firma ABC A/S | Firma ABC A/S ejes af Peter Johnson. |
| Person - person | Mark Johnson (Konsulentfirma Co.) er søn af Peter Johnson (Firma ABC A/S). | Peter Johnson (Firma ABC Ltd) er far til Mark Johnson (Konsulentfirma Co.). |

## Se relationer

Detaljekortet **Relationer**, som er tilgængeligt både på Firmakortet og Personkortet, viser relationer mellem den valgte enhed og andre firmaer eller personer.

![Relationer (Firmakort) -screenshot][img2]

[!include[Relationsfanens kolonner](../includes/table-relations-tab-columns.md)]

For at se flere detaljer eller redigere, dobbeltklik på en række for at åbne **Relation**-dialogen.

## <a id="add"></a>Tilføj relation

1. Gå til Firmakortet eller Personkortet, hvor du ønsker at tilføje en relation.

1. Vælg detaljekortet **Relationer**.

1. Klik på **Tilføj** for at åbne **Relation**-dialogen.

 ![Relationer-dialog -screenshot][img1]

1. **Angiv parter:**

    * **Aktiv:** Vælg et firma eller en person.
    * **Passiv:** Vælg den anden enhed involveret i relationen.

1. **Vælg relationstype:** Vælg relationstypen, som "ejer", "ansat af" eller "partner" fra **Relation**-listen. De tilgængelige muligheder afhænger af, om relationen er mellem en person og et firma eller mellem to personer.

    **Resultat**-feltet opdateres automatisk baseret på dine valg.

1. Tilføj en beskrivelse (valgfrit): Inkluder yderligere information, hvis det er nødvendigt.

1. Klik **Gem** for at oprette relationen.

## <a id="delete"></a>Slet relation

1. Gå til detaljekortet **Relationer** på enten Firmakortet eller Personkortet.

1. Find relationen, du vil slette, højreklik, og vælg **Slet**.

1. I den dialogboks, der vises, klik på **Ja** for at bekræfte.

## Yderligere tips

* **Rullemenuen-søgning:** Når du vælger de aktive og passive parter, start med at skrive navnet for hurtigt at finde firmaet eller personen.

* **Relationstyper:** Relationstyper defineres i Indstillinger og vedligeholdelse. Tilpasning af disse gør det nemmere at afspejle din organisations specifikke behov.

## Relateret indhold

* [Sletning af elementer i SuperOffice CRM][2]
* [Gruppere oplysninger i detaljekort][1]
* [Tilføjelse af forekomster på listen Generelt – Relation][3]
* [Tilpassede felter i relationer][4]

<!-- Referenced links -->
[1]: ../section-tabs/index.md
[2]: deleting-elements.md
[3]: ../../admin/lists/learn/adding-items-to-relation-list.md
[4]: ../../custom-objects/learn/extra-field.md#relation

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/relation.png
[img2]: ../../../media/loc/en/company/relations-detail.png
