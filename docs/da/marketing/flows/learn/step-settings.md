---
uid: help-da-flow-step-settings
title: Trinindstillinger
description: Gennemgang af indstillingerne for de forskellige flowtrin.
keywords: Marketing, flow, trin, trinindstilling
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.17.2024
version: 10.3.9
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Trinindstillinger

> [!NOTE]
> Mange felter har en liste over foruddefinerede værdier, du kan vælge fra. Klik på <i class="ph ph-caret-down" aria-label="Chevron"></i> for at udvide listen. Vælg derefter en værdi for det felt. Alternativt kan du begynde at skrive i feltet for at søge efter en bestemt værdi, såsom et udvalgsnavn.

## Tilføj til udvalg og/eller projekt

| Indstilling | Beskrivelse |
|---|---|
| Tilføj person til statisk udvalg | Deltageren bliver medlem af det angivne statiske udvalg. |
| Tilføj person som projektmedlem | Deltageren bliver medlem af det angivne projekt. |

## Opret opfølgning

| Indstilling | Beskrivelse |
|---|---|
| Titel | En beskrivende etiket. Yderligere detaljer tilføjes i dagsordenen. |
| Type | En foruddefineret liste over aktiviteter såsom Møde (eksternt). Tilgængelige felter afhænger af den valgte opfølgningstype. |
| Projekt | Et projekt knyttet til opfølgningen. |
| Dato | Hvornår opfølgningen starter eller skal være færdig.<br />**Opgavedato:** Dette betyder en to-do i brugerens tjekliste<br />**Mødedato:** Dette betyder en opfølgning i dagbogen. "Første tilgængelige" eller "Første tilgængelige efter x dage/arbejdsdage/uger". |
| Overfør til | Ejeren af opfølgningen. Deltagerens "vores kontakt" eller "vores servicekontakt" eller en bestemt navngivet medarbejder. |
| Dagsorden | Yderligere detaljer om opfølgningen, såsom en dagsorden, en beskrivelse, filer, billeder og links. Der er muligheder for formatering af rich tekst. |

## Opret sag

| Indstilling | Beskrivelse |
|---|---|
| Titel | Et beskrivende navn for sagen. |
| Sagstype | Sigter mod et sæt attributter, der er nødvendige for en bestemt proces. Påvirker de tilgængelige statusser og prioriteter. |
| Status | Angiver sagsstyringsfasen (åben eller lukket). |
| Kategori | Et sæt regler, der definerer, hvordan sager behandles. |
| Prioritet | Reflekterer vigtigheden af sagen. |
| Ejendom | Hvem sagen skal tildeles til. |
| Besked | Indholdet af sagen. Der er muligheder for formatering af rich tekst og skabelonvariabler for person og personens firma. |

## Opret salg

| Indstilling | Beskrivelse |
|---|---|
| Titel | Et beskrivende navn på salget. Detaljer tilføjes i beskrivelsen. |
| Salgstype | Et navngivet sæt information om salgsprocessen. Påvirker standard salgsstadie og estimeret salgsdato. Nogle salgstyper er knyttet til en [salgsguide][14]. |
| Stadium | Salgets nuværende stadium (åben, tabt, solgt). |
| Beløb | Forventet beløb for pipelinen. |
| Beskrivelse | En mere detaljeret beskrivelse af salget. |
| Projekt | Et projekt knyttet til salget. |
| Dato | Den estimerede salgsdato. "Estimeret efter salgstype" eller "Efter x dage/arbejdsdage/uger". |
| Ejendom | Personen ansvarlig for salget. Deltagerens "vores kontakt" eller "vores servicekontakt" eller en bestemt navngivet medarbejder. |

## Avslut flow

Flowkontroltrinnene **del** og **vent på handling** (og også Send SMS) har en **Avslut flow**-mulighed for at trække deltagere, der ikke opfylder en betingelse, ud af flowet. Hvis valgt, kan den afbrudte person flyttes til et andet flow og/eller tilføjes til et udvalg.

| Indstilling | Beskrivelse |
|---|---|
| Tilføj deltager til et andet flow efter afslutning | Den afbrudte person **foreslås** som deltager til det angivne flow. Filtre afgør, om de starter dette flow eller ej. |
| Tilføj deltager til statisk udvalg efter afslutning | Den afbrudte person bliver medlem af det angivne udvalg. Du kan oprette et nyt udvalg fra trinindstillingerne. |

## Afslut

Deltagere, der når afslutningstrinnet, har nået slutningen af flowet. Deltageren kan have afsluttet flowet med status = afsluttet eller afsluttet med succes. Der sker ikke flere handlinger med en deltager i dette flow, når de når dette trin.

