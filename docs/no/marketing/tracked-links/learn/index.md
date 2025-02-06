---
uid: help-no-mailing-tracked-links
title: Sporede koblinger
description: En kobling som du inkluderer i en utsendelse, kan brukes til å spore svar fra kunder og potensielle kunder. Når mottakerne av utsendelsen klikker på koblingen, utløses det en handling.
keywords: Markedsføring, utsendelse, sporet kobling, Google Analytics
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: no
---

# Sporede koblinger

Koblingene du bruker i nyhetsbrevet eller e-postkampanjen din bestemmes av målene dine. Hvert mål har en unik CTA som utløser et svar fra mottakeren, som du kan spore. Dette lar deg følge opp mottakerne dine etter at du har mottatt alle resultatene.

For eksempel kan det å klikke på en kobling åpne en ny nettside eller oppdatere et mottakers personkort. Det kan også legge til en [service-sak][8].

Du kan sette opp ofte brukte koblinger selv før du lager innhold. Dette lar deg gjenbruke disse koblingene, noe som sparer tid. Ofte brukte koblinger inkluderer:

* Avmeldingssider
* Personskjemaer
* Kanaler på sosiale medier

![I bildet Egenskaper for kobling kan du legge til koblinger du vil spore -screenshot][img4]

URL-adressene må være unike for hver mottaker, slik at du kan være sikker på at det er ulike mottakere som har klikket på dem, og ikke samme mottaker som har klikket flere ganger. I tillegg må URL-adressene peke mot SuperOffice-serveren, slik at de kan telles før de omdirigeres til den opprinnelige URL-adressen. Dette ordner programmet automatisk når du velger hvilke av URL-adressene i meldingen du vil spore.

## Hvilke koblinger sporer jeg?

For å se alle koblingene i en utsendelse, åpner du utsendelsen i visningsmodus og velger fanen **Sporede koblinger**.

## Fanen Sporede koblinger

I fanen **Sporede koblinger** har du følgende alternativer:

| Ikon | Alternativ | Les mer |
|:-:|---|---|
| <i class="ph ph-plus" aria-label="Plus"></i> | Legg til | [Opprett en ny kobling][1], [Definere koblingshandlinger][7] |
| <i class="ph ph-folder" aria-label="Folder"></i> | Legg til mappe | [Opprett en mappe][5] for koblingene |
| Kobling | Klikk på en kobling for å åpne bildet **Vis kobling**. | [Arbeide med sporede koblinger i etterkant av utsendelsen][2] |
| <i class="ph ph-list" aria-label="Task menu"></i> | Meny | Klikk på knappen ved siden av en kobling for å få tilgang til flere alternativer. |

Menyalternativer:

* [**Vis**][2]
* [**Rediger**][1]
* [**Tilbakestill**][10] (tellere for koblinger)
* **Flytt til mappe** (flytter koblingen til en annen mappe)
* **Slett**

## <a id="ex"></a>Use cases

Sporbare koblingr kan brukes på forskjellige måter:

* **Respons**: Registrer hvert mottakers klikk på en kobling, for eksempel til en ny produktside, for å måle interesse over flere utsendelser.

* **Prospektliste**: For en ny produktlansering kan mottakere uttrykke interesse ved å klikke på koblingn "Jeg vil gjerne ha et tilbu". Klikkere kan legges til i et [statisk utvalg][9] som selgerne kan bruke til å behandle videre kontakt med kundene.

* **CRM-oppfølginger**: I stedet for en prospektliste, gener en to-do eller et møte for hvert koblingklikk og tildel det til en selger eller kundekontakt. For eksempel kan et "Kontakt meg" koblingklikk generere en "Telefon ut" oppfølging.

* **Avmelding**: Sett inn en [avmeldingskobling][4] i innholdsredigeringsprogrammet for å stoppe en bestemt utsendelsestype. Alternativt kan kunder melde seg av individuelle mottakerlister.

    Legg til en kobling (for eksempel, "Klikk her hvis du ikke ønsker å motta nyhetsbrev fra oss") for å fjerne kunder fra mottakerlisten. Hvis et nyhetsbrev bare sendes til kontakter med interessen "Nyhetsbrev", kan denne interessen fjernes for koblingklikkere.

    > [!TIP]
    > Overvåk abonnementsavbestillinger ved å legge til koblingklikkere i et separat utvalg, for eksempel, "Nyhetsbrev 2024 – avsluttede abonnementer". Flere handlinger kan legges til samme kobling.

* **Bestill konsulent**: For en større produktoppdatering, legg til en kobling for kunder å bestille en konsulent. Hvert koblingklikk registrerer en ny sak i Service, tildelt til "Konsulent"-kategorien. Kunden mottar tilbakemelding om at de vil bli kontaktet av en konsulent.

> [!NOTE]
> Disse eksemplene fungerer like bra for vanlige koblinger, men klikkene måles da bare for den enkelte utsendelse.

## <a id="google"></a>Google Analytics

Når du setter opp en utsendelse, har du muligheten til å bruke Google Analytics som sporingssystem. Oppsettet i utsendelser lar deg definere en mer nøyaktig sporing av e-postmeldinger ved hjelp av de angitte feltene, noe som resulterer i mer detaljerte Google Channel-rapporter.

Google Analytics er den mest populære digitale analyseprogramvaren som finnes. Ved å spore hvordan besøkende på websiden din finner og bruker den, gir tjenesten bedriften din nyttig innsikt som hjelper deg med å gjøre de digitale markedsføringsstrategiene dine mer vellykkede.

Standarden er at Google Analytics ikke identifiserer besøkende som kommer fra bestemte utsendelser. Du må legge en emneknagg til koblingne i e-posten din for å kunne:

* Identifiser hvilke koblinger mottakerne har klikket på,
* Se hvilke websider de besøkte etter at de landet på websiden din.

Når du legger til en kobling til websiden din i utsendelsen din uten en emneknagg, kan du se at de besøkende kommer fra en utsendelse, men du vil ikke vite hvilken spesifikk utsendelse. Dermed vet du fortsatt ikke hvordan atferden til mottakerne av spesifikke utsendelser er på websiden din.

Google Analytics-funksjonen i SuperOffice Marketing identifiserer utsendelsene dine i rapportene. Ved å legge en unik emneknagg til alle koblingene du bruker i utsendelsen din, vil Google Analytics gjenkjenne utsendelsen din som kilden der de besøkende kommer fra. Google Analytics gir deg også innsikt i de besøkendes vei gjennom websiden din.

**Medium**: "E-post" er det forhåndsdefinerte mediet i automatiserte UTM-koder. Det betyr at sporede koblingr i utsendelser som sendes fra SuperOffice, finnes i Google Channel-rapporter under "E-post" (i motsetning til "andre").

**Kilde** og **Kampanje**: Disse feltene identifiserer denne spesifikke utsendelsen som kilden, og gir mulighet for en mer nøyaktig sporing og rapportering i Google.

## Aktuelt innhold

* [Inkludere koblinger du vil spore][3]
* [Legge til påmeldingskoblinger][4]
* [Enkel Google Analytics e-postsporing][6]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[7]: define-link-actions.md
[6]: ga-tutorial.md
[10]: reset-counter.md
[3]: ../../editor/learn/add-tracked-link-to-msg.md
[4]: ../../editor/learn/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[8]: ../../../request/learn/index.md
[9]: ../../../search-options/selection/learn/static-selections.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/link-properties.png
