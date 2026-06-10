---
uid: help-no-user-add
title: Legge til bruker
description: I denne guiden lærer du hvordan du legger til en ny bruker i SuperOffice CRM.
keywords: Legg til bruker, medarbeider
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
tier: starter
redirect_from: /no/admin/user-management/learn/add-associate
language: no
---

# Legge til brukere

Når SuperOffice CRM-løsningen er konfigurert og tilpasset, er det på tide å gi brukerne tilgang. Denne guiden beskriver hvordan du legger til én bruker om gangen.

Administratorer har ansvaret for å tildele hvert nye bruker et brukernavn, et passord og en primærgruppe. I **SuperOffice CRM Online** inkluderer dette også valg av en brukerplan. I abonnementer på **SuperOffice CRM Suite** gjelder firmaets plan for alle brukere – aktiver bare alternativet **Kan logge inn** for å gi tilgang.

> [!NOTE]
> Hvis du oppga brukerinformasjon da du bestilte SuperOffice CRM, er disse brukerne kanskje allerede i systemet og har fått påloggingsinformasjon via e-post. Sjekk skjermbildet **Brukere** før du legger til noen manuelt.

## Trinn

1. Åpne skjermbildet Brukere.
1. Velg fanen **Medarbeidere**.
1. Klikk på **Legg til**-knappen under listen.
1. Skriv inn navnet og e-postadressen til den nye brukeren øverst på kortet.
1. Hvis mer enn ett eierfirma er tilgjengelig i SuperOffice-tenanten, kan du velge eieren under feltet **E-post**.
1. Skriv inn relevant informasjon i fanene **Detaljer** og **Lisenser**.

    ![Create user details -screenshot][img7]

1. Klikk på **Lagre**. Navnet på den nye brukeren vises nå i listen.

    * **SuperOffice CRM Online:** Hvis aktive brukere trenger en annen brukerplan, kan du [tilordne brukerplaner][4] i Innstillinger og vedlikehold.
    * **SuperOffice CRM Suite:** Administrer brukertilgang ved å aktivere eller deaktivere alternativet **Kan logge inn**. Firmaets plan bestemmer hvilke funksjoner alle brukere kan få tilgang til. Se [CRM Suite-planer][5].

## <a id="fields"></a>Viktige felt forklart

<!-- markdownlint-disable-file MD051 -->
### [Fanen Detaljer](#tab/details)

I fanen **Detaljer** finner du følgende alternativer:

* **Bruker-ID:** I feltet **Bruker-ID** redigerer du den foreslåtte IDen for brukeren (hvis du ikke vil bruke den automatisk genererte IDen). Du kan ikke angi en bruker-ID som allerede finnes i databasen. Det er ingen begrensninger på hvilke tegn som kan brukes i bruker-IDen.

    > [!NOTE]
    > Bruker-ID-en bør ikke inneholde for mange tegn, siden den vises i ID-kolonnene i SuperOffice CRM, og plassen i disse kolonnene kan være begrenset.

* **Kallenavn:** Kallenavnet er navnet som er synlig for andre brukere av SuperOffice, og det brukes bare for SuperOffice Service-brukere. Du kan redigere det foreslåtte kallenavnet for brukeren (hvis du ikke vil bruke det automatisk genererte navnet).

* **Autentisering:** Hvis det finnes flere tilgjengelige autentiseringsmåter, kan du velge en her.

* **Brukernavn:** Skriv inn SuperOffice-brukernavnet. Dette bør være det samme navnet som i identitetsleverandørens system (hvis du bruker Office 365 eller Gmail til autentisering). Når du bruker SuperOffice til autentisering, fyller du bare inn e-postadressen din. Kontroller at e-postadressen er gyldig, siden den brukes til kontobekreftelse.

* **Rolle:** I listeboksen **Rolle** velger du hvilken [rolle][3] brukeren skal ha. Rollen bestemmer datatilgang og funksjonelle rettigheter for brukeren. Du kan ikke endre din egen rolle.

* **Brukerplan:** Velg den aktuelle brukerplanen for brukeren. Dette bestemmer hvilke SuperOffice-funksjoner brukeren kan få tilgang til. (Kun SuperOffice CRM Online. I abonnementer på SuperOffice CRM Suite gjelder firmaets plan for alle brukere.)

* **Sluttet:** Hvis en bruker ikke lenger skal ha tilgang til SuperOffice, velger du dette alternativet for å fjerne brukerplanen og påloggingsrettighetene til brukeren.

