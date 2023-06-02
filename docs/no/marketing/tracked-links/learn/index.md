---
uid: help-no-mailing-tracked-links
title: Sporede koblinger
description: "En kobling som du inkluderer i en utsendelse, kan brukes til å spore svar fra kunder og potensielle kunder. Når mottakerne av utsendelsen klikker på koblingen, utløses det en handling." 
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Markedsføring
so.topic: concept
language: no
---

# Sporede koblinger

[!include[Requirement](includes/req-marketing.md)]

Målet med nyhetsbrevet eller e-postkampanjen din vil avgjøre hvilke koblinger du bør bruke. Hvert mål har sin egen CTA for å utløse et svar fra mottakeren du ønsker å spore. På denne måten kan du følge opp mottakerne etter at du har mottatt alle resultatene.

For eksempel kan det å klikke på en kobling åpne en ny webside eller oppdatere personkortet til mottakeren. Handlingen kan også legge til en service-sak i Service og i detaljkortet Sak på personkortet. Bruk av koblinger er bare tilgjengelig for brukere som abonnerer på markedsføringsplanen.

Før du starter selve utsendelsene, kan du konfigurere koblingene du ofte vil bruke i utsendelsene. Etter at du har konfigurert dem, kan du bruke dem om og om igjen, noe som vil være tidsbesparende. De vanligste koblingene som skal brukes, er for eksempel:

* Avmeldingssider
* Personskjemaer
* Kanaler på sosiale medier

![img4 -screenshot][I bildet Egenskaper for kobling kan du legge til koblinger du vil spore]

I en melding kan du inkludere koblinger (URL-adresser) som du kan spore. På denne måten kan du se hvor mange mottakere som har klikket på dem.

URL-adressene må være unike for hver mottaker, slik at du kan være sikker på at det er ulike mottakere som har klikket på dem, og ikke samme mottaker som har klikket flere ganger. I tillegg må URL-adressene peke mot SuperOffice-serveren, slik at de kan telles før de omdirigeres til den opprinnelige URL-adressen. Dette ordner programmet automatisk når du velger hvilke av URL-adressene i meldingen du vil spore.

I fanen **Sporede koblinger** har du følgende alternativer:

| Ikon | Alternativ | Les mer |
|---|---|---|
| ![ikon][img2] | Legg til | [Opprett en ny kobling][1] |
| ![ikon][img3] | Legg til mappe | [Opprett en mappe][5] for koblingene |
| Kobling | Klikk på en kobling for å åpne bildet **Vis kobling**. | [Arbeide med sporede koblinger i etterkant av utsendelsen][2] |
| ![ikon][img1] | Meny | Klikk på knappen ved siden av en kobling for å få tilgang til flere alternativer. |

Menyalternativer:

* **Vis**. [Slik arbeider du med sporede koblinger i etterkant av utsendelsen][2].
* **Rediger**. [Slik oppretter du sporede koblinger][1].
* **Tilbakestill**. [Slik tilbakestiller du tellere for koblinger][2].
* **Flytt til mappe**. Brukes til å flytte koblingen til en annen mappe.
* **Slett**. Sletter koblingen.

## Hvilke koblinger sporer jeg?

Hvis du vil [vise alle koblingene i en utsendelse][4], åpner du utsendelsen i visningsmodus og velger fanen **Sporede koblinger**.

## <a id="google" />Google Analytics

Når du setter opp en utsendelse, har du muligheten til å bruke Google Analytics som sporingssystem. Oppsettet i utsendelser lar deg definere en mer nøyaktig sporing av e-postmeldinger ved hjelp av de angitte feltene, noe som resulterer i mer detaljerte Google Channel-rapporter.

Google Analytics er den mest populære digitale analyseprogramvaren som finnes. Ved å spore hvordan besøkende på websiden din finner og bruker den, gir tjenesten bedriften din nyttig innsikt som hjelper deg med å gjøre de digitale markedsføringsstrategiene dine mer vellykkede.

Standarden er at Google Analytics ikke identifiserer besøkende som kommer fra bestemte utsendelser. Du må legge en emneknagg til lenkene i e-posten din for å kunne:

* Identifiser hvilke koblinger mottakerne har klikket på,
* Se hvilke websider de besøkte etter at de landet på websiden din.

Når du legger til en kobling til websiden din i utsendelsen din uten en emneknagg, kan du se at de besøkende kommer fra en utsendelse, men du vil ikke vite hvilken spesifikk utsendelse. Dermed vet du fortsatt ikke hvordan atferden til mottakerne av spesifikke utsendelser er på websiden din.

Google Analytics-funksjonen i SuperOffice Marketing identifiserer utsendelsene dine i rapportene. Ved å legge en unik emneknagg til alle koblingene du bruker i utsendelsen din, vil Google Analytics gjenkjenne utsendelsen din som kilden der de besøkende kommer fra. Google Analytics gir deg også innsikt i de besøkendes vei gjennom websiden din.

**Medium**: «E-post» er det forhåndsdefinerte mediet i automatiserte UTM-koder. Det betyr at sporede lenker i utsendelser som sendes fra SuperOffice, finnes i Google Channel-rapporter under «E-post» (i motsetning til «andre»).

**Kilde** og **Kampanje**: Disse feltene identifiserer denne spesifikke utsendelsen som kilden, og gir mulighet for en mer nøyaktig sporing og rapportering i Google.

## Aktuelt innhold

* [Inkludere koblinger du vil spore][3]
* [Legge til påmeldingskoblinger][4]
* [Enkel Google Analytics e-postsporing][6] – blogg
* [Definere koblingshandlinger][7]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[3]: add-tracked-link-to-msg.md
[4]: ../../mailing/learn/create/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[6]: https://community.superoffice.com/en/technical/blogs/archive/simple-google-analytics-email-tracking/
[7]: define-link-actions.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../media/icons/btn-add.png
[img3]: ../../../../../common/icons/folder.png
[img4]: media/link-properties.png
