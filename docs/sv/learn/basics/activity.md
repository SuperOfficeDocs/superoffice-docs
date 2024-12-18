---
uid: help-sv-activity
title: Aktiviteter
description: Aktiviteter i SuperOffice CRM
author: SuperOffice RnD
date: 12.12.2023
version: 10.2.11
keywords: activity
topic: concept
language: sv
audience: person
audience_tooltip: SuperOffice CRM
---

# Aktiviteter

![Aktiviteter i SuperOffice CRM -screenshot][img3]

## Typer

Det finns två typer av aktiviteter – dokument och händelser. Dessutom visas utskick, formulärinlämningar och chattuppföljningar på detaljkortet **Aktiviteter**.

* [Händelser][1]
  * ![icon][img11] Möte (bokning)
  * ![icon][img13] Händelse (samtal)
  * ![icon][img12] Att göra (uppgift)
* [Dokument][4]
  * ![icon][img14] Dokument (brev och andra dokument)
  * ![icon][img15] E-post
* ![icon][img16] [Utskick][3] (massutskick med massbrevsmall, e-post eller SMS)
* ![icon][img18] [Chattposter][12]
* ![icon][img17] Formulärinlämningar

## Var hittar jag aktiviteter?

[Aktivitetsfliken][18] är tillgänglig i Företag-, Kontakt-, Projekt-, Försäljnings- och Kalender-skärmarna.

> [!NOTE]
> Aktiviteter visas även i de [olika vyerna][7] i fönstret Kalender.

## <a id="view"></a>Visa aktiviteter

Vilka aktiviteter som visas beror på vilka filter du väljer längst ned på detaljkortet. Du kan välja att visa alla aktiviteter eller en av typerna. Klicka på ![ikon][img5] Filtrera-knappen för att [filtrera aktiviteter][17] efter datum och användare.

![Activities section tabs shows filter options of different record types -screenshot][img4]

## Kolumner

I kolumnerna i aktivitetslistan finns följande information:

* ![ikon][img1]: Den första kolumnen i aktivitetslistan anger **Slutfört**-status för en aktivitet. En bock i kolumnen betyder att aktiviteten är slutförd. Om kolumnen är tom betyder detta att aktiviteten inte är slutförd.

* Kolumnen Kategori innehåller ikoner som anger typ av aktivitet, till exempel en kalender indikerar ett möte. De här ikonerna återspeglar texten i kolumnen **Typ**.

* Resten av kolumnerna i aktivitetslistan visar information om aktiviteten. Om du inte ser all text i ett fält kan du hålla muspekaren över texten så visas den i en inforuta.

## Skapa en aktivitet

Du skapar aktiviteter med **Ny** på toppraden, eller genom att dubbelklicka på knappen **Lägg till** på avsnittsfliken.

## <a id="delete"></a>Ta bort aktivitete

Du kan ta bort aktiviteter från alla fönster där de visas:

1. Markera en eller flera aktiviteter som du vill ta bort.

2. Högerklicka på den eller de markerade aktiviteterna och välj **Ta bort**.

3. Klicka på **Ja** när du tillfrågas om du verkligen vill ta bort aktiviteten.

[!include[Deleting items](../includes/tip-deletion.md)]

## Preferenser ![ikon][img2]

När en aktivitet har slutförts tas den bort från aktivitetslistan nästa dag. Som standard visar **Aktivitetsfliken** uppgifter som du inte har slutfört per dagens datum.

### Visa framtida uppgifter

1. Gå till **Personliga inställningar** > **Inställningar**.
2. Välj **Funktioner** och hitta alternativet **Visa dagar framåt**.
3. Definiera hur många dagar framåt du vill att uppgifter ska vara synliga. Till exempel, genom att ange 7 här kommer du att visa uppgifter för nästa vecka.

### Ta bort aktivitet från listan när den är slutförd

1. Gå till **Personliga inställningar** > **Inställningar**.
2. Välj **Visuella effekter**.
3. Uppdatera [inställningen][2] **Ta bort slutförda aktiviteter**.

### Markera förfallna aktiviteter

Om en aktivitet skrivs med röd text betyder det att dess planerade datum har passerat. För att ändra den här inställningen:

1. Gå till **Personliga inställningar** > **Inställningar**.
2. Välj **Funktioner**.
3. Uppdatera alternativet **Markera aktiviteter som har utgått**.

## Vad vill du göra nu?

* [Filtrera aktiviteter][17]
* [Ändra Slutfört-status för en aktivitet][10]
* [Lägga till händelser][8]
* [Ringa till kontakter][11]
* [Arbeta med dokument][4]
* [Skriv ett e-postmeddelande][5]
* [The Activities tab][18]

<!-- Referenced links -->
[1]: ../../diary/learn/follow-ups.md
[2]: ../getting-started/preferences.md
[3]: ../../marketing/mailing/learn/index.md
[4]: ../../document/learn/index.md
[5]: ../../email/learn/compose.md
[7]: ../../diary/learn/screen/index.md
[8]: ../../diary/learn/create-follow-up.md
[10]: ../../diary/learn/change-completed-status.md
[11]: ../../contact/learn/dial.md
[12]: ../../chat/learn/index.md
[17]: ../section-tabs/filter.md
[18]: ../section-tabs/activities-tab.md

<!-- Referenced images -->
[img1]: ../../../media/icons/check.png
[img2]: ../../../media/icons/personal-settings-small.png
[img3]: ../../../media/loc/en/diary/activities-detail.png
[img4]: ../../../media/loc/en/learn/activities-filter.png
[img5]: ../../../../common/icons/filter-icon.png
[img11]: ../../../../common/icons/appointment.png
[img12]: ../../../../common/icons/appointment-task.png
[img13]: ../../../../common/icons/appointment-followup.png
[img14]: ../../../../common/icons/document.png
[img15]: ../../../../common/icons/email.png
[img16]: ../../../../common/icons/marketing.png
[img17]: ../../../../common/icons/webforms.png
[img18]: ../../../../common/icons/chat.png