* **Primærgruppe:** I listeboksen **Primærgruppe** velger du et av de forhåndsdefinerte alternativene for gruppetilhørighet. Gruppene defineres i **Lister**-bildet. Brukeren får tilgang til data som eies av andre brukere i samme primærgruppe. Tilgangsrettighetene (for eksempel skrive- og slettetilgang) for disse dataene er definert i den [rollen][3] brukeren tilhører. Se [Synlighet][2] hvis du vil ha mer informasjon om hvordan du deler data med primærgruppen din.

* **Andre grupper:** Klikk i feltet **Andre grupper**, og velg hvilke andre grupper brukeren skal tilhøre. Hvis listen inneholder mange grupper, begynner du å skrive inn et gruppenavn i søkefeltet for å filtrere listen.

* **SuperOffice Service-kategorier:** Disse kategoriene brukes til å gi brukerne tilgang til bestemte sakskategorier.

* **Service-kategorier fra brukergrupper:** Viser kategoriene brukeren får ved å være i en brukergruppe.

#### Eksempel

Jon Jonsen jobber i salgsavdelingen i et stort selskap. Primærgruppen settes til "Salg", slik at Jon har tilgangsrettigheter til data som brukere i salgsavdelingen har opprettet. Tilgangsrettighetene til primærgruppen er definert i rollen som Jon tilhører. Denne rollen bestemmer om Jon kan redigere eller slette data som er opprettet av de andre brukerne i salgsavdelingen (se [Angi datarettigheter for rolle][8]).

Jon trenger i tillegg begrenset tilgang til dokumenter fra markedsavdelingen og utviklingsavdelingen. Disse to avdelingene legges til under **Andre grupper**. I rollen som Jon tilhører, er det angitt at Jon bare har lesetilgang til disse dataene.

### [Lisenser-fanen](#tab/license)

I **Lisenser**-fanen kan du velge ekstra lisenser.

**Confidential activities:** Aktiverer listen **Synlig for** for oppfølginger, dokumenter og salg, slik at [oppføringer blir synlige bare for][2] brukeren, brukerens primærgruppe eller alle.

***

## Video: Legge til en ny SuperOffice CRM-bruker

Se denne demoen for å se hvordan du legger til en ny bruker i SuperOffice CRM.
(Denne videoen viser en tidligere versjon av SuperOffice, så designet kan se annerledes ut. Trinnene er de samme.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

(videolengde – 1.46)

## Feilsøking

### En nyopprettet bruker kan ikke logge på SuperOffice

Det er to vanlige situasjoner der en ny bruker ikke kan logge på:

* Brukernavnet er ikke en e-postadresse, eller e-postadressen er ugyldig
* Den nye brukerens konto er ikke aktivert

1. [!include[Klikk på Brukere](includes/goto-users.md)]

1. Velg brukeren som ikke kan logge på, i listen over brukere.

1. Kontroller at brukeren har angitt en gyldig e-postadresse, siden aktiverings-e-posten sendes til denne adressen.

    ![Bekreft brukerens e-postadresse -screenshot][img2]

1. Kontroller at brukeren har mottatt aktiverings-e-posten, og at aktiveringslenken ble klikket innen 48 timer.

    ![Aktiverings-e-post -screenshot][img3]

    Hvis du vil sende velkomst-e-posten på nytt, går du til **Innstillinger og vedlikehold** > **Brukere**, velger brukeren, klikker på **Oppgave**-knappen og velger **Send velkomst-e-post**.

1. Kontroller at brukeren har fulgt [instruksjonene for å logge på SuperOffice CRM][7].

## Relatert innhold

* [Rediger bruker/medarbeider][6]
* [Onsite-brukeradministrasjon][10]

<!-- Referenced links -->

[2]: index.md#visible
[3]: role/index.md
[4]: ../license/user-plans.md#change
[5]: ../license/crm-suite.md
[6]: update-user.md
[7]: ../../learn/getting-started/login.md
[8]: role/set-data-rights-for-role.md
[10]: https://help.superoffice.com/docs/11/no/admin/user-management/add-associate.html

<!-- Referenced images -->
[img2]: ../../../media/loc/en/admin/filled-in-email.png
[img3]: ../../../media/loc/en/admin/activation-email.png
[img7]: ../../../media/loc/en/admin/selected-user-plan.png
