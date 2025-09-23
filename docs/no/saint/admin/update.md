---
uid: help-no-saint-update
title: Oppdatere aktivitetsovervåking
description: Oppdatere aktivitetsovervåking
keywords: SAINT, aktivitetsovervåking, standard oppfølgingstype, slette statusovervåking, gjenopprette statusovervåking, kriterier, regenerere statusovervåking, regenerere teller
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
index: true
redirect_from: 
  - /no/sale/saint/learn/admin/edit-status
  - /no/saint/admin/edit-status
  - /no/sale/saint/learn/admin/select-default-follow-up-type-for-status
  - /no/saint/admin/select-default-follow-up-type-for-status
  - /no/sale/saint/learn/admin/restore-status
  - /no/saint/admin/restore-status
  - /no/sale/saint/learn/admin/select-status-criteria
  - /no/saint/admin/select-status-criteria
  - /no/sale/saint/learn/admin/manage-status-monitors
  - /no/saint/admin/manage-status-monitors
---

# Oppdatere aktivitetsovervåking

[!include[Requirement](../includes/note-saint-req.md)]

## Åpne SAINT-skjermbildet

Før du utfører noen av de følgende oppgavene, åpne skjermbildet **SAINT** i Innstillinger og vedlikehold og velg fanen **Firma**, **Person** eller **Prosjekt**.

## Redigere statusbeskrivelse

I fanen **Beskrivelse** vises beskrivelsen du anga da du [opprettet statusen][1].

1. I statuslisten velger du statusen du vil redigere beskrivelsen for.

1. Rediger teksten i fanen **Beskrivelse**.

## Velg en standard oppfølgingstype for en status

Du kan koble en oppfølgingstype til en status. Når en bruker klikker midt på statuskortet, åpnes en oppfølging automatisk. Dette kan inkludere forhåndsutfylt tekst som forklarer hvilken handling som skal utføres for firmaer, personer eller prosjekter med denne statusen.

For å angi en standard oppfølgingstype og beskrivelse, bruk fanen **Opprett oppfølging**.

1. Velg ønsket status i statuslisten.
1. Gå til fanen **Opprett oppfølging**.
1. Velg en oppfølgingstype fra rullegardinlisten **Type**.
1. Skriv inn meldingen som skal vises i oppfølgingsdialogboksen.

![Fanen 'Opprett oppfølging' i SAINT-statusovervåkingen, som viser valg av oppfølgingstype og innskriving av tilpasset melding. -screenshot][img1]

## <a id="criteria"></a>Legge til kriterier til en status

Hver status må ha minst ett kriterium. [Kriteriene][2] bestemmer hvilke firmaer, personer eller prosjekter statusen gjelder for.

1. I statuslisten velger du ønsket status.

1. Under kriterielisten velger du **Legg til** for å sette inn en ny rad.

1. Velg en kriterietype fra rullegardinlisten.

    ![Kriterieliste med flere betingelser definert og Legg til-knappen under listen -screenshot][img3]

1. Angi betingelsen (som **Før**, **Etter** eller **Lik**), og skriv inn en verdi.

1. Gjenta for å legge til flere kriterier.

    > [!NOTE]
    > Du kan bare legge til ett av hver kriterietype. Du kan for eksempel ikke legge til kriteriet **Postnummer** to ganger.

1. Velg <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Generer valgt statusovervåking på nytt** for å aktivere endringene.

## <a id="delete"></a>Slette en statusovervåking

Du kan slette en status fra statusovervåkingslisten. Slettede statuser kan gjenopprettes senere.

1. I statuslisten velger du statusen du vil slette.
1. Klikk **Slett** nederst i listen.

Den slettede statusen blir fjernet fra den aktive listen, men kan vises igjen ved å velge **Vis slettede**.

## <a id="restore"></a>Gjenopprette en slettet statusovervåking

Du kan gjenopprette en tidligere slettet status og regenerere den.

1. Nederst i statuslisten velger du **Vis slettede**.

1. Dobbeltklikk på statusen du vil gjenopprette.

    ![Statusovervåkingsdialogen åpen etter å ha valgt en slettet status, med Gjenopprett og Lagre-knapper synlige -screenshot][img2]

1. I dialogboksen **Statusovervåking** velger du **Gjenopprett**, deretter velger du **Lagre**.

    Statusen blir gjenopprettet og vises med svart tekst i listen.

1. Velg **Regenerer valgt statusovervåking** for å oppdatere den gjenopprettede statusen.

## <a id="regen"></a>Regenerere statuser og tellere <i class="ph ph-arrow-circle-right" aria-hidden="true"></i>

Nederst i fanen **Statusovervåking** viser indikatorer datoen for den nyeste oppdateringen. Et rødt kryss i statuslisten betyr at statusen ikke er aktiv før du regenererer den. Hvis et element aldri har blitt generert, eller den siste genereringen var for lenge siden, kan resultatene være utdaterte.

Statuser og tellere som ikke er oppdaterte forblir synlige i SuperOffice CRM, men dataene kan være feil. Du bør regenerere når kriterier endres, du har redigert en intensjon for en oppgave, eller når indikatorene antyder at dataene er utdaterte.

### Regenerere statuser

| Navn | Beskrivelse | Plassering |
|---|---|---|
| Regenerer valgt statusovervåking | Oppdaterer den valgte statusen | Nederst i fanen **Firma**, **Person** eller **Prosjekt** |
| Regenerer alle statusovervåkinger | Oppdaterer alle statuser | Nederst i fanen **Statusovervåking** |

### Regenerere tellere

| Navn | Beskrivelse |
|---|---|
| Regenerer alle tellere | Oppdaterer alle tellere |

<!-- Referenced links -->
[1]: set-up.md
[2]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/saint-create-follow-up-tab.png
[img2]: ../../../media/loc/en/saint/delete-restore-status-monitor.png
[img3]: ../../../media/loc/en/saint/criteria.png
