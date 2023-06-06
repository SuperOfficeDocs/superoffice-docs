---
uid: help-no-extra-table-create
title:  Definere ekstratabeller
description:  Definere ekstratabeller
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: ekstra tabell
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance

language: no
---

# Legge til ekstra tabeller

Du kan opprette ekstra tabeller i SuperOffice for å registrere ulike typer data. Når du har opprettet tabellen og [opprettet ekstra felt][1] i den, kan du åpne tabellen for å legge til innhold ved å gå til **Systemdesign** > **Tabeller**, peke på tabellen, og deretter klikke på knappen ![ikon][img1].

> [!NOTE]
> I SuperOffice CRM kan du opprette nettleserfaner som kan inneholde tabellinformasjon. For å angi de relevante tilgangsrettighetene må brukeren tilhøre en rolle som har de funksjonelle rettighetene **Liste opp tabeller** og **Rediger tabeller**.

**Trinn:**

1. Gå til **Tabeller**-bildet.

    * I Innstillinger og vedlikehold: Klikk på ![ikon][img3] **Systemdesign**-knappen i navigatoren. Velg deretter **Tabeller**-fanen.

2. Klikk på knappen ![ikon][img4]. Bildet **Egenskaper for tabell** vises.

3. I bildet **Egenskaper for tabell** angir du informasjon om den nye tabellen. Se detaljer om feltene nedenfor.

4. Klikk på **OK** for å lagre den nye tabellen.

## Felt

| Felt | Beskrivelse |
|---|---|
| Mappe | Hvis du vil legge tabellen i en eksisterende mappe, velger du en mappe fra listen. |
| Navn | Tabellens navn. |
| Databasetabell   Navnet på databasetabellen. Kan bare angis ved opprettelse, og kan ikke endres. Tabellnavnet kan bare inneholde understrek, bokstavene a–z og tall, og navnet må starte med "y_". Det er lurt å bruke et logisk navn, slik at det er lett å skjønne hva databasen inneholder. |
| Overskrift for søk | Overskriften som brukes i søkebildet for denne tabellen. |
| Overskrift for visning av datapost | Overskriften som brukes når du viser en oppføring i denne tabellen. |
| Overskrift for ny post | Overskriften som brukes når du oppretter en ny oppføring i denne tabellen. |
| Overskrift for redigering av datapost | Overskriften som brukes når du redigerer en oppføring i denne tabellen. |
| Sorteringsrekkefølge | Kolonnen tabellen sorteres etter. Hvis du merker av for **Synkende**, sorteres verdiene i synkende rekkefølge. Ved tallverdier vil det si at den høyeste verdien vises øverst i tabellen. Tabellen må inneholde felt før du kan velge noe her. |
| Visningsfelt | Hvis data fra denne tabellen vises i en annen tabell (en relasjon), må du velge hvilket felt som skal vises i den andre tabellen. Tabellen må inneholde felt før du kan velge noe her. |
| Overordnet felt | Dette feltet brukes i forbindelse med hierarkisk organiserte tabeller. |
| Fullstendig navn |  Hvis dette er en hierarkisk organisert tabell, kan dette feltet angi et felt som automatisk oppdateres med postens fullstendige navn basert på navnefeltet for denne posten, og alle overordnede poster. |
| Skjul ID-felt | Hvis du merker av for dette alternativet, vises ikke ID-feltet når poster føres opp i tabellen. |
| Skjul tabellen | Hvis denne er merket, vil ikke tabellen være synlig fra ![ikon][img3] **Systemdesign** > **Tabeller**. |

## Hva vil du gjøre nå?

* [Definere ekstrafelt][1]

<!-- Referenced links -->
[1]: ../extra-field/create.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/service/new-field.png
[img3]: ../../../../../common/icons/nav-admin-systemdesign-active.png
[img4]: ../../../../media/icons/service/new-table.png
