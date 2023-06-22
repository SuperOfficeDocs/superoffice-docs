---
uid: help-da-form-submissions-process
title: Behandling af formularindsendelser
description: "I denne vejledning lærer du, hvordan du behandler formularindsendelser manuelt."
author: SuperOffice RnD
so.date: 02.21.2023
keywords: Formularer
so.topic: howto
language: da
---

# Behandling af formularindsendelser

Så snart formularindsendelserne begynder at strømme ind, er det tid til at behandle dem. Formularer kan behandles automatisk, manuelt eller en kombination af begge.

> [!NOTE]
> SuperOffice kontrollerer og validerer e-mailadressen indsat i formularen for at sikre, at det er et eksisterende domænenavn. Grundlæggende e-mailadressesyntaks vil også blive kontrolleret.

Når du har konfigureret din webformular til automatisk at behandle alle indgående indsendelser, behøver du ikke løfte en finger. SuperOffice CRM behandler dem for dig og opretter en ny kontakt, når der ikke findes noget match i din database.

* Når du behandler formularindsendelser manuelt, kan du forhindre dublerede kontaktpersoner ved at kontrollere, om en person allerede er registreret i databasen eller ej.

* Du kan også vælge denne mulighed "Manuelt, hvis indsenderen er ukendt. Automatisk, hvis indsenderen er kendt." Derefter har du mere kontrol over de kontakter, der føjes til databasen via formularindsendelser.

Formularindsendelser med status **Indsendt** skal behandles manuelt. Det betyder gennemgang af formularen og indholdet samt tilknytning af indsenderen til en eksisterende eller ny person og/eller et eksisterende eller nyt firma i SuperOffice. Behandlede formularer vil være tilgængelige under fanen **Aktiviteter** i skærmene Firma og Person i SuperOffice CRM. Hvis du har valgt at blive underrettet om nye sager, vil de behandlede formularer være tilgængelige under detaljekortet **Sag**.

Se denne video (eller følg den trinvise vejledning nedenfor) for at få mere at vide om, hvordan du manuelt kan behandle en indsendt webformular (videolængde - 4:30), eller følg nedenstående trin.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/XtdkUwIXkww]

## Trin

1. I SuperOffice Markedsføring:
    1. Åbn en formular og gå til fanen **Formularindsendelser** eller gå til fanen **Formularindsendelser** (i hovedskærmbilleder **Udsendelser**).
    2. Nederst på listen over formularindsendelser skal du fravælge alle filtre undtagen **Indsendt**. Listen viser nu kun formularindsendelser, der skal behandles.

    I SuperOffice CRM: Gå til skærmbilledet Person, søg efter den relevante person, og vælg fanen **Aktiviteter**.

2. Dobbeltklik på en række.

3. Gennemgå de indsendte data i fanen **Data fra formular** i vinduet **Indsendelse af formular**.

4. Gå til fanen **Handlinger** for at vise de handlinger, der udføres på formulardataene, når du behandler den.

5. I sidepanelet **Indsender** skal du knytte indsenderen til en eksisterende eller ny person i SuperOffice.

6. Klik på **Behandl**.

## Tilknytning af indsenderen til SuperOffice-person og firma

Når formularen er indsendt, prøver SuperOffice at matche e-mailadressen i formularen med eksisterende e-mailadresser i SuperOffice for at knytte den indsendte formular til en eksisterende person. Hvis indsenderen findes i SuperOffice, kan du vise kontaktinformation, sager, salg, opfølgninger og tidligere chat-sessioner, der er blevet registreret.

Hvis der ikke er noget match, skal du prøve at finde den rigtige person eller oprette en ny person (og et nyt firma).

### Brug foreslået person

Hvis SuperOffice finder matchende personer i databasen, vil de blive opført under **Denne person kan være...**. Klik på en person for at se relevant information, og knyt personen til denne formularindsendelse.

### Søg efter en person

Hvis SuperOffice ikke kan finde den rigtige person i databasen, kan du søge efter personen ved hjælp af søgefeltet. Her kan du også vælge fra historiklisten og foretrukne.

### Skift person

Hvis du har valgt den forkerte person, kan du klikke på **Skift person** nederst i sidepanelet for at søge efter en anden person.

### Opret nyt firma og person

Hvis indsenderen ikke findes i SuperOffice, kan du oprette en ny person og et nyt firma i sidepanelet.

1. Klik på **Opret nyt firma og ny person**. Nogle felter udfyldes med oplysninger, som kunden har angivet i formularen.
2. Udfyld de relevante felter.
3. Klik på **Tilføj**. Den nye person og det nye firma føjes til SuperOffice.
