---
uid: help-no-extra-fields-create
title: Legge til ekstrafelt
description: Legge til ekstrafelt
keywords: ekstrafelt, tilpasset felt, databasefelt, feltegenskaper
author: Bergfrid Dias
date: 04.09.2024
version: 10.3.4
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Legge til ekstrafelt

Når du har opprettet en [ekstratabell][1], må du definere felt i tabellen, slik at du senere kan skrive inn data (oppføringer). Du kan også opprette ekstrafelt i standardtabeller.

## Trinn

1. [!include[Gå til tabeller](includes/goto-tables.md)]

1. Bla til ønsket tabell, pek på tabellnavnet, og klikk **Nytt felt**.

    ![Legge til ekstrafelt -screenshot][img1]

1. Velg en type for det nye feltet og klikk **OK**.

1. I bildet **Egenskaper for felt**, skriv inn data om det nye feltet.

    * Skriv inn et *navn* som skal brukes som ledetekst.
    * Skriv inn et *databasefelt* som begynner med **x_** for å identifisere feltet i skjemaet.
    * Valgfritt sett andre egenskaper. Typen (spesifisert i trinn 3) bestemmer hva som er tilgjengelig. Se detaljer om feltene nedenfor.

    > [!TIP]
    > For å gjøre et felt obligatorisk, velg **Kan ikke være tomt**.

1. Klikk **OK** for å lagre det nye feltet (kjører `alter table y_mynewtable add column x_mynewfield ...`).

1. Fortsett å legge til flere felt.

1. Klikk **Start NetServer om igjen** når du er ferdig. Hvis Travel er aktivert, vil du også se en melding om at en ny Travel-database må genereres.

## Egenskaper for felt

| Felt | Beskrivelse |
|---|---|
| Kan ikke være tomt | Hvis dette er merket, blir feltet obligatorisk. |
| Velg fra listeboks | Hvis feltet er knyttet til en ekstratabell, velger du dette alternativet for å vise en liste over tabellverdier. |
| Velg verdier fra liste | Hvis dette er merket, blir feltet til en listeboks. Alternativene på listen vil være de tekstene som skrives inn i tekstboksen. Det er én linje per alternativ. |
| Opprett indeks | Angi om feltet skal indekseres. Det er raskere å søke etter data i indekserte felt. |
| Databasefelt | Navnet som kolonnen vil få i databasen. Dette navnet må være unikt for denne tabellen. Videre må kolonnenavnet være et enkeltord, og det kan bare inneholde understrek, bokstavene a til z eller tall, og det må begynne med "x_". Kan bare angis når feltet opprettes. **Kan ikke endres senere**. |
| Antall desimaler | Antall desimaler som er tillatt i et tall. |
| Standardverdi | Standardverdien brukes for dette feltet. |
| Beskrivelse | Standardbeskrivelsen. |
| Vis verdi | Angi om verdien skal vises. |
| Eksterne | Hvis det er merket av, er feltet tilgjengelig fra et kundesenter. Bare relevant for standardtabeller, siden ekstratabeller alltid vises i kundesentre. |
| Topptekst for liste | En overskrift for disse postene når de vises som "underposter" på en liste. |
| Skjul funksjonsknapper | (relasjoner) Velg dette alternativet hvis du vil skjule funksjonen for å legge til nye poster i relasjonstabellen. |
| Skjul feltet | Angi om feltet skal vises. |
| Behold HTML-koder | (tekst) Velg dette alternativet for å inkludere HTML-koden i teksten. |
| Navn | Feltets navn. |
| Antall enheter | (tidsperiode) Angi maksimum antall enheter for den "største" valgte tidsenheten. Eksempel: Hvis du valgte timer og minutter og skriver "4", kan maksimum 4 timer velges, mens minutter går til 60. På samme måte kan du for dager og timer maksimum velge 4 dager, mens timer går til 24. |
| Tillat bladnode bare i hierarkiske listebokser | (relasjon til ekstratabell) Angi om bare den laveste noden i hierarkiet skal kunne velges av brukeren. |
| Posisjon | Angir dette feltets plassering blant de andre feltene i oversikter. |
| Søkeoperator | Velg søkeoperator som skal brukes i dette feltet. |
| Vis i tabell | Hvis det er merket av for dette alternativet, vil dette feltet vises som en kolonne i de bildene hvor flere poster vises i en tabell. |
| Vis én-til-mange-relasjoner | Hvis du har valgt felttypen **Personrelasjon**, **Firmarelasjon** eller **Saksrelasjon** og ønsker at det skal vises en fane med informasjon fra denne tabellen i bildene for person, firma eller sak, kan du merke av i dette feltet. |
| Tabell | Angir hvilken tabell feltet tilhører. |
| Måltabell | Angi hvilken tabell som skal brukes. |
| Tekstområde/høyde | Antall linjer på tekstfeltet. |
| Type | Viser felttypen du valgte. |
| Oppdater nullverdier nå | Merk av for dette alternativet hvis du vil erstatte alle nullverdier (tomme felt) i databasen med standardverdien. **Denne operasjonen kan ta tid.** |
| URL | Angi URLen for den dynamiske koblingen her. |
| Bruk aktiv bruker som standardverdi | Hvis det er merket av, angis feltets verdi som aktiv bruker som standard. |
| Bruk gjeldende dato/klokkeslett som standardverdi | Hvis det er merket av, angis feltets verdi som gjeldende dato/klokkeslett som standard. |
| Bruk dager / Bruk timer / Bruk minutter | Velg tidsenhetene du vil bruke i feltet for tidsperiode. |
| Bruk standardverdi | Hvis det er merket av for dette alternativet, får feltet en standardverdi hvis ikke annet er angitt. |
| Vis i relasjonsvelgere | Hvis den gjeldende tabellen har en relasjon til en annen tabell (relasjon til ekstratabell), velger du dette alternativet for å gjøre dette feltet tilgjengelig som et søkefelt. Eksempel: Du har opprettet en ekstratabell kalt "Produkter" med en relasjon til tabellen **Saker**. På denne måten kan du søke etter og legge til produkter i fanen **Ekstrafelt** når du oppretter nye saker. Hvis du velger **Vis i relasjonsvelger** for bestemte felt i tabellen "Produkter", blir disse feltene tilgjengelige som søkefelt i fanen **Ekstrafelt**. |

## Legg til relasjon (fremmednøkkel, FK)

1. Klikk på **Nytt felt**.
1. Velg relasjonstypen for enheten du vil koble til og klikk på **OK**.
1. Sett feltegenskaper som beskrevet ovenfor.

    > [!NOTE]
    > Tilgjengelig fra versjon 10.3.4 i pilot: Valg av **Vis én-til-mange-relasjoner** legger til et detalkort (arkiv) til relaterte standardenheter.

1. Klikk på **OK** for å lagre relasjonen.
1. Klikk på **Start NetServer om igjen** for å anvende endringene.

For eksempel, for å koble alle innkommende saker til et bestemt salg, kan du legge til et ekstrafelt av typen salgsrelasjon til Sak ([ticket tabellen][4]). For å liste opp tilknyttede saker når du ser på et salg i SuperOffice CRM, må du bygge et webpanel.

<!-- Referenced links -->
[1]: create-extra-table.md
[4]: ../../../en/database/tables/ticket.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