| Indstilling | Beskrivelse |
|---|-|
| Føj til et andet flow, når et succeskriterium er opfyldt | Afsluttet med succes |
| Føj til et andet flow, når intet succeskriterium er opfyldt | Afsluttet |

## Giv besked via e-mail

| Indstilling | Beskrivelse |
|---|---|
| Til | Modtageren - "vores kontakt", "vores servicekontakt" eller en specifik e-mailadresse. |
| Overskrift | Tekst til e-mailens emnelinje. |
| Tekst | Indtast beskeden. |

Du kan tilpasse emnet med personvariabler (det samme som mergetags).

## Giv besked via SMS

| Indstilling | Beskrivelse |
|---|---|
| Til | Modtageren - "vores kontakt", "vores servicekontakt" eller specifikke kontakter. |
| Fra | Standardindstilling til flow "SMS-afsender". |
| Tekst | Indtast SMS-teksten. Du kan personalisere beskeden med personvariabler (det samme som sammenfletningstags inden for mailredigeringsværktøjet). |

## Send e-mail

| Indstilling | Beskrivelse |
|---|---|
| Opret ny e-mail til dette trin | Åbner udsendelsesguiden. |
| Vælg eksisterende e-mail til dette trin | Se [Tilføj indhold][1]. |
| Emnelinje | Tekst til e-mailens emnelinje. Du kan tilpasse emnet med personvariabler (det samme som mergetags). |
| Vedhæftning | Maks. 25 MB i alt. |

## Send SMS

| Indstilling | Beskrivelse |
|---|---|
| Fra | Standardindstilling til flow "SMS-afsender". |
| Tekst | Indtast SMS-teksten. Du kan personalisere beskeden med personvariabler (det samme som sammenfletningstags inden for mailredigeringsværktøjet). |
| Afslut flow, hvis der ikke er registreret mobiltelefon | Hvad skal der ske, hvis personen ikke kan modtage SMS'en? Hvis sandt, kan du tilføje dem til et andet flow eller til et statisk udvalg efter afslutning. |

## Del

| Indstilling | Beskrivelse |
|---|---|
| Titel | En kort beskrivende etiket. |
| Opdelt baseret på | Data/adfærd at differentiere på. |
| Grenens navn | Et beskrivende navn på grenen, der angiver hvilke deltagere, der bevæger sig ned ad hvilken gren. |
| Alle andre | Grenen til håndtering af deltagere, der ikke opfylder betingelserne for nogen af de andre grene. |
| Afslut flow | Bestemmer, om deltagere, der ender i alle-andre-grenen, skal afslutte. Hvis sandt, kan du tilføje dem til et andet flow eller til et statisk udvalg efter afslutning. Hvis falsk, kan du tilføje flere trin til denne gren. |

De resterende felter til specificering af grenindstillinger afhænger af, hvad opdelingen er baseret på.

## Trigger

| Indstilling | Beskrivelse |
|---|---|
| En person kan kun starte dette flow én gang | Hvorvidt en person kan genindskrives i dette flow. |
| Filter | Et sæt kriterier, der skal opfyldes for, at en foreslået person kan tillades i flowet. Kun kontrolleret én gang. |
| Udelukkelsesliste | Et statisk udvalg af personer, der ikke vil blive tilføjet til flowet eller vil afslutte flowet, hvis de allerede deltager. |

## Opdater person

Dette fungerer på samme måde som [masseopdatering][10].

## Ventetid

| Indstilling | Beskrivelse |
|---|---|
| Antal dage/timer efter forrige trin | **Varigheden** af pausen. Vent en bestemt tid. |
| Indtil specifik dato/ specifikt klokkeslæt | **Slutningen** af pausen. Vent indtil en bestemt dato. |

## Vent på handling

| Indstilling | Beskrivelse |
|---|---|
| Maksimal ventetid | Hvor lang tid man skal vente på en handling (en timeout). Standard: 7 dage. |
| Afslut flow, hvis der ikke er handlinger inden for maksimal ventetid | Deltagere, der ikke svarer, forlader flowet med status "frafald". Hvis sandt, kan du tilføje dem til et andet flow eller til et statisk udvalg efter afslutning. |

## Relateret indhold

* [Lær om aktiviteter][11]

<!-- Referenced links -->
[1]: content.md
[10]: ../../../learn/basics/bulk-update.md
[11]: ../../../learn/basics/activity.md
[14]: ../../../sale/learn/sales-guides.md
