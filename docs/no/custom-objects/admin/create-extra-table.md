---
uid: help-no-extra-table-create
title: Legge til ekstratabeller
description: Legge til ekstratabeller
keywords: ekstratabell, tredjepartstabell, systemdesign, tabelleegenskaper
author: Bergfrid Dias
date: 01.25.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Legge til ekstratabeller

Du kan opprette ekstratabeller i SuperOffice for å registrere ulike typer data. Når du har opprettet tabellen og [opprettet ekstrafelt][1] i den, kan du åpne tabellen for å legge til innhold.

## Trinn

1. [!include[Gå til tabeller](includes/goto-tables.md)]

1. Klikk på **Ny tabell**.

    ![Opprett ekstratabell -screenshot][img1]

1. I bildet **Egenskaper for tabell** skriv inn data om den nye tabellen.

    * Skriv inn et *navn* som skal brukes som ledetekst.
    * Skriv inn en *databasetabell* som begynner med **y_** for å identifisere tabellen i skjemaet.
    * Valgfritt sett andre egenskaper. Se detaljer om feltene nedenfor.

    > [!NOTE]
    > Noen tabelleegenskaper kan ikke settes før du har lagt til felt.

1. Klikk på **OK** for å lagre den nye tabellen (kjører `create table y_mynewtable ...`).

1. [Legg til felt i din nye tabell][1].

1. Valgfritt, juster tabelleegenskaper som sorteringsrekkefølge. (Klikk på tabellnavnet i listen for å gå inn i redigeringsmodus.)

1. Klikk **Start NetServer om igjen** når du er ferdig. Hvis Travel er aktivert, vil du også se en melding om at en ny Travel-database må genereres.

Du kan nå åpne tabellen i brukergrensesnittet for å legge til innhold i den **eller** fylle den via APIene.

## Felt

| Felt | Beskrivelse |
|---|---|
| Mappe | Hvis du vil legge tabellen i en eksisterende mappe, velger du en mappe fra listen. |
| Navn | Tabellens navn. |
| Databasetabell | Navnet på databasetabellen. Kan bare angis ved opprettelse, og kan ikke endres. Tabellnavnet kan bare inneholde understrek, bokstavene a–z og tall, og navnet må starte med "y_". Det er lurt å bruke et logisk navn, slik at det er lett å skjønne hva databasen inneholder. |
| Overskrift for søk | Overskriften som brukes i søkebildet for denne tabellen. |
| Overskrift for visning av datapost | Overskriften som brukes når du viser en oppføring i denne tabellen. |
| Overskrift for ny post | Overskriften som brukes når du oppretter en ny oppføring i denne tabellen. |
| Overskrift for redigering av datapost | Overskriften som brukes når du redigerer en oppføring i denne tabellen. |
| Sorteringsrekkefølge | Kolonnen tabellen sorteres etter. Hvis du merker av for **Synkende**, sorteres verdiene i synkende rekkefølge. Ved tallverdier vil det si at den høyeste verdien vises øverst i tabellen. Tabellen må inneholde felt før du kan velge noe her. |
| Visningsfelt | Hvis data fra denne tabellen vises i en annen tabell (en relasjon), må du velge hvilket felt som skal vises i den andre tabellen. Tabellen må inneholde felt før du kan velge noe her. |
| Overordnet felt | Dette feltet brukes i forbindelse med hierarkisk organiserte tabeller. |
| Fullstendig navn |  Hvis dette er en hierarkisk organisert tabell, kan dette feltet angi et felt som automatisk oppdateres med postens fullstendige navn basert på navnefeltet for denne posten, og alle overordnede poster. |
| Skjul ID-felt | Hvis du merker av for dette alternativet, vises ikke ID-feltet når poster føres opp i tabellen. |
| Skjul tabellen | Hvis denne er merket, vil ikke tabellen være synlig fra **Systemdesign** > **Tabeller**. |

## Vis tabell i nettleserfane

I SuperOffice CRM kan du opprette nettleserfaner som kan inneholde tabellinformasjon. For å angi de relevante tilgangsrettighetene må brukeren tilhøre en rolle som har de funksjonelle rettighetene **Liste opp tabeller** og **Rediger tabeller**.

<!-- Referenced links -->
[1]: create-extra-field.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
