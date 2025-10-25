---
uid: help-sv-user-other
title: Hantera andra användare
description: Hantera anonyma användare och systemanvändare (lokalt)
keywords: anonyma användare, systemanvändare, Andra användare
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
deployment: onsite
platform: web
index: true
redirect_from: 
  - /sv/admin/user-management/learn/other-users
  - /sv/admin/user-management/learn/role/edit-rights-for-anonymous-users
language: sv
---

# Hantera anonyma användare och systemanvändare (lokalt)

* **Systemanvändare**: Systemanvändare kan logga in i systemet via applikationer från tredje part, med fullständiga behörigheter.
* **Anonym**: Anonyma användare har behörigheter baserat på [rollen för anonyma användare](#rights). Normalt behövs inte mer än en konfiguration för anonyma användare.

> [!NOTE]
> Anonyma användare och systemanvändare kräver systemlicens för [SuperOffice Expander Services][1] och kan hanteras på fliken **Andra användare**.
>
> 1. Klicka på <i class="ph ph-user" aria-hidden="true"></i> **Användare** i navigatorn.
> 1. Välj fliken **Andra användare**. Listan visar befintliga anonyma användare och systemanvändare.

## Lägg till anonym användare eller systemanvändare

1. Klicka på **Lägg till** under listan.

1. Ange ett ID i fältet **Användar-ID**.

1. I fältet **Lösenord** anger du ett lösenord för användaren om det krävs.

1. Lägg eventuellt till en beskrivning av användaren i rutan **Beskrivning**.

1. Välj **Typ**: **Systemanvändare** eller **Anonym**.

1. Välj **Aktiv** till höger om **Inloggning** för att aktivera användaren.

1. Klicka på **Spara**. Användaren läggs till i listan.

## Redigera anonym användare eller systemanvändare

1. I listan, dubbelklicka på den användare du vill redigera.

1. Gör önskade ändringar i dialogrutan som visas.

1. Klicka på **Spara** för att avsluta.

## <a id="rights"></a>Redigera behörigheter för anonyma användare

Det finns bara en roll för anonyma användare och endast databehörigheter för den rollen kan redigeras.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Välj fliken **Anonyma**.

1. [Ange databehörigheter på fliken **Databehörigheter**][2].

Ändringarna sparas automatiskt.

## Ändra inloggningsbehörighet för andra användare

Om en anonym användare eller systemanvändare inte längre ska kunna logga in i systemet kan du ta bort användarens inloggningsbehörigheter. Den externa användaren tas inte bort, men definieras som inaktiv och kan alltid återaktiveras vid behov.

### Inaktivera en användare

1. Välj den aktiva användare som du vill ta bort inloggningsbehörigheterna för i listan och klicka på **Ta bort inloggning** under listan.

    Användaren kan då inte längre logga in i systemet.

### Aktivera en användare

1. Dubbelklicka på den användare du vill aktivera i listan.
1. Välj **Aktiv** till höger om **Inloggning** för att aktivera användaren.
1. Klicka på **Spara**. Användaren kan nu logga in i systemet.

## Ta bort anonyma användare eller systemanvändare

1. Markera den användare du vill ta bort.
1. Klicka på knappen **Ta bort**. Användaren tas bort från listan.

<!-- Referenced links -->
[1]: ../../license/expander-services.md
[2]: ../role/set-data-rights-for-role.md
