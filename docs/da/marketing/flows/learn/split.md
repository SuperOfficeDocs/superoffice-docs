---
uid: help-da-flow-split
title: Flowkontrol - opdeling
description: Flowkontrol - opdeling
keywords: Marketing, flow, flowkontrol, opdel, gren
author: Bergfrid Dias, Trude Lien Smedbråten
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Flowkontrol - opdeling

Et opdelingstrin deler flowets deltagere op i 2 eller flere grene baseret på en eller flere betingelser. Dette giver dig mulighed for at bruge alternative stier og behandle deltagere forskelligt baseret på persondata eller engagement.

Du kan differentiere baseret på:

* Persondata
* Formularindsendelse (ja/nej)
* Formulardata
* Klikket på link (sporet)
* Projektdeltagelse
* Udvalgsmedlemskab

## Sådan virker det

Når deltageren når delingen, evalueres kriterierne for **venstremest** gren først. De kan kun følge én sti. Hvis der er en match, bevæger de sig videre til næste trin i den gren. Derefter kontrolleres den næste grenbetingelse, og så videre. Alle opdelinger har en gren for alle, der ikke opfylder nogen af betingelserne.​

## Trin

1. Træk **Del**-boksen fra trinmenuen og slip den i en ledig position i flowdiagrammet.
2. Indtast en beskrivende **titel**.

    > [!TIP]
    > Beskrivende titel og grennavne gør flowet nemmere at læse​.

3. Vælg, hvad opdelingen skal baseres på. Nogle muligheder kræver, at du giver yderligere detaljer her.
4. Navngiv den nye gren.
5. Indstil grenspecifikke kriterier. Mulighederne afhænger af, hvad du baserede opdelingen på.
6. Tilføj eventuelt flere grene og gentag trin 4-5.
7. Vælg, om deltagere, der matcher ingen kriterier, skal forlade flowet.
8. Fortsæt med at tilføje trin til hver gren.

Alle andre fortsætter:

![Marketing automation: opdel flow baseret på personoplysninger -screenshot][img1]

Alle andre afslutter:

![Marketing automation: opdel flow baseret på personoplysninger -screenshot][img2]

> [!NOTE]
> Du kan ikke slette grenen "alle andre".

### Opdeling baseret på personoplysninger

Når du vælger at dele op deltagere baseret på personoplysninger, kan du vælge fra de personoplysninger og firmakriterier, der er tilgængelige i **Find person**.

* For hver gren skal du [vælge værdier for kriteriet][11] i de forskellige felter på linjen (tilsvarende til på Find-skærmen). Klik på **Tilføj** for at indsætte flere kriterier.

![Marketing automation: opdel flow baseret på firmaoplysninger -screenshot][img3]

### Opdeling baseret på klik på link

Når det er valgt, vises et felt til at angive, hvilken e-mail der vises.

* E-mail: Vælg **Enhver e-mail** eller en specifik udsendelse.
* For hver gren skal du vælge, hvilket [sporet link][7] deltageren skal klikke på for at komme ind i denne gren.

![Marketing automation: opdel flow baseret på klik på link -screenshot][img4]

### Opdeling baseret på formular indsendt ja/nej

Når det er valgt, vises et felt til at angive, hvilken formular der vises.

* Formular: Vælg en specifik formular.

![Marketing automation: opdel flow baseret på formular indsendt -screenshot][img5]

> [!NOTE]
> Denne opdeling er uafhængig af, hvilke formulardata der blev indsendt. Der er ingen grenspecifikke indstillinger. Da dette er en ja/nej-test, kan du ikke tilføje flere grene.

### Opdeling baseret på formulardata

Denne betingelse er en variant af opdeling baseret på indsendelse med yderligere datakriterier, der anvendes til grenen.

Når det er valgt, vises et felt til at angive, hvilken formular der vises.

* Formular: Vælg en specifik formular.
* For hver gren skal du vælge værdier for kriteriet i de forskellige felter på linjen (tilsvarende til på Find-skærmen). Tilgængelige kriterier afhænger af de valgte formularers felter. Klik på **Tilføj** for at indsætte flere kriterier.

![Marketing automation: opdel flow baseret på formulardata (Kontakt mig) -screenshot][img6]

> [!NOTE]
> I dette scenarie betyder **alle andre**, at både deltagere, der ikke indsender formularen, *og* de, der ikke opfylder yderligere kriterier på nogen af de andre grene.

### Opdeling baseret på projektmedlemskab

* For hver gren skal du vælge, hvilket projekt deltageren skal være medlem af.

![Marketing automation: opdel flow baseret på projektmedlemskab -screenshot][img7]

### Opdeling baseret på statisk udvalg

Lignende til opdeling baseret på projektmedlemskab.

## Succeskriterier anvendt som tidlig afslutningsbetingelse

Succeskriterier kan også bruges som en tidlig afslutningsbetingelse i flowet, hvilket eliminerer behovet for forgrening. Før der udføres handlinger på en deltager i et flowtrin, genevalueres deltagerens status. Denne genevaluering tager højde for succeskriterierne. Hvis en deltager opfylder succeskriterierne, opdateres deres status til *Afsluttet med succes*, eller de fortsætter som *Aktiv*, hvis de skal fuldføre flowet. Ved afslutningstrinnet får deltagere, der har opfyldt succeskriterierne, status *Afsluttet med succes*.

<!-- Referenced links -->
[7]: ../../tracked-links/learn/index.md
[11]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/split-flow-contact-data-no-exit.png
[img2]: ../../../../media/loc/en/marketing/split-flow-contact-data-yes-exit.png
[img3]: ../../../../media/loc/en/marketing/split-flow-company-data-dropdown.png
[img4]: ../../../../media/loc/en/marketing/split-flow-link-clicked.png
[img5]: ../../../../media/loc/en/marketing/split-flow-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/split-flow-form-data-contact-me.png
[img7]: ../../../../media/loc/en/marketing/split-flow-project-member.png
