---
uid: help-da-manage-status-monitors
title: Administration af statusovervågning
description: Administration af statusovervågning
keywords: SAINT, statusovervågning
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Administration af statusovervågning

[!include[Requirement](../includes/note-saint-req.md)]

Når du opretter flere statusovervågninger og forskellige perioder/tællere, er det vigtigt at have en regelmæssig kontrol af dem for at sikre, at tællerne og statusserne genoprettes og opdateres, og at [kriterierne][1] er korrekte på de forskellige statusser.

Sektionerne nedenunder indeholder information om, hvordan du aktiverer og deaktiverer statusovervågning, og hvordan du genopretter statusser og tællere. [!include[Define counter](../includes/def-counter.md)]

## Generel information om opdatering og genopretning af statusser og tællere

Nederst under **fanen Statusovervåger** vises indikatorer (tekst, der viser datoen for den seneste generation, hvis den valgte status eller tæller aldrig er blevet oprettet, eller hvis den valgte status skal genereres igen på grund af ændringer) til genopretning af statusser eller tællere.

Du bør generere statusser og/eller tællere igen, hvis indikatorerne viser, at den sidste generation er længe siden, eller at statusserne og/eller tællerne aldrig er blevet oprettet. Det samme gælder, hvis statusser ændres. Statusser og tællere, der ikke opdateres, vil stadig være aktiveret og brugbare i SuperOffice CRM, men de returnerede datoer vil ikke nødvendigvis være korrekte. Sektionerne nedenunder beskrev, hvordan du genopretter statusser og tællere.

### Sådan kan du se, om et element er opdateret

Hvis et element ikke er opdateret, vises det som ![ikon][img1] (statusser) og ![ikon][img3]/![ikon][img4]/![ikon][img5] (tællere) i SuperOffice CRM.

## Genopret statusser

Når du har [tilføjet, redigeret eller slettet kriterier][2], eller hvis du for eksempel har redigeret en hensigt til en opgave i SuperOffice CRM, vises der et rødt kryds på statuslisten til venstre for den/de pågældende statusser. Statusser markeret med et rødt kryds er ikke aktiveret.

Du skal derefter genoprette disse statusser ved at klikke på en af disse knapper:

| Ikon | Navn | Beskrivelse | Sted |
|---|---|---|---|
| ![ikon][img2] | Genopretter valgt statusovervågning | Vælg for at genoprette den valgte status | Nederst på fanen **Firma**, **Person** eller **Projekt** |
| ![ikon][img2] | Generer alle statusser igen | Vælg Genopret alle statusser | Nederst på fanen **Status** |

## Genopret tællerværdier

| Ikon | Navn | Beskrivelse |
|---|---|---|
| ![ikon][img2] | Genopret alle tællere | Vælg for at genopret alle tællere |

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: select-status-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/status-inactive.png
[img2]: ../../../media/icons/arrow-right.png
[img3]: ../../../media/icons/admin/saint-counter-company-dis.png
[img4]: ../../../media/icons/admin/saint-counter-project-dis.png
[img5]: ../../../media/icons/admin/saint-counter-sale-disabled.png
