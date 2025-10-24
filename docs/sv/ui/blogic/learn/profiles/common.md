---
uid: help-sv-service-profile-common
title: Delade profiler
description: Delade profiler
author: SuperOffice RnD
date: 06.29.2022
keywords: profil, tjänst
content_type: howto
language: sv
---

# Delade profiler

[!include[Legacy](../includes/legacy-profiles.md)]

Delade profiler är kopplade till en [roll][2] och gäller för alla användare som har den aktuella rollen. Du konfigurerar delade profiler på skärmen **Visa profiler**.

## Profiltyper

* **System**: Dessa profiler kan du konfigurera genom att följa proceduren nedan.
* **System screens**: En översikt över skärmar som har skapats med hjälp av [systemdesignern][1] i SuperOffice Service. Du kan ändra dessa skärmar om du har tillgång till **Systemdesign** > **Skärmbilder**.

## <a id="create"></a>Skapa delade profiler

Följande steg visar till exempel hur du lägger till ett fält i fönstret **Söka ärenden**.

1. Välj **Systeminställningar** > **Profil**. Skärmen **Visa profiler** visas.
2. Välj **System**. En hierarkisk översikt visas över alla profilerna i systemet.
3. Klicka på **Sök**.
4. Peka på **Sök ärenden** och klicka på <i class="ph ph-list" aria-label="Main menu"></i> (**Ny delad profil**) till höger om namnet. Skärmen **Redigera objektsprofil** visas.
5. I fältet **Namn** skriver du namnet på profilen.
6. Klicka på knappen **Lägg till kriterier**.
7. Gör följande i dialogrutan:
    * **Ange rubriken på fältet här**: Ange fältnamnet.
    * **Välj fält**: Välj vilket fält i databasen som du vill hämta information från.
8. Klicka på **OK**. Det nya kriteriet läggs till under de andra.
9. Klicka på **OK**. Den nya profilen skapas. Nu kan du till exempel [koppla den till en specifik roll][3].

## Redigera information i en enhetlig profil

1. Välj **Systeminställningar** > **Profil**. Skärmen **Visa profiler** visas.
2. Välj **System**. En hierarkisk översikt visas över alla profilerna i systemet.
3. Bläddra nedåt i hierarkin tills du hittar önskad profil.
4. Klicka på profilnamnet. Skärmen **Redigera objektsprofil** visas.
5. Gör nödvändiga ändringar.
6. Klicka på **OK**. Ändringarna sparas.

## Ta bort en enhetlig profil

1. Välj **Systeminställningar** > **Profil**. Skärmen **Visa profiler** visas.
2. Välj **System**. En hierarkisk översikt visas över alla profilerna i systemet.
3. Bläddra nedåt i hierarkin tills du hittar önskad profil.
4. Klicka på profilnamnet. Skärmen **Redigera objektsprofil** visas.
5. Klicka på knappen **Återställ standard (tar bort den här profilen)** längst ned på skärmen. Profilen raderas.

## Vad vill du veta mer om?

* [Personliga profiler][4]
* [Globala profiler][5]

<!-- Referenced links -->
[1]: ../screen-properties.md
[2]: ../../../../admin/user-management/role/index.md
[3]: ../../../../admin/user-management/role/create-role.md
[4]: personal.md
[5]: global.md
