---
uid: help-da-section-tab-contacts
title: Contacts tab
description: Lær hvordan du administrerer og interagerer med personinformation knyttet til firmaer ved hjælp af Personfanen i SuperOffice CRM. Spor persondata og vedligehold kommunikationsoptegnelser for problemfri kundeforhold.
keywords: detaljekortet Personer, Personer-fanen, Personfanen, fanen Personer, fanen Kontaktpersoner, detaljekort, personarkiv, aktiver mellemnavn
author: Bergfrid Skaara Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Personfanen

Detaljekortet **Personer** i SuperOffice CRM giver brugerne mulighed for at se og administrere alle [personer][1], der er knyttet til et specifikt firma. Denne fane hjælper brugerne med at holde styr på forholdene mellem firmaet og dets ansatte eller andre relevante personer. Ved at give en organiseret liste over alle tilknyttede personer, letter den adgang til personoplysninger, hvilket gør det nemt at opretholde detaljeret kommunikation. Detaljekortet **Personer** er kun tilgængelig på [Firma-skærmen][9].

![Detaljekortet Personer i Firma-skærmen -screenshot][img1]

## <a id="columns"></a>Kolonneoversigt for Personfanen

Detaljekortet **Personer** indeholder følgende kolonner for at vise nøgleinformation om hver person:

| Kolonne | Beskrivelse |
|---|---|
| Info | Viser et papirklipsikon (<i class="ph ph-paperclip" aria-hidden="true"></i>) hvis **Bemærkning**-fanen i Personkortet har en note. Hold musemarkøren over ikonet for at se det. |
| Interesser | Viser en prik hvis personen har interesser. Hold musemarkøren over ikonet for at se interesserne. |
| Hr./Fr. | Viser hvordan personen bør adresseres. |
| Fornavn / Mellemnavn / Efternavn | Personens fulde navn. Brugen af mellemnavne kan konfigureres i Indstillinger og vedligeholdelse. |
| Titel | Viser personens professionelle titel eller rolle inden for firmaet. |
| Mobiltelefon | Personens mobiltelefonnummer. |
| E-mail | Personens e-mailadresse. Klik på e-mailen for at [åbne en ny meddelelse][7] i dit foretrukne e-mailprogram. |

[!include[Konfigurer kolonner](../includes/tip-configure-columns.md)]

## Vis personer i Personfanen

1. Gå til den relevante **Firma-skærm**.

1. Klik på detaljekortet **Personer** for at se alle personer knyttet til firmaet.

1. Dobbeltklik på en person i listen for at åbne Personskærmen for mere detaljeret information.

### Inkluder fratrådte medarbejdere

For at inkludere personer, der er forladt firmaet, markér **Fratrådt**. Fratrådte medarbejdere vises i en anden farve på listen, samt i detaljekortet **Projektmedlemmer** i Projekt-skærmen og i medlemslisterne på Udvalgsskærmen.

## Opret en ny person

1. Klik på **Tilføj** for at [oprette en ny person][2] knyttet til firmaet.

1. Udfyld de nødvendige oplysninger, og klik på **Gem**.

## Rediger personinformation

1. Dobbeltklik på den person, du ønsker at [redigere][3].

1. I Personkortet, foretag de ønskede ændringer.

1. Klik på **Gem** for at bekræfte dine opdateringer.

## Rediger personinteresser

1. Dobbeltklik på personens navn for at åbne Personkortet.

1. Gå til fanen **Interesser** for at opdatere interesser knyttet til personen.

## Sammenflet eller flyt personer

* For at sammenflette personer, følg trinnene i [sammenfletning af personer][5].

* For at flytte en person til et andet firma, følg trinnene i [flytte personer][4].

## Aktivér støtte for mellemnavne

Du kan aktivere brugen af mellemnavne i Indstillinger og vedligehold ved at følge disse trin:

1. Gå til Indstillinger og vedligehold.

1. Gå til **Præference** > **Globale præferencer** > **Funktioner**.

1. Vælg **Aktivér brug af mellemnavn**.

Hvis denne præference er aktiveret, vil den første del af efternavnet blive brugt som mellemnavn (men sorteres ikke efter). Hvis ikke aktiveret, kan du indtaste et mellemnavn i **Fornavn**-feltet, som så vil blive betragtet som et andet fornavn.

## Relateret indhold

* [Opret ny person][2]
* [Slet personer][6]
* [Konfigurer kolonner i detaljekort][8]

<!-- Referenced links -->
[1]: ../../contact/learn/index.md
[2]: ../../contact/learn/create.md
[3]: ../../contact/learn/edit.md
[4]: ../../contact/learn/move.md
[5]: ../../contact/learn/merge-contacts.md
[6]: ../../contact/learn/delete.md
[7]: ../../contact/learn/send-email.md
[8]: configure-columns.md
[9]: ../../company/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/contacts-detail.png
