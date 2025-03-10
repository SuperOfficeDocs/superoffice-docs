---
uid: help-da-form-submissions-process
title: Behandling af formularindsendelser
description: I denne vejledning lærer du, hvordan du behandler formularindsendelser manuelt.
keywords: formular, formularindsendelse, indsendelse, indsendt, indsender, formulardata, data fra formular
author: Bergfrid Dias
date: 03.12.2024
version: 10
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Behandling af formularindsendelser

Så snart formularindsendelserne begynder at strømme ind, er det tid til at behandle dem. Formularer kan behandles automatisk, manuelt eller en kombination af begge. Dette er specificeret som [formularhandlinger][2].

Formularindsendelser med status **Indsendt** skal behandles manuelt. Dette betyder gennemgang af formularets indhold og knytning af indsenderen til en eksisterende eller ny person og/eller et eksisterende eller nyt firma i SuperOffice.

Den primære årsag til at vælge manuel behandling er at have mere kontrol over de kontakter, der tilføjes din database gennem formularindsendelser. Specifikt kan du forhindre duplikatkontakter ved at kontrollere, om en person allerede er registreret. SuperOffice kontrollerer og validerer e-mailadressen indsat i formularen for at sikre, at det er et eksisterende domænenavn. Grundlæggende e-mailadressesyntaks vil også blive kontrolleret.

Når et formular indsendes, forsøger SuperOffice at knytte formularet til en eksisterende person ved hjælp af den angivne e-mailadresse.

* Hvis der findes en match, kan du vise kontaktinformation, sager, salg, opfølgninger og tidligere chat-sessioner.
* Hvis der ikke findes en match, søg efter den korrekte person eller opret en ny.

Se denne video (eller følg den trinvise vejledning nedenfor) for at få mere at vide om, hvordan du manuelt kan behandle en indsendt webformular (videolængde - 4:30), eller følg nedenstående trin.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/XtdkUwIXkww]

## Trin

### 1- Find og åbn formularen

Gør et af følgende:

* Hvis du blev underrettet af en servicesag, åbne sagen og klik på linket.

* Hvis afsenderen er kendt, gå til skærmbilledet Person, søg efter den relevante person, og vælg fanen **Aktiviteter**. Dobbeltklik på rækken med den ubehandlede formularindsendelse.

* I SuperOffice Marketing:

    1. Åbn en formular og gå til fanen **Formularindsendelser**, eller gå til fanen **Formularindsendelser** på hovedskærmen for marketing.

    2. I bunden af listen over formularindsendelser skal du fravælge alle filtre undtagen **Indsendt**. Listen viser nu kun formularindsendelser, der skal behandles.

    3. Dobbeltklik på rækken med den indsendelse, du vil behandle.

### 2 - Gennemgå og behandle data

I vinduet **Indsendelse af formular**:

1. Vælg fanen **Data fra formular** og gennemgå de indsendte data.

2. Vælg fanen **Handlinger** for at se de handlinger, der udføres på formulardataene, når du behandler dem.

3. I sidepanelet for **Indsender**, knyt indsenderen til en eksisterende eller ny person i SuperOffice:

    * **Brug foreslået person:** Hvis SuperOffice finder matchende personer, vises de under **Denne person kan være...**. Klik på en person for at knytte den til denne formularindsendelse.

    * **Søg efter en person:** Hvis den korrekte person ikke findes, skal du bruge søgefeltet for at finde den. Du kan også vælge fra historik og foretrukne.

    * **Skift person:** Hvis du har valgt den forkerte person, skal du klikke på **Skift person** for at søge igen.

    * **Opret nyt firma og ny person:** Hvis indsenderen ikke findes i SuperOffice, opret en ny person og et nyt firma:

      1. Klik på **Opret nyt firma og kontakt**. Nogle felter er forudfyldt med formulardata.
      2. Udfyld relevante felter.
      3. Klik på **Tilføj** for at føje den nye person og det nye firma til SuperOffice.

4. Klik på **Behandl**.

![Formularindsendelse, Data fra formular -screenshot][img1]

## Relateret indhold

* [Sporing af formularindsendelser og visning af statistik][1]
* [Analysere resultaterne af dine udsendelser][4]

<!-- Referenced links -->
[1]: view-statistics.md
[2]: define-form-actions.md
[4]: ../../mailing/learn/view-statistics.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/form-submission-add-contact.png
