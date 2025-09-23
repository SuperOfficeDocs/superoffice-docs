---
uid: help-sv-saint-update
title: Uppdatera aktivitetsövervakning
description: Uppdatera aktivitetsövervakning
keywords: SAINT, aktivitetsövervakning, standardhändelsetyp, ta bort statusövervakning, återställ statusövervakning, kriterier, regenerera statusövervakning, regenerera räknare
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
index: true
redirect_from: 
  - /sv/sale/saint/learn/admin/edit-status
  - /sv/saint/admin/edit-status
  - /sv/sale/saint/learn/admin/select-default-follow-up-type-for-status
  - /sv/saint/admin/select-default-follow-up-type-for-status
  - /sv/sale/saint/learn/admin/restore-status
  - /sv/saint/admin/restore-status
  - /sv/sale/saint/learn/admin/select-status-criteria
  - /sv/saint/admin/select-status-criteria
  - /sv/sale/saint/learn/admin/manage-status-monitors
  - /sv/saint/admin/manage-status-monitors
---

# Uppdatera aktivitetsövervakning

[!include[Requirement](../includes/note-saint-req.md)]

## Öppna SAINT-skärmen

Innan du utför någon av följande uppgifter ska du öppna fönstret **SAINT** i Inställningar och underhåll och välja fliken **Företag**, **Kontakt** eller **Projekt**.

## Redigera statusbeskrivning

På fliken **Beskrivning** visas den beskrivning du angav när du [skapade statusen][1].

1. Välj den status som du vill redigera beskrivningen för i statuslistan.

1. Redigera texten på fliken **Beskrivning**.

## Välja typ av standardhändelse för status

Du kan koppla en händelsetyp till en status. När en användare klickar i mitten av statuskortet öppnas en händelse automatiskt. Detta kan inkludera förifylld text som förklarar vilken åtgärd som ska vidtas för företag, kontakter eller projekt med denna status.

För att ange en standardhändelsetyp och beskrivning, använd fliken **Skapa händelse**.

1. Välj önskad status i statuslistan.
1. Gå till fliken **Skapa händelse**.
1. Välj en händelsetyp från rullgardinsmenyn **Typ**.
1. Ange meddelandet som ska visas i händelsedialogrutan.

![Fliken 'Skapa händelse' i SAINT-statusövervakningen, som visar val av händelsetyp och inmatning av anpassat meddelande. -screenshot][img1]

## <a id="criteria"></a>Lägg till kriterier till en status

Varje status måste ha minst ett kriterium. [Kriterierna][2] avgör vilka företag, kontakter eller projekt som statusen gäller för.

1. I statuslistan väljer du önskad status.

1. Under kriterielistan väljer du **Lägg till** för att infoga en ny rad.

1. Välj en kriterietyp från rullgardinsmenyn.

    ![Kriterielista med flera definierade villkor och knappen Lägg till under listan -screenshot][img3]

1. Ange villkoret (som **Före**, **Efter** eller **Lika med**) och ange ett värde.

1. Upprepa för att lägga till fler kriterier.

    > [!NOTE]
    > Du kan bara lägga till ett av varje kriterietyp. Du kan till exempel inte lägga till kriteriet **Postnummer** två gånger.

1. Välj <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Återskapar vald status** för att tillämpa ändringarna.

## <a id="delete"></a>Ta bort en statusövervakning

Du kan ta bort en status från statusövervakningslistan. Borttagna statusar kan återställas senare.

1. I statuslistan väljer du den status du vill ta bort.
1. Klicka på **Ta bort** längst ned i listan.

Den borttagna statusen tas bort från den aktiva listan men kan visas igen genom att välja **Visa borttagna**.

## <a id="restore"></a>Återställ en borttagen statusövervakning

Du kan återställa en tidigare borttagen status och regenerera den.

1. Längst ned i statuslistan väljer du **Visa borttagna**.

1. Dubbelklicka på den status som du vill återställa.

    ![Statusövervakningsdialogrutan öppen efter att ha valt en borttagen status, med knapparna Återställ och Spara synliga -screenshot][img2]

1. I dialogrutan **Statusövervakning** väljer du **Återställ** och sedan **Spara**.

    Statusen återställs och visas med svart text i listan.

1. Välj **Regenerera vald statusövervakning** för att uppdatera den återställda statusen.

## <a id="regen"></a>Regenerera statusar och räknare <i class="ph ph-arrow-circle-right" aria-hidden="true"></i>

Längst ned på fliken **Statusövervakning** visar indikatorer datumet för den senaste uppdateringen. Ett rött kryss i statuslistan betyder att statusen inte är aktiv förrän du regenererar den. Om ett element aldrig har genererats, eller den senaste genereringen var för länge sedan, kan resultaten vara inaktuella.

Statusar och räknare som inte är uppdaterade förblir synliga i SuperOffice CRM, men data kan vara felaktiga. Du bör regenerera när kriterier ändras, du har redigerat ett syfte för en uppgift, eller när indikatorerna antyder att data är inaktuella.

### Regenerera statusar

| Namn | Beskrivning | Plats |
|---|---|---|
| Återskapa vald statusövervakning | Uppdaterar den valda statusen | Längst ned på fliken **Företag**, **Kontakt** eller **Projekt** |
| Återskapa all statusövervakning | Uppdaterar alla statusar | Längst ned på fliken **Statusövervakning** |

### Regenerera räknare

| Namn | Beskrivning |
|---|---|
| Återskapa alla räknare | Uppdaterar alla räknare |

<!-- Referenced links -->
[1]: set-up.md
[2]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/saint-create-follow-up-tab.png
[img2]: ../../../media/loc/en/saint/delete-restore-status-monitor.png
[img3]: ../../../media/loc/en/saint/criteria.png
