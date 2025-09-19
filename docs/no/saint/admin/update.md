---
uid: help-no-saint-update
title: Oppdatere aktivitetsovervåking
description: Oppdatere aktivitetsovervåking
keywords: SAINT, aktivitetsovervåking, standard oppfølgingstype, slette statusovervåking, gjenopprette statusovervåking
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

<!-- Referenced links -->
[1]: create-status.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/saint-create-follow-up-tab.png
[img2]: ../../../media/loc/en/saint/delete-restore-status-monitor.png
