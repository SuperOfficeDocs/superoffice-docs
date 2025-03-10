---
uid: help-da-project-create
title: Opret et nyt projekt
description: Sådan opretter du et projekt, så du kan holde endnu bedre styr på tingene.
keywords: opret projekt, nyt projekt, tilføj projekt, projekt
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Opret et nyt projekt

Du kan oprette et projekt i SuperOffice CRM ved at bruge knappen **Ny** på toplinjen. Se denne video, eller følg trinene nedenfor for at lære, hvordan du opretter et projekt:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/zLJwNll223w]

(videoens længde - 2:49)

## Trin

1. Klik på **Ny** i toplinjen, og vælg **Projekt**.

1. Indtast et **projektnavn** (obligatorisk, markeret med rødt).

    Hvis projektets navn er en dublet, vises dialogboksen **Dubletter**, så du kan undgå at oprette en redundant post.

    ![Projektkort i redigeringstilstand, der viser projektdetaljer -screenshot][img1]

1. Brug tekstfeltet til at skrive en detaljeret beskrivelse af projektet. Dette er feltet **Beskrivelse**.

1. Vælg **Type** for projektet (obligatorisk). Værdierne er foruddefinerede og opsat i **Indstillinger og vedligeholdelse**.

1. **Valgfrit: Tilføj flere oplysninger** på fanen **Projekt**:
    * Tilføj en **Webadresse** og titel.
    * Vælg en **Ansvarlig** bruger for projektet.
    * Vælg **Status** for projektet. Værdierne er foruddefinerede og opsat i **Indstillinger og vedligeholdelse**.
    * Angiv en **Slutdato** via kalenderikonet.

1. **Tilføj flere detaljer:**
    * Gå til fanen **Mere** for at [angive brugerdefinerede felter][12].
    * Gå til fanen **Billede** for at [tilføje et projektbillede][2].
    * Gå til fanen **Bemærkning** for at [tilføje noter][11].
    * Gå til fanen **Links** for at [tilknytte aktiviteter, salg, dokumenter eller websteder][10] til projektet.

1. Klik på **Gem** for at gemme projektoplysningerne. Du er nu klar til at [tilføje projektdeltagere][5].

## <a id="fields"></a>Vigtige felter forklaret

Følgende felter findes på projektkortet. Nogle felter udfyldes automatisk, mens andre kræver input.

> [!NOTE]
> Felter og layout kan variere afhængigt af [Skærmdesigner][13] og andre UI-tilpasninger.

* **Projektnavn:** Projektets primære identifikator. Dette felt er obligatorisk.
* **Nummer:** Automatisk genereret som næste ledige projektnummer, hvis det er konfigureret i **Indstillinger og vedligeholdelse**. Kan redigeres manuelt.
* **Websted:** Tilføj webadresser med korte beskrivelser. Klik uden for tabellen eller tryk på **TAB** for at lukke inputfeltet.
* **Beskrivelse:** Kort opsummering af projektets mål, omfang eller formål. Valgfrit, men nyttigt til sporing af målsætninger.
* **Ansvarlig:** Tildel en ansvarlig medarbejder for projektet.
* **Type:** Foruddefinerede projekttyper. Nogle typer kan være knyttet til en [projektguide][1].
* **Status:** Angiver projektets nuværende fase (f.eks. Planlagt, I gang, Afsluttet). Hvis projektet er tilknyttet en projektguide, vil statusmulighederne fra guiden være tilgængelige.
* **Slutdato:** Angiv en dato for projektets afslutning. Kan justeres efter behov.
* **Næste milepæl:** Hvis projektet er tilknyttet en guide, viser dette felt datoen for næste planlagte opfølgning. Datoen beregnes automatisk baseret på tilknyttede aktiviteter eller projektguiden. Hvis ingen projektguide er knyttet, vises projektets slutdato. Datoer før dags dato markeres med rødt.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Dubletkontrol

Hvis projektnavnet matcher eller ligner en eksisterende post, vises dialogboksen **Dubletter**, som hjælper dig med at [undgå dubletter][6]. Gennemgå forslagene og fortsæt derefter.

## Relateret indhold

* [Tilføj eller skift et projektbillede][2]
* [Tilføj projektdeltagere][5]
* [Rediger projekter][7]
* [Slå projekter sammen][8]
* [Slet projekter][9]
* [Projektguider][1]
* [Aktiviteter][3]

<!-- Referenced links -->
[5]: project-members/add.md
[2]: add-image.md
[7]: edit.md
[8]: merge-projects.md
[9]: delete.md
[1]: project-guides.md
[3]: ../../learn/basics/activity.md
[6]: ../../learn/basics/duplicates.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md
[13]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/create-project.png
