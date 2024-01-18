---
uid: help-no-extra-fields-create
title:  Definere ekstrafelt
description: Definere ekstrafelt
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: ekstrafelt, egendefinert felt
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Legge til ekstrafelt

Når du har opprettet en [ekstra tabell][1], må du definere felt i tabellen, slik at du senere kan skrive inn data (oppføringer) i tabellen. Du kan også opprette ekstrafelt i standardtabeller.

> [!TIP]
> Ekstrafelt kan for eksempel brukes som søkekriterier og kolonner i salg i SuperOffice CRM.

**Trinn:**

1. Klikk på ![ikon][img1] **Systemdesign**-knappen i navigatoren. Velg deretter **Tabeller**-fanen.
1. Bla til ønsket tabell, pek på tabellnavnet, og klikk deretter på knappen ![ikon][img2].
1. I skjermen **Nytt ekstrafelt** velger du en felttype i listeboksen **Type**.
1. Klikk på **OK**. Bildet **Egenskaper for felt** åpnes.
1. I bildet **Egenskaper for felt** angir du informasjon om det nye feltet. Hvilke egenskaper som er tilgjengelige, avhenger av typen ekstrafelt (angitt i trinn 3).
1. Klikk på **OK** for å lagre, og klikk deretter på knappen **Start NetServer om igjen** øverst til høyre.

## Egenskaper for felt

| Felt | Beskrivelse |
|---|---|
| Kan ikke være tomt | Hvis dette er merket, blir feltet obligatorisk. |
| Velg fra listeboks | Hvis feltet er knyttet til en ekstratabell, velger du dette alternativet for å vise en liste over tabellverdier. |
| Velg verdier fra liste | Hvis dette er merket, blir feltet til en listeboks. Alternativene på listen vil være de tekstene som skrives inn i tekstboksen. Det er én linje per alternativ. |
| Opprett indeks | Angi om feltet skal indekseres. Det er raskere å søke etter data i indekserte felt. |
| Database-felt | Navnet som kolonnen vil få i databasen. Dette navnet må være unikt for denne tabellen. Videre må kolonnenavnet være et enkeltord, og det kan bare inneholde understrek, bokstavene a til z eller tall, og det må begynne med "x_". Kan bare angis når feltet opprettes. Dette kan ikke endres senere. |
| Antall desimaler | Antall desimaler som er tillatt i et tall. |
| Standardverdi | Standardverdien brukes for dette feltet. |
| Beskrivelse | Standardbeskrivelsen. |
| Vis verdi | Angi om verdien skal vises. |
| Eksterne | Hvis det er merket av, er feltet tilgjengelig fra et kundesenter. Bare relevant for standardtabeller, siden ekstra tabeller alltid vises i kundesentre. |
| Topptekst for liste | Dette feltet brukes til å angi en overskrift for disse postene når de vises som "underposter" på en liste. I vårt eksempel vil dette si navnet på den nye fanen i bildet **Vis person**, så vi skriver "Datamaskin" her. |
| Skjul funksjonsknapper | (relasjoner) Velg dette alternativet hvis du vil skjule funksjonen for å legge til nye poster i relasjonstabellen. |
| Skjul feltet | Angi om feltet skal vises. |
| Behold HTML-koder | (tekst) Velg dette alternativet for å inkludere HTML-koden i teksten. |
| Navn | Feltets navn. I vårt eksempel er dette navnene som står i listen i innledningen til dette kapittelet. |
| Antall enheter | (tidsperiode) Angi maksimum antall enheter for den "største" valgte tidsenheten. Eksempel: Hvis du valgte timer og minutter og skriver "4", kan maksimum 4 timer velges, mens minutter går til 60. På samme måte kan du for dager og timer maksimum velge 4 dager, mens timer går til 24. |
| Tillat bladnode bare i hierarkiske listebokser | (relasjon til ekstratabell) Angi om bare den laveste noden i hierarkiet skal kunne velges av brukeren. |
| Posisjon | Angir dette feltets plassering blant de andre feltene i oversikter. |
| Søkeoperator | Velg søkeoperator som skal brukes i dette feltet. |
| Vis i tabell | Hvis det er merket av for dette alternativet, vil dette feltet vises som en kolonne i de bildene hvor flere poster vises i en tabell. |
| Vis én-til-mange-relasjoner | Hvis du har valgt felttypen **Personrelasjon**, **Firmarelasjon** eller **Saksrelasjon** og ønsker at det skal vises en fane med informasjon fra denne tabellen i bildene for person, firma eller sak, kan du merke av i dette feltet. |
| Tabell | Angir hvilken tabell feltet tilhører. |
| Måltabell | Angi hvilken tabell som skal brukes. |
| Tekstområde/Høyde | Velg disse alternativene for å velge høyden (antall linjer) på tekstfeltet. |
| Type | Viser felttypen du valgte. |
| Oppdater nullverdier nå | Merk av for dette alternativet hvis du vil erstatte alle nullverdier (tomme felt) i databasen med standardverdien. Vær oppmerksom på at denne operasjonen kan ta tid. |
| URL | Angi URLen for den dynamiske koblingen her. |
| Bruk aktiv bruker som standardverdi | Hvis det er merket av, angis feltets verdi som aktiv bruker som standard. I vårt eksempel kan dette være aktuelt for feltet "Registrert av". |
| Bruk gjeldende dato/klokkeslett som standardverdi | Hvis det er merket av, angis feltets verdi som gjeldende dato/klokkeslett som standard. I vårt eksempel kan dette være aktuelt for feltet "Registrert dato". |
| Bruk dager / Bruk timer / Bruk minutter | Velg tidsenhetene du vil bruke i feltet for tidsperiode. |
| Bruk standardverdi | Hvis det er merket av for dette alternativet, får feltet en standardverdi hvis ikke annet er angitt. |
| Vis i relasjonsvelgere | Hvis den gjeldende tabellen har en relasjon til en annen tabell (relasjon til ekstratabell), velger du dette alternativet for å gjøre dette feltet tilgjengelig som et søkefelt. Eksempel: Du har opprettet en ekstratabell kalt "Produkter" med en relasjon til tabellen **Saker**. På denne måten kan du søke etter og legge til produkter i fanen **Ekstrafelt** når du oppretter nye saker. Hvis du velger **Vis i relasjonsvelger** for bestemte felt i tabellen "Produkter", blir disse feltene tilgjengelige som søkefelt i fanen **Ekstrafelt**. |

<!-- Referenced links -->
[1]: create-extra-table.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/nav-admin-systemdesign-active.png
[img2]: ../../../media/icons/service/new-field.png
