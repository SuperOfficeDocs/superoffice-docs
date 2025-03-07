---
uid: help-da-sale-create
title: Registrer et salg
description: Registrer salg i SuperOffice Sales for at samle alle dine muligheder og kundeoplysninger ét sted. Denne vejledning viser, hvordan du registrerer salg.
keywords: opret salg, nyt salg, tilføj salg, registrer salg, salg
author: SuperOffice RnD
date: 03.07.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Registrer et salg

Du kan oprette et salg i SuperOffice CRM ved at bruge knappen **Ny** i toplinjen. Se denne video eller følg trinene nedenfor for at registrere et salg:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/7Am9pqMyHSA]

(videoens længde – 2:10)

## Trin

1. Klik på **Ny** i toplinjen, og vælg **Salg**.

1. Indtast en **titel for salget** (obligatorisk, markeret med rød understregning). Dette er den primære identifikation af salget.

    ![Fanen Salg med de grundlæggende felter i salgskortet -screenshot][img1]

1. Indtast **beløb og valuta** for at estimere salgsværdien.

1. Vælg en **salgstype** fra rullemenuen (obligatorisk). Salgstyper definerer salgsprocessen og kan omfatte faser eller guider. Disse værdier er foruddefinerede i **Indstillinger og vedligeholdelse**.

1. (Valgfrit) Udfyld yderligere oplysninger i fanen **Salg**, såsom:
    * Tilknyt salget til et **firma**.
    * Knyt salget til et igangværende **projekt**.
    * Justér den forventede afslutningsdato for salget.
    * Brug tekstfeltet til at tilføje en beskrivelse af salget.
    * Vælg den aktuelle **fase** for salget (hvis relevant). Faser sporer salgets fremskridt.

    > [!NOTE]
    > Hvis salgstypen ikke har tilknyttede faser, vil salget have status som **Åbent**.

1. Vælg fanen **Detaljer** for at tilføje finansielle oplysninger som kostpris, fortjeneste og konkurrenter.

1. **Tilføj flere detaljer:**
    * Gå til fanen **Mere** for at [indtaste brugerdefinerede felter][12].
    * Gå til fanen **Bemærkning** for at [tilføje noter][11].
    * Gå til fanen **Links** for at [tilknytte aktiviteter, dokumenter eller websider][10] til salget.

1. Klik på **Gem** for at oprette salget. Salgskortet er nu oprettet.

## <a id="fields"></a>Vigtige felter forklaret

Følgende felter er tilgængelige i salgskortet. Nogle felter udfyldes automatisk, mens andre kræver manuel indtastning.

> [!NOTE]
> Felter og layout kan variere afhængigt af **Skærmdesigner**-konfigurationer og andre UI-tilpasninger.

<!-- markdownlint-disable MD051 -->
### [Fanen Salg](#tab/sale)

* **Titel:** Et obligatorisk felt til identifikation af salget.
* **Beskrivelse:** Valgfrit tekstfelt til en kort beskrivelse af salget.
* **Salgstype:** Foruddefinerede typer, der bestemmer processen og eventuelle faser eller salgsguider. Defineres i **Indstillinger og vedligeholdelse**.
* **Fase:** Viser salgets nuværende fremskridt. Tilgængelige faser afhænger af den valgte salgstype.
* **Beløb og valuta:** Estimeret værdi af salget. *(Valuta skal være aktiveret i Indstillinger og vedligeholdelse for at bruge denne mulighed).*
* **Sandsynlighed:** Viser sandsynligheden for, at salget lykkes. Beregnes baseret på den aktuelle fase, men kan ændres manuelt.
* **Firma:** Det firma, salget er knyttet til.
* **Person:** Kontaktpersonen hos firmaet, der er forbundet med salget.
* **Projekt:** Knytter salget til et igangværende projekt.
* **Ejer:** Den bruger, der er ansvarlig for salget. Standard er den aktuelt loggede bruger, men kan ændres.
* **Salgsdato:** Den forventede afslutningsdato for salget.
* **Næste aktivitet:** Automatisk udfyldt med den ældste ikke-fuldførte opfølgning. Datoer før dags dato vises med rød skrift.
* **Udsat afkrydsningsfelt:** Angiver, at salget er sat på pause, og aktiverer felterne **Genåbningsdato** og **Årsag (udsat)**.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Fanen Detaljer](#tab/details)

Fanen **Detaljer** fokuserer på salgets økonomiske oplysninger.

* **Nummer:** Automatisk genereret salgs-ID.
* **Kilde:** Viser kilden til salget.
* **Konkurrent:** Vælg en foruddefineret konkurrent til salget (kun én kan vælges).
* **Samlet kostpris:** Omkostninger forbundet med salget. Opdaterer automatisk fortjenesten.
* **Fortjeneste:** Beregnes ud fra salgsbeløb og kostpris.
* **Krediteret:** Angiver, hvilken afdeling der er ansvarlig for salget.

Værdierne for *Konkurrent* og *Krediteret* er defineret i Indstillinger og vedligeholdelse.

### [Fanerne Links og Bemærkning](#tab/other)

* **Fanen Links:** Tilføj relevante aktiviteter, dokumenter eller andre salg.
* **Fanen Bemærkning:** Tilføj fritekstnoter for at holde styr på yderligere oplysninger.

***
<!-- markdownlint-enable MD051 -->

## Relateret indhold

* [Opret et tilbud][4]
* [Opdater et salg][1]
* [Arbejde med salgsguider][2]

<!-- Referenced links -->
[1]: update.md
[2]: sales-guides.md
[4]: ../../quote/learn/create.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/create-sale.png
